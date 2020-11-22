using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Client.Forms;
using DatabaseLibrary;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Enums;
using Infrastructure.Models;

namespace Client.UserControls
{
    public partial class ClientsManageUserControl : UserControl, IClosableUI
    {
        #region fields and props

        private readonly Color ColdClientColor = Color.FromArgb(135, 206, 250);
        private readonly Color HotClientColor = Color.FromArgb(189, 218, 87);
        private readonly Color ArchiveReasonColor = Color.FromArgb(221, 160, 221);
        private readonly Color DisabledColor = Color.FromArgb(64, 64, 64);

        private List<ClientModel> clientCollection;
        private List<ArchiveModel> archiveCollection;
        private string currentTarget;
        private string currentValue;
        private readonly MainForm parentForm;

        #endregion fields and props

        #region ctor

        public ClientsManageUserControl(MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            Size = parentForm.CurrentControlSize;
            leadColorLabel.BackColor = ColdClientColor;
            clientColorLabel.BackColor = HotClientColor;
            showArchived.BackColor = ArchiveReasonColor;
            closeView.Dock = (DockStyle)parentForm.Settings.CloseViewButtonPosition;

            if (!parentForm.Settings.ShowAdditionalInfo)
            {
                ClientContactNumberAdditional.Width = 0;
                ClientAddress.Width = 0;
                ClientPreferences.Width = 0;
            }

            UpdateArchiveList();
            UpdateClientsList();
            SetButtonsEnabledByRole();
        }
        private void SetButtonsEnabledByRole()
        {
            insertClientButton.SetVisibleByPermission(
                parentForm.currentUser.CheckPermission(DataPermissions.ClientInsert,
                parentForm.currentPermissions));
            deleteClientButton.SetVisibleByPermission(
                parentForm.currentUser.CheckPermission(DataPermissions.ClientDelete,
                parentForm.currentPermissions));
            acceptEditButton.SetEnabledByPermission(
                parentForm.currentUser.CheckPermission(DataPermissions.ClientUpdate,
                parentForm.currentPermissions),
                DisabledColor);
        }
        private void UpdateArchiveList(int selected = ConstValues.NullIndex)
        {
            using ArchiveData data = new ArchiveData(parentForm.Settings.ConnectionString);
            archiveCollection = data.GetDataCollection();

            ArchiveList.Items.Clear();
            foreach (ArchiveModel record in archiveCollection)
            {
                List<string> archiveRow = new List<string>
                {
                    record.Client.GetFullName,
                    record.Reason
                };

                ListViewItem sourceItem = new ListViewItem(archiveRow.ToArray())
                {
                    BackColor = ArchiveReasonColor
                };

                ArchiveList.Items.Add(sourceItem);
            }
            if (!selected.Equals(ConstValues.NullIndex) && !ArchiveList.Items.Count.Equals(ConstValues.Zero))
            {
                ArchiveList.Items[selected].Selected = true;
            }
        }
        private void UpdateClientsList(int selected = ConstValues.NullIndex)
        {
            using SQLExecuter sql = new SQLExecuter(parentForm.Settings.ConnectionString);
            sql.ExecuteStoreProcedureWithoutParameters(nameof(SQLEnums.StoredProcedureNames.ОбнулитьПустыеДопИнфоКлиентов));
            sql.ExecuteStoreProcedureWithoutParameters(nameof(SQLEnums.StoredProcedureNames.УдалитьПустыеДопИнфо));

            using ClientData data = new ClientData(parentForm.Settings.ConnectionString);
            if (showArchived.Checked)
            {
                clientCollection = data.GetDataCollection();
            }
            else
            {
                clientCollection = data.GetDataCollection().Where(x => !archiveCollection.Any(a => a.Client.ID.Equals(x.ID))).ToList();
            }

            ClientsList.Items.Clear();
            foreach (ClientModel client in clientCollection)
            {
                List<string> clientRow = new List<string>
                {
                    client.MiddleName,
                    client.FirstName,
                    client.LastName,
                    client.ContactNumber,
                    client.AddtionalInfo != null ? client.AddtionalInfo.AdditionalContactNumber : string.Empty,
                    client.AddtionalInfo != null ? client.AddtionalInfo.Address : string.Empty,
                    client.AddtionalInfo != null ? client.AddtionalInfo.Preferences : string.Empty,
                    client.OrdersCount.ToString()
                };
                ListViewItem sourceItem = new ListViewItem(clientRow.ToArray());
                if (archiveCollection.Any(x => x.Client.ID.Equals(client.ID)))
                {
                    sourceItem.BackColor = ArchiveReasonColor;
                }
                else
                {
                    sourceItem.BackColor = client.AddtionalInfo == null ? ColdClientColor : HotClientColor;
                }

                ClientsList.Items.Add(sourceItem);
            }
            if (!selected.Equals(ConstValues.NullIndex) &&
                !ClientsList.Items.Count.Equals(ConstValues.Zero) &&
                selected < ClientsList.Items.Count)
            {
                ClientsList.Items[selected].Selected = true;
            }
        }
        private void ShowArchivedCheckedEvent(object sender, EventArgs e)
        {
            if (ClientsList.SelectedIndices.Count.Equals(ConstValues.Zero))
            {
                UpdateClientsList();
            }
            else
            {
                UpdateClientsList(ClientsList.SelectedIndices[ConstValues.Zero]);
            }
        }

        #endregion ctor

        #region Clients list view doubleclickable

        private void ClientsListMouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = ClientsList.GetItemAt(e.X, e.Y);
            ListViewItem.ListViewSubItem subItem = item.GetSubItemAt(e.X, e.Y);
            editElemPanel.Visible = true;
            editElemPanel.Location = new Point(0, subItem.Bounds.Y + 1 + ClientsList.TopItem.Bounds.Top);
            currentValue = subItem.Text;
            currentTarget = ClientsList.Columns[item.SubItems.IndexOf(subItem)].Text;
            editValueTextBox.Mask = string.Empty;
            if (currentTarget.Equals("Контактный номер") || currentTarget.Equals("Доп. контактный номер"))
            {
                editValueTextBox.Mask = "0 ( 000 ) 000 - 00 - 00";
            }

            if (currentTarget.Equals("Всего заказов"))
            {
                editValueTextBox.Mask = "000";
            }

            editValueTextBox.Text = currentValue;
            editLabel.Text = currentTarget;
            editValueTextBox.SelectAll();
            editValueTextBox.Focus();
        }

        #region accept

        private void AcceptEditButtonClick(object sender, EventArgs e)
        {
            ClientModel oldModel = clientCollection[ClientsList.SelectedIndices[ConstValues.Zero]];
            ClientModel client = (ClientModel)oldModel.Clone();
            SwitchCurrentTargetToModelItem(ref client, editValueTextBox.Text);
            using AddditionalClientInfoData addditionalData = new AddditionalClientInfoData(parentForm.Settings.ConnectionString);
            if (oldModel.AddtionalInfo != null)
            {
                addditionalData.UpdateData(
                    client.AddtionalInfo,
                    nameof(SQLEnums.StoredProcedureNames.ДопинфоИзменить)
                    );
            }
            else
            {
                addditionalData.InsertData(
                    client.AddtionalInfo ?? new AddditionalClientInfoModel(true),
                    nameof(SQLEnums.StoredProcedureNames.ДопинфоДобавить)
                    );
            }

            using ClientData clientData = new ClientData(parentForm.Settings.ConnectionString);
            clientData.UpdateData(client, nameof(SQLEnums.StoredProcedureNames.КлиентыИзменить));
            editElemPanel.Visible = false;
            UpdateClientsList(ClientsList.SelectedIndices[ConstValues.Zero]);
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
                    {
                        client.AddtionalInfo.AdditionalContactNumber = value;
                    }
                    else
                    {
                        CreateAdditionalAndAtempToModel(ref client, new string[] { nameof(client.AddtionalInfo.AdditionalContactNumber), value });
                    }

                    return;
                case "Адрес":
                    if (client.AddtionalInfo != null)
                    {
                        client.AddtionalInfo.Address = value;
                    }
                    else
                    {
                        CreateAdditionalAndAtempToModel(ref client, new string[] { nameof(client.AddtionalInfo.Address), value });
                    }

                    return;
                case "Предпочтения":
                    if (client.AddtionalInfo != null)
                    {
                        client.AddtionalInfo.Preferences = value;
                    }
                    else
                    {
                        CreateAdditionalAndAtempToModel(ref client, new string[] { nameof(client.AddtionalInfo.Preferences), value });
                    }

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
        private void ClientsListMouseCaptureChanged(object sender, EventArgs e) => editElemPanel.Visible = false;

        #endregion decline

        #endregion Clients list view doubleclickable

        #region Client list delete client region

        private void ClientsListSelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ClientsList.Items)
            {
                if (item.Selected)
                {
                    deleteClientButton.Enabled = true;
                    return;
                }
            }

            deleteClientButton.Enabled = false;
        }
        private void DeleteClientButtonClick(object sender, EventArgs e)
        {
            ConfirmClientDeletingForm deletingForm = new ConfirmClientDeletingForm(
                clientCollection[ClientsList.SelectedIndices[ConstValues.Zero]],
                parentForm.Settings.ConnectionString
                );
            deletingForm.ShowDialog();
            UpdateArchiveList();
            UpdateClientsList();
        }

        #endregion Client list delete client region

        #region Insert client

        private void InsertClientButtonClick(object sender, EventArgs e)
        {
            using ClientData data = new ClientData(parentForm.Settings.ConnectionString);
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

        public void CloseViewClick(object sender, EventArgs e) => Dispose();
    }
}
