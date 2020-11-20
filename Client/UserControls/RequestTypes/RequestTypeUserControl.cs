using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;
using Client.Forms;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Methods;
using Infrastructure.Models;

namespace Client.UserControls.RequestTypes
{
    public partial class RequestTypeUserControl : UserControl, IClosableUI
    {
        #region ctor

        #region props

        public string ConnectionString { get; set; }
        public ObservableCollection<RequestTypeModel> Models { get; set; }

        #endregion props

        public RequestTypeUserControl(MainForm parentForm, string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;
            Size = parentForm.CurrentControlSize;
            Models = new ObservableCollection<RequestTypeModel>();
            Models.CollectionChanged += ModelsCollectionChanged;

            UpdateDataList();
        }

        #endregion ctor

        #region update list

        internal void UpdateDataList(int selected = ConstValues.NullIndex)
        {
            using RequestTypeData data = new RequestTypeData(ConnectionString);
            List<RequestTypeModel> retrieved = data.GetDataCollection();
            Models.Clear();
            retrieved.ForEach(x => Models.Add(x));

            if (!selected.Equals(ConstValues.NullIndex) && !SourceList.Items.Count.Equals(ConstValues.Zero))
                SourceList.Items[selected].Selected = true;
            else
                SetUpdateDeleteButtonsEnabled(0b_00);
        }

        #endregion update list

        #region models observe event

        private void ModelsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        RequestTypeModel data = e.NewItems[0] as RequestTypeModel;
                        SourceList.Items.Add(new ListViewItem(new string[] {
                            data.Name, data.Description
                        }));
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    {
                        RequestTypeModel temp = e.OldItems[0] as RequestTypeModel;
                        using RequestTypeData data = new RequestTypeData(ConnectionString);
                        data.DeleteDataByGuid(temp.ID).Equals(ConstValues.Zero);
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    {
                        SourceList.Items.Clear();
                    }
                    break;
            }
        }

        #endregion models observe event

        #region buttons

        #region insert
        private void InsertButtonClick(object sender, EventArgs e)
        {
            EditRequestTypeUserControl view = new EditRequestTypeUserControl(
                this, new RequestTypeModel() { ID = Guid.Empty },
                ConnectionString);

            ActivateEditView(view);
        }
        #endregion insert

        #region update
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            EditRequestTypeUserControl view = new EditRequestTypeUserControl(
                this, Models[SourceList.SelectedIndices[ConstValues.Zero]],
                ConnectionString);

            ActivateEditView(view);
        }
        private void SourceListMouseDoubleClick(object sender, MouseEventArgs e) => updateButton.PerformClick();
        #endregion update

        #region delete
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (SourceList.SelectedItems.Count <= 1)
            {
                if (!MessageBoxImplementation.AskMessageBox("Удалить запись?"))
                    return;
                Models.RemoveAt(SourceList.SelectedIndices[ConstValues.Zero]);
            }
            else
            {
                if (!MessageBoxImplementation.AskMessageBox($"Будет удалено {SourceList.SelectedItems.Count} записей, продолжить?"))
                    return;

                for (int i = SourceList.SelectedIndices.Count - 1; i >= ConstValues.Zero; i--)
                    Models.RemoveAt(SourceList.SelectedIndices[i]);
            }
            UpdateDataList();
        }
        private void SourceListKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete))
                deleteButton.PerformClick();
        }
        #endregion delete

        private void RefreshButtonClick(object sender, EventArgs e) => UpdateDataList();

        public void CloseViewClick(object sender, EventArgs e) => Dispose();

        #endregion buttons

        #region activate controls

        private void ActivateEditView(EditRequestTypeUserControl view)
        {
            view.Location = new Point(Right - view.Size.Width, Top);
            view.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top;
            view.Size = new Size((int)(Size.Width / 1.5), Size.Height);
            view.BackColor = Color.Transparent;

            Controls.Add(view);
            view.BringToFront();
            foreach (Control item in Controls)
            {
                if (!item.Equals(view))
                    item.Enabled = false;
            }
        }

        public void ActivateFormControls()
        {
            foreach (Control item in Controls)
                item.Enabled = true;
        }

        #endregion activate controls

        #region other

        private void SourceListSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SourceList.SelectedIndices.Count)
            {
                case 0:
                    SetUpdateDeleteButtonsEnabled(0b_00);
                    break;
                case 1:
                    SetUpdateDeleteButtonsEnabled(0b_11);
                    break;
                default:
                    SetUpdateDeleteButtonsEnabled(0b_01);
                    break;
            }
        }

        private void SetUpdateDeleteButtonsEnabled(int state)
        {
            updateButton.Enabled = state.Equals(3);
            deleteButton.Enabled = state.Equals(1) || state.Equals(3);
        }

        #endregion other
    }
}
