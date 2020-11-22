namespace Client.UserControls
{
    partial class RoleManagmentUserControl
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
            this.rolePositionPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rolePositionRightPanel = new System.Windows.Forms.Panel();
            this.blockACheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rolePositionLeftPanel = new System.Windows.Forms.Panel();
            this.blockAListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.blockBCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.blockBListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.viewHeaderPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.rolePositionPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.rolePositionRightPanel.SuspendLayout();
            this.rolePositionLeftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.viewHeaderPanel.TabIndex = 22;
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
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rolePositionPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 461);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // rolePositionPanel
            // 
            this.rolePositionPanel.Controls.Add(this.tableLayoutPanel2);
            this.rolePositionPanel.Controls.Add(this.label1);
            this.rolePositionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolePositionPanel.Location = new System.Drawing.Point(3, 3);
            this.rolePositionPanel.Name = "rolePositionPanel";
            this.rolePositionPanel.Size = new System.Drawing.Size(696, 132);
            this.rolePositionPanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rolePositionRightPanel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rolePositionLeftPanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(696, 109);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // rolePositionRightPanel
            // 
            this.rolePositionRightPanel.Controls.Add(this.blockACheckedListBox);
            this.rolePositionRightPanel.Controls.Add(this.label3);
            this.rolePositionRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolePositionRightPanel.Location = new System.Drawing.Point(352, 5);
            this.rolePositionRightPanel.Name = "rolePositionRightPanel";
            this.rolePositionRightPanel.Size = new System.Drawing.Size(339, 99);
            this.rolePositionRightPanel.TabIndex = 2;
            // 
            // blockACheckedListBox
            // 
            this.blockACheckedListBox.CheckOnClick = true;
            this.blockACheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blockACheckedListBox.Enabled = false;
            this.blockACheckedListBox.FormattingEnabled = true;
            this.blockACheckedListBox.IntegralHeight = false;
            this.blockACheckedListBox.Location = new System.Drawing.Point(0, 17);
            this.blockACheckedListBox.Name = "blockACheckedListBox";
            this.blockACheckedListBox.Size = new System.Drawing.Size(339, 82);
            this.blockACheckedListBox.TabIndex = 1;
            this.blockACheckedListBox.SelectedIndexChanged += new System.EventHandler(this.BlockACheckedListBoxSelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Должности";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rolePositionLeftPanel
            // 
            this.rolePositionLeftPanel.Controls.Add(this.blockAListBox);
            this.rolePositionLeftPanel.Controls.Add(this.label2);
            this.rolePositionLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolePositionLeftPanel.Location = new System.Drawing.Point(5, 5);
            this.rolePositionLeftPanel.Name = "rolePositionLeftPanel";
            this.rolePositionLeftPanel.Size = new System.Drawing.Size(339, 99);
            this.rolePositionLeftPanel.TabIndex = 1;
            // 
            // blockAListBox
            // 
            this.blockAListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blockAListBox.FormattingEnabled = true;
            this.blockAListBox.Location = new System.Drawing.Point(0, 17);
            this.blockAListBox.Name = "blockAListBox";
            this.blockAListBox.Size = new System.Drawing.Size(339, 82);
            this.blockAListBox.TabIndex = 1;
            this.blockAListBox.SelectedIndexChanged += new System.EventHandler(this.BlockAListBoxSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Роль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройка должностей для выбранной роли";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 317);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(696, 294);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.blockBCheckedListBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(352, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 284);
            this.panel2.TabIndex = 2;
            // 
            // blockBCheckedListBox
            // 
            this.blockBCheckedListBox.CheckOnClick = true;
            this.blockBCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blockBCheckedListBox.Enabled = false;
            this.blockBCheckedListBox.FormattingEnabled = true;
            this.blockBCheckedListBox.IntegralHeight = false;
            this.blockBCheckedListBox.Location = new System.Drawing.Point(0, 17);
            this.blockBCheckedListBox.Name = "blockBCheckedListBox";
            this.blockBCheckedListBox.Size = new System.Drawing.Size(339, 267);
            this.blockBCheckedListBox.TabIndex = 1;
            this.blockBCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.BlockBCheckedListBoxSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Разрешения";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.blockBListBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 284);
            this.panel3.TabIndex = 1;
            // 
            // blockBListBox
            // 
            this.blockBListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blockBListBox.FormattingEnabled = true;
            this.blockBListBox.Location = new System.Drawing.Point(0, 17);
            this.blockBListBox.Name = "blockBListBox";
            this.blockBListBox.Size = new System.Drawing.Size(339, 147);
            this.blockBListBox.TabIndex = 1;
            this.blockBListBox.SelectedIndexChanged += new System.EventHandler(this.BlockBListBoxSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Роль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(696, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Настройка разрешений для выбранной роли";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RoleManagmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.viewHeaderPanel);
            this.Name = "RoleManagmentUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.viewHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.rolePositionPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.rolePositionRightPanel.ResumeLayout(false);
            this.rolePositionLeftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewHeaderPanel;
        private System.Windows.Forms.Button returnChangesButton;
        private System.Windows.Forms.Button saveANDexitButton;
        private System.Windows.Forms.Button closeView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel rolePositionPanel;
        private System.Windows.Forms.Panel rolePositionRightPanel;
        private System.Windows.Forms.CheckedListBox blockACheckedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel rolePositionLeftPanel;
        private System.Windows.Forms.ListBox blockAListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox blockBCheckedListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox blockBListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
