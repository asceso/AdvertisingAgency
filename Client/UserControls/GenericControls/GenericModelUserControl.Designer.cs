namespace Client.UserControls.GenericControls
{
    partial class GenericModelUserControl<ModelType, DataType>
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
            this.managePanel = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.closeView = new System.Windows.Forms.Button();
            this.SourceList = new System.Windows.Forms.ListView();
            this.headerLabel = new System.Windows.Forms.Label();
            this.managePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // managePanel
            // 
            this.managePanel.Controls.Add(this.refreshButton);
            this.managePanel.Controls.Add(this.deleteButton);
            this.managePanel.Controls.Add(this.updateButton);
            this.managePanel.Controls.Add(this.insertButton);
            this.managePanel.Controls.Add(this.closeView);
            this.managePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.managePanel.Location = new System.Drawing.Point(0, 0);
            this.managePanel.Name = "managePanel";
            this.managePanel.Size = new System.Drawing.Size(702, 25);
            this.managePanel.TabIndex = 2;
            // 
            // refreshButton
            // 
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.refreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(450, 0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(150, 25);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Обновить данные";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(300, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 25);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // updateButton
            // 
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.updateButton.Enabled = false;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(150, 0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 25);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // insertButton
            // 
            this.insertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.insertButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insertButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Location = new System.Drawing.Point(0, 0);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(150, 25);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Добавить";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButtonClick);
            // 
            // closeView
            // 
            this.closeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.closeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeView.Location = new System.Drawing.Point(677, 0);
            this.closeView.Name = "closeView";
            this.closeView.Size = new System.Drawing.Size(25, 25);
            this.closeView.TabIndex = 3;
            this.closeView.Text = "X";
            this.closeView.UseVisualStyleBackColor = true;
            this.closeView.Click += new System.EventHandler(this.CloseViewClick);
            // 
            // SourceList
            // 
            this.SourceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceList.FullRowSelect = true;
            this.SourceList.GridLines = true;
            this.SourceList.HideSelection = false;
            this.SourceList.Location = new System.Drawing.Point(0, 50);
            this.SourceList.Name = "SourceList";
            this.SourceList.Size = new System.Drawing.Size(702, 437);
            this.SourceList.TabIndex = 4;
            this.SourceList.UseCompatibleStateImageBehavior = false;
            this.SourceList.View = System.Windows.Forms.View.Details;
            this.SourceList.SelectedIndexChanged += new System.EventHandler(this.SourceListSelectedIndexChanged);
            this.SourceList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SourceListKeyDown);
            this.SourceList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SourceListMouseDoubleClick);
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Location = new System.Drawing.Point(0, 25);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(702, 25);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Типы заявок";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenericModelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SourceList);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.managePanel);
            this.Name = "GenericModelUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.managePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel managePanel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button closeView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.ListView SourceList;
        private System.Windows.Forms.Label headerLabel;
    }
}
