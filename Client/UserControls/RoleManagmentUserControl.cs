using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class RoleManagmentUserControl : UserControl, IClosableUI
    {
        #region fields and props

        private SettingsModel settings;
        private readonly MainForm parentForm;
        private Dictionary<Guid, List<Guid>> RolePositionPair;
        private Dictionary<Guid, List<Guid>> RolePermissionPair;
        private Dictionary<Guid, List<Guid>> dbRolePermissionPair;

        public ObservableCollection<RoleModel> Roles;
        public ObservableCollection<PositionModel> Positions;
        public ObservableCollection<PermissionModel> Permissions;

        public string ConnectionString { get; set; }

        #endregion fields and props

        #region ctor

        public RoleManagmentUserControl(MainForm parentForm, SettingsModel settings)
        {
            InitializeComponent();
            this.settings = settings;
            this.parentForm = parentForm;

            Roles = new ObservableCollection<RoleModel>();
            Positions = new ObservableCollection<PositionModel>();
            Permissions = new ObservableCollection<PermissionModel>();

            Size = parentForm.CurrentControlSize;
            closeView.Dock = (DockStyle)parentForm.Settings.CloseViewButtonPosition;
            UpdateSource();
            ResetModels();
        }

        private void ResetModels()
        {
            settings = SettingsMethods.ReadConfig();

            RolePositionPair = settings.RolePositionsDictionary;
            for (int i = 0; i < blockACheckedListBox.Items.Count; i++)
            {
                blockACheckedListBox.SetItemChecked(i, false);
            }

            RolePermissionPair = new Dictionary<Guid, List<Guid>>();
            dbRolePermissionPair = new Dictionary<Guid, List<Guid>>();
            using (PermissionData data = new PermissionData(settings.ConnectionString))
            {
                foreach (RoleModel role in Roles)
                {
                    List<PermissionModel> rolePermissionRetrieved = data.GetPermissionListByRoleGuid(role.ID);
                    foreach (PermissionModel perm in rolePermissionRetrieved)
                    {
                        dbRolePermissionPair.AddWithKey(role.ID, perm.ID);
                    }
                }
            }

            foreach (KeyValuePair<Guid, List<Guid>> item in dbRolePermissionPair)
            {
                foreach (Guid value in item.Value)
                {
                    RolePermissionPair.AddWithKey(item.Key, value);
                }
            }

            blockAListBox.SelectedIndex = -1;
            blockACheckedListBox.SelectedIndex = -1;
        }

        private void UpdateSource()
        {
            using RoleData roleData = new RoleData(settings.ConnectionString);
            using PositionData positionData = new PositionData(settings.ConnectionString);
            using PermissionData permissionData = new PermissionData(settings.ConnectionString);

            List<RoleModel> retrievedRoles = roleData.GetDataCollection();
            retrievedRoles.ForEach(x => Roles.Add(x));
            Roles.Remove(Roles.FirstOrDefault(r => r.Name.Equals("Administrator")));
            Roles.Remove(Roles.FirstOrDefault(r => r.Name.Equals("nullRole")));

            List<PositionModel> retrievedPositions = positionData.GetDataCollection();
            retrievedPositions.ForEach(x => Positions.Add(x));
            Positions.Remove(Positions.FirstOrDefault(r => r.Name.Equals("Директор")));

            List<PermissionModel> retrievedPermissions = permissionData.GetDataCollection();
            retrievedPermissions.ForEach(x => Permissions.Add(x));
            FillListCollections();
        }
        private void FillListCollections()
        {
            blockAListBox.Items.Clear();
            blockBListBox.Items.Clear();
            foreach (RoleModel item in Roles)
            {
                blockAListBox.Items.Add(item.Name);
                blockBListBox.Items.Add(item.Name);
            }
            blockACheckedListBox.Items.Clear();
            blockBCheckedListBox.Items.Clear();
            foreach (PositionModel item in Positions)
            {
                blockACheckedListBox.Items.Add(item.Name);
            }

            foreach (PermissionModel item in Permissions)
            {
                blockBCheckedListBox.Items.Add(item.Description);
            }
        }

        #endregion ctor

        #region selecting

        #region blockA

        private void BlockAListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            blockACheckedListBox.Enabled = !blockAListBox.SelectedIndex.Equals(-1);

            if (!blockACheckedListBox.Enabled)
            {
                return;
            }

            List<Guid> selectedGuids = RolePositionPair[Roles.FirstOrDefault(r => r.Name.Equals(blockAListBox.SelectedItem)).ID];

            for (int i = 0; i < blockACheckedListBox.Items.Count; i++)
            {
                blockACheckedListBox.SetItemChecked(i, false);
            }

            for (int i = 0; i < blockACheckedListBox.Items.Count; i++)
            {
                blockACheckedListBox.SetItemChecked(i, selectedGuids.Any(p => p.Equals(Positions.FirstOrDefault(x => x.Name.Equals(blockACheckedListBox.Items[i])).ID)));
            }
        }
        private void BlockACheckedListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (blockACheckedListBox.SelectedIndex.Equals(-1))
            {
                return;
            }

            Guid pairGuid = Roles.FirstOrDefault(r => r.Name.Equals(blockAListBox.SelectedItem)).ID;
            Guid selectedGuid = Positions.FirstOrDefault(p => p.Name.Equals(blockACheckedListBox.SelectedItem)).ID;

            if (!RolePositionPair.ContainsKey(pairGuid))
            {
                return;
            }

            List<Guid> currentPair = RolePositionPair[pairGuid];

            if (currentPair.Contains(selectedGuid))
            {
                RolePositionPair[pairGuid].Remove(selectedGuid);
            }
            else
            {
                RolePositionPair[pairGuid].Add(selectedGuid);
            }

            RolePositionPair[pairGuid] = currentPair;
        }

        #endregion blockA

        #region blockB

        private void BlockBListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            blockBCheckedListBox.Enabled = !blockBListBox.SelectedIndex.Equals(-1);

            if (!blockBCheckedListBox.Enabled)
            {
                return;
            }

            List<Guid> selectedGuids = RolePermissionPair[Roles
                .FirstOrDefault(r => r.Name
                .Equals(blockBListBox.SelectedItem)).ID];

            for (int i = 0; i < blockBCheckedListBox.Items.Count; i++)
            {
                blockBCheckedListBox.SetItemChecked(i, false);
            }

            for (int i = 0; i < blockBCheckedListBox.Items.Count; i++)
            {
                blockBCheckedListBox.SetItemChecked(i, selectedGuids
                    .Any(p => p
                    .Equals(Permissions
                    .FirstOrDefault(x => x.Description
                    .Equals(blockBCheckedListBox.Items[i])).ID)));
            }
        }

        //todo: Переделать по типу blockA
        private void BlockBCheckedListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (blockBCheckedListBox.SelectedIndex.Equals(-1))
            {
                return;
            }

            Guid pairGuid = Roles.FirstOrDefault(r => r.Name.Equals(blockBListBox.SelectedItem)).ID;
            Guid selectedGuid = Permissions.FirstOrDefault(p => p.Description.Equals(blockBCheckedListBox.SelectedItem)).ID;

            if (!RolePermissionPair.ContainsKey(pairGuid))
            {
                return;
            }

            List<Guid> currentPair = RolePermissionPair[pairGuid];

            if (currentPair.Contains(selectedGuid))
            {
                RolePermissionPair[pairGuid].Remove(selectedGuid);
            }
            else
            {
                RolePermissionPair[pairGuid].Add(selectedGuid);
            }

            RolePermissionPair[pairGuid] = currentPair;
        }

        #endregion blockB

        #endregion selecting

        #region buttons

        public void CloseViewClick(object sender, EventArgs e)
            => parentForm.ChangeUserControl(new SettingsUserControl(parentForm));

        private void ReturnChangesButtonClick(object sender, EventArgs e) => ResetModels();

        //todo:доработать сохранение настроек
        private void SaveANDexitButtonClick(object sender, EventArgs e)
        {
            CompareRolePermissionsAndUpdateDatabase(dbRolePermissionPair, RolePermissionPair);
            SettingsModel model = (SettingsModel)settings.Clone();
            model.RolePositionsDictionary = RolePositionPair;
            SettingsMethods.SetConfig(model);
            closeView.PerformClick();
        }
        private void CompareRolePermissionsAndUpdateDatabase(
            Dictionary<Guid, List<Guid>> collectionOne,
            Dictionary<Guid, List<Guid>> collectionTwo)
        {
            //stage 0: check deleting and addditional
            Dictionary<Guid, List<Guid>> deletedPair = new Dictionary<Guid, List<Guid>>();
            Dictionary<Guid, List<Guid>> additionalPair = new Dictionary<Guid, List<Guid>>();

            foreach (Guid key in collectionOne.Keys)
            {
                IEnumerable<Guid> exceptDeleted = collectionOne[key].Except(collectionTwo[key]);
                foreach (Guid item in exceptDeleted)
                {
                    deletedPair.AddWithKey(key, item);
                }

                IEnumerable<Guid> exceptAdditional = collectionTwo[key].Except(collectionOne[key]);
                foreach (Guid item in exceptAdditional)
                {
                    additionalPair.AddWithKey(key, item);
                }
            }

            using RolePermissionData data = new RolePermissionData(settings.ConnectionString);

            //stage 1: add new pairs in DB
            foreach (Guid key in additionalPair.Keys)
            {
                foreach (Guid value in additionalPair[key])
                {
                    data.InsertData(new RolePermissionModel()
                    {
                        ID = Guid.NewGuid(),
                        RoleGuid = key,
                        PermissionGuid = value
                    },
                    nameof(SQLEnums.StoredProcedureNames.РазрешенияРолейДобавить));
                }
            }

            //stage 2: delete old pairs in DB
            foreach (Guid key in deletedPair.Keys)
            {
                foreach (Guid value in deletedPair[key])
                {
                    data.DeleteDataByRoleGuidAndPermissionGuid(key, value);
                }
            }
        }

        #endregion buttons
    }
}
