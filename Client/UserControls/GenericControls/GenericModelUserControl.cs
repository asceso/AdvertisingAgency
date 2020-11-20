using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Client.Forms;
using DatabaseLibrary;
using DatabaseLibrary.Data;
using Infrastructure.Methods;
using Infrastructure.Models;

namespace Client.UserControls.GenericControls
{
    public partial class GenericModelUserControl<ModelType, DataType> : UserControl, IClosableUI
        where DataType : CommonData<ModelType>
        where ModelType : DataModel, new()
    {
        #region ctor
        internal SettingsModel Settings;
        private readonly DataType data;

        #region props

        public string ConnectionString { get; set; }
        public string TableName { get; set; }

        public ObservableCollection<ModelType> Models { get; set; }

        #endregion props

        public GenericModelUserControl(MainForm parentForm, string connectionString, string tableName, bool[] permissionStates)
        {
            InitializeComponent();

            insertButton.Visible = permissionStates[0];
            updateButton.Visible = permissionStates[1];
            deleteButton.Visible = permissionStates[2];

            ConnectionString = connectionString;
            TableName = tableName;
            Settings = parentForm.Settings;
            Size = parentForm.CurrentControlSize;
            closeView.Dock = (DockStyle)parentForm.Settings.CloseViewButtonPosition;
            Models = new ObservableCollection<ModelType>();
            data = (DataType)Activator.CreateInstance(typeof(DataType));
            data.connection.ConnectionString = connectionString;
            data.TableName = tableName;
            Models.CollectionChanged += ModelsCollectionChanged;

            SetUserControlInterface();
            UpdateDataList();
        }
        private void SetUserControlInterface()
        {
            headerLabel.Text = TableName;
            var headers = typeof(ModelType).GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                .Where(p => !p.PropertyType.Equals(typeof(Guid)));

            var headersName = headers.Select(x => x.CustomAttributes
                .FirstOrDefault(c => c.AttributeType.Equals(typeof(DescriptionAttribute)))
                .ConstructorArguments[ConstValues.Zero].Value);

            foreach (var item in headersName)
            {
                ColumnHeader column = new ColumnHeader
                {
                    Text = item.ToString(),
                    Width = 250
                };
                SourceList.Columns.Add(column);
            }
        }
        #endregion ctor

        #region models observe event

        private void ModelsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        ModelType data = e.NewItems[0] as ModelType;
                        string[] collumnValues = new string[SourceList.Columns.Count];

                        for (int i = 0; i < collumnValues.Length; i++)
                        {
                            var headers = data.GetType().GetProperties()
                                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                                .Where(p => !p.PropertyType.Equals(typeof(Guid)));

                            var prop = headers
                                .FirstOrDefault(p => p.CustomAttributes
                                .FirstOrDefault(c => c.AttributeType.Equals(typeof(DescriptionAttribute)))
                                .ConstructorArguments[ConstValues.Zero].Value.Equals(SourceList.Columns[i].Text));

                            object propValue = prop.GetValue(data);

                            collumnValues[i] = propValue is DataModel ? (propValue as DataModel).Name : propValue.ToString();
                        }

                        SourceList.Items.Add(new ListViewItem(collumnValues));
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    {
                        ModelType temp = e.OldItems[0] as ModelType;
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

        #region update list

        internal void UpdateDataList(int selected = ConstValues.NullIndex)
        {
            List<ModelType> retrieved = data.GetDataCollection();
            Models.Clear();
            retrieved.ForEach(x => Models.Add(x));

            if (!selected.Equals(ConstValues.NullIndex) && !SourceList.Items.Count.Equals(ConstValues.Zero))
                SourceList.Items[selected].Selected = true;
            else
                SetUpdateDeleteButtonsEnabled(0b_00);
        }

        #endregion update list

        #region buttons

        #region insert
        private void InsertButtonClick(object sender, EventArgs e)
        {
            GenericEditModelUserControl<ModelType, DataType> view = new GenericEditModelUserControl<ModelType, DataType>(
                this, new ModelType() { ID = Guid.Empty },
                ConnectionString);

            ActivateEditView(view);
        }
        #endregion insert

        #region update
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            GenericEditModelUserControl<ModelType, DataType> view = new GenericEditModelUserControl<ModelType, DataType>(
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

        private void ActivateEditView(Control view)
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
