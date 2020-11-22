namespace Client.UserControls
{
    partial class SettingsUserControl
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
            this.viewHeaderPanel = new System.Windows.Forms.Panel();
            this.returnChangesButton = new System.Windows.Forms.Button();
            this.saveANDexitButton = new System.Windows.Forms.Button();
            this.closeView = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showAdditionalInfo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showBorderMenu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.closeViewButtonPosition = new System.Windows.Forms.ComboBox();
            this.restoreBorderMenu = new System.Windows.Forms.ComboBox();
            this.fullScreenAtStart = new System.Windows.Forms.ComboBox();
            this.RoleManagmentButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderDialogButton = new System.Windows.Forms.Button();
            this.fileFolderPath = new System.Windows.Forms.TextBox();
            this.showOnlyOwnRequests = new System.Windows.Forms.ComboBox();
            this.viewHeaderPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewHeaderPanel
            // 
            this.viewHeaderPanel.Controls.Add(this.returnChangesButton);
            this.viewHeaderPanel.Controls.Add(this.saveANDexitButton);
            this.viewHeaderPanel.Controls.Add(this.closeView);
            this.viewHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.viewHeaderPanel.Name = "viewHeaderPanel";
            this.viewHeaderPanel.Size = new System.Drawing.Size(702, 26);
            this.viewHeaderPanel.TabIndex = 21;
            // 
            // returnChangesButton
            // 
            this.returnChangesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnChangesButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.returnChangesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returnChangesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.returnChangesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.returnChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnChangesButton.Location = new System.Drawing.Point(158, 0);
            this.returnChangesButton.Name = "returnChangesButton";
            this.returnChangesButton.Size = new System.Drawing.Size(158, 26);
            this.returnChangesButton.TabIndex = 3;
            this.returnChangesButton.Text = "Отменить изменения";
            this.returnChangesButton.UseVisualStyleBackColor = true;
            this.returnChangesButton.Click += new System.EventHandler(this.ReturnChangesButtonClick);
            // 
            // saveANDexitButton
            // 
            this.saveANDexitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveANDexitButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveANDexitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveANDexitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveANDexitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.saveANDexitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveANDexitButton.Location = new System.Drawing.Point(0, 0);
            this.saveANDexitButton.Name = "saveANDexitButton";
            this.saveANDexitButton.Size = new System.Drawing.Size(158, 26);
            this.saveANDexitButton.TabIndex = 2;
            this.saveANDexitButton.Text = "Сохранить и закрыть";
            this.saveANDexitButton.UseVisualStyleBackColor = true;
            this.saveANDexitButton.Click += new System.EventHandler(this.SaveANDexitButtonClick);
            // 
            // closeView
            // 
            this.closeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.closeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeView.Location = new System.Drawing.Point(676, 0);
            this.closeView.Name = "closeView";
            this.closeView.Size = new System.Drawing.Size(26, 26);
            this.closeView.TabIndex = 1;
            this.closeView.Text = "X";
            this.closeView.UseVisualStyleBackColor = true;
            this.closeView.Click += new System.EventHandler(this.CloseViewClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.showAdditionalInfo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.showBorderMenu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.closeViewButtonPosition, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.restoreBorderMenu, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fullScreenAtStart, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.RoleManagmentButton, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.showOnlyOwnRequests, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 461);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(3, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(344, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "Показывать только свои заявки\r\n(если не администратор!)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(3, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(694, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Путь к папке с файлами информационной системы";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(3, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "При загрузке включать режим";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Возвращать боковое меню при закрытии элемента";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showAdditionalInfo
            // 
            this.showAdditionalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showAdditionalInfo.BackColor = System.Drawing.SystemColors.Window;
            this.showAdditionalInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showAdditionalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAdditionalInfo.FormattingEnabled = true;
            this.showAdditionalInfo.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.showAdditionalInfo.Location = new System.Drawing.Point(353, 79);
            this.showAdditionalInfo.Name = "showAdditionalInfo";
            this.showAdditionalInfo.Size = new System.Drawing.Size(344, 21);
            this.showAdditionalInfo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сворачивать боковое меню при открытии";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Показывать доп инфо в базе клиентов";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showBorderMenu
            // 
            this.showBorderMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showBorderMenu.BackColor = System.Drawing.SystemColors.Window;
            this.showBorderMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showBorderMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showBorderMenu.FormattingEnabled = true;
            this.showBorderMenu.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.showBorderMenu.Location = new System.Drawing.Point(353, 19);
            this.showBorderMenu.Name = "showBorderMenu";
            this.showBorderMenu.Size = new System.Drawing.Size(344, 21);
            this.showBorderMenu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(3, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Положение кнопки закрыть";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeViewButtonPosition
            // 
            this.closeViewButtonPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.closeViewButtonPosition.BackColor = System.Drawing.SystemColors.Window;
            this.closeViewButtonPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.closeViewButtonPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeViewButtonPosition.FormattingEnabled = true;
            this.closeViewButtonPosition.Items.AddRange(new object[] {
            "Слева",
            "Справа"});
            this.closeViewButtonPosition.Location = new System.Drawing.Point(353, 139);
            this.closeViewButtonPosition.Name = "closeViewButtonPosition";
            this.closeViewButtonPosition.Size = new System.Drawing.Size(344, 21);
            this.closeViewButtonPosition.TabIndex = 5;
            // 
            // restoreBorderMenu
            // 
            this.restoreBorderMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreBorderMenu.BackColor = System.Drawing.SystemColors.Window;
            this.restoreBorderMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restoreBorderMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreBorderMenu.FormattingEnabled = true;
            this.restoreBorderMenu.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.restoreBorderMenu.Location = new System.Drawing.Point(353, 49);
            this.restoreBorderMenu.Name = "restoreBorderMenu";
            this.restoreBorderMenu.Size = new System.Drawing.Size(344, 21);
            this.restoreBorderMenu.TabIndex = 7;
            // 
            // fullScreenAtStart
            // 
            this.fullScreenAtStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fullScreenAtStart.BackColor = System.Drawing.SystemColors.Window;
            this.fullScreenAtStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fullScreenAtStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullScreenAtStart.FormattingEnabled = true;
            this.fullScreenAtStart.Items.AddRange(new object[] {
            "Обычный",
            "Полный экран"});
            this.fullScreenAtStart.Location = new System.Drawing.Point(353, 169);
            this.fullScreenAtStart.Name = "fullScreenAtStart";
            this.fullScreenAtStart.Size = new System.Drawing.Size(344, 21);
            this.fullScreenAtStart.TabIndex = 9;
            // 
            // RoleManagmentButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.RoleManagmentButton, 2);
            this.RoleManagmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoleManagmentButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RoleManagmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RoleManagmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.RoleManagmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoleManagmentButton.Location = new System.Drawing.Point(3, 268);
            this.RoleManagmentButton.Name = "RoleManagmentButton";
            this.RoleManagmentButton.Size = new System.Drawing.Size(694, 24);
            this.RoleManagmentButton.TabIndex = 10;
            this.RoleManagmentButton.Text = "Настройка ролей";
            this.RoleManagmentButton.UseVisualStyleBackColor = true;
            this.RoleManagmentButton.Click += new System.EventHandler(this.RoleManagmentClick);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.folderDialogButton);
            this.panel1.Controls.Add(this.fileFolderPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 34);
            this.panel1.TabIndex = 14;
            // 
            // folderDialogButton
            // 
            this.folderDialogButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.folderDialogButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.folderDialogButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.folderDialogButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.folderDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderDialogButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.folderDialogButton.Location = new System.Drawing.Point(662, 0);
            this.folderDialogButton.MaximumSize = new System.Drawing.Size(32, 32);
            this.folderDialogButton.Name = "folderDialogButton";
            this.folderDialogButton.Size = new System.Drawing.Size(32, 32);
            this.folderDialogButton.TabIndex = 13;
            this.folderDialogButton.UseVisualStyleBackColor = true;
            this.folderDialogButton.Click += new System.EventHandler(this.FolderDialogButtonClick);
            // 
            // fileFolderPath
            // 
            this.fileFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileFolderPath.Location = new System.Drawing.Point(3, 8);
            this.fileFolderPath.Name = "fileFolderPath";
            this.fileFolderPath.Size = new System.Drawing.Size(653, 20);
            this.fileFolderPath.TabIndex = 12;
            // 
            // showOnlyOwnRequests
            // 
            this.showOnlyOwnRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showOnlyOwnRequests.BackColor = System.Drawing.SystemColors.Window;
            this.showOnlyOwnRequests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showOnlyOwnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showOnlyOwnRequests.FormattingEnabled = true;
            this.showOnlyOwnRequests.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.showOnlyOwnRequests.Location = new System.Drawing.Point(353, 109);
            this.showOnlyOwnRequests.Name = "showOnlyOwnRequests";
            this.showOnlyOwnRequests.Size = new System.Drawing.Size(344, 21);
            this.showOnlyOwnRequests.TabIndex = 16;
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.viewHeaderPanel);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.viewHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox showBorderMenu;
        private System.Windows.Forms.ComboBox restoreBorderMenu;
        private System.Windows.Forms.ComboBox showAdditionalInfo;
        private System.Windows.Forms.ComboBox closeViewButtonPosition;
        private System.Windows.Forms.Panel viewHeaderPanel;
        private System.Windows.Forms.Button closeView;
        private System.Windows.Forms.Button saveANDexitButton;
        private System.Windows.Forms.Button returnChangesButton;
        private System.Windows.Forms.ComboBox fullScreenAtStart;
        private System.Windows.Forms.Button RoleManagmentButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fileFolderPath;
        private System.Windows.Forms.Button folderDialogButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox showOnlyOwnRequests;
    }
}
