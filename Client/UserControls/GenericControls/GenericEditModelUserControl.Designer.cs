namespace Client.UserControls.GenericControls
{
    partial class GenericEditModelUserControl<ModelType, DataType>
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
            this.manageButtons = new System.Windows.Forms.Panel();
            this.returnChangesButton = new System.Windows.Forms.Button();
            this.saveANDexitButton = new System.Windows.Forms.Button();
            this.closeViewButton = new System.Windows.Forms.Button();
            this.modelPanel = new System.Windows.Forms.Panel();
            this.manageButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // manageButtons
            // 
            this.manageButtons.Controls.Add(this.returnChangesButton);
            this.manageButtons.Controls.Add(this.saveANDexitButton);
            this.manageButtons.Controls.Add(this.closeViewButton);
            this.manageButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageButtons.Location = new System.Drawing.Point(0, 0);
            this.manageButtons.Name = "manageButtons";
            this.manageButtons.Size = new System.Drawing.Size(464, 29);
            this.manageButtons.TabIndex = 2;
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
            // closeViewButton
            // 
            this.closeViewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeViewButton.Location = new System.Drawing.Point(356, 0);
            this.closeViewButton.Name = "closeViewButton";
            this.closeViewButton.Size = new System.Drawing.Size(108, 29);
            this.closeViewButton.TabIndex = 0;
            this.closeViewButton.Text = "Закрыть";
            this.closeViewButton.UseVisualStyleBackColor = true;
            this.closeViewButton.Click += new System.EventHandler(this.CloseViewClick);
            // 
            // modelPanel
            // 
            this.modelPanel.AutoScroll = true;
            this.modelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelPanel.Location = new System.Drawing.Point(0, 29);
            this.modelPanel.Name = "modelPanel";
            this.modelPanel.Size = new System.Drawing.Size(464, 456);
            this.modelPanel.TabIndex = 3;
            // 
            // GenericEditModelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.modelPanel);
            this.Controls.Add(this.manageButtons);
            this.Name = "GenericEditModelUserControl";
            this.Size = new System.Drawing.Size(464, 485);
            this.manageButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel manageButtons;
        private System.Windows.Forms.Button returnChangesButton;
        private System.Windows.Forms.Button saveANDexitButton;
        private System.Windows.Forms.Button closeViewButton;
        private System.Windows.Forms.Panel modelPanel;
    }
}
