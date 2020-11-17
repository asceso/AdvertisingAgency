using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Enums;
using System;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class ConfirmClientDeletingForm : Form
    {
        private ClientModel client;
        private string connectionString;
        public ConfirmClientDeletingForm(ClientModel client, string connectionString)
        {
            InitializeComponent();
            this.client = client;
            this.connectionString = connectionString;
        }
        private void ReasonTextChanged(object sender, EventArgs e) => acceptButton.Enabled = !string.IsNullOrEmpty(reasonBox.Text);
        private void AcceptButtonClick(object sender, EventArgs e) => OnAccept();

        private async void OnAccept()
        {
            using ArchiveData data = new ArchiveData(connectionString);
            await data.InsertDataAsync(
                new ArchiveModel()
                {
                    ID = Guid.NewGuid(),
                    Client = client,
                    Reason = reasonBox.Text
                },
                nameof(SQLEnums.StoredProcedureNames.ПереносКлиентаВАрхив)
                );
            Close();
        }
    }
}
