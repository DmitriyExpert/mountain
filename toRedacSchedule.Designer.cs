namespace WinFormsApp1
{
    partial class toRedacSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toRedacSchedule));
            logoiconRegister = new PictureBox();
            toClient = new Label();
            AdminPanelLogo = new PictureBox();
            iconimg = new Button();
            closeBtnRegister = new Button();
            label1 = new Label();
            usersNames = new ComboBox();
            daysInSchedule = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            newTypeShift = new ComboBox();
            label4 = new Label();
            newTimePeriods = new ComboBox();
            label5 = new Label();
            saveSchedule = new Button();
            deleteSchedule = new Button();
            label6 = new Label();
            backtomenu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).BeginInit();
            SuspendLayout();
            // 
            // logoiconRegister
            // 
            logoiconRegister.Image = Properties.Resources.SCHEDULE_mountain;
            logoiconRegister.Location = new Point(26, 31);
            logoiconRegister.Name = "logoiconRegister";
            logoiconRegister.Size = new Size(298, 37);
            logoiconRegister.TabIndex = 64;
            logoiconRegister.TabStop = false;
            // 
            // toClient
            // 
            toClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toClient.AutoSize = true;
            toClient.Cursor = Cursors.Hand;
            toClient.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toClient.Location = new Point(753, 40);
            toClient.Name = "toClient";
            toClient.Size = new Size(222, 29);
            toClient.TabIndex = 63;
            toClient.Text = "Клиентская часть";
            toClient.Click += toClient_Click;
            // 
            // AdminPanelLogo
            // 
            AdminPanelLogo.Image = (Image)resources.GetObject("AdminPanelLogo.Image");
            AdminPanelLogo.Location = new Point(432, 31);
            AdminPanelLogo.Name = "AdminPanelLogo";
            AdminPanelLogo.Size = new Size(298, 37);
            AdminPanelLogo.TabIndex = 62;
            AdminPanelLogo.TabStop = false;
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(1044, 31);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 61;
            iconimg.UseVisualStyleBackColor = true;
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
            closeBtnRegister.Location = new Point(1124, 25);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 60;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(26, 147);
            label1.Name = "label1";
            label1.Size = new Size(426, 37);
            label1.TabIndex = 65;
            label1.Text = "Управление расписанием";
            // 
            // usersNames
            // 
            usersNames.DropDownStyle = ComboBoxStyle.DropDownList;
            usersNames.FormattingEnabled = true;
            usersNames.Location = new Point(26, 265);
            usersNames.Name = "usersNames";
            usersNames.Size = new Size(298, 23);
            usersNames.TabIndex = 66;
            usersNames.SelectedIndexChanged += usersNames_SelectedIndexChanged;
            // 
            // daysInSchedule
            // 
            daysInSchedule.DropDownStyle = ComboBoxStyle.DropDownList;
            daysInSchedule.FormattingEnabled = true;
            daysInSchedule.Location = new Point(26, 334);
            daysInSchedule.Name = "daysInSchedule";
            daysInSchedule.Size = new Size(298, 23);
            daysInSchedule.TabIndex = 67;
            daysInSchedule.SelectedIndexChanged += daysInSchedule_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(26, 246);
            label2.Name = "label2";
            label2.Size = new Size(170, 16);
            label2.TabIndex = 68;
            label2.Text = "Выберите пользователя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(26, 315);
            label3.Name = "label3";
            label3.Size = new Size(210, 16);
            label3.TabIndex = 69;
            label3.Text = "Выберите день из расписания";
            // 
            // newTypeShift
            // 
            newTypeShift.DropDownStyle = ComboBoxStyle.DropDownList;
            newTypeShift.FormattingEnabled = true;
            newTypeShift.Location = new Point(26, 399);
            newTypeShift.Name = "newTypeShift";
            newTypeShift.Size = new Size(298, 23);
            newTypeShift.TabIndex = 70;
            newTypeShift.SelectedIndexChanged += newTypeShift_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(26, 380);
            label4.Name = "label4";
            label4.Size = new Size(193, 16);
            label4.TabIndex = 71;
            label4.Text = "Выберите новый тип смены";
            // 
            // newTimePeriods
            // 
            newTimePeriods.DropDownStyle = ComboBoxStyle.DropDownList;
            newTimePeriods.FormattingEnabled = true;
            newTimePeriods.Location = new Point(26, 461);
            newTimePeriods.Name = "newTimePeriods";
            newTimePeriods.Size = new Size(298, 23);
            newTimePeriods.TabIndex = 72;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(26, 442);
            label5.Name = "label5";
            label5.Size = new Size(275, 16);
            label5.TabIndex = 73;
            label5.Text = "Выберите новый промежуток выремени";
            // 
            // saveSchedule
            // 
            saveSchedule.BackColor = Color.LimeGreen;
            saveSchedule.Cursor = Cursors.Hand;
            saveSchedule.FlatStyle = FlatStyle.Flat;
            saveSchedule.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveSchedule.Location = new Point(26, 522);
            saveSchedule.Name = "saveSchedule";
            saveSchedule.Size = new Size(136, 38);
            saveSchedule.TabIndex = 74;
            saveSchedule.Text = "Сохранить";
            saveSchedule.UseVisualStyleBackColor = false;
            saveSchedule.Click += saveSchedule_Click;
            // 
            // deleteSchedule
            // 
            deleteSchedule.BackColor = Color.Red;
            deleteSchedule.Cursor = Cursors.Hand;
            deleteSchedule.FlatStyle = FlatStyle.Flat;
            deleteSchedule.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteSchedule.ForeColor = SystemColors.ButtonHighlight;
            deleteSchedule.Location = new Point(26, 590);
            deleteSchedule.Name = "deleteSchedule";
            deleteSchedule.Size = new Size(232, 38);
            deleteSchedule.TabIndex = 75;
            deleteSchedule.Text = "Удалить расписание";
            deleteSchedule.UseVisualStyleBackColor = false;
            deleteSchedule.Click += deleteSchedule_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(26, 655);
            label6.Name = "label6";
            label6.Size = new Size(492, 16);
            label6.TabIndex = 76;
            label6.Text = "*Для удаления достаточно заполнить поля с ФИО и днем из расписания!";
            // 
            // backtomenu
            // 
            backtomenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backtomenu.BackgroundImage = Properties.Resources.backtomenu;
            backtomenu.Cursor = Cursors.Hand;
            backtomenu.Location = new Point(26, 705);
            backtomenu.Name = "backtomenu";
            backtomenu.Size = new Size(69, 71);
            backtomenu.TabIndex = 77;
            backtomenu.TabStop = false;
            backtomenu.Click += backtomenu_Click;
            // 
            // toRedacSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1259, 806);
            ControlBox = false;
            Controls.Add(backtomenu);
            Controls.Add(label6);
            Controls.Add(deleteSchedule);
            Controls.Add(saveSchedule);
            Controls.Add(label5);
            Controls.Add(newTimePeriods);
            Controls.Add(label4);
            Controls.Add(newTypeShift);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(daysInSchedule);
            Controls.Add(usersNames);
            Controls.Add(label1);
            Controls.Add(logoiconRegister);
            Controls.Add(toClient);
            Controls.Add(AdminPanelLogo);
            Controls.Add(iconimg);
            Controls.Add(closeBtnRegister);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1275, 845);
            Name = "toRedacSchedule";
            Text = "Управление расписанием";
            Load += toRedacSchedule_Load;
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
        private Label label1;
        private ComboBox usersNames;
        private ComboBox daysInSchedule;
        private Label label2;
        private Label label3;
        private ComboBox newTypeShift;
        private Label label4;
        private ComboBox newTimePeriods;
        private Label label5;
        private Button saveSchedule;
        private Button deleteSchedule;
        private Label label6;
        private PictureBox backtomenu;
    }
}