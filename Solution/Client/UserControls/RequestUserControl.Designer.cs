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
            System.Windows.Forms.ColumnHeader Collumn7;
            System.Windows.Forms.ColumnHeader Collumn8;
            this.viewHeaderPanel = new System.Windows.Forms.Panel();
            this.requestCompleteLabel = new System.Windows.Forms.Label();
            this.requestInWorkLabel = new System.Windows.Forms.Label();
            this.currentUserColorLabel = new System.Windows.Forms.Label();
            this.closeView = new System.Windows.Forms.Button();
            this.RequestList = new System.Windows.Forms.ListView();
            this.Collumn6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requestsPanel = new System.Windows.Forms.Panel();
            this.requsetManageButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.createReportAndCloseButton = new System.Windows.Forms.Button();
            this.acceptRequest = new System.Windows.Forms.Button();
            this.newRequestButton = new System.Windows.Forms.Button();
            this.newRequestPanel = new System.Windows.Forms.Panel();
            this.newRequestTable = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NRserviceCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NRnameTB = new System.Windows.Forms.TextBox();
            this.NRrequestTypeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NRaddressTB = new System.Windows.Forms.TextBox();
            this.NRtargetUserCB = new System.Windows.Forms.ComboBox();
            this.NRclientsCB = new System.Windows.Forms.ComboBox();
            Collumn1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Collumn2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Collumn3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Collumn4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Collumn5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Collumn7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Collumn8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewHeaderPanel.SuspendLayout();
            this.requestsPanel.SuspendLayout();
            this.requsetManageButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.newRequestPanel.SuspendLayout();
            this.newRequestTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // Collumn1
            // 
            Collumn1.Text = "Заявка";
            Collumn1.Width = 110;
            // 
            // Collumn2
            // 
            Collumn2.Text = "Тип заявки";
            Collumn2.Width = 150;
            // 
            // Collumn3
            // 
            Collumn3.Text = "Адрес";
            Collumn3.Width = 200;
            // 
            // Collumn4
            // 
            Collumn4.Text = "Услуга";
            Collumn4.Width = 200;
            // 
            // Collumn5
            // 
            Collumn5.Text = "Сотрудник";
            Collumn5.Width = 250;
            // 
            // Collumn7
            // 
            Collumn7.Text = "Клиент";
            Collumn7.Width = 200;
            // 
            // Collumn8
            // 
            Collumn8.Text = "Статус заявки";
            Collumn8.Width = 130;
            // 
            // viewHeaderPanel
            // 
            this.viewHeaderPanel.Controls.Add(this.requestCompleteLabel);
            this.viewHeaderPanel.Controls.Add(this.requestInWorkLabel);
            this.viewHeaderPanel.Controls.Add(this.currentUserColorLabel);
            this.viewHeaderPanel.Controls.Add(this.closeView);
            this.viewHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.viewHeaderPanel.Name = "viewHeaderPanel";
            this.viewHeaderPanel.Size = new System.Drawing.Size(702, 23);
            this.viewHeaderPanel.TabIndex = 20;
            // 
            // requestCompleteLabel
            // 
            this.requestCompleteLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.requestCompleteLabel.Location = new System.Drawing.Point(428, 0);
            this.requestCompleteLabel.Name = "requestCompleteLabel";
            this.requestCompleteLabel.Size = new System.Drawing.Size(144, 23);
            this.requestCompleteLabel.TabIndex = 4;
            this.requestCompleteLabel.Text = "Выполненные заявки";
            this.requestCompleteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // requestInWorkLabel
            // 
            this.requestInWorkLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.requestInWorkLabel.Location = new System.Drawing.Point(301, 0);
            this.requestInWorkLabel.Name = "requestInWorkLabel";
            this.requestInWorkLabel.Size = new System.Drawing.Size(127, 23);
            this.requestInWorkLabel.TabIndex = 3;
            this.requestInWorkLabel.Text = "Заявки в работе";
            this.requestInWorkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentUserColorLabel
            // 
            this.currentUserColorLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentUserColorLabel.Location = new System.Drawing.Point(0, 0);
            this.currentUserColorLabel.Name = "currentUserColorLabel";
            this.currentUserColorLabel.Size = new System.Drawing.Size(301, 23);
            this.currentUserColorLabel.TabIndex = 2;
            this.currentUserColorLabel.Text = "Заявки назначенные текущему пользователю";
            this.currentUserColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeView
            // 
            this.closeView.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Collumn6,
            Collumn7,
            Collumn8});
            this.RequestList.FullRowSelect = true;
            this.RequestList.GridLines = true;
            this.RequestList.HideSelection = false;
            this.RequestList.Location = new System.Drawing.Point(3, 3);
            this.RequestList.MultiSelect = false;
            this.RequestList.Name = "RequestList";
            this.RequestList.Size = new System.Drawing.Size(696, 210);
            this.RequestList.TabIndex = 21;
            this.RequestList.UseCompatibleStateImageBehavior = false;
            this.RequestList.View = System.Windows.Forms.View.Details;
            this.RequestList.SelectedIndexChanged += new System.EventHandler(this.RequestListSelectedIndexChanged);
            // 
            // Collumn6
            // 
            this.Collumn6.Text = "Назначенный сотрудник";
            this.Collumn6.Width = 250;
            // 
            // requestsPanel
            // 
            this.requestsPanel.Controls.Add(this.requsetManageButtons);
            this.requestsPanel.Controls.Add(this.RequestList);
            this.requestsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestsPanel.Location = new System.Drawing.Point(0, 23);
            this.requestsPanel.Name = "requestsPanel";
            this.requestsPanel.Size = new System.Drawing.Size(702, 251);
            this.requestsPanel.TabIndex = 25;
            // 
            // requsetManageButtons
            // 
            this.requsetManageButtons.Controls.Add(this.tableLayoutPanel1);
            this.requsetManageButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.requsetManageButtons.Location = new System.Drawing.Point(0, 216);
            this.requsetManageButtons.Name = "requsetManageButtons";
            this.requsetManageButtons.Size = new System.Drawing.Size(702, 35);
            this.requsetManageButtons.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.createReportAndCloseButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.acceptRequest, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 35);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // createReportAndCloseButton
            // 
            this.createReportAndCloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createReportAndCloseButton.Enabled = false;
            this.createReportAndCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createReportAndCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createReportAndCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.createReportAndCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReportAndCloseButton.Location = new System.Drawing.Point(354, 3);
            this.createReportAndCloseButton.Name = "createReportAndCloseButton";
            this.createReportAndCloseButton.Size = new System.Drawing.Size(345, 29);
            this.createReportAndCloseButton.TabIndex = 1;
            this.createReportAndCloseButton.Text = "Добавить отчет выполненной работы и закрыть заявку";
            this.createReportAndCloseButton.UseVisualStyleBackColor = true;
            this.createReportAndCloseButton.Click += new System.EventHandler(this.CreateReportAndCloseButtonClick);
            // 
            // acceptRequest
            // 
            this.acceptRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceptRequest.Enabled = false;
            this.acceptRequest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.acceptRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.acceptRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.acceptRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptRequest.Location = new System.Drawing.Point(3, 3);
            this.acceptRequest.Name = "acceptRequest";
            this.acceptRequest.Size = new System.Drawing.Size(345, 29);
            this.acceptRequest.TabIndex = 0;
            this.acceptRequest.Text = "Принять в работу";
            this.acceptRequest.UseVisualStyleBackColor = true;
            this.acceptRequest.Click += new System.EventHandler(this.AcceptRequestClick);
            // 
            // newRequestButton
            // 
            this.newRequestTable.SetColumnSpan(this.newRequestButton, 2);
            this.newRequestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newRequestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newRequestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newRequestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.newRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRequestButton.Location = new System.Drawing.Point(3, 163);
            this.newRequestButton.Name = "newRequestButton";
            this.newRequestButton.Size = new System.Drawing.Size(746, 24);
            this.newRequestButton.TabIndex = 22;
            this.newRequestButton.Text = "Новая заявка";
            this.newRequestButton.UseVisualStyleBackColor = true;
            this.newRequestButton.Click += new System.EventHandler(this.NewRequestButtonClick);
            // 
            // newRequestPanel
            // 
            this.newRequestPanel.Controls.Add(this.newRequestTable);
            this.newRequestPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newRequestPanel.Location = new System.Drawing.Point(0, 274);
            this.newRequestPanel.Name = "newRequestPanel";
            this.newRequestPanel.Size = new System.Drawing.Size(702, 213);
            this.newRequestPanel.TabIndex = 24;
            // 
            // newRequestTable
            // 
            this.newRequestTable.ColumnCount = 2;
            this.newRequestTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.newRequestTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.newRequestTable.Controls.Add(this.newRequestButton, 0, 6);
            this.newRequestTable.Controls.Add(this.label6, 0, 5);
            this.newRequestTable.Controls.Add(this.label5, 0, 4);
            this.newRequestTable.Controls.Add(this.NRserviceCB, 1, 3);
            this.newRequestTable.Controls.Add(this.label4, 0, 3);
            this.newRequestTable.Controls.Add(this.label2, 0, 0);
            this.newRequestTable.Controls.Add(this.label1, 0, 1);
            this.newRequestTable.Controls.Add(this.NRnameTB, 1, 1);
            this.newRequestTable.Controls.Add(this.NRrequestTypeCB, 1, 0);
            this.newRequestTable.Controls.Add(this.label3, 0, 2);
            this.newRequestTable.Controls.Add(this.NRaddressTB, 1, 2);
            this.newRequestTable.Controls.Add(this.NRtargetUserCB, 1, 4);
            this.newRequestTable.Controls.Add(this.NRclientsCB, 1, 5);
            this.newRequestTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newRequestTable.Location = new System.Drawing.Point(0, 0);
            this.newRequestTable.Name = "newRequestTable";
            this.newRequestTable.RowCount = 8;
            this.newRequestTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newRequestTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newRequestTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newRequestTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newRequestTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newRequestTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newRequestTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.newRequestTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.newRequestTable.Size = new System.Drawing.Size(702, 213);
            this.newRequestTable.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Клиент";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Назначенный сотрудник";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NRserviceCB
            // 
            this.NRserviceCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NRserviceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NRserviceCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NRserviceCB.FormattingEnabled = true;
            this.NRserviceCB.IntegralHeight = false;
            this.NRserviceCB.Location = new System.Drawing.Point(203, 82);
            this.NRserviceCB.Name = "NRserviceCB";
            this.NRserviceCB.Size = new System.Drawing.Size(546, 21);
            this.NRserviceCB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Услуга";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип заявки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заявка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NRnameTB
            // 
            this.NRnameTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NRnameTB.Location = new System.Drawing.Point(203, 30);
            this.NRnameTB.Name = "NRnameTB";
            this.NRnameTB.ReadOnly = true;
            this.NRnameTB.Size = new System.Drawing.Size(546, 20);
            this.NRnameTB.TabIndex = 2;
            // 
            // NRrequestTypeCB
            // 
            this.NRrequestTypeCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NRrequestTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NRrequestTypeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NRrequestTypeCB.FormattingEnabled = true;
            this.NRrequestTypeCB.IntegralHeight = false;
            this.NRrequestTypeCB.Location = new System.Drawing.Point(203, 3);
            this.NRrequestTypeCB.Name = "NRrequestTypeCB";
            this.NRrequestTypeCB.Size = new System.Drawing.Size(546, 21);
            this.NRrequestTypeCB.TabIndex = 3;
            this.NRrequestTypeCB.SelectedIndexChanged += new System.EventHandler(this.NRrequestTypeCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Адрес";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NRaddressTB
            // 
            this.NRaddressTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NRaddressTB.Location = new System.Drawing.Point(203, 56);
            this.NRaddressTB.Name = "NRaddressTB";
            this.NRaddressTB.Size = new System.Drawing.Size(546, 20);
            this.NRaddressTB.TabIndex = 5;
            // 
            // NRtargetUserCB
            // 
            this.NRtargetUserCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NRtargetUserCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NRtargetUserCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NRtargetUserCB.FormattingEnabled = true;
            this.NRtargetUserCB.IntegralHeight = false;
            this.NRtargetUserCB.Location = new System.Drawing.Point(203, 109);
            this.NRtargetUserCB.Name = "NRtargetUserCB";
            this.NRtargetUserCB.Size = new System.Drawing.Size(546, 21);
            this.NRtargetUserCB.TabIndex = 9;
            // 
            // NRclientsCB
            // 
            this.NRclientsCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NRclientsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NRclientsCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NRclientsCB.FormattingEnabled = true;
            this.NRclientsCB.IntegralHeight = false;
            this.NRclientsCB.Location = new System.Drawing.Point(203, 136);
            this.NRclientsCB.Name = "NRclientsCB";
            this.NRclientsCB.Size = new System.Drawing.Size(546, 21);
            this.NRclientsCB.TabIndex = 11;
            // 
            // RequestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.requestsPanel);
            this.Controls.Add(this.viewHeaderPanel);
            this.Controls.Add(this.newRequestPanel);
            this.Name = "RequestUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.viewHeaderPanel.ResumeLayout(false);
            this.requestsPanel.ResumeLayout(false);
            this.requsetManageButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.newRequestPanel.ResumeLayout(false);
            this.newRequestTable.ResumeLayout(false);
            this.newRequestTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewHeaderPanel;
        private System.Windows.Forms.Button closeView;
        private System.Windows.Forms.ListView RequestList;
        private System.Windows.Forms.ColumnHeader Collumn6;
        private System.Windows.Forms.Panel requestsPanel;
        private System.Windows.Forms.Button newRequestButton;
        private System.Windows.Forms.Panel requsetManageButtons;
        private System.Windows.Forms.Panel newRequestPanel;
        private System.Windows.Forms.TableLayoutPanel newRequestTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NRnameTB;
        private System.Windows.Forms.ComboBox NRrequestTypeCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NRaddressTB;
        private System.Windows.Forms.ComboBox NRserviceCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NRtargetUserCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox NRclientsCB;
        private System.Windows.Forms.Label currentUserColorLabel;
        private System.Windows.Forms.Button acceptRequest;
        private System.Windows.Forms.Label requestInWorkLabel;
        private System.Windows.Forms.Label requestCompleteLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button createReportAndCloseButton;
    }
}
