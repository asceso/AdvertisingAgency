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
            this.textEdit1 = new VSIXProject1.TextEdit();
            this.textEdit2 = new VSIXProject1.TextEdit();
            this.textEdit3 = new VSIXProject1.TextEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AcceptChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEdit1.Location = new System.Drawing.Point(0, 0);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(495, 27);
            this.textEdit1.TabIndex = 0;
            this.textEdit1.TextBoxPasswordChar = '\0';
            this.textEdit1.TextBoxUseSystemPasswordChar = false;
            this.textEdit1.TextBoxValue = "";
            this.textEdit1.TextHeaderMinSize = new System.Drawing.Size(75, 0);
            this.textEdit1.TextHeaderValue = "Имя";
            this.textEdit1.TextValueMultiline = false;
            // 
            // textEdit2
            // 
            this.textEdit2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEdit2.Location = new System.Drawing.Point(0, 27);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(495, 27);
            this.textEdit2.TabIndex = 1;
            this.textEdit2.TextBoxPasswordChar = '\0';
            this.textEdit2.TextBoxUseSystemPasswordChar = false;
            this.textEdit2.TextBoxValue = "";
            this.textEdit2.TextHeaderMinSize = new System.Drawing.Size(75, 0);
            this.textEdit2.TextHeaderValue = "Фамилия";
            this.textEdit2.TextValueMultiline = false;
            // 
            // textEdit3
            // 
            this.textEdit3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEdit3.Location = new System.Drawing.Point(0, 54);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(495, 27);
            this.textEdit3.TabIndex = 2;
            this.textEdit3.TextBoxPasswordChar = '\0';
            this.textEdit3.TextBoxUseSystemPasswordChar = false;
            this.textEdit3.TextBoxValue = "";
            this.textEdit3.TextHeaderMinSize = new System.Drawing.Size(75, 0);
            this.textEdit3.TextHeaderValue = "Отчество";
            this.textEdit3.TextValueMultiline = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(495, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Должность";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AcceptChangesButton
            // 
            this.AcceptChangesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AcceptChangesButton.Location = new System.Drawing.Point(0, 125);
            this.AcceptChangesButton.Name = "AcceptChangesButton";
            this.AcceptChangesButton.Size = new System.Drawing.Size(495, 23);
            this.AcceptChangesButton.TabIndex = 5;
            this.AcceptChangesButton.Text = "Подтвердить";
            this.AcceptChangesButton.UseVisualStyleBackColor = true;
            this.AcceptChangesButton.Click += new System.EventHandler(this.AcceptChangesButtonClick);
            // 
            // UserManageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AcceptChangesButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Name = "UserManageUserControl";
            this.Size = new System.Drawing.Size(495, 331);
            this.Load += new System.EventHandler(this.UserManageUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VSIXProject1.TextEdit textEdit1;
        private VSIXProject1.TextEdit textEdit2;
        private VSIXProject1.TextEdit textEdit3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AcceptChangesButton;
    }
}
