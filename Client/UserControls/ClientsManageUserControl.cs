using Client.Forms;
using DatabaseLibrary;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Enums;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class ClientsManageUserControl : UserControl
    {
        private readonly Color ColdClientColor = Color.FromArgb(135, 206, 250);
        private readonly Color HotClientColor = Color.FromArgb(189, 218, 87);
        private readonly Color ArchiveReasonColor = Color.FromArgb(221, 160, 221);

        private readonly string connectionString;
        private MainForm parentForm;
        private List<ClientModel> clientCollection;
        private List<ArchiveModel> archiveCollection;
        private string currentTarget;
        private string currentValue;

        public ClientsManageUserControl(MainForm parentForm, string connectionString)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.connectionString = connectionString;
            Size = parentForm.CurrentControlSize;
            label1.BackColor = ColdClientColor;
            label2.BackColor = HotClientColor;
            checkBox1.BackColor = ArchiveReasonColor;

            UpdateArchiveList();
            UpdateClientsList();
        }
        private void UpdateArchiveList(int selected = ConstValues.NullIndex)
        {
            using ArchiveData data = new ArchiveData(connectionString);
            archiveCollection = data.GetDataCollection();

            ArchiveList.Items.Clear();
            foreach (var record in archiveCollection)
            {
                List<string> archiveRow = new List<string>();
                archiveRow.Add(record.Client.GetFullName);
                archiveRow.Add(record.Reason);

                ListViewItem sourceItem = new ListViewItem(archiveRow.ToArray());
                sourceItem.BackColor = ArchiveReasonColor;

                ArchiveList.Items.Add(sourceItem);
            }
            if (!selected.Equals(ConstValues.NullIndex) && !ArchiveList.Items.Count.Equals(ConstValues.ZeroIndex))
                ArchiveList.Items[selected].Selected = true;
        }
        private void UpdateClientsList(int selected = ConstValues.NullIndex)
        {
            using SQLExecuter sql = new SQLExecuter(connectionString);
            sql.ExecuteStoreProcedureWithoutParameters(nameof(SQLEnums.StoredProcedureNames.ОбнулитьПустыеДопИнфоКлиентов));
            sql.ExecuteStoreProcedureWithoutParameters(nameof(SQLEnums.StoredProcedureNames.УдалитьПустыеДопИнфо));

            using ClientData data = new ClientData(connectionString);
            if (checkBox1.Checked)
                clientCollection = data.GetDataCollection();
            else
                clientCollection = data.GetDataCollection().Where(x => !archiveCollection.Any(a => a.Client.ID.Equals(x.ID))).ToList();

            ClientsList.Items.Clear();
            foreach (var client in clientCollection)
            {
                List<string> clientRow = new List<string>();
                clientRow.Add(client.MiddleName);
                clientRow.Add(client.FirstName);
                clientRow.Add(client.LastName);
                clientRow.Add(client.ContactNumber);
                clientRow.Add(client.AddtionalInfo != null ? client.AddtionalInfo.AdditionalContactNumber : string.Empty);
                clientRow.Add(client.AddtionalInfo != null ? client.AddtionalInfo.Address : string.Empty);
                clientRow.Add(client.AddtionalInfo != null ? client.AddtionalInfo.Preferences : string.Empty);
                clientRow.Add(client.OrdersCount.ToString());
                ListViewItem sourceItem = new ListViewItem(clientRow.ToArray());
                if (archiveCollection.Any(x => x.Client.ID.Equals(client.ID)))
                    sourceItem.BackColor = ArchiveReasonColor;
                else
                    sourceItem.BackColor = client.AddtionalInfo == null ? ColdClientColor : HotClientColor;
                ClientsList.Items.Add(sourceItem);
            }
            if (!selected.Equals(ConstValues.NullIndex) && !ClientsList.Items.Count.Equals(ConstValues.ZeroIndex))
                ClientsList.Items[selected].Selected = true;
        }
        private void ShowArchivedCheckedEvent(object sender, EventArgs e)
        {
            if (ClientsList.SelectedIndices.Count.Equals(ConstValues.ZeroIndex))
                UpdateClientsList();
            else
                UpdateClientsList(ClientsList.SelectedIndices[ConstValues.ZeroIndex]);
        }

        #region Clients list view doubleclickable

        private void ClientsListMouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = ClientsList.GetItemAt(e.X, e.Y);
            var subItem = item.GetSubItemAt(e.X, e.Y);
            editElemPanel.Visible = true;
            editElemPanel.Location = new Point(0, (subItem.Bounds.Y + 1) + ClientsList.TopItem.Bounds.Top);

            //editValueTextBox.Width = e.X < ClientsList.Columns[ConstValues.ZeroIndex].Width ?
            //    ClientsList.Columns[ConstValues.ZeroIndex].Width :
            //    subItem.Bounds.Width;

            currentValue = subItem.Text;
            currentTarget = ClientsList.Columns[item.SubItems.IndexOf(subItem)].Text;
            editValueTextBox.Mask = string.Empty;
            if (currentTarget.Equals("Контактный номер") || currentTarget.Equals("Доп. контактный номер"))
                editValueTextBox.Mask = "0 ( 000 ) 000 - 00 - 00";
            if (currentTarget.Equals("Всего заказов"))
                editValueTextBox.Mask = "000";
            editValueTextBox.Text = currentValue;
            editLabel.Text = currentTarget;
            editValueTextBox.Focus();
        }

        #region accept

        private void AcceptEditButtonClick(object sender, EventArgs e)
        {
            ClientModel oldModel = clientCollection[ClientsList.SelectedIndices[ConstValues.ZeroIndex]];
            ClientModel client = (ClientModel)oldModel.Clone();
            SwitchCurrentTargetToModelItem(ref client, editValueTextBox.Text);
            using AddditionalClientInfoData addditionalData = new AddditionalClientInfoData(connectionString);
            if (oldModel.AddtionalInfo != null)
                addditionalData.UpdateData(client.AddtionalInfo, nameof(SQLEnums.StoredProcedureNames.ДопинфоИзменить));
            else
                addditionalData.InsertData(client.AddtionalInfo, nameof(SQLEnums.StoredProcedureNames.ДопинфоДобавить));
            using ClientData clientData = new ClientData(connectionString);
            clientData.UpdateData(client, nameof(SQLEnums.StoredProcedureNames.КлиентыИзменить));
            editElemPanel.Visible = false;
            UpdateClientsList(ClientsList.SelectedIndices[ConstValues.ZeroIndex]);
        }

        private void SwitchCurrentTargetToModelItem(ref ClientModel client, string value)
        {
            switch (currentTarget)
            {
                case "Фамилия": client.MiddleName = value; return;
                case "Имя": client.FirstName = value; return;
                case "Отчество": client.LastName = value; return;
                case "Контактный номер": client.ContactNumber = value; return;
                case "Доп. контактный номер":
                    if (client.AddtionalInfo != null)
                        client.AddtionalInfo.AdditionalContactNumber = value;
                    else
                        CreateAdditionalAndAtempToModel(ref client, new string[] { nameof(client.AddtionalInfo.AdditionalContactNumber), value });
                    return;
                case "Адрес":
                    if (client.AddtionalInfo != null)
                        client.AddtionalInfo.Address = value;
                    else
                        CreateAdditionalAndAtempToModel(ref client, new string[] { nameof(client.AddtionalInfo.Address), value });
                    return;
                case "Предпочтения":
                    if (client.AddtionalInfo != null)
                        client.AddtionalInfo.Preferences = value;
                    else
                        CreateAdditionalAndAtempToModel(ref client, new string[] { nameof(client.AddtionalInfo.Preferences), value });
                    return;
            }
        }
        private void CreateAdditionalAndAtempToModel(ref ClientModel client, string[] value)
        {
            AddditionalClientInfoModel addditional = new AddditionalClientInfoModel() { ID = Guid.NewGuid() };
            switch (value[0])
            {
                case nameof(addditional.AdditionalContactNumber):
                    addditional.AdditionalContactNumber = value[1];
                    break;
                case nameof(addditional.Address):
                    addditional.Address = value[1];
                    break;
                case nameof(addditional.Preferences):
                    addditional.Preferences = value[1];
                    break;
            }
            client.AddtionalInfo = addditional;
        }
        private void EditValueTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                editElemPanel.Visible = false;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode.Equals(Keys.Enter))
            {
                acceptEditButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        #endregion accept

        #region decline
        private void ClientsListMouseCaptureChanged(object sender, EventArgs e)
        {
            editElemPanel.Visible = false;
        }
        #endregion decline

        #endregion Clients list view doubleclickable

        #region Client list delete client region

        private void ClientsListSelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ClientsList.Items)
                if (item.Selected)
                {
                    deleteClientButton.Enabled = true;
                    return;
                }
            deleteClientButton.Enabled = false;
        }
        private void DeleteClientButtonClick(object sender, EventArgs e)
        {
            ConfirmClientDeletingForm deletingForm = new ConfirmClientDeletingForm(
                clientCollection[ClientsList.SelectedIndices[ConstValues.ZeroIndex]],
                connectionString
                );
            deletingForm.ShowDialog();
            UpdateArchiveList();
            UpdateClientsList();
        }

        #endregion Client list delete client region

        #region Insert client

        private void InsertClientButtonClick(object sender, EventArgs e)
        {
            using ClientData data = new ClientData(connectionString);
            data.InsertData(
                new ClientModel()
                {
                    ID = Guid.NewGuid(),
                    FirstName = "Имя",
                    MiddleName = "Фамилия",
                    LastName = "Отчество",
                    AddtionalInfo = new AddditionalClientInfoModel(true)
                },
                nameof(SQLEnums.StoredProcedureNames.ЛидДобавить));
            UpdateClientsList();
        }

        #endregion Insert client

        private void CloseViewClick(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
