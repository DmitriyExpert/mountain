namespace WinFormsApp1
{
    partial class cabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cabinet));
            logoiconRegister = new PictureBox();
            panel = new Label();
            pictureToCabinet = new PictureBox();
            iconimg = new Button();
            closeBtnRegister = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            backtomenu = new PictureBox();
            cabinetActive = new Button();
            pictureBoxCabinetActive = new PictureBox();
            pictureBox4 = new PictureBox();
            toContact = new Button();
            labelCabinetTitle = new Label();
            pictureBox3 = new PictureBox();
            identifyUser = new Label();
            fioUser = new Label();
            labelProff = new Label();
            toRedact = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureToCabinet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCabinetActive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // logoiconRegister
            // 
            logoiconRegister.Image = Properties.Resources.SCHEDULE_mountain;
            logoiconRegister.Location = new Point(44, 40);
            logoiconRegister.Name = "logoiconRegister";
            logoiconRegister.Size = new Size(298, 37);
            logoiconRegister.TabIndex = 3;
            logoiconRegister.TabStop = false;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel.AutoSize = true;
            panel.Cursor = Cursors.Hand;
            panel.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panel.Location = new Point(1308, 52);
            panel.Name = "panel";
            panel.Size = new Size(185, 25);
            panel.TabIndex = 30;
            panel.Text = "Панель управления";
            panel.Click += panel_Click;
            // 
            // pictureToCabinet
            // 
            pictureToCabinet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureToCabinet.BackgroundImage = Properties.Resources.user__icon;
            pictureToCabinet.BackgroundImageLayout = ImageLayout.Center;
            pictureToCabinet.Location = new Point(1548, 26);
            pictureToCabinet.Name = "pictureToCabinet";
            pictureToCabinet.Size = new Size(74, 74);
            pictureToCabinet.TabIndex = 29;
            pictureToCabinet.TabStop = false;
            pictureToCabinet.Click += pictureToCabinet_Click;
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(1707, 40);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 28;
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
            closeBtnRegister.Location = new Point(1787, 34);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 27;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-2, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 928);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGray;
            pictureBox2.Location = new Point(97, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1807, 928);
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // backtomenu
            // 
            backtomenu.BackgroundImage = Properties.Resources.backtomenu;
            backtomenu.Cursor = Cursors.Hand;
            backtomenu.Location = new Point(12, 958);
            backtomenu.Name = "backtomenu";
            backtomenu.Size = new Size(69, 71);
            backtomenu.TabIndex = 33;
            backtomenu.TabStop = false;
            backtomenu.Click += backtomenu_Click;
            // 
            // cabinetActive
            // 
            cabinetActive.BackColor = Color.LightGray;
            cabinetActive.BackgroundImage = Properties.Resources.cabinet;
            cabinetActive.Cursor = Cursors.Hand;
            cabinetActive.FlatAppearance.BorderColor = Color.White;
            cabinetActive.FlatAppearance.BorderSize = 0;
            cabinetActive.FlatAppearance.MouseDownBackColor = Color.White;
            cabinetActive.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            cabinetActive.FlatStyle = FlatStyle.Flat;
            cabinetActive.Location = new Point(22, 148);
            cabinetActive.Name = "cabinetActive";
            cabinetActive.Size = new Size(48, 48);
            cabinetActive.TabIndex = 34;
            cabinetActive.UseVisualStyleBackColor = false;
            // 
            // pictureBoxCabinetActive
            // 
            pictureBoxCabinetActive.BackColor = Color.LightGray;
            pictureBoxCabinetActive.Cursor = Cursors.Hand;
            pictureBoxCabinetActive.Location = new Point(12, 138);
            pictureBoxCabinetActive.Name = "pictureBoxCabinetActive";
            pictureBoxCabinetActive.Size = new Size(69, 69);
            pictureBoxCabinetActive.TabIndex = 35;
            pictureBoxCabinetActive.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Location = new Point(12, 233);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 69);
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // toContact
            // 
            toContact.BackColor = Color.Transparent;
            toContact.BackgroundImage = (Image)resources.GetObject("toContact.BackgroundImage");
            toContact.Cursor = Cursors.Hand;
            toContact.FlatAppearance.BorderColor = Color.White;
            toContact.FlatAppearance.BorderSize = 0;
            toContact.FlatAppearance.MouseDownBackColor = Color.White;
            toContact.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            toContact.FlatStyle = FlatStyle.Flat;
            toContact.Location = new Point(22, 243);
            toContact.Name = "toContact";
            toContact.Size = new Size(48, 48);
            toContact.TabIndex = 37;
            toContact.UseVisualStyleBackColor = false;
            toContact.Click += toContact_Click;
            // 
            // labelCabinetTitle
            // 
            labelCabinetTitle.AutoSize = true;
            labelCabinetTitle.BackColor = Color.LightGray;
            labelCabinetTitle.Font = new Font("Arial", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCabinetTitle.Location = new Point(146, 148);
            labelCabinetTitle.Name = "labelCabinetTitle";
            labelCabinetTitle.Size = new Size(195, 51);
            labelCabinetTitle.TabIndex = 38;
            labelCabinetTitle.Text = "Кабинет";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Location = new Point(146, 268);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1716, 697);
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // identifyUser
            // 
            identifyUser.AutoSize = true;
            identifyUser.BackColor = SystemColors.ControlLightLight;
            identifyUser.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            identifyUser.Location = new Point(197, 312);
            identifyUser.Name = "identifyUser";
            identifyUser.Size = new Size(56, 32);
            identifyUser.TabIndex = 40;
            identifyUser.Text = "id -";
            // 
            // fioUser
            // 
            fioUser.AutoSize = true;
            fioUser.BackColor = SystemColors.ControlLightLight;
            fioUser.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            fioUser.Location = new Point(259, 312);
            fioUser.Name = "fioUser";
            fioUser.Size = new Size(70, 32);
            fioUser.TabIndex = 41;
            fioUser.Text = "Фио";
            // 
            // labelProff
            // 
            labelProff.AutoSize = true;
            labelProff.BackColor = Color.LimeGreen;
            labelProff.Cursor = Cursors.IBeam;
            labelProff.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelProff.ForeColor = SystemColors.Control;
            labelProff.Location = new Point(197, 373);
            labelProff.Name = "labelProff";
            labelProff.Padding = new Padding(30, 7, 30, 7);
            labelProff.Size = new Size(121, 38);
            labelProff.TabIndex = 43;
            labelProff.Text = "Роль";
            // 
            // toRedact
            // 
            toRedact.AutoSize = true;
            toRedact.BackColor = Color.LimeGreen;
            toRedact.Cursor = Cursors.Hand;
            toRedact.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toRedact.ForeColor = SystemColors.Control;
            toRedact.Location = new Point(1374, 306);
            toRedact.Name = "toRedact";
            toRedact.Padding = new Padding(30, 7, 30, 7);
            toRedact.Size = new Size(448, 38);
            toRedact.TabIndex = 44;
            toRedact.Text = "Редактировать информацию о себе";
            toRedact.Click += toRedact_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(197, 467);
            label1.Name = "label1";
            label1.Size = new Size(136, 48);
            label1.TabIndex = 45;
            label1.Text = "Расписание\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(368, 467);
            label2.Name = "label2";
            label2.Size = new Size(189, 24);
            label2.TabIndex = 46;
            label2.Text = "С кем я в смене?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(602, 467);
            label3.Name = "label3";
            label3.Size = new Size(317, 24);
            label3.TabIndex = 47;
            label3.Text = "Запрос на смену расписания";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            comboBox1.Location = new Point(197, 553);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 23);
            comboBox1.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Location = new Point(197, 526);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 50;
            label4.Text = "Период";
            // 
            // cabinet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toRedact);
            Controls.Add(labelProff);
            Controls.Add(fioUser);
            Controls.Add(identifyUser);
            Controls.Add(pictureBox3);
            Controls.Add(labelCabinetTitle);
            Controls.Add(toContact);
            Controls.Add(pictureBox4);
            Controls.Add(cabinetActive);
            Controls.Add(pictureBoxCabinetActive);
            Controls.Add(backtomenu);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel);
            Controls.Add(pictureToCabinet);
            Controls.Add(iconimg);
            Controls.Add(closeBtnRegister);
            Controls.Add(logoiconRegister);
            Name = "cabinet";
            Text = "cabinet";
            Load += cabinet_Load;
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureToCabinet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCabinetActive).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoiconRegister;
        private Label panel;
        private PictureBox pictureToCabinet;
        private Button iconimg;
        private Button closeBtnRegister;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox backtomenu;
        private Button cabinetActive;
        private PictureBox pictureBoxCabinetActive;
        private PictureBox pictureBox4;
        private Button toContact;
        private Label labelCabinetTitle;
        private PictureBox pictureBox3;
        private Label identifyUser;
        private Label fioUser;
        private Label labelProff;
        private Label toRedact;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
    }
}