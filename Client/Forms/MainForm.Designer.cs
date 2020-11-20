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
            this.MainMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServicesButton = new System.Windows.Forms.Button();
            this.RequestTypeButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.UsersManageButton = new System.Windows.Forms.Button();
            this.InsertUserButton = new System.Windows.Forms.Button();
            this.UsersList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStateButton = new System.Windows.Forms.Button();
            this.CurrentControl = new System.Windows.Forms.Panel();
            this.usersContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePasswordContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTable.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.usersPanel.SuspendLayout();
            this.usersContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTable.Controls.Add(this.MainMenu, 0, 0);
            this.MainTable.Controls.Add(this.CurrentControl, 1, 0);
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
            // MainMenu
            // 
            this.MainMenu.AutoScroll = true;
            this.MainMenu.Controls.Add(this.panel1);
            this.MainMenu.Controls.Add(this.usersPanel);
            this.MainMenu.Controls.Add(this.menuStateButton);
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenu.Location = new System.Drawing.Point(5, 6);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(442, 487);
            this.MainMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ServicesButton);
            this.panel1.Controls.Add(this.RequestTypeButton);
            this.panel1.Controls.Add(this.ClientsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 129);
            this.panel1.TabIndex = 8;
            // 
            // ServicesButton
            // 
            this.ServicesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServicesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServicesButton.Location = new System.Drawing.Point(0, 60);
            this.ServicesButton.Name = "ServicesButton";
            this.ServicesButton.Size = new System.Drawing.Size(438, 30);
            this.ServicesButton.TabIndex = 2;
            this.ServicesButton.Text = "Услуги";
            this.ServicesButton.UseVisualStyleBackColor = true;
            this.ServicesButton.Click += new System.EventHandler(this.ServicesButtonClick);
            // 
            // RequestTypeButton
            // 
            this.RequestTypeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RequestTypeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestTypeButton.Location = new System.Drawing.Point(0, 30);
            this.RequestTypeButton.Name = "RequestTypeButton";
            this.RequestTypeButton.Size = new System.Drawing.Size(438, 30);
            this.RequestTypeButton.TabIndex = 1;
            this.RequestTypeButton.Text = "Типы заявок";
            this.RequestTypeButton.UseVisualStyleBackColor = true;
            this.RequestTypeButton.Click += new System.EventHandler(this.RequestTypeButtonClick);
            // 
            // ClientsButton
            // 
            this.ClientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsButton.Location = new System.Drawing.Point(0, 0);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(438, 30);
            this.ClientsButton.TabIndex = 0;
            this.ClientsButton.Text = "База клиентов";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButtonClick);
            // 
            // usersPanel
            // 
            this.usersPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usersPanel.Controls.Add(this.UsersManageButton);
            this.usersPanel.Controls.Add(this.InsertUserButton);
            this.usersPanel.Controls.Add(this.UsersList);
            this.usersPanel.Controls.Add(this.label1);
            this.usersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersPanel.Location = new System.Drawing.Point(0, 23);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Size = new System.Drawing.Size(442, 207);
            this.usersPanel.TabIndex = 7;
            // 
            // UsersManageButton
            // 
            this.UsersManageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersManageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersManageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersManageButton.Location = new System.Drawing.Point(0, 171);
            this.UsersManageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsersManageButton.Name = "UsersManageButton";
            this.UsersManageButton.Size = new System.Drawing.Size(438, 30);
            this.UsersManageButton.TabIndex = 5;
            this.UsersManageButton.Text = "Изменить";
            this.UsersManageButton.UseVisualStyleBackColor = true;
            this.UsersManageButton.Click += new System.EventHandler(this.UsersManageButtonClick);
            // 
            // InsertUserButton
            // 
            this.InsertUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertUserButton.Location = new System.Drawing.Point(0, 141);
            this.InsertUserButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsertUserButton.Name = "InsertUserButton";
            this.InsertUserButton.Size = new System.Drawing.Size(438, 30);
            this.InsertUserButton.TabIndex = 6;
            this.InsertUserButton.Text = "Новый пользователь";
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
            this.UsersList.Size = new System.Drawing.Size(438, 121);
            this.UsersList.TabIndex = 4;
            this.UsersList.SelectedIndexChanged += new System.EventHandler(this.UsersListSelectedIndexChanged);
            this.UsersList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsersListKeyPress);
            this.UsersList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UsersListMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список сотрудников";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStateButton
            // 
            this.menuStateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuStateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStateButton.Location = new System.Drawing.Point(0, 0);
            this.menuStateButton.Name = "menuStateButton";
            this.menuStateButton.Size = new System.Drawing.Size(442, 23);
            this.menuStateButton.TabIndex = 9;
            this.menuStateButton.Text = "Свернуть меню ◀";
            this.menuStateButton.UseVisualStyleBackColor = true;
            this.menuStateButton.Click += new System.EventHandler(this.MenuStateButtonClick);
            // 
            // CurrentControl
            // 
            this.CurrentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentControl.Location = new System.Drawing.Point(456, 6);
            this.CurrentControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentControl.Name = "CurrentControl";
            this.CurrentControl.Size = new System.Drawing.Size(702, 487);
            this.CurrentControl.TabIndex = 1;
            this.CurrentControl.Resize += new System.EventHandler(this.CurrentControlResize);
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
            this.panel1.ResumeLayout(false);
            this.usersPanel.ResumeLayout(false);
            this.usersContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Button UsersManageButton;
        private System.Windows.Forms.ListBox UsersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CurrentControl;
        private System.Windows.Forms.Button InsertUserButton;
        private System.Windows.Forms.Panel usersPanel;
        private System.Windows.Forms.ContextMenuStrip usersContextMenu;
        private System.Windows.Forms.ToolStripMenuItem changePasswordContextButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button menuStateButton;
        private System.Windows.Forms.Button RequestTypeButton;
        private System.Windows.Forms.Button ServicesButton;
    }
}

