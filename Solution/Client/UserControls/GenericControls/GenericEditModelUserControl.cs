using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DatabaseLibrary;
using DatabaseLibrary.Data;
using Infrastructure.Models;

namespace Client.UserControls.GenericControls
{
    public partial class GenericEditModelUserControl<ModelType, DataType> : UserControl, IClosableUI
        where DataType : CommonData<ModelType>
        where ModelType : DataModel, new()
    {
        public string TableName { get; set; }

        private readonly ModelType inputModel;
        private readonly GenericModelUserControl<ModelType, DataType> parrentView;
        private List<object[]> modelBoxes;

        private readonly DataType data;

        public GenericEditModelUserControl(
            GenericModelUserControl<ModelType, DataType> parrentView,
            ModelType model)
        {
            InitializeComponent();
            this.parrentView = parrentView;
            inputModel = model;
            MaximumSize = new Size(Size.Width, Screen.PrimaryScreen.Bounds.Height);
            data = (DataType)Activator.CreateInstance(typeof(DataType));
            data.connection.ConnectionString = parrentView.parentForm.Settings.ConnectionString;

            SetUserControlInterface();
            ResetCurrentModel();
        }
        private void SetUserControlInterface()
        {
            IEnumerable<PropertyInfo> headers = typeof(ModelType).GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                .Where(p => !p.PropertyType.Equals(typeof(Guid)));

            IEnumerable<object> headersName = headers.Select(x => x.CustomAttributes
                .FirstOrDefault(c => c.AttributeType.Equals(typeof(DescriptionAttribute)))
                .ConstructorArguments[ConstValues.Zero].Value);

            List<object> valueTypes = headers.Select(x => x.CustomAttributes
                .FirstOrDefault(c => c.AttributeType.Equals(typeof(ItemType)))
                .ConstructorArguments[ConstValues.Zero].Value).ToList();

            int elemCounter = 0;
            List<object> controls = new List<object>();
            foreach (object header in headersName)
            {
                Panel elementPanel = new Panel
                {
                    Dock = DockStyle.Top
                };

                Label elementLabel = new Label()
                {
                    Text = header.ToString(),
                    Dock = DockStyle.Top,
                    AutoSize = false,
                    TextAlign = ContentAlignment.BottomCenter,
                    Size = new Size(elementPanel.Size.Width, 30)
                };

                Control elementValueBox = null;

                if (valueTypes[elemCounter].Equals("TextBox"))
                {
                    elementValueBox = new TextBox()
                    {
                        Name = $"elementBox{elemCounter}",
                        Dock = DockStyle.Top
                    };
                }
                if (valueTypes[elemCounter].Equals("CheckBox"))
                {
                    elementValueBox = new ComboBox()
                    {
                        Name = $"elementBox{elemCounter}",
                        Dock = DockStyle.Top,
                        Items = { "Да", "Нет" },
                        DropDownStyle = ComboBoxStyle.DropDownList,
                        FlatStyle = FlatStyle.Flat
                    };
                }

                elementPanel.Controls.Add(elementValueBox);
                elementPanel.Controls.Add(elementLabel);

                Size panelSize = new Size();
                foreach (object item in elementPanel.Controls)
                {
                    panelSize.Height += (item as Control).Height;
                }

                panelSize.Width = elementPanel.Width;

                elementPanel.Size = panelSize;
                controls.Add(elementPanel);
                elemCounter++;
            }

            foreach (object item in controls.Reverse<object>())
            {
                modelPanel.Controls.Add(item as Control);
            }
        }
        private void ResetCurrentModel()
        {
            modelBoxes = new List<object[]>();
            foreach (Panel item in modelPanel.Controls)
            {
                object[] headersAndValues = new object[] { null, null };
                foreach (object subitem in item.Controls)
                {
                    if (subitem is Label labelElem)
                        headersAndValues[0] = labelElem;

                    if (subitem is TextBox textBoxElem)
                        headersAndValues[1] = textBoxElem;

                    if (subitem is ComboBox comboBoxElem)
                        headersAndValues[1] = comboBoxElem;
                }
                modelBoxes.Add(headersAndValues);
            }
            for (int i = 0; i < modelPanel.Controls.Count; i++)
            {
                IEnumerable<PropertyInfo> headers = inputModel.GetType().GetProperties()
                                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                                .Where(p => !p.PropertyType.Equals(typeof(Guid)));

                PropertyInfo prop = headers
                    .FirstOrDefault(p => p.CustomAttributes
                    .FirstOrDefault(c => c.AttributeType.Equals(typeof(DescriptionAttribute)))
                    .ConstructorArguments.FirstOrDefault().Value.Equals((modelBoxes[i][0] as Label).Text));

                object propValue = prop.GetValue(inputModel);
                if (propValue is bool boolProp)
                    (modelBoxes[i][1] as ComboBox).SelectedItem = boolProp ? "Да" : "Нет";
                if (propValue is double doubleProp)
                    (modelBoxes[i][1] as TextBox).Text = doubleProp.ToString();
                if (propValue is string boolString)
                    (modelBoxes[i][1] as TextBox).Text = boolString;
            }
        }

        public void CloseViewClick(object sender, EventArgs e)
        {
            parrentView.ActivateFormControls();
            Dispose();
        }

        private void ReturnChangesButtonClick(object sender, EventArgs e) => ResetCurrentModel();

        private ModelType MapFromTextBoxes()
        {
            ModelType mappedModel = new ModelType()
            {
                ID = inputModel.ID.Equals(Guid.Empty) ? Guid.NewGuid() : inputModel.ID
            };
            for (int i = 0; i < modelPanel.Controls.Count; i++)
            {
                IEnumerable<System.Reflection.PropertyInfo> headers = inputModel.GetType().GetProperties()
                                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                                .Where(p => !p.PropertyType.Equals(typeof(Guid)));

                System.Reflection.PropertyInfo prop = headers
                    .FirstOrDefault(p => p.CustomAttributes
                    .FirstOrDefault(c => c.AttributeType.Equals(typeof(DescriptionAttribute)))
                    .ConstructorArguments.FirstOrDefault().Value.Equals((modelBoxes[i][0] as Label).Text));

                object propObject = null;
                if (prop.PropertyType.Equals(typeof(double)))
                    propObject = Convert.ToDouble((modelBoxes[i][1] as TextBox).Text);

                if (prop.PropertyType.Equals(typeof(int)))
                    propObject = Convert.ToInt32((modelBoxes[i][1] as TextBox).Text);

                if (prop.PropertyType.Equals(typeof(string)))
                    propObject = (modelBoxes[i][1] as TextBox).Text;

                if (prop.PropertyType.Equals(typeof(bool)))
                    propObject = (modelBoxes[i][1] as ComboBox).Text.Equals("Да");

                prop.SetValue(mappedModel, propObject);
            }
            return mappedModel;
        }
        private void SaveAndExitButtonClick(object sender, EventArgs e)
        {
            ModelType mappedModel = MapFromTextBoxes();

            if (inputModel.ID.Equals(Guid.Empty))
                data.InsertDataWithSqlGeneratedQuery(mappedModel);
            else
                data.UpdateDataWithSqlGeneratedQuery(mappedModel);

            parrentView.UpdateDataList();
            closeView.PerformClick();
        }
    }
}
