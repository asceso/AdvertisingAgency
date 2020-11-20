using System;
using System.Drawing;
using System.Windows.Forms;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Enums;
using Infrastructure.Models;

namespace Client.UserControls.RequestTypes
{
    public partial class EditRequestTypeUserControl : UserControl, IClosableUI
    {
        public string ConnectionString { get; set; }
        private readonly RequestTypeModel inputModel;
        private readonly RequestTypeUserControl parrentView;

        public EditRequestTypeUserControl(RequestTypeUserControl parrentView, RequestTypeModel model, string connectionString)
        {
            InitializeComponent();
            this.parrentView = parrentView;
            inputModel = model;
            ConnectionString = connectionString;
            MaximumSize = new Size(Size.Width, Screen.PrimaryScreen.Bounds.Height);

            ResetCurrentModel();
        }

        private void ResetCurrentModel()
        {
            nameTextBox.Text = inputModel.Name;
            descriptionTextBox.Text = inputModel.Description;
        }

        public void CloseViewClick(object sender, EventArgs e)
        {
            parrentView.ActivateFormControls();
            Dispose();
        }

        private void ReturnChangesButtonClick(object sender, EventArgs e) => ResetCurrentModel();
        private RequestTypeModel MapFromTextBoxes()
        {
            return new RequestTypeModel()
            {
                ID = inputModel.ID.Equals(Guid.Empty) ? Guid.NewGuid() : inputModel.ID,
                Name = nameTextBox.Text,
                Description = descriptionTextBox.Text
            };
        }
        private async void SaveAndExitButtonClick(object sender, EventArgs e)
        {
            using RequestTypeData data = new RequestTypeData(ConnectionString);
            if (inputModel.ID.Equals(Guid.Empty))
                await data.InsertDataAsync(MapFromTextBoxes(), nameof(SQLEnums.StoredProcedureNames.ТипыЗаявокДобавить));
            else
                await data.UpdateDataAsync(MapFromTextBoxes(), nameof(SQLEnums.StoredProcedureNames.ТипыЗаявокИзменить));
            parrentView.UpdateDataList();
            closeViewButton.PerformClick();
        }
    }
}
