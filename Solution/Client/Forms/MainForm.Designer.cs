namespace Client.Forms
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentControl = new System.Windows.Forms.Panel();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.SystemButtons = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.PositionsButton = new System.Windows.Forms.Button();
            this.ServicesButton = new System.Windows.Forms.Button();
            this.RequestTypeButton = new System.Windows.Forms.Button();
            this.RequestButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.UsersPanel = new System.Windows.Forms.Panel();
            this.UpdateUserButton = new System.Windows.Forms.Button();
            this.InsertUserButton = new System.Windows.Forms.Button();
            this.UsersList = new System.Windows.Forms.ListBox();
            this.usersListLabel = new System.Windows.Forms.Label();
            this.MenuStateButton = new System.Windows.Forms.Button();
            this.ApplicationButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CloseApplicationButton = new System.Windows.Forms.Button();
            this.ChangeAccountButton = new System.Windows.Forms.Button();
            this.usersContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePasswordContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTable.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SystemButtons.SuspendLayout();
            this.UsersPanel.SuspendLayout();
            this.ApplicationButtonsPanel.SuspendLayout();
            this.usersContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTable.Controls.Add(this.CurrentControl, 1, 0);
            this.MainTable.Controls.Add(this.MainMenu, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(1163, 499);
            this.MainTable.TabIndex = 3;
            // 
            // CurrentControl
            // 
            this.CurrentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentControl.Location = new System.Drawing.Point(381, 6);
            this.CurrentControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentControl.Name = "CurrentControl";
            this.CurrentControl.Size = new System.Drawing.Size(802, 487);
            this.CurrentControl.TabIndex = 1;
            this.CurrentControl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.CurrentControlControlRemoved);
            this.CurrentControl.Resize += new System.EventHandler(this.CurrentControlResize);
            // 
            // MainMenu
            // 
            this.MainMenu.AutoScroll = true;
            this.MainMenu.Controls.Add(this.SystemButtons);
            this.MainMenu.Controls.Add(this.UsersPanel);
            this.MainMenu.Controls.Add(this.MenuStateButton);
            this.MainMenu.Controls.Add(this.ApplicationButtonsPanel);
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenu.Location = new System.Drawing.Point(5, 6);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(367, 487);
            this.MainMenu.TabIndex = 0;
            // 
            // SystemButtons
            // 
            this.SystemButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SystemButtons.Controls.Add(this.SettingsButton);
            this.SystemButtons.Controls.Add(this.PositionsButton);
            this.SystemButtons.Controls.Add(this.ServicesButton);
            this.SystemButtons.Controls.Add(this.RequestTypeButton);
            this.SystemButtons.Controls.Add(this.RequestButton);
            this.SystemButtons.Controls.Add(this.ClientsButton);
            this.SystemButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemButtons.Location = new System.Drawing.Point(0, 294);
            this.SystemButtons.Name = "SystemButtons";
            this.SystemButtons.Size = new System.Drawing.Size(367, 193);
            this.SystemButtons.TabIndex = 8;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Location = new System.Drawing.Point(0, 150);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(363, 30);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.OpenSettingsView_Click);
            // 
            // PositionsButton
            // 
            this.PositionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PositionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PositionsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PositionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PositionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PositionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionsButton.Location = new System.Drawing.Point(0, 120);
            this.PositionsButton.Name = "PositionsButton";
            this.PositionsButton.Size = new System.Drawing.Size(363, 30);
            this.PositionsButton.TabIndex = 6;
            this.PositionsButton.Text = "Должности";
            this.PositionsButton.UseVisualStyleBackColor = true;
            this.PositionsButton.Click += new System.EventHandler(this.PositionsButtonClick);
            // 
            // ServicesButton
            // 
            this.ServicesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServicesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServicesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ServicesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ServicesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ServicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesButton.Location = new System.Drawing.Point(0, 90);
            this.ServicesButton.Name = "ServicesButton";
            this.ServicesButton.Size = new System.Drawing.Size(363, 30);
            this.ServicesButton.TabIndex = 2;
            this.ServicesButton.Text = "Услуги";
            this.ServicesButton.UseVisualStyleBackColor = true;
            this.ServicesButton.Click += new System.EventHandler(this.ServicesButtonClick);
            // 
            // RequestTypeButton
            // 
            this.RequestTypeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RequestTypeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestTypeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RequestTypeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RequestTypeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.RequestTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestTypeButton.Location = new System.Drawing.Point(0, 60);
            this.RequestTypeButton.Name = "RequestTypeButton";
            this.RequestTypeButton.Size = new System.Drawing.Size(363, 30);
            this.RequestTypeButton.TabIndex = 1;
            this.RequestTypeButton.Text = "Типы заявок";
            this.RequestTypeButton.UseVisualStyleBackColor = true;
            this.RequestTypeButton.Click += new System.EventHandler(this.RequestTypeButtonClick);
            // 
            // RequestButton
            // 
            this.RequestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RequestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RequestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RequestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.RequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestButton.Location = new System.Drawing.Point(0, 30);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(363, 30);
            this.RequestButton.TabIndex = 3;
            this.RequestButton.Text = "Заявки";
            this.RequestButton.UseVisualStyleBackColor = true;
            this.RequestButton.Click += new System.EventHandler(this.RequestButtonClick);
            // 
            // ClientsButton
            // 
            this.ClientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClientsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.Location = new System.Drawing.Point(0, 0);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(363, 30);
            this.ClientsButton.TabIndex = 0;
            this.ClientsButton.Text = "База клиентов";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButtonClick);
            // 
            // UsersPanel
            // 
            this.UsersPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsersPanel.Controls.Add(this.UpdateUserButton);
            this.UsersPanel.Controls.Add(this.InsertUserButton);
            this.UsersPanel.Controls.Add(this.UsersList);
            this.UsersPanel.Controls.Add(this.usersListLabel);
            this.UsersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersPanel.Location = new System.Drawing.Point(0, 74);
            this.UsersPanel.Name = "UsersPanel";
            this.UsersPanel.Size = new System.Drawing.Size(367, 220);
            this.UsersPanel.TabIndex = 7;
            // 
            // UpdateUserButton
            // 
            this.UpdateUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateUserButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UpdateUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.UpdateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateUserButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.UpdateUserButton.Location = new System.Drawing.Point(0, 175);
            this.UpdateUserButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateUserButton.Name = "UpdateUserButton";
            this.UpdateUserButton.Size = new System.Drawing.Size(363, 34);
            this.UpdateUserButton.TabIndex = 5;
            this.UpdateUserButton.Text = "Изменить";
            this.UpdateUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.UpdateUserButton.UseVisualStyleBackColor = true;
            this.UpdateUserButton.Click += new System.EventHandler(this.UsersManageButtonClick);
            // 
            // InsertUserButton
            // 
            this.InsertUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertUserButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.InsertUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InsertUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.InsertUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertUserButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.InsertUserButton.Location = new System.Drawing.Point(0, 141);
            this.InsertUserButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsertUserButton.Name = "InsertUserButton";
            this.InsertUserButton.Size = new System.Drawing.Size(363, 34);
            this.InsertUserButton.TabIndex = 6;
            this.InsertUserButton.Text = "Новый пользователь";
            this.InsertUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InsertUserButton.UseVisualStyleBackColor = true;
            this.InsertUserButton.Click += new System.EventHandler(this.InsertUserButtonClick);
            // 
            // UsersList
            // 
            this.UsersList.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersList.FormattingEnabled = true;
            this.UsersList.Location = new System.Drawing.Point(0, 20);
            this.UsersList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(363, 121);
            this.UsersList.TabIndex = 4;
            this.UsersList.SelectedIndexChanged += new System.EventHandler(this.UsersListSelectedIndexChanged);
            this.UsersList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsersListKeyPress);
            this.UsersList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UsersListMouseDoubleClick);
            // 
            // usersListLabel
            // 
            this.usersListLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.usersListLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersListLabel.Location = new System.Drawing.Point(0, 0);
            this.usersListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usersListLabel.Name = "usersListLabel";
            this.usersListLabel.Size = new System.Drawing.Size(363, 20);
            this.usersListLabel.TabIndex = 3;
            this.usersListLabel.Text = "Список сотрудников";
            this.usersListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuStateButton
            // 
            this.MenuStateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuStateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuStateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MenuStateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuStateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.MenuStateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuStateButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.MenuStateButton.Location = new System.Drawing.Point(0, 40);
            this.MenuStateButton.Name = "MenuStateButton";
            this.MenuStateButton.Size = new System.Drawing.Size(367, 34);
            this.MenuStateButton.TabIndex = 9;
            this.MenuStateButton.Text = "Свернуть меню";
            this.MenuStateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MenuStateButton.UseVisualStyleBackColor = true;
            this.MenuStateButton.Click += new System.EventHandler(this.MenuStateButtonClick);
            // 
            // ApplicationButtonsPanel
            // 
            this.ApplicationButtonsPanel.ColumnCount = 2;
            this.ApplicationButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ApplicationButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ApplicationButtonsPanel.Controls.Add(this.CloseApplicationButton, 1, 0);
            this.ApplicationButtonsPanel.Controls.Add(this.ChangeAccountButton, 0, 0);
            this.ApplicationButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApplicationButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ApplicationButtonsPanel.Name = "ApplicationButtonsPanel";
            this.ApplicationButtonsPanel.RowCount = 1;
            this.ApplicationButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ApplicationButtonsPanel.Size = new System.Drawing.Size(367, 40);
            this.ApplicationButtonsPanel.TabIndex = 7;
            // 
            // CloseApplicationButton
            // 
            this.CloseApplicationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseApplicationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseApplicationButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseApplicationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseApplicationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.CloseApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApplicationButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseApplicationButton.Location = new System.Drawing.Point(186, 3);
            this.CloseApplicationButton.Name = "CloseApplicationButton";
            this.CloseApplicationButton.Size = new System.Drawing.Size(178, 34);
            this.CloseApplicationButton.TabIndex = 11;
            this.CloseApplicationButton.Text = "Закрыть программу";
            this.CloseApplicationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseApplicationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CloseApplicationButton.UseVisualStyleBackColor = true;
            this.CloseApplicationButton.Click += new System.EventHandler(this.CloseApplicationButtonClick);
            // 
            // ChangeAccountButton
            // 
            this.ChangeAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeAccountButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ChangeAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChangeAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ChangeAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeAccountButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ChangeAccountButton.Location = new System.Drawing.Point(3, 3);
            this.ChangeAccountButton.Name = "ChangeAccountButton";
            this.ChangeAccountButton.Size = new System.Drawing.Size(177, 34);
            this.ChangeAccountButton.TabIndex = 10;
            this.ChangeAccountButton.Text = "Сменить пользователя";
            this.ChangeAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeAccountButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ChangeAccountButton.UseVisualStyleBackColor = true;
            this.ChangeAccountButton.Click += new System.EventHandler(this.ChangeAccountButtonClick);
            // 
            // usersContextMenu
            // 
            this.usersContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordContextButton});
            this.usersContextMenu.Name = "usersContextMenu";
            this.usersContextMenu.Size = new System.Drawing.Size(232, 26);
            // 
            // changePasswordContextButton
            // 
            this.changePasswordContextButton.Enabled = false;
            this.changePasswordContextButton.Name = "changePasswordContextButton";
            this.changePasswordContextButton.Size = new System.Drawing.Size(231, 22);
            this.changePasswordContextButton.Text = "Смена пароля пользователя";
            this.changePasswordContextButton.Click += new System.EventHandler(this.ChangeUserPasswordClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 499);
            this.Controls.Add(this.MainTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рекламное агентство";
            this.MainTable.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.SystemButtons.ResumeLayout(false);
            this.UsersPanel.ResumeLayout(false);
            this.ApplicationButtonsPanel.ResumeLayout(false);
            this.usersContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Button UpdateUserButton;
        private System.Windows.Forms.ListBox UsersList;
        private System.Windows.Forms.Label usersListLabel;
        private System.Windows.Forms.Panel CurrentControl;
        private System.Windows.Forms.Button InsertUserButton;
        private System.Windows.Forms.Panel UsersPanel;
        private System.Windows.Forms.ContextMenuStrip usersContextMenu;
        private System.Windows.Forms.ToolStripMenuItem changePasswordContextButton;
        private System.Windows.Forms.Panel SystemButtons;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button MenuStateButton;
        private System.Windows.Forms.Button RequestTypeButton;
        private System.Windows.Forms.Button ServicesButton;
        private System.Windows.Forms.Button RequestButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ChangeAccountButton;
        private System.Windows.Forms.TableLayoutPanel ApplicationButtonsPanel;
        private System.Windows.Forms.Button CloseApplicationButton;
        private System.Windows.Forms.Button PositionsButton;
    }
}

