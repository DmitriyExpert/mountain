namespace WinFormsApp1
{
    partial class requestsinadmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(requestsinadmin));
            logoiconRegister = new PictureBox();
            toClient = new Label();
            AdminPanelLogo = new PictureBox();
            iconimg = new Button();
            closeBtnRegister = new Button();
            comboBoxWithRequest = new ComboBox();
            label1 = new Label();
            buttonReaderInfo = new Button();
            labelDateSelected = new Label();
            labelNewTime = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            pushButton = new Button();
            stopButton = new Button();
            labelFio = new Label();
            backtomenu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).BeginInit();
            SuspendLayout();
            // 
            // logoiconRegister
            // 
            logoiconRegister.Image = Properties.Resources.SCHEDULE_mountain;
            logoiconRegister.Location = new Point(25, 31);
            logoiconRegister.Name = "logoiconRegister";
            logoiconRegister.Size = new Size(298, 37);
            logoiconRegister.TabIndex = 59;
            logoiconRegister.TabStop = false;
            // 
            // toClient
            // 
            toClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toClient.AutoSize = true;
            toClient.Cursor = Cursors.Hand;
            toClient.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toClient.Location = new Point(760, 40);
            toClient.MaximumSize = new Size(1920, 1080);
            toClient.Name = "toClient";
            toClient.Size = new Size(222, 29);
            toClient.TabIndex = 58;
            toClient.Text = "Клиентская часть";
            toClient.Click += toClient_Click;
            // 
            // AdminPanelLogo
            // 
            AdminPanelLogo.Image = (Image)resources.GetObject("AdminPanelLogo.Image");
            AdminPanelLogo.Location = new Point(431, 31);
            AdminPanelLogo.Name = "AdminPanelLogo";
            AdminPanelLogo.Size = new Size(298, 37);
            AdminPanelLogo.TabIndex = 57;
            AdminPanelLogo.TabStop = false;
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(1053, 31);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 56;
            iconimg.UseVisualStyleBackColor = true;
            iconimg.Click += iconimg_Click;
            // 
            // closeBtnRegister
            // 
            closeBtnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeBtnRegister.Cursor = Cursors.Hand;
            closeBtnRegister.FlatAppearance.BorderColor = Color.White;
            closeBtnRegister.FlatAppearance.BorderSize = 0;
            closeBtnRegister.FlatAppearance.MouseDownBackColor = Color.White;
            closeBtnRegister.FlatAppearance.MouseOverBackColor = Color.White;
            closeBtnRegister.FlatStyle = FlatStyle.Popup;
            closeBtnRegister.ForeColor = SystemColors.ButtonHighlight;
            closeBtnRegister.Image = Properties.Resources.close;
            closeBtnRegister.Location = new Point(1133, 25);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 55;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // comboBoxWithRequest
            // 
            comboBoxWithRequest.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWithRequest.FormattingEnabled = true;
            comboBoxWithRequest.Location = new Point(25, 156);
            comboBoxWithRequest.Name = "comboBoxWithRequest";
            comboBoxWithRequest.Size = new Size(389, 23);
            comboBoxWithRequest.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(25, 138);
            label1.Name = "label1";
            label1.Size = new Size(193, 16);
            label1.TabIndex = 61;
            label1.Text = "Не рассмотренные запросы";
            // 
            // buttonReaderInfo
            // 
            buttonReaderInfo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonReaderInfo.Location = new Point(25, 210);
            buttonReaderInfo.Name = "buttonReaderInfo";
            buttonReaderInfo.Size = new Size(298, 31);
            buttonReaderInfo.TabIndex = 62;
            buttonReaderInfo.Text = "Вывести информацию запроса";
            buttonReaderInfo.UseVisualStyleBackColor = true;
            buttonReaderInfo.Click += buttonReaderInfo_Click;
            // 
            // labelDateSelected
            // 
            labelDateSelected.AutoSize = true;
            labelDateSelected.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDateSelected.Location = new Point(25, 335);
            labelDateSelected.Name = "labelDateSelected";
            labelDateSelected.Size = new Size(179, 22);
            labelDateSelected.TabIndex = 63;
            labelDateSelected.Text = "Выбранная дата: ";
            // 
            // labelNewTime
            // 
            labelNewTime.AutoSize = true;
            labelNewTime.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelNewTime.Location = new Point(25, 386);
            labelNewTime.Name = "labelNewTime";
            labelNewTime.Size = new Size(141, 22);
            labelNewTime.TabIndex = 64;
            labelNewTime.Text = "Новое время:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(25, 461);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(512, 262);
            richTextBox1.TabIndex = 65;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(25, 442);
            label2.Name = "label2";
            label2.Size = new Size(104, 16);
            label2.TabIndex = 66;
            label2.Text = "Текст запроса:";
            // 
            // pushButton
            // 
            pushButton.BackColor = Color.Green;
            pushButton.BackgroundImageLayout = ImageLayout.None;
            pushButton.Cursor = Cursors.Hand;
            pushButton.FlatAppearance.BorderSize = 0;
            pushButton.FlatStyle = FlatStyle.Flat;
            pushButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            pushButton.ForeColor = SystemColors.ButtonHighlight;
            pushButton.Location = new Point(25, 755);
            pushButton.Name = "pushButton";
            pushButton.Size = new Size(117, 38);
            pushButton.TabIndex = 69;
            pushButton.Text = "Одобрить";
            pushButton.UseVisualStyleBackColor = false;
            pushButton.Click += pushButton_Click;
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.Red;
            stopButton.BackgroundImageLayout = ImageLayout.None;
            stopButton.Cursor = Cursors.Hand;
            stopButton.FlatAppearance.BorderSize = 0;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            stopButton.ForeColor = SystemColors.ButtonHighlight;
            stopButton.Location = new Point(420, 755);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(117, 38);
            stopButton.TabIndex = 70;
            stopButton.Text = "Отклонить";
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += stopButton_Click;
            // 
            // labelFio
            // 
            labelFio.AutoSize = true;
            labelFio.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFio.Location = new Point(25, 288);
            labelFio.Name = "labelFio";
            labelFio.Size = new Size(67, 22);
            labelFio.TabIndex = 71;
            labelFio.Text = "ФИО: ";
            // 
            // backtomenu
            // 
            backtomenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backtomenu.BackgroundImage = Properties.Resources.backtomenu;
            backtomenu.Cursor = Cursors.Hand;
            backtomenu.Location = new Point(25, 831);
            backtomenu.Name = "backtomenu";
            backtomenu.Size = new Size(69, 71);
            backtomenu.TabIndex = 72;
            backtomenu.TabStop = false;
            backtomenu.Click += backtomenu_Click;
            // 
            // requestsinadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1269, 926);
            ControlBox = false;
            Controls.Add(backtomenu);
            Controls.Add(labelFio);
            Controls.Add(stopButton);
            Controls.Add(pushButton);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(labelNewTime);
            Controls.Add(labelDateSelected);
            Controls.Add(buttonReaderInfo);
            Controls.Add(label1);
            Controls.Add(comboBoxWithRequest);
            Controls.Add(logoiconRegister);
            Controls.Add(toClient);
            Controls.Add(AdminPanelLogo);
            Controls.Add(iconimg);
            Controls.Add(closeBtnRegister);
            Name = "requestsinadmin";
            Text = "Управление запросами";
            Load += requestsinadmin_Load;
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoiconRegister;
        private Label toClient;
        private PictureBox AdminPanelLogo;
        private Button iconimg;
        private Button closeBtnRegister;
        private ComboBox comboBoxWithRequest;
        private Label label1;
        private Button buttonReaderInfo;
        private Label labelDateSelected;
        private Label labelNewTime;
        private RichTextBox richTextBox1;
        private Label label2;
        private Button pushButton;
        private Button stopButton;
        private Label labelFio;
        private PictureBox backtomenu;
    }
}