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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.editElemPanel = new System.Windows.Forms.Panel();
            this.declineEditButton = new System.Windows.Forms.Button();
            this.acceptEditButton = new System.Windows.Forms.Button();
            this.editValueTextBox = new System.Windows.Forms.MaskedTextBox();
            this.editLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.insertClientButton = new System.Windows.Forms.Button();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.ClientsList = new System.Windows.Forms.ListView();
            this.MiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactNumberAdditional = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preferences = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrdersCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ArchiveList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closeView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.editElemPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 484);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 443);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editElemPanel);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.ClientsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Текущие клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.insertClientButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteClientButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 387);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 33);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // insertClientButton
            // 
            this.insertClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertClientButton.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.MiddleName,
            this.FirstName,
            this.LastName,
            this.ContactNumber,
            this.ContactNumberAdditional,
            this.Address,
            this.Preferences,
            this.OrdersCount});
            this.ClientsList.FullRowSelect = true;
            this.ClientsList.GridLines = true;
            this.ClientsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ClientsList.HideSelection = false;
            this.ClientsList.Location = new System.Drawing.Point(3, 6);
            this.ClientsList.MultiSelect = false;
            this.ClientsList.Name = "ClientsList";
            this.ClientsList.Size = new System.Drawing.Size(683, 379);
            this.ClientsList.TabIndex = 0;
            this.ClientsList.UseCompatibleStateImageBehavior = false;
            this.ClientsList.View = System.Windows.Forms.View.Details;
            this.ClientsList.SelectedIndexChanged += new System.EventHandler(this.ClientsListSelectedIndexChanged);
            this.ClientsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ClientsListMouseDoubleClick);
            this.ClientsList.MouseCaptureChanged += new System.EventHandler(this.ClientsListMouseCaptureChanged);
            // 
            // MiddleName
            // 
            this.MiddleName.Text = "Фамилия";
            this.MiddleName.Width = 80;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Имя";
            this.FirstName.Width = 80;
            // 
            // LastName
            // 
            this.LastName.Text = "Отчество";
            this.LastName.Width = 80;
            // 
            // ContactNumber
            // 
            this.ContactNumber.Text = "Контактный номер";
            this.ContactNumber.Width = 130;
            // 
            // ContactNumberAdditional
            // 
            this.ContactNumberAdditional.Text = "Доп. контактный номер";
            this.ContactNumberAdditional.Width = 140;
            // 
            // Address
            // 
            this.Address.Text = "Адрес";
            this.Address.Width = 265;
            // 
            // Preferences
            // 
            this.Preferences.Text = "Предпочтения";
            this.Preferences.Width = 350;
            // 
            // OrdersCount
            // 
            this.OrdersCount.Text = "Всего заказов";
            this.OrdersCount.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ArchiveList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Архив";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ArchiveList
            // 
            this.ArchiveList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "ФИО Клиента";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Причина удаления";
            this.columnHeader2.Width = 800;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Controls.Add(this.closeView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(698, 23);
            this.panel4.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.37197F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.47439F));
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 23);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(195, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.checkBox1.Size = new System.Drawing.Size(148, 17);
            this.checkBox1.TabIndex = 1005;
            this.checkBox1.Text = "Удаленные в архив";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.ShowArchivedCheckedEvent);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Холодный контакт";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(118, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1001;
            this.label2.Text = "Клиент";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeView
            // 
            this.closeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeView.Location = new System.Drawing.Point(674, 0);
            this.closeView.Name = "closeView";
            this.closeView.Size = new System.Drawing.Size(24, 23);
            this.closeView.TabIndex = 1;
            this.closeView.Text = "X";
            this.closeView.UseVisualStyleBackColor = true;
            this.closeView.Click += new System.EventHandler(this.CloseViewClick);
            // 
            // ClientsManageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ClientsManageUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.editElemPanel.ResumeLayout(false);
            this.editElemPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button closeView;
        private System.Windows.Forms.ListView ClientsList;
        private System.Windows.Forms.ColumnHeader MiddleName;
        private System.Windows.Forms.ColumnHeader ContactNumber;
        private System.Windows.Forms.ColumnHeader ContactNumberAdditional;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Preferences;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.Panel editElemPanel;
        private System.Windows.Forms.Button acceptEditButton;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.Button declineEditButton;
        private System.Windows.Forms.MaskedTextBox editValueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader OrdersCount;
        private System.Windows.Forms.Button deleteClientButton;
        private System.Windows.Forms.Button insertClientButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView ArchiveList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
