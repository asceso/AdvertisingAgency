namespace Client.UserControls
{
    partial class ClientsManageUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader ClientMiddleName;
            System.Windows.Forms.ColumnHeader ClientFirstName;
            System.Windows.Forms.ColumnHeader ClientLastName;
            System.Windows.Forms.ColumnHeader ClientContactNumber;
            System.Windows.Forms.ColumnHeader ClientOrdersCount;
            System.Windows.Forms.ColumnHeader ArchiveReason;
            System.Windows.Forms.ColumnHeader ArchiveFIO;
            this.mainPanel = new System.Windows.Forms.Panel();
            this.clientsTabs = new System.Windows.Forms.TabControl();
            this.currentClientsTab = new System.Windows.Forms.TabPage();
            this.editElemPanel = new System.Windows.Forms.Panel();
            this.declineEditButton = new System.Windows.Forms.Button();
            this.acceptEditButton = new System.Windows.Forms.Button();
            this.editValueTextBox = new System.Windows.Forms.MaskedTextBox();
            this.editLabel = new System.Windows.Forms.Label();
            this.clientManageButtons = new System.Windows.Forms.TableLayoutPanel();
            this.insertClientButton = new System.Windows.Forms.Button();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.ClientsList = new System.Windows.Forms.ListView();
            this.ClientContactNumberAdditional = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientPreferences = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.archiveTab = new System.Windows.Forms.TabPage();
            this.ArchiveList = new System.Windows.Forms.ListView();
            this.viewHeader = new System.Windows.Forms.Panel();
            this.headerElements = new System.Windows.Forms.TableLayoutPanel();
            this.showArchived = new System.Windows.Forms.CheckBox();
            this.leadColorLabel = new System.Windows.Forms.Label();
            this.clientColorLabel = new System.Windows.Forms.Label();
            this.closeView = new System.Windows.Forms.Button();
            ClientMiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ClientFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ClientLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ClientContactNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ClientOrdersCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ArchiveReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ArchiveFIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainPanel.SuspendLayout();
            this.clientsTabs.SuspendLayout();
            this.currentClientsTab.SuspendLayout();
            this.editElemPanel.SuspendLayout();
            this.clientManageButtons.SuspendLayout();
            this.archiveTab.SuspendLayout();
            this.viewHeader.SuspendLayout();
            this.headerElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientMiddleName
            // 
            ClientMiddleName.Text = "Фамилия";
            ClientMiddleName.Width = 93;
            // 
            // ClientFirstName
            // 
            ClientFirstName.Text = "Имя";
            ClientFirstName.Width = 113;
            // 
            // ClientLastName
            // 
            ClientLastName.Text = "Отчество";
            ClientLastName.Width = 110;
            // 
            // ClientContactNumber
            // 
            ClientContactNumber.Text = "Контактный номер";
            ClientContactNumber.Width = 130;
            // 
            // ClientOrdersCount
            // 
            ClientOrdersCount.Text = "Всего заказов";
            ClientOrdersCount.Width = 120;
            // 
            // ArchiveReason
            // 
            ArchiveReason.Text = "Причина удаления";
            ArchiveReason.Width = 800;
            // 
            // ArchiveFIO
            // 
            ArchiveFIO.Text = "ФИО Клиента";
            ArchiveFIO.Width = 200;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.clientsTabs);
            this.mainPanel.Controls.Add(this.viewHeader);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(702, 484);
            this.mainPanel.TabIndex = 0;
            // 
            // clientsTabs
            // 
            this.clientsTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsTabs.Controls.Add(this.currentClientsTab);
            this.clientsTabs.Controls.Add(this.archiveTab);
            this.clientsTabs.Location = new System.Drawing.Point(0, 39);
            this.clientsTabs.Name = "clientsTabs";
            this.clientsTabs.SelectedIndex = 0;
            this.clientsTabs.Size = new System.Drawing.Size(700, 443);
            this.clientsTabs.TabIndex = 25;
            // 
            // currentClientsTab
            // 
            this.currentClientsTab.Controls.Add(this.editElemPanel);
            this.currentClientsTab.Controls.Add(this.clientManageButtons);
            this.currentClientsTab.Controls.Add(this.ClientsList);
            this.currentClientsTab.Location = new System.Drawing.Point(4, 22);
            this.currentClientsTab.Name = "currentClientsTab";
            this.currentClientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.currentClientsTab.Size = new System.Drawing.Size(692, 417);
            this.currentClientsTab.TabIndex = 0;
            this.currentClientsTab.Text = "Текущие клиенты";
            this.currentClientsTab.UseVisualStyleBackColor = true;
            // 
            // editElemPanel
            // 
            this.editElemPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editElemPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editElemPanel.Controls.Add(this.declineEditButton);
            this.editElemPanel.Controls.Add(this.acceptEditButton);
            this.editElemPanel.Controls.Add(this.editValueTextBox);
            this.editElemPanel.Controls.Add(this.editLabel);
            this.editElemPanel.Location = new System.Drawing.Point(12, 205);
            this.editElemPanel.Name = "editElemPanel";
            this.editElemPanel.Size = new System.Drawing.Size(674, 25);
            this.editElemPanel.TabIndex = 21;
            this.editElemPanel.Visible = false;
            // 
            // declineEditButton
            // 
            this.declineEditButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.declineEditButton.BackColor = System.Drawing.Color.Firebrick;
            this.declineEditButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.declineEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.declineEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.declineEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.declineEditButton.Location = new System.Drawing.Point(650, 1);
            this.declineEditButton.MaximumSize = new System.Drawing.Size(22, 22);
            this.declineEditButton.Name = "declineEditButton";
            this.declineEditButton.Size = new System.Drawing.Size(22, 22);
            this.declineEditButton.TabIndex = 23;
            this.declineEditButton.Text = "✗";
            this.declineEditButton.UseVisualStyleBackColor = false;
            this.declineEditButton.Click += new System.EventHandler(this.ClientsListMouseCaptureChanged);
            // 
            // acceptEditButton
            // 
            this.acceptEditButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.acceptEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.acceptEditButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.acceptEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.acceptEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptEditButton.Location = new System.Drawing.Point(627, 1);
            this.acceptEditButton.MaximumSize = new System.Drawing.Size(22, 22);
            this.acceptEditButton.Name = "acceptEditButton";
            this.acceptEditButton.Size = new System.Drawing.Size(22, 22);
            this.acceptEditButton.TabIndex = 22;
            this.acceptEditButton.Text = "✓";
            this.acceptEditButton.UseVisualStyleBackColor = false;
            this.acceptEditButton.Click += new System.EventHandler(this.AcceptEditButtonClick);
            // 
            // editValueTextBox
            // 
            this.editValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editValueTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.editValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editValueTextBox.Location = new System.Drawing.Point(161, 1);
            this.editValueTextBox.Name = "editValueTextBox";
            this.editValueTextBox.Size = new System.Drawing.Size(460, 22);
            this.editValueTextBox.TabIndex = 24;
            this.editValueTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.editValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditValueTextBoxKeyDown);
            // 
            // editLabel
            // 
            this.editLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.editLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editLabel.Location = new System.Drawing.Point(0, 0);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(155, 25);
            this.editLabel.TabIndex = 21;
            this.editLabel.Text = "label1";
            this.editLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientManageButtons
            // 
            this.clientManageButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientManageButtons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.clientManageButtons.ColumnCount = 2;
            this.clientManageButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clientManageButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clientManageButtons.Controls.Add(this.insertClientButton, 0, 0);
            this.clientManageButtons.Controls.Add(this.deleteClientButton, 1, 0);
            this.clientManageButtons.Location = new System.Drawing.Point(2, 387);
            this.clientManageButtons.Name = "clientManageButtons";
            this.clientManageButtons.RowCount = 1;
            this.clientManageButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clientManageButtons.Size = new System.Drawing.Size(687, 33);
            this.clientManageButtons.TabIndex = 24;
            // 
            // insertClientButton
            // 
            this.insertClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertClientButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertClientButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertClientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insertClientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.insertClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertClientButton.Location = new System.Drawing.Point(4, 4);
            this.insertClientButton.Name = "insertClientButton";
            this.insertClientButton.Size = new System.Drawing.Size(336, 25);
            this.insertClientButton.TabIndex = 22;
            this.insertClientButton.Text = "Новый клиент";
            this.insertClientButton.UseVisualStyleBackColor = true;
            this.insertClientButton.Click += new System.EventHandler(this.InsertClientButtonClick);
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteClientButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteClientButton.Enabled = false;
            this.deleteClientButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteClientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteClientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.deleteClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteClientButton.Location = new System.Drawing.Point(347, 4);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(336, 25);
            this.deleteClientButton.TabIndex = 23;
            this.deleteClientButton.Text = "Удалить клиента";
            this.deleteClientButton.UseVisualStyleBackColor = true;
            this.deleteClientButton.Click += new System.EventHandler(this.DeleteClientButtonClick);
            // 
            // ClientsList
            // 
            this.ClientsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ClientMiddleName,
            ClientFirstName,
            ClientLastName,
            ClientContactNumber,
            this.ClientContactNumberAdditional,
            this.ClientAddress,
            this.ClientPreferences,
            ClientOrdersCount});
            this.ClientsList.FullRowSelect = true;
            this.ClientsList.GridLines = true;
            this.ClientsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ClientsList.HideSelection = false;
            this.ClientsList.Location = new System.Drawing.Point(3, 3);
            this.ClientsList.MultiSelect = false;
            this.ClientsList.Name = "ClientsList";
            this.ClientsList.Size = new System.Drawing.Size(683, 382);
            this.ClientsList.TabIndex = 0;
            this.ClientsList.UseCompatibleStateImageBehavior = false;
            this.ClientsList.View = System.Windows.Forms.View.Details;
            this.ClientsList.SelectedIndexChanged += new System.EventHandler(this.ClientsListSelectedIndexChanged);
            this.ClientsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ClientsListMouseDoubleClick);
            this.ClientsList.MouseCaptureChanged += new System.EventHandler(this.ClientsListMouseCaptureChanged);
            // 
            // ClientContactNumberAdditional
            // 
            this.ClientContactNumberAdditional.Text = "Доп. контактный номер";
            this.ClientContactNumberAdditional.Width = 140;
            // 
            // ClientAddress
            // 
            this.ClientAddress.Text = "Адрес";
            this.ClientAddress.Width = 265;
            // 
            // ClientPreferences
            // 
            this.ClientPreferences.Text = "Предпочтения";
            this.ClientPreferences.Width = 350;
            // 
            // archiveTab
            // 
            this.archiveTab.Controls.Add(this.ArchiveList);
            this.archiveTab.Location = new System.Drawing.Point(4, 22);
            this.archiveTab.Name = "archiveTab";
            this.archiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.archiveTab.Size = new System.Drawing.Size(692, 417);
            this.archiveTab.TabIndex = 1;
            this.archiveTab.Text = "Архив";
            this.archiveTab.UseVisualStyleBackColor = true;
            // 
            // ArchiveList
            // 
            this.ArchiveList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ArchiveFIO,
            ArchiveReason});
            this.ArchiveList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchiveList.FullRowSelect = true;
            this.ArchiveList.GridLines = true;
            this.ArchiveList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ArchiveList.HideSelection = false;
            this.ArchiveList.Location = new System.Drawing.Point(3, 3);
            this.ArchiveList.MultiSelect = false;
            this.ArchiveList.Name = "ArchiveList";
            this.ArchiveList.Size = new System.Drawing.Size(686, 411);
            this.ArchiveList.TabIndex = 0;
            this.ArchiveList.UseCompatibleStateImageBehavior = false;
            this.ArchiveList.View = System.Windows.Forms.View.Details;
            // 
            // viewHeader
            // 
            this.viewHeader.Controls.Add(this.headerElements);
            this.viewHeader.Controls.Add(this.closeView);
            this.viewHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewHeader.Location = new System.Drawing.Point(0, 0);
            this.viewHeader.Name = "viewHeader";
            this.viewHeader.Size = new System.Drawing.Size(698, 33);
            this.viewHeader.TabIndex = 19;
            // 
            // headerElements
            // 
            this.headerElements.ColumnCount = 4;
            this.headerElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.headerElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.93122F));
            this.headerElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.98413F));
            this.headerElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.headerElements.Controls.Add(this.showArchived, 2, 0);
            this.headerElements.Controls.Add(this.leadColorLabel, 0, 0);
            this.headerElements.Controls.Add(this.clientColorLabel, 1, 0);
            this.headerElements.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerElements.Location = new System.Drawing.Point(0, 0);
            this.headerElements.Name = "headerElements";
            this.headerElements.RowCount = 1;
            this.headerElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerElements.Size = new System.Drawing.Size(567, 33);
            this.headerElements.TabIndex = 26;
            // 
            // showArchived
            // 
            this.showArchived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showArchived.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showArchived.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showArchived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showArchived.Location = new System.Drawing.Point(228, 4);
            this.showArchived.Name = "showArchived";
            this.showArchived.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.showArchived.Size = new System.Drawing.Size(146, 25);
            this.showArchived.TabIndex = 1005;
            this.showArchived.Text = "Удаленные в архив";
            this.showArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showArchived.UseVisualStyleBackColor = true;
            this.showArchived.CheckedChanged += new System.EventHandler(this.ShowArchivedCheckedEvent);
            // 
            // leadColorLabel
            // 
            this.leadColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.leadColorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leadColorLabel.Location = new System.Drawing.Point(3, 4);
            this.leadColorLabel.Name = "leadColorLabel";
            this.leadColorLabel.Size = new System.Drawing.Size(124, 25);
            this.leadColorLabel.TabIndex = 0;
            this.leadColorLabel.Text = "Холодный контакт";
            this.leadColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientColorLabel
            // 
            this.clientColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clientColorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientColorLabel.Location = new System.Drawing.Point(133, 4);
            this.clientColorLabel.Name = "clientColorLabel";
            this.clientColorLabel.Size = new System.Drawing.Size(89, 25);
            this.clientColorLabel.TabIndex = 1001;
            this.clientColorLabel.Text = "Клиент";
            this.clientColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeView
            // 
            this.closeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.closeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeView.Location = new System.Drawing.Point(674, 0);
            this.closeView.MaximumSize = new System.Drawing.Size(24, 24);
            this.closeView.Name = "closeView";
            this.closeView.Size = new System.Drawing.Size(24, 24);
            this.closeView.TabIndex = 1;
            this.closeView.Text = "X";
            this.closeView.UseVisualStyleBackColor = true;
            this.closeView.Click += new System.EventHandler(this.CloseViewClick);
            // 
            // ClientsManageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "ClientsManageUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.mainPanel.ResumeLayout(false);
            this.clientsTabs.ResumeLayout(false);
            this.currentClientsTab.ResumeLayout(false);
            this.editElemPanel.ResumeLayout(false);
            this.editElemPanel.PerformLayout();
            this.clientManageButtons.ResumeLayout(false);
            this.archiveTab.ResumeLayout(false);
            this.viewHeader.ResumeLayout(false);
            this.headerElements.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel viewHeader;
        private System.Windows.Forms.Button closeView;
        private System.Windows.Forms.ListView ClientsList;
        private System.Windows.Forms.Panel editElemPanel;
        private System.Windows.Forms.Button acceptEditButton;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.Button declineEditButton;
        private System.Windows.Forms.MaskedTextBox editValueTextBox;
        private System.Windows.Forms.Label leadColorLabel;
        private System.Windows.Forms.Label clientColorLabel;
        private System.Windows.Forms.Button deleteClientButton;
        private System.Windows.Forms.Button insertClientButton;
        private System.Windows.Forms.TableLayoutPanel clientManageButtons;
        private System.Windows.Forms.TabControl clientsTabs;
        private System.Windows.Forms.TabPage currentClientsTab;
        private System.Windows.Forms.TabPage archiveTab;
        private System.Windows.Forms.ListView ArchiveList;
        private System.Windows.Forms.CheckBox showArchived;
        private System.Windows.Forms.TableLayoutPanel headerElements;
        private System.Windows.Forms.ColumnHeader ClientContactNumberAdditional;
        private System.Windows.Forms.ColumnHeader ClientAddress;
        private System.Windows.Forms.ColumnHeader ClientPreferences;
    }
}
