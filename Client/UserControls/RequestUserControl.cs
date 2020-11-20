using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Client.Forms;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Models;

namespace Client.UserControls
{
    public partial class RequestUserControl : UserControl, IClosableUI
    {
        #region fields and props

        enum RequestStatuses { Открыта, Закрыта, Отменена, Удалена }

        private List<RequestTypeModel> requestTypes;
        private List<ServiceModel> services;
        private List<ClientModel> clients;
        private readonly UserModel currentUser;

        public ObservableCollection<RequestModel> Requests;

        public string ConnectionString { get; set; }

        #endregion fields and props

        #region ctor
        public RequestUserControl(MainForm parentForm, string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;
            Size = parentForm.CurrentControlSize;
            currentUser = parentForm.currentUser;
            Requests = new ObservableCollection<RequestModel>();
            closeView.Dock = (DockStyle)parentForm.Settings.CloseViewButtonPosition;

            UpdateDictionaries();
            UpdateRequestCollection();
        }
        #endregion ctor

        #region Update data
        private void UpdateDictionaries()
        {
            using RequestTypeData requestData = new RequestTypeData(ConnectionString);
            requestTypes = requestData.GetDataCollection();
            using ServiceData serviceData = new ServiceData(ConnectionString);
            services = serviceData.GetDataCollection();
            using ClientData clientData = new ClientData(ConnectionString);
            clients = clientData.GetDataCollection();
        }

        private void UpdateRequestCollection()
        {
            using RequestData data = new RequestData(ConnectionString);
            var retrieved = data.GetDataCollection();

            Requests.Clear();
            retrieved.ForEach(d => Requests.Add(d));
        }
        #endregion Update data

        public void CloseViewClick(object sender, EventArgs e) => Dispose();
    }
}
