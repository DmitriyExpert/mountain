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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCabinetActive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureToCabinet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).BeginInit();
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
            backtomenu.BackgroundImage = Properties.Resources.backtomenu;
            backtomenu.Cursor = Cursors.Hand;
            backtomenu.Location = new Point(13, 945);
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
            panel.Location = new Point(1309, 39);
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
            pictureToCabinet.Location = new Point(1549, 13);
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
            iconimg.Location = new Point(1708, 27);
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
            closeBtnRegister.Location = new Point(1788, 21);
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
            // contacts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            ControlBox = false;
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
            Name = "contacts";
            Text = "contacts";
            Load += contacts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCabinetActive).EndInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureToCabinet).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).EndInit();
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
    }
}