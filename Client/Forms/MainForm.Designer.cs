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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.UsersManageButton = new System.Windows.Forms.Button();
            this.UsersList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentControl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MainTable.SuspendLayout();
            this.MainMenu.SuspendLayout();
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
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(954, 339);
            this.MainTable.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.MainMenu.AutoScroll = true;
            this.MainMenu.Controls.Add(this.button1);
            this.MainMenu.Controls.Add(this.UsersManageButton);
            this.MainMenu.Controls.Add(this.UsersList);
            this.MainMenu.Controls.Add(this.label1);
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Location = new System.Drawing.Point(4, 4);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(444, 331);
            this.MainMenu.TabIndex = 0;
            // 
            // UsersManageButton
            // 
            this.UsersManageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersManageButton.Location = new System.Drawing.Point(0, 134);
            this.UsersManageButton.Name = "UsersManageButton";
            this.UsersManageButton.Size = new System.Drawing.Size(444, 23);
            this.UsersManageButton.TabIndex = 5;
            this.UsersManageButton.Text = "Редактировать выделенного";
            this.UsersManageButton.UseVisualStyleBackColor = true;
            this.UsersManageButton.Click += new System.EventHandler(this.UsersManageButtonClick);
            // 
            // UsersList
            // 
            this.UsersList.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersList.FormattingEnabled = true;
            this.UsersList.Location = new System.Drawing.Point(0, 13);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(444, 121);
            this.UsersList.TabIndex = 4;
            this.UsersList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsersListKeyPress);
            this.UsersList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UsersListMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список сотрудников";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CurrentControl
            // 
            this.CurrentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentControl.Location = new System.Drawing.Point(455, 4);
            this.CurrentControl.Name = "CurrentControl";
            this.CurrentControl.Size = new System.Drawing.Size(495, 331);
            this.CurrentControl.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 339);
            this.Controls.Add(this.MainTable);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рекламное агентство";
            this.MainTable.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Button UsersManageButton;
        private System.Windows.Forms.ListBox UsersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CurrentControl;
        private System.Windows.Forms.Button button1;
    }
}

