using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Client.Forms;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Enums;
using Infrastructure.Methods;
using Infrastructure.Models;

namespace Client.UserControls
{
    public partial class RequestUserControl : UserControl, IClosableUI
    {
        #region fields and props

        private readonly Color CurrentUserRequestsColor = Color.FromArgb(135, 206, 250);
        private readonly Color RequestInWorkColor = Color.FromArgb(189, 218, 87);
        private readonly Color RequestCompleteColor = Color.FromArgb(221, 160, 221);
        private readonly MainForm parentForm;
        private readonly List<UserModel> users;
        private List<RequestTypeModel> requestTypes;
        private List<ServiceModel> services;
        private List<ClientModel> clients;

        public ObservableCollection<RequestModel> Requests;

        #endregion fields and props

        #region ctor
        public RequestUserControl(MainForm parentForm)
        {
            InitializeComponent();
            Size = parentForm.CurrentControlSize;
            this.parentForm = parentForm;
            users = parentForm.UsersCollection;

            Requests = new ObservableCollection<RequestModel>();
            Requests.CollectionChanged += RequestsCollectionChanged;
            closeView.Dock = (DockStyle)parentForm.Settings.CloseViewButtonPosition;
            currentUserColorLabel.BackColor = CurrentUserRequestsColor;
            requestInWorkLabel.BackColor = RequestInWorkColor;
            requestCompleteLabel.BackColor = RequestCompleteColor;

            newRequestPanel.Visible = parentForm.currentUser.CheckPermission(
                DataPermissions.RequestInsert,
                parentForm.currentPermissions);

            newRequestButton.Visible = parentForm.currentUser.CheckPermission(
                DataPermissions.RequestInsert,
                parentForm.currentPermissions);

            acceptRequest.Visible = parentForm.currentUser.CheckPermission(
                DataPermissions.RequestUpdate,
                parentForm.currentPermissions);

            createReportAndCloseButton.Visible = parentForm.currentUser.CheckPermission(
                DataPermissions.RequestUpdate,
                parentForm.currentPermissions);

            UpdateRequestCollection();
            UpdateDictionaries();
        }

        private void RequestsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        RequestModel newItem = e.NewItems[0] as RequestModel;

                        string clientFullName = (newItem.Client == null) ? "Клиент в офисе" : newItem.Client.GetFullName;
                        string[] listItem = new string[]
                        {
                            $"{newItem.Name}-{newItem.Number}",
                            $"{newItem.RequestType.Name}",
                            $"{newItem.Address}",
                            $"{newItem.Service.Name}",
                            $"{newItem.User.GetFullName}, {newItem.User.Position.Name}",
                            $"{newItem.TargetUser.GetFullName}, {newItem.TargetUser.Position.Name}",
                            $"{clientFullName}",
                            $"{EnumsMethods.GetRusEnumName(typeof(ApplicationEnums.RequestStatuses), newItem.Status)}",
                        };
                        ListViewItem requestItem = new ListViewItem(listItem);
                        if (parentForm.currentUser.ID.Equals(newItem.TargetUser.ID))
                            requestItem.BackColor = CurrentUserRequestsColor;
                        if (newItem.Status.Equals((int)ApplicationEnums.RequestStatuses.В_работе))
                            requestItem.BackColor = RequestInWorkColor;
                        if (newItem.Status.Equals((int)ApplicationEnums.RequestStatuses.Выполнена))
                            requestItem.BackColor = RequestCompleteColor;
                        RequestList.Items.Add(requestItem);
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    {
                        RequestList.Items.Clear();
                        acceptRequest.Enabled = false;
                        createReportAndCloseButton.Enabled = false;
                        UpdateRequestCollection();
                    }
                    break;
            }
        }
        #endregion ctor

        #region Update data
        private void UpdateDictionaries()
        {
            using RequestTypeData requestData = new RequestTypeData(parentForm.Settings.ConnectionString);
            requestTypes = requestData.GetDataCollection();
            requestTypes.ForEach(x => NRrequestTypeCB.Items.Add(x.Name));
            if (!NRrequestTypeCB.Items.Count.Equals(0))
                NRrequestTypeCB.SelectedIndex = 0;

            using ServiceData serviceData = new ServiceData(parentForm.Settings.ConnectionString);
            services = serviceData.GetDataCollection();
            services.ForEach(x => NRserviceCB.Items.Add(x.Name));
            if (!NRserviceCB.Items.Count.Equals(0))
                NRserviceCB.SelectedIndex = 0;

            users.ForEach(x => NRtargetUserCB.Items.Add($"{x.GetFullName}, {x.Position.Name}"));
            if (!NRtargetUserCB.Items.Count.Equals(0))
                NRtargetUserCB.SelectedIndex = 0;

            using ArchiveData archiveData = new ArchiveData(parentForm.Settings.ConnectionString);
            var archiveCollection = archiveData.GetDataCollection().ToList();

            using ClientData clientData = new ClientData(parentForm.Settings.ConnectionString);
            clients = clientData.GetDataCollection();
            foreach (ClientModel item in clients)
            {
                if (archiveCollection.Any(a => a.Client.ID.Equals(item.ID)))
                    continue;
                else
                    NRclientsCB.Items.Add(item.GetFullName);
            }
            if (!NRclientsCB.Items.Count.Equals(0))
                NRclientsCB.SelectedIndex = 0;
        }

        private void UpdateRequestCollection()
        {
            using RequestData data = new RequestData(parentForm.Settings.ConnectionString);
            List<RequestModel> retrieved = data.GetDataCollection();

            foreach (RequestModel item in retrieved)
            {
                if (parentForm.Settings.ShowOnlyOwnRequests &&
                           !item.TargetUser.ID.Equals(parentForm.currentUser.ID) &&
                           !parentForm.currentUser.Login.Equals("admin")
                           )
                    continue;
                Requests.Add(item);
            }
        }
        #endregion Update data

        #region selecting

        private void NRrequestTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NRrequestTypeCB.SelectedIndex.Equals(-1))
                return;

            RequestTypeModel requestType = requestTypes[NRrequestTypeCB.SelectedIndex];

            if (Requests.Count.Equals(0))
                NRnameTB.Text = $"{requestType.ShortName}-0000000001";
            else
                NRnameTB.Text = $"{requestType.ShortName}-{Convert.ToInt32(Requests[Requests.Count - 1].Number) + 1:0000000000}";

            NRaddressTB.Enabled = requestType.RequireOtherWorks;
            NRclientsCB.Enabled = requestType.RequireOtherWorks;
        }

        private void RequestListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (RequestList.SelectedIndices.Count.Equals(0))
            {
                acceptRequest.Enabled = false;
                createReportAndCloseButton.Enabled = false;
                return;
            }

            RequestModel model = Requests[RequestList.SelectedIndices[0]];
            acceptRequest.Enabled =
                parentForm.currentUser.ID.Equals(model.TargetUser.ID) &&
                model.Status.Equals((int)ApplicationEnums.RequestStatuses.Открыта);

            createReportAndCloseButton.Enabled =
                parentForm.currentUser.ID.Equals(model.TargetUser.ID) &&
                model.Status.Equals((int)ApplicationEnums.RequestStatuses.В_работе);
        }

        #endregion selecting

        #region buttons

        public void CloseViewClick(object sender, EventArgs e) => Dispose();

        private void NewRequestButtonClick(object sender, EventArgs e)
        {
            RequestModel request = new RequestModel()
            {
                ID = Guid.NewGuid(),
                Name = NRnameTB.Text.Remove(3),
                Number = NRnameTB.Text.Remove(0, 3),
                RequestType = requestTypes[NRrequestTypeCB.SelectedIndex],
                Service = services[NRserviceCB.SelectedIndex],
                User = parentForm.currentUser,
                TargetUser = users[NRtargetUserCB.SelectedIndex]
            };
            request.Address = request.RequestType.RequireOtherWorks ? NRaddressTB.Text : "Адрес офиса рекламного агентства";
            request.Client = request.RequestType.RequireOtherWorks ? clients[NRclientsCB.SelectedIndex] : null;
            request.Status = request.RequestType.RequireOtherWorks ?
                (int)ApplicationEnums.RequestStatuses.Открыта : (int)ApplicationEnums.RequestStatuses.Выполнена;

            using RequestData data = new RequestData(parentForm.Settings.ConnectionString);
            data.InsertData(request, nameof(SQLEnums.StoredProcedureNames.ЗаявкиДобавить));
            Requests.Clear();
        }

        private void AcceptRequestClick(object sender, EventArgs e)
        {
            using RequestData data = new RequestData(parentForm.Settings.ConnectionString);
            RequestModel model = Requests[RequestList.SelectedIndices[0]];
            data.UpdateRequestStatus(model.ID, (int)ApplicationEnums.RequestStatuses.В_работе);
            Requests.Clear();
        }
        private void CreateReportAndCloseButtonClick(object sender, EventArgs e)
        {
            RequestModel request = Requests[RequestList.SelectedIndices[0]];
            string requestFolderPath = parentForm.Settings.FileFolderPath + $"\\{request.Name}{request.Number:0000000000}";
            if (!Directory.Exists(parentForm.Settings.FileFolderPath))
                Directory.CreateDirectory(parentForm.Settings.FileFolderPath);
            if (!Directory.Exists(requestFolderPath))
                Directory.CreateDirectory(requestFolderPath);
            OpenFileDialog fileDialog = new OpenFileDialog() { Multiselect = true };
            if (fileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                foreach (string filename in fileDialog.FileNames)
                    File.Copy(filename, requestFolderPath + filename.Remove(0, filename.LastIndexOf("\\")));
            }
            else
                return;
            if (!Directory.GetFiles(requestFolderPath).Length.Equals(0))
            {
                using RequestData data = new RequestData(parentForm.Settings.ConnectionString);
                data.UpdateRequestStatus(request.ID, (int)ApplicationEnums.RequestStatuses.Выполнена);
            }
            Requests.Clear();
        }

        #endregion buttons
    }
}
