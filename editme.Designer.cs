namespace WinFormsApp1
{
    partial class editme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editme));
            labelProff = new Label();
            fioUser = new Label();
            identifyUser = new Label();
            pictureBox3 = new PictureBox();
            labelCabinetTitle = new Label();
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
            lastNameEditField = new TextBox();
            firstNameEditField = new TextBox();
            middleNameEditField = new TextBox();
            passwordEditField = new TextBox();
            repassEditField = new TextBox();
            labelSubTitle = new Label();
            labelSub = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            // labelProff
            // 
            labelProff.AutoSize = true;
            labelProff.BackColor = Color.LimeGreen;
            labelProff.Cursor = Cursors.IBeam;
            labelProff.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelProff.ForeColor = SystemColors.Control;
            labelProff.Location = new Point(198, 360);
            labelProff.Name = "labelProff";
            labelProff.Padding = new Padding(30, 7, 30, 7);
            labelProff.Size = new Size(121, 38);
            labelProff.TabIndex = 60;
            labelProff.Text = "Роль";
            // 
            // fioUser
            // 
            fioUser.AutoSize = true;
            fioUser.BackColor = SystemColors.ControlLightLight;
            fioUser.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            fioUser.Location = new Point(260, 299);
            fioUser.Name = "fioUser";
            fioUser.Size = new Size(70, 32);
            fioUser.TabIndex = 59;
            fioUser.Text = "Фио";
            // 
            // identifyUser
            // 
            identifyUser.AutoSize = true;
            identifyUser.BackColor = SystemColors.ControlLightLight;
            identifyUser.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            identifyUser.Location = new Point(198, 299);
            identifyUser.Name = "identifyUser";
            identifyUser.Size = new Size(56, 32);
            identifyUser.TabIndex = 58;
            identifyUser.Text = "id -";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Location = new Point(147, 265);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1695, 697);
            pictureBox3.TabIndex = 57;
            pictureBox3.TabStop = false;
            // 
            // labelCabinetTitle
            // 
            labelCabinetTitle.AutoSize = true;
            labelCabinetTitle.BackColor = Color.LightGray;
            labelCabinetTitle.Font = new Font("Arial", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCabinetTitle.Location = new Point(147, 135);
            labelCabinetTitle.Name = "labelCabinetTitle";
            labelCabinetTitle.Size = new Size(195, 51);
            labelCabinetTitle.TabIndex = 56;
            labelCabinetTitle.Text = "Кабинет";
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
            toContact.Location = new Point(23, 230);
            toContact.Name = "toContact";
            toContact.Size = new Size(48, 48);
            toContact.TabIndex = 55;
            toContact.UseVisualStyleBackColor = false;
            toContact.Click += toContact_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Location = new Point(13, 220);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 69);
            pictureBox4.TabIndex = 54;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
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
            cabinetActive.Location = new Point(23, 135);
            cabinetActive.Name = "cabinetActive";
            cabinetActive.Size = new Size(48, 48);
            cabinetActive.TabIndex = 52;
            cabinetActive.UseVisualStyleBackColor = false;
            // 
            // pictureBoxCabinetActive
            // 
            pictureBoxCabinetActive.BackColor = Color.LightGray;
            pictureBoxCabinetActive.Cursor = Cursors.Hand;
            pictureBoxCabinetActive.Location = new Point(13, 125);
            pictureBoxCabinetActive.Name = "pictureBoxCabinetActive";
            pictureBoxCabinetActive.Size = new Size(69, 69);
            pictureBoxCabinetActive.TabIndex = 53;
            pictureBoxCabinetActive.TabStop = false;
            // 
            // backtomenu
            // 
            backtomenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backtomenu.BackgroundImage = Properties.Resources.backtomenu;
            backtomenu.Cursor = Cursors.Hand;
            backtomenu.Location = new Point(13, 850);
            backtomenu.Name = "backtomenu";
            backtomenu.Size = new Size(69, 71);
            backtomenu.TabIndex = 51;
            backtomenu.TabStop = false;
            backtomenu.Click += backtomenu_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGray;
            pictureBox2.Location = new Point(98, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1807, 923);
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 943);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel.AutoSize = true;
            panel.Cursor = Cursors.Hand;
            panel.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panel.Location = new Point(379, 39);
            panel.Name = "panel";
            panel.Size = new Size(185, 25);
            panel.TabIndex = 48;
            panel.Text = "Панель управления";
            panel.Click += panel_Click;
            // 
            // pictureToCabinet
            // 
            pictureToCabinet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureToCabinet.BackgroundImage = Properties.Resources.user__icon;
            pictureToCabinet.BackgroundImageLayout = ImageLayout.Center;
            pictureToCabinet.Location = new Point(619, 13);
            pictureToCabinet.Name = "pictureToCabinet";
            pictureToCabinet.Size = new Size(74, 74);
            pictureToCabinet.TabIndex = 47;
            pictureToCabinet.TabStop = false;
            pictureToCabinet.Click += pictureToCabinet_Click;
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(778, 27);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 46;
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
            closeBtnRegister.Location = new Point(858, 21);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 45;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // logoiconRegister
            // 
            logoiconRegister.Image = Properties.Resources.SCHEDULE_mountain;
            logoiconRegister.Location = new Point(45, 27);
            logoiconRegister.Name = "logoiconRegister";
            logoiconRegister.Size = new Size(298, 37);
            logoiconRegister.TabIndex = 44;
            logoiconRegister.TabStop = false;
            // 
            // lastNameEditField
            // 
            lastNameEditField.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lastNameEditField.Location = new Point(198, 486);
            lastNameEditField.Name = "lastNameEditField";
            lastNameEditField.Size = new Size(246, 29);
            lastNameEditField.TabIndex = 61;
            // 
            // firstNameEditField
            // 
            firstNameEditField.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            firstNameEditField.Location = new Point(198, 568);
            firstNameEditField.Name = "firstNameEditField";
            firstNameEditField.Size = new Size(246, 29);
            firstNameEditField.TabIndex = 62;
            // 
            // middleNameEditField
            // 
            middleNameEditField.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            middleNameEditField.Location = new Point(198, 653);
            middleNameEditField.Name = "middleNameEditField";
            middleNameEditField.Size = new Size(246, 29);
            middleNameEditField.TabIndex = 63;
            // 
            // passwordEditField
            // 
            passwordEditField.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordEditField.Location = new Point(198, 738);
            passwordEditField.Name = "passwordEditField";
            passwordEditField.Size = new Size(246, 29);
            passwordEditField.TabIndex = 64;
            // 
            // repassEditField
            // 
            repassEditField.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            repassEditField.Location = new Point(198, 822);
            repassEditField.Name = "repassEditField";
            repassEditField.Size = new Size(246, 29);
            repassEditField.TabIndex = 65;
            // 
            // labelSubTitle
            // 
            labelSubTitle.AutoSize = true;
            labelSubTitle.BackColor = SystemColors.ControlLightLight;
            labelSubTitle.Location = new Point(198, 468);
            labelSubTitle.Name = "labelSubTitle";
            labelSubTitle.Size = new Size(0, 15);
            labelSubTitle.TabIndex = 66;
            // 
            // labelSub
            // 
            labelSub.AutoSize = true;
            labelSub.BackColor = SystemColors.ControlLightLight;
            labelSub.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSub.Location = new Point(198, 453);
            labelSub.Name = "labelSub";
            labelSub.Size = new Size(171, 20);
            labelSub.TabIndex = 67;
            labelSub.Text = "Введите новую фамилию";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(198, 536);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 68;
            label1.Text = "Введите новое имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(198, 621);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 69;
            label2.Text = "Введите новое отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(198, 705);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 70;
            label3.Text = "Введите новый пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(198, 789);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 71;
            label4.Text = "Введите пароль еще раз";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LimeGreen;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(198, 879);
            label5.Name = "label5";
            label5.Padding = new Padding(30, 7, 30, 7);
            label5.Size = new Size(182, 38);
            label5.TabIndex = 72;
            label5.Text = "Сохранить";
            label5.Click += label5_Click;
            // 
            // editme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 926);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelSub);
            Controls.Add(labelSubTitle);
            Controls.Add(repassEditField);
            Controls.Add(passwordEditField);
            Controls.Add(middleNameEditField);
            Controls.Add(firstNameEditField);
            Controls.Add(lastNameEditField);
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
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(990, 965);
            Name = "editme";
            Text = "Редактирование данных";
            Load += editme_Load;
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

        private Label labelProff;
        private Label fioUser;
        private Label identifyUser;
        private PictureBox pictureBox3;
        private Label labelCabinetTitle;
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
        private TextBox lastNameEditField;
        private TextBox firstNameEditField;
        private TextBox middleNameEditField;
        private TextBox passwordEditField;
        private TextBox repassEditField;
        private Label labelSubTitle;
        private Label labelSub;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}