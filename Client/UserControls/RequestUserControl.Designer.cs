namespace Client.UserControls
{
    partial class RequestUserControl
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
            System.Windows.Forms.ColumnHeader Collumn1;
            System.Windows.Forms.ColumnHeader Collumn2;
            System.Windows.Forms.ColumnHeader Collumn3;
            System.Windows.Forms.ColumnHeader Collumn4;
            System.Windows.Forms.ColumnHeader Collumn5;
            System.Windows.Forms.ColumnHeader Collumn6;
            System.Windows.Forms.ColumnHeader Collumn7;
            this.viewHeaderPanel = new System.Windows.Forms.Panel();
            this.closeView = new System.Windows.Forms.Button();
            this.RequestList = new System.Windows.Forms.ListView();
            Collumn1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Collumn2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Collumn3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Collumn4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Collumn5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Collumn6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Collumn7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Collumn1
            // 
            Collumn1.Text = "Заявка";
            Collumn1.Width = 130;
            // 
            // Collumn2
            // 
            Collumn2.Text = "Тип заявки";
            Collumn2.Width = 100;
            // 
            // Collumn3
            // 
            Collumn3.Text = "Адрес";
            Collumn3.Width = 250;
            // 
            // Collumn4
            // 
            Collumn4.Text = "Услуга";
            Collumn4.Width = 150;
            // 
            // Collumn5
            // 
            Collumn5.Text = "Сотрудник";
            Collumn5.Width = 150;
            // 
            // Collumn6
            // 
            Collumn6.Text = "Клиент";
            Collumn6.Width = 150;
            // 
            // Collumn7
            // 
            Collumn7.Text = "Статус заявки";
            Collumn7.Width = 100;
            // 
            // viewHeaderPanel
            // 
            this.viewHeaderPanel.Controls.Add(this.closeView);
            this.viewHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.viewHeaderPanel.Name = "viewHeaderPanel";
            this.viewHeaderPanel.Size = new System.Drawing.Size(702, 23);
            this.viewHeaderPanel.TabIndex = 20;
            // 
            // closeView
            // 
            this.closeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.closeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeView.Location = new System.Drawing.Point(678, 0);
            this.closeView.Name = "closeView";
            this.closeView.Size = new System.Drawing.Size(24, 23);
            this.closeView.TabIndex = 1;
            this.closeView.Text = "X";
            this.closeView.UseVisualStyleBackColor = true;
            this.closeView.Click += new System.EventHandler(this.CloseViewClick);
            // 
            // RequestList
            // 
            this.RequestList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Collumn1,
            Collumn2,
            Collumn3,
            Collumn4,
            Collumn5,
            Collumn6,
            Collumn7});
            this.RequestList.FullRowSelect = true;
            this.RequestList.GridLines = true;
            this.RequestList.HideSelection = false;
            this.RequestList.Location = new System.Drawing.Point(3, 26);
            this.RequestList.MultiSelect = false;
            this.RequestList.Name = "RequestList";
            this.RequestList.Size = new System.Drawing.Size(696, 263);
            this.RequestList.TabIndex = 21;
            this.RequestList.UseCompatibleStateImageBehavior = false;
            this.RequestList.View = System.Windows.Forms.View.Details;
            // 
            // RequestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RequestList);
            this.Controls.Add(this.viewHeaderPanel);
            this.Name = "RequestUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.viewHeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewHeaderPanel;
        private System.Windows.Forms.Button closeView;
        private System.Windows.Forms.ListView RequestList;
    }
}
