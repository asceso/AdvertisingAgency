using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public string ConnectionString { get; set; }
        public string TableName { get; set; }

        private readonly ModelType inputModel;
        private readonly GenericModelUserControl<ModelType, DataType> parrentView;
        private List<object[]> modelBoxes;

        private readonly DataType data;

        public GenericEditModelUserControl(
            GenericModelUserControl<ModelType, DataType> parrentView,
            ModelType model,
            string connectionString)
        {
            InitializeComponent();
            this.parrentView = parrentView;
            inputModel = model;
            ConnectionString = connectionString;
            MaximumSize = new Size(Size.Width, Screen.PrimaryScreen.Bounds.Height);
            data = (DataType)Activator.CreateInstance(typeof(DataType));
            data.connection.ConnectionString = connectionString;

            SetUserControlInterface();
            ResetCurrentModel();
        }
        private void SetUserControlInterface()
        {
            var headers = typeof(ModelType).GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                .Where(p => !p.PropertyType.Equals(typeof(Guid)));

            var headersName = headers.Select(x => x.CustomAttributes
                .FirstOrDefault(c => c.AttributeType.Equals(typeof(DescriptionAttribute)))
                .ConstructorArguments[ConstValues.Zero].Value);

            int elemCounter = 1;
            List<object> controls = new List<object>();
            foreach (var header in headersName)
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

                TextBox elementTextBox = new TextBox()
                {
                    Name = $"textBox{elemCounter++}",
                    Dock = DockStyle.Top
                };

                elementPanel.Controls.Add(elementTextBox);
                elementPanel.Controls.Add(elementLabel);

                Size panelSize = new Size();
                foreach (var item in elementPanel.Controls)
                    panelSize.Height += (item as Control).Height;
                panelSize.Width = elementPanel.Width;

                elementPanel.Size = panelSize;
                controls.Add(elementPanel);
            }

            foreach (var item in controls.Reverse<object>())
                modelPanel.Controls.Add(item as Control);
        }
        private void ResetCurrentModel()
        {
            modelBoxes = new List<object[]>();
            foreach (Panel item in modelPanel.Controls)
            {
                object[] headersAndValues = new object[] { null, null };
                foreach (var subitem in item.Controls)
                {
                    if (subitem is Label)
                        headersAndValues[0] = subitem as Label;
                    if (subitem is TextBox)
                        headersAndValues[1] = subitem as TextBox;
                }
                modelBoxes.Add(headersAndValues);
            }
            for (int i = 0; i < modelPanel.Controls.Count; i++)
            {
                var headers = inputModel.GetType().GetProperties()
                                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                                .Where(p => !p.PropertyType.Equals(typeof(Guid)));

                var prop = headers
                    .FirstOrDefault(p => p.CustomAttributes
                    .FirstOrDefault(c => c.AttributeType.Equals(typeof(DescriptionAttribute)))
                    .ConstructorArguments.FirstOrDefault().Value.Equals((modelBoxes[i][0] as Label).Text));

                object propValue = prop.GetValue(inputModel);
                (modelBoxes[i][1] as TextBox).Text = propValue.ToString();
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
                var headers = inputModel.GetType().GetProperties()
                                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                                .Where(p => !p.PropertyType.Equals(typeof(Guid)));

                var prop = headers
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
            closeViewButton.PerformClick();
        }
    }
}
