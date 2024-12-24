namespace WinFormsApp1
{
    partial class contacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contacts));
            pictureBox3 = new PictureBox();
            labelContactTitle = new Label();
            toContact = new Button();
            pictureBox4 = new PictureBox();
            cabinetActive = new Button();
            pictureBoxCabinetActive = new PictureBox();
            backtomenu = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel = new Label();
            pictureToCabinet = new PictureBox();
            iconimg = new Button();
            closeBtnRegister = new Button();
            logoiconRegister = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCabinetActive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureToCabinet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Location = new Point(147, 255);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1716, 697);
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            // 
            // labelContactTitle
            // 
            labelContactTitle.AutoSize = true;
            labelContactTitle.BackColor = Color.LightGray;
            labelContactTitle.Font = new Font("Arial", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelContactTitle.Location = new Point(147, 135);
            labelContactTitle.Name = "labelContactTitle";
            labelContactTitle.Size = new Size(223, 51);
            labelContactTitle.TabIndex = 52;
            labelContactTitle.Text = "Контакты";
            // 
            // toContact
            // 
            toContact.BackColor = Color.LightGray;
            toContact.BackgroundImage = (Image)resources.GetObject("toContact.BackgroundImage");
            toContact.Cursor = Cursors.Hand;
            toContact.FlatAppearance.BorderColor = Color.White;
            toContact.FlatAppearance.BorderSize = 0;
            toContact.FlatAppearance.MouseDownBackColor = Color.White;
            toContact.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            toContact.FlatStyle = FlatStyle.Flat;
            toContact.Location = new Point(23, 230);
            toContact.Name = "toContact";
            toContact.Size = new Size(48, 48);
            toContact.TabIndex = 51;
            toContact.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.LightGray;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Location = new Point(13, 220);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 69);
            pictureBox4.TabIndex = 50;
            pictureBox4.TabStop = false;
            // 
            // cabinetActive
            // 
            cabinetActive.BackColor = Color.Transparent;
            cabinetActive.BackgroundImage = Properties.Resources.cabinet;
            cabinetActive.Cursor = Cursors.Hand;
            cabinetActive.FlatAppearance.BorderColor = Color.White;
            cabinetActive.FlatAppearance.BorderSize = 0;
            cabinetActive.FlatAppearance.MouseDownBackColor = Color.White;
            cabinetActive.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            cabinetActive.FlatStyle = FlatStyle.Flat;
            cabinetActive.Location = new Point(23, 135);
            cabinetActive.Name = "cabinetActive";
            cabinetActive.Size = new Size(48, 48);
            cabinetActive.TabIndex = 48;
            cabinetActive.UseVisualStyleBackColor = false;
            cabinetActive.Click += cabinetActive_Click;
            // 
            // pictureBoxCabinetActive
            // 
            pictureBoxCabinetActive.BackColor = Color.Transparent;
            pictureBoxCabinetActive.Cursor = Cursors.Hand;
            pictureBoxCabinetActive.Location = new Point(13, 125);
            pictureBoxCabinetActive.Name = "pictureBoxCabinetActive";
            pictureBoxCabinetActive.Size = new Size(69, 69);
            pictureBoxCabinetActive.TabIndex = 49;
            pictureBoxCabinetActive.TabStop = false;
            pictureBoxCabinetActive.Click += pictureBoxCabinetActive_Click;
            // 
            // backtomenu
            // 
            backtomenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backtomenu.BackgroundImage = Properties.Resources.backtomenu;
            backtomenu.Cursor = Cursors.Hand;
            backtomenu.Location = new Point(13, 785);
            backtomenu.Name = "backtomenu";
            backtomenu.Size = new Size(69, 71);
            backtomenu.TabIndex = 47;
            backtomenu.TabStop = false;
            backtomenu.Click += backtomenu_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGray;
            pictureBox2.Location = new Point(98, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1807, 946);
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 946);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel.AutoSize = true;
            panel.Cursor = Cursors.Hand;
            panel.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panel.Location = new Point(1041, 39);
            panel.Name = "panel";
            panel.Size = new Size(185, 25);
            panel.TabIndex = 44;
            panel.Text = "Панель управления";
            panel.Click += panel_Click;
            // 
            // pictureToCabinet
            // 
            pictureToCabinet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureToCabinet.BackgroundImage = Properties.Resources.user__icon;
            pictureToCabinet.BackgroundImageLayout = ImageLayout.Center;
            pictureToCabinet.Location = new Point(1281, 13);
            pictureToCabinet.Name = "pictureToCabinet";
            pictureToCabinet.Size = new Size(74, 74);
            pictureToCabinet.TabIndex = 43;
            pictureToCabinet.TabStop = false;
            pictureToCabinet.Click += pictureToCabinet_Click;
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(1440, 27);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 42;
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
            closeBtnRegister.Location = new Point(1520, 21);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 41;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // logoiconRegister
            // 
            logoiconRegister.Image = Properties.Resources.SCHEDULE_mountain;
            logoiconRegister.Location = new Point(45, 27);
            logoiconRegister.Name = "logoiconRegister";
            logoiconRegister.Size = new Size(298, 37);
            logoiconRegister.TabIndex = 40;
            logoiconRegister.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(167, 494);
            label1.Name = "label1";
            label1.Size = new Size(390, 29);
            label1.TabIndex = 54;
            label1.Text = "Демаков Дмитрий Максимович";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(628, 494);
            label2.Name = "label2";
            label2.Size = new Size(341, 29);
            label2.TabIndex = 55;
            label2.Text = "Маслова Ксения Сергеевна\r\n";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(1185, 494);
            label3.Name = "label3";
            label3.Size = new Size(373, 29);
            label3.TabIndex = 56;
            label3.Text = "Мусатов Тимофей Артемович";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ButtonHighlight;
            pictureBox5.BackgroundImage = Properties.Resources.phone;
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.Location = new Point(167, 562);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 36);
            pictureBox5.TabIndex = 57;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ButtonHighlight;
            pictureBox6.BackgroundImage = Properties.Resources.mail;
            pictureBox6.BackgroundImageLayout = ImageLayout.None;
            pictureBox6.Location = new Point(167, 621);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 33);
            pictureBox6.TabIndex = 58;
            pictureBox6.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(218, 568);
            label4.Name = "label4";
            label4.Size = new Size(178, 22);
            label4.TabIndex = 59;
            label4.Text = "+7-(909)-022-77-28";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(218, 627);
            label5.Name = "label5";
            label5.Size = new Size(175, 22);
            label5.TabIndex = 60;
            label5.Text = "ddpemvr@mail.ru";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(202, 291);
            label6.Name = "label6";
            label6.Size = new Size(438, 56);
            label6.TabIndex = 61;
            label6.Text = "Администраторы\r\n";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(683, 621);
            label7.Name = "label7";
            label7.Size = new Size(205, 22);
            label7.TabIndex = 65;
            label7.Text = "barawek55@gmail.ru";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(683, 562);
            label8.Name = "label8";
            label8.Size = new Size(178, 22);
            label8.TabIndex = 64;
            label8.Text = "+7-(912)-612-42-31";
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox7.BackColor = SystemColors.ButtonHighlight;
            pictureBox7.BackgroundImage = Properties.Resources.mail;
            pictureBox7.BackgroundImageLayout = ImageLayout.None;
            pictureBox7.Location = new Point(632, 615);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(36, 33);
            pictureBox7.TabIndex = 63;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox8.BackColor = SystemColors.ButtonHighlight;
            pictureBox8.BackgroundImage = Properties.Resources.phone;
            pictureBox8.BackgroundImageLayout = ImageLayout.None;
            pictureBox8.Location = new Point(632, 556);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 36);
            pictureBox8.TabIndex = 62;
            pictureBox8.TabStop = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(1243, 615);
            label9.Name = "label9";
            label9.Size = new Size(234, 22);
            label9.TabIndex = 69;
            label9.Text = "musatowtim@yandex.ru";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(1243, 556);
            label10.Name = "label10";
            label10.Size = new Size(178, 22);
            label10.TabIndex = 68;
            label10.Text = "+7-(912)-279-17-50";
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox9.BackColor = SystemColors.ButtonHighlight;
            pictureBox9.BackgroundImage = Properties.Resources.mail;
            pictureBox9.BackgroundImageLayout = ImageLayout.None;
            pictureBox9.Location = new Point(1192, 609);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(36, 33);
            pictureBox9.TabIndex = 67;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox10.BackColor = SystemColors.ButtonHighlight;
            pictureBox10.BackgroundImage = Properties.Resources.phone;
            pictureBox10.BackgroundImageLayout = ImageLayout.None;
            pictureBox10.Location = new Point(1192, 550);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(36, 36);
            pictureBox10.TabIndex = 66;
            pictureBox10.TabStop = false;
            // 
            // contacts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1636, 904);
            ControlBox = false;
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox10);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(labelContactTitle);
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
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1650, 920);
            Name = "contacts";
            Text = "Контакты";
            WindowState = FormWindowState.Minimized;
            Load += contacts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCabinetActive).EndInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureToCabinet).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label labelContactTitle;
        private Button toContact;
        private PictureBox pictureBox4;
        private Button cabinetActive;
        private PictureBox pictureBoxCabinetActive;
        private PictureBox backtomenu;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label panel;
        private PictureBox pictureToCabinet;
        private Button iconimg;
        private Button closeBtnRegister;
        private PictureBox logoiconRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
    }
}