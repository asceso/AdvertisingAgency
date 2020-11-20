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
            this.viewHeaderPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.showAdditionalInfo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.showBorderMenu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.closeViewButtonPosition, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.restoreBorderMenu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fullScreenAtStart, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 461);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(5, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 43);
            this.label5.TabIndex = 8;
            this.label5.Text = "При загрузке включать режим";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(5, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 43);
            this.label4.TabIndex = 6;
            this.label4.Text = "Возвращать боковое меню при закрытии элемента";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showAdditionalInfo
            // 
            this.showAdditionalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showAdditionalInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showAdditionalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAdditionalInfo.FormattingEnabled = true;
            this.showAdditionalInfo.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.showAdditionalInfo.Location = new System.Drawing.Point(215, 103);
            this.showAdditionalInfo.Name = "showAdditionalInfo";
            this.showAdditionalInfo.Size = new System.Drawing.Size(482, 21);
            this.showAdditionalInfo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сворачивать боковое меню при открытии";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Показывать доп инфо в базе клиентов";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showBorderMenu
            // 
            this.showBorderMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showBorderMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showBorderMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showBorderMenu.FormattingEnabled = true;
            this.showBorderMenu.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.showBorderMenu.Location = new System.Drawing.Point(215, 13);
            this.showBorderMenu.Name = "showBorderMenu";
            this.showBorderMenu.Size = new System.Drawing.Size(482, 21);
            this.showBorderMenu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(5, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Положение кнопки закрыть";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeViewButtonPosition
            // 
            this.closeViewButtonPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.closeViewButtonPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.closeViewButtonPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeViewButtonPosition.FormattingEnabled = true;
            this.closeViewButtonPosition.Items.AddRange(new object[] {
            "Слева",
            "Справа"});
            this.closeViewButtonPosition.Location = new System.Drawing.Point(215, 148);
            this.closeViewButtonPosition.Name = "closeViewButtonPosition";
            this.closeViewButtonPosition.Size = new System.Drawing.Size(482, 21);
            this.closeViewButtonPosition.TabIndex = 5;
            // 
            // restoreBorderMenu
            // 
            this.restoreBorderMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreBorderMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restoreBorderMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreBorderMenu.FormattingEnabled = true;
            this.restoreBorderMenu.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.restoreBorderMenu.Location = new System.Drawing.Point(215, 58);
            this.restoreBorderMenu.Name = "restoreBorderMenu";
            this.restoreBorderMenu.Size = new System.Drawing.Size(482, 21);
            this.restoreBorderMenu.TabIndex = 7;
            // 
            // fullScreenAtStart
            // 
            this.fullScreenAtStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fullScreenAtStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fullScreenAtStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullScreenAtStart.FormattingEnabled = true;
            this.fullScreenAtStart.Items.AddRange(new object[] {
            "Обычный",
            "Полный экран"});
            this.fullScreenAtStart.Location = new System.Drawing.Point(215, 193);
            this.fullScreenAtStart.Name = "fullScreenAtStart";
            this.fullScreenAtStart.Size = new System.Drawing.Size(482, 21);
            this.fullScreenAtStart.TabIndex = 9;
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
    }
}
