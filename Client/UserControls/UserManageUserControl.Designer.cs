namespace Client.UserControls
{
    partial class UserManageUserControl
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
            this.elemPanel = new System.Windows.Forms.Panel();
            this.AcceptChangesButton = new System.Windows.Forms.Button();
            this.emptLabel = new System.Windows.Forms.Label();
            this.cnPanel = new System.Windows.Forms.Panel();
            this.contactNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cnLabel = new System.Windows.Forms.Label();
            this.positionsComboBox = new System.Windows.Forms.ComboBox();
            this.posLabel = new System.Windows.Forms.Label();
            this.lnPanel = new System.Windows.Forms.Panel();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.lnLabel = new System.Windows.Forms.Label();
            this.mnPanel = new System.Windows.Forms.Panel();
            this.mNameTextBox = new System.Windows.Forms.TextBox();
            this.mnLabel = new System.Windows.Forms.Label();
            this.fnPanel = new System.Windows.Forms.Panel();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.fnLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeView = new System.Windows.Forms.Button();
            this.elemPanel.SuspendLayout();
            this.cnPanel.SuspendLayout();
            this.lnPanel.SuspendLayout();
            this.mnPanel.SuspendLayout();
            this.fnPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // elemPanel
            // 
            this.elemPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elemPanel.Controls.Add(this.AcceptChangesButton);
            this.elemPanel.Controls.Add(this.emptLabel);
            this.elemPanel.Controls.Add(this.cnPanel);
            this.elemPanel.Controls.Add(this.positionsComboBox);
            this.elemPanel.Controls.Add(this.posLabel);
            this.elemPanel.Controls.Add(this.lnPanel);
            this.elemPanel.Controls.Add(this.mnPanel);
            this.elemPanel.Controls.Add(this.fnPanel);
            this.elemPanel.Controls.Add(this.headerPanel);
            this.elemPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.elemPanel.Location = new System.Drawing.Point(0, 0);
            this.elemPanel.Name = "elemPanel";
            this.elemPanel.Size = new System.Drawing.Size(702, 301);
            this.elemPanel.TabIndex = 0;
            // 
            // AcceptChangesButton
            // 
            this.AcceptChangesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptChangesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AcceptChangesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AcceptChangesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AcceptChangesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AcceptChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptChangesButton.Location = new System.Drawing.Point(0, 269);
            this.AcceptChangesButton.Name = "AcceptChangesButton";
            this.AcceptChangesButton.Size = new System.Drawing.Size(698, 27);
            this.AcceptChangesButton.TabIndex = 13;
            this.AcceptChangesButton.Text = "Подтвердить изменения";
            this.AcceptChangesButton.UseVisualStyleBackColor = true;
            this.AcceptChangesButton.Click += new System.EventHandler(this.AcceptChangesButtonClick);
            // 
            // emptLabel
            // 
            this.emptLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.emptLabel.Location = new System.Drawing.Point(0, 259);
            this.emptLabel.Name = "emptLabel";
            this.emptLabel.Size = new System.Drawing.Size(698, 10);
            this.emptLabel.TabIndex = 17;
            // 
            // cnPanel
            // 
            this.cnPanel.Controls.Add(this.contactNumberTextBox);
            this.cnPanel.Controls.Add(this.cnLabel);
            this.cnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cnPanel.Location = new System.Drawing.Point(0, 212);
            this.cnPanel.Name = "cnPanel";
            this.cnPanel.Size = new System.Drawing.Size(698, 47);
            this.cnPanel.TabIndex = 19;
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Location = new System.Drawing.Point(156, 14);
            this.contactNumberTextBox.Mask = "0 ( 000 ) 000 - 00 - 00";
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(539, 20);
            this.contactNumberTextBox.TabIndex = 2;
            this.contactNumberTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cnLabel
            // 
            this.cnLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cnLabel.Location = new System.Drawing.Point(0, 0);
            this.cnLabel.MinimumSize = new System.Drawing.Size(150, 0);
            this.cnLabel.Name = "cnLabel";
            this.cnLabel.Size = new System.Drawing.Size(150, 47);
            this.cnLabel.TabIndex = 0;
            this.cnLabel.Text = "Контактный номер";
            this.cnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // positionsComboBox
            // 
            this.positionsComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.positionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionsComboBox.DropDownWidth = 500;
            this.positionsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionsComboBox.FormattingEnabled = true;
            this.positionsComboBox.ItemHeight = 13;
            this.positionsComboBox.Location = new System.Drawing.Point(0, 191);
            this.positionsComboBox.MaxDropDownItems = 15;
            this.positionsComboBox.Name = "positionsComboBox";
            this.positionsComboBox.Size = new System.Drawing.Size(698, 21);
            this.positionsComboBox.TabIndex = 12;
            // 
            // posLabel
            // 
            this.posLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.posLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.posLabel.Location = new System.Drawing.Point(0, 165);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(698, 26);
            this.posLabel.TabIndex = 11;
            this.posLabel.Text = "Должность";
            this.posLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnPanel
            // 
            this.lnPanel.Controls.Add(this.lNameTextBox);
            this.lnPanel.Controls.Add(this.lnLabel);
            this.lnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnPanel.Location = new System.Drawing.Point(0, 118);
            this.lnPanel.Name = "lnPanel";
            this.lnPanel.Size = new System.Drawing.Size(698, 47);
            this.lnPanel.TabIndex = 16;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lNameTextBox.Location = new System.Drawing.Point(106, 14);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(589, 20);
            this.lNameTextBox.TabIndex = 1;
            // 
            // lnLabel
            // 
            this.lnLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnLabel.Location = new System.Drawing.Point(0, 0);
            this.lnLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.lnLabel.Name = "lnLabel";
            this.lnLabel.Size = new System.Drawing.Size(100, 47);
            this.lnLabel.TabIndex = 0;
            this.lnLabel.Text = "Отчество";
            this.lnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnPanel
            // 
            this.mnPanel.Controls.Add(this.mNameTextBox);
            this.mnPanel.Controls.Add(this.mnLabel);
            this.mnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnPanel.Location = new System.Drawing.Point(0, 71);
            this.mnPanel.Name = "mnPanel";
            this.mnPanel.Size = new System.Drawing.Size(698, 47);
            this.mnPanel.TabIndex = 15;
            // 
            // mNameTextBox
            // 
            this.mNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mNameTextBox.Location = new System.Drawing.Point(106, 14);
            this.mNameTextBox.Name = "mNameTextBox";
            this.mNameTextBox.Size = new System.Drawing.Size(589, 20);
            this.mNameTextBox.TabIndex = 1;
            // 
            // mnLabel
            // 
            this.mnLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnLabel.Location = new System.Drawing.Point(0, 0);
            this.mnLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.mnLabel.Name = "mnLabel";
            this.mnLabel.Size = new System.Drawing.Size(100, 47);
            this.mnLabel.TabIndex = 0;
            this.mnLabel.Text = "Фамилия";
            this.mnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fnPanel
            // 
            this.fnPanel.Controls.Add(this.fNameTextBox);
            this.fnPanel.Controls.Add(this.fnLabel);
            this.fnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fnPanel.Location = new System.Drawing.Point(0, 24);
            this.fnPanel.Name = "fnPanel";
            this.fnPanel.Size = new System.Drawing.Size(698, 47);
            this.fnPanel.TabIndex = 14;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fNameTextBox.Location = new System.Drawing.Point(106, 14);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(589, 20);
            this.fNameTextBox.TabIndex = 1;
            // 
            // fnLabel
            // 
            this.fnLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fnLabel.Location = new System.Drawing.Point(0, 0);
            this.fnLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(100, 47);
            this.fnLabel.TabIndex = 0;
            this.fnLabel.Text = "Имя";
            this.fnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.closeView);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(698, 24);
            this.headerPanel.TabIndex = 18;
            // 
            // closeView
            // 
            this.closeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.closeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeView.Location = new System.Drawing.Point(674, 0);
            this.closeView.Name = "closeView";
            this.closeView.Size = new System.Drawing.Size(24, 24);
            this.closeView.TabIndex = 0;
            this.closeView.Text = "X";
            this.closeView.UseVisualStyleBackColor = true;
            this.closeView.Click += new System.EventHandler(this.CloseViewClick);
            // 
            // UserManageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.elemPanel);
            this.Name = "UserManageUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.Load += new System.EventHandler(this.UserManageUserControlLoad);
            this.elemPanel.ResumeLayout(false);
            this.cnPanel.ResumeLayout(false);
            this.cnPanel.PerformLayout();
            this.lnPanel.ResumeLayout(false);
            this.lnPanel.PerformLayout();
            this.mnPanel.ResumeLayout(false);
            this.mnPanel.PerformLayout();
            this.fnPanel.ResumeLayout(false);
            this.fnPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel elemPanel;
        private System.Windows.Forms.Button AcceptChangesButton;
        private System.Windows.Forms.Label emptLabel;
        private System.Windows.Forms.ComboBox positionsComboBox;
        private System.Windows.Forms.Label posLabel;
        private System.Windows.Forms.Panel lnPanel;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.Label lnLabel;
        private System.Windows.Forms.Panel mnPanel;
        private System.Windows.Forms.TextBox mNameTextBox;
        private System.Windows.Forms.Label mnLabel;
        private System.Windows.Forms.Panel fnPanel;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button closeView;
        private System.Windows.Forms.Panel cnPanel;
        private System.Windows.Forms.Label cnLabel;
        private System.Windows.Forms.MaskedTextBox contactNumberTextBox;
    }
}
