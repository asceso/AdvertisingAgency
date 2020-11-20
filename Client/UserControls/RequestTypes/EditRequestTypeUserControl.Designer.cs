namespace Client.UserControls.RequestTypes
{
    partial class EditRequestTypeUserControl
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
            this.closeViewButton = new System.Windows.Forms.Button();
            this.manageButtons = new System.Windows.Forms.Panel();
            this.returnChangesButton = new System.Windows.Forms.Button();
            this.saveANDexitButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.manageButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeViewButton
            // 
            this.closeViewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeViewButton.Location = new System.Drawing.Point(358, 0);
            this.closeViewButton.Name = "closeViewButton";
            this.closeViewButton.Size = new System.Drawing.Size(108, 29);
            this.closeViewButton.TabIndex = 0;
            this.closeViewButton.Text = "Закрыть";
            this.closeViewButton.UseVisualStyleBackColor = true;
            this.closeViewButton.Click += new System.EventHandler(this.CloseViewClick);
            // 
            // manageButtons
            // 
            this.manageButtons.Controls.Add(this.returnChangesButton);
            this.manageButtons.Controls.Add(this.saveANDexitButton);
            this.manageButtons.Controls.Add(this.closeViewButton);
            this.manageButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageButtons.Location = new System.Drawing.Point(0, 0);
            this.manageButtons.Name = "manageButtons";
            this.manageButtons.Size = new System.Drawing.Size(466, 29);
            this.manageButtons.TabIndex = 1;
            // 
            // returnChangesButton
            // 
            this.returnChangesButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.returnChangesButton.Location = new System.Drawing.Point(158, 0);
            this.returnChangesButton.Name = "returnChangesButton";
            this.returnChangesButton.Size = new System.Drawing.Size(158, 29);
            this.returnChangesButton.TabIndex = 2;
            this.returnChangesButton.Text = "Отменить изменения";
            this.returnChangesButton.UseVisualStyleBackColor = true;
            this.returnChangesButton.Click += new System.EventHandler(this.ReturnChangesButtonClick);
            // 
            // saveANDexitButton
            // 
            this.saveANDexitButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveANDexitButton.Location = new System.Drawing.Point(0, 0);
            this.saveANDexitButton.Name = "saveANDexitButton";
            this.saveANDexitButton.Size = new System.Drawing.Size(158, 29);
            this.saveANDexitButton.TabIndex = 1;
            this.saveANDexitButton.Text = "Сохранить и закрыть";
            this.saveANDexitButton.UseVisualStyleBackColor = true;
            this.saveANDexitButton.Click += new System.EventHandler(this.SaveAndExitButtonClick);
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Location = new System.Drawing.Point(0, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.nameLabel.Size = new System.Drawing.Size(466, 33);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Название";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTextBox.Location = new System.Drawing.Point(0, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(466, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 115);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(466, 80);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionLabel.Location = new System.Drawing.Point(0, 82);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.descriptionLabel.Size = new System.Drawing.Size(466, 33);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Описание";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // EditRequestTypeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.manageButtons);
            this.Name = "EditRequestTypeUserControl";
            this.Size = new System.Drawing.Size(466, 487);
            this.manageButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeViewButton;
        private System.Windows.Forms.Panel manageButtons;
        private System.Windows.Forms.Button returnChangesButton;
        private System.Windows.Forms.Button saveANDexitButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
    }
}
