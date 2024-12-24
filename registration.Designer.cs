namespace WinFormsApp1
{
    partial class registration
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
            logoiconRegister = new PictureBox();
            toAuthinRegistration = new Label();
            toRegisterinRegistration = new Label();
            registerTextSupForm = new Label();
            nameTextbox = new TextBox();
            lastnameTextbox = new TextBox();
            logintextBox = new TextBox();
            passwordtextBox = new TextBox();
            repasswordtextBox3 = new TextBox();
            registerBtn = new Button();
            toAuth = new Label();
            toRegister = new Label();
            iconimg = new Button();
            closeBtnRegister = new Button();
            middleNametextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).BeginInit();
            SuspendLayout();
            // 
            // logoiconRegister
            // 
            logoiconRegister.Image = Properties.Resources.SCHEDULE_mountain;
            logoiconRegister.Location = new Point(29, 24);
            logoiconRegister.Name = "logoiconRegister";
            logoiconRegister.Size = new Size(298, 37);
            logoiconRegister.TabIndex = 1;
            logoiconRegister.TabStop = false;
            // 
            // toAuthinRegistration
            // 
            toAuthinRegistration.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toAuthinRegistration.AutoSize = true;
            toAuthinRegistration.Cursor = Cursors.Hand;
            toAuthinRegistration.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toAuthinRegistration.Location = new Point(2312, 37);
            toAuthinRegistration.Name = "toAuthinRegistration";
            toAuthinRegistration.Size = new Size(54, 23);
            toAuthinRegistration.TabIndex = 8;
            toAuthinRegistration.Text = "Войти";
            // 
            // toRegisterinRegistration
            // 
            toRegisterinRegistration.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toRegisterinRegistration.AutoSize = true;
            toRegisterinRegistration.Cursor = Cursors.Hand;
            toRegisterinRegistration.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toRegisterinRegistration.Location = new Point(2396, 36);
            toRegisterinRegistration.Name = "toRegisterinRegistration";
            toRegisterinRegistration.Size = new Size(189, 25);
            toRegisterinRegistration.TabIndex = 7;
            toRegisterinRegistration.Text = "Зарегистрироваться";
            // 
            // registerTextSupForm
            // 
            registerTextSupForm.AutoSize = true;
            registerTextSupForm.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registerTextSupForm.Location = new Point(182, 234);
            registerTextSupForm.Name = "registerTextSupForm";
            registerTextSupForm.Size = new Size(183, 32);
            registerTextSupForm.TabIndex = 9;
            registerTextSupForm.Text = "Регистрация";
            // 
            // nameTextbox
            // 
            nameTextbox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameTextbox.Location = new Point(182, 279);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.PlaceholderText = "Введите имя";
            nameTextbox.Size = new Size(269, 26);
            nameTextbox.TabIndex = 10;
            // 
            // lastnameTextbox
            // 
            lastnameTextbox.Cursor = Cursors.IBeam;
            lastnameTextbox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lastnameTextbox.Location = new Point(182, 361);
            lastnameTextbox.Name = "lastnameTextbox";
            lastnameTextbox.PlaceholderText = "Введите фамилию";
            lastnameTextbox.Size = new Size(269, 26);
            lastnameTextbox.TabIndex = 11;
            // 
            // logintextBox
            // 
            logintextBox.Cursor = Cursors.IBeam;
            logintextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logintextBox.Location = new Point(182, 406);
            logintextBox.Name = "logintextBox";
            logintextBox.PlaceholderText = "Придумайте логин";
            logintextBox.Size = new Size(269, 26);
            logintextBox.TabIndex = 12;
            // 
            // passwordtextBox
            // 
            passwordtextBox.Cursor = Cursors.IBeam;
            passwordtextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordtextBox.Location = new Point(182, 453);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.PlaceholderText = "Придумайте пароль";
            passwordtextBox.Size = new Size(269, 26);
            passwordtextBox.TabIndex = 13;
            // 
            // repasswordtextBox3
            // 
            repasswordtextBox3.Cursor = Cursors.IBeam;
            repasswordtextBox3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            repasswordtextBox3.Location = new Point(182, 497);
            repasswordtextBox3.Name = "repasswordtextBox3";
            repasswordtextBox3.PlaceholderText = "Введите пароль еще раз";
            repasswordtextBox3.Size = new Size(269, 26);
            repasswordtextBox3.TabIndex = 14;
            repasswordtextBox3.TextChanged += repasswordtextBox3_TextChanged;
            // 
            // registerBtn
            // 
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registerBtn.Location = new Point(182, 550);
            registerBtn.Name = "registerBtn";
            registerBtn.Padding = new Padding(10);
            registerBtn.Size = new Size(214, 54);
            registerBtn.TabIndex = 15;
            registerBtn.Text = "Зарегистрироваться";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // toAuth
            // 
            toAuth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toAuth.AutoSize = true;
            toAuth.Cursor = Cursors.Hand;
            toAuth.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toAuth.Location = new Point(721, 31);
            toAuth.Name = "toAuth";
            toAuth.Size = new Size(54, 23);
            toAuth.TabIndex = 21;
            toAuth.Text = "Войти";
            toAuth.Click += toAuth_Click;
            // 
            // toRegister
            // 
            toRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toRegister.AutoSize = true;
            toRegister.Cursor = Cursors.Hand;
            toRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toRegister.Location = new Point(805, 30);
            toRegister.Name = "toRegister";
            toRegister.Size = new Size(189, 25);
            toRegister.TabIndex = 20;
            toRegister.Text = "Зарегистрироваться";
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(1017, 18);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 19;
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
            closeBtnRegister.Location = new Point(1097, 12);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 18;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click_1;
            // 
            // middleNametextBox
            // 
            middleNametextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            middleNametextBox.Location = new Point(182, 320);
            middleNametextBox.Name = "middleNametextBox";
            middleNametextBox.PlaceholderText = "Введите отчество";
            middleNametextBox.Size = new Size(269, 26);
            middleNametextBox.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(502, 343);
            label1.Name = "label1";
            label1.Size = new Size(577, 136);
            label1.TabIndex = 23;
            label1.Text = "SCHEDULE mountain - сервис для\r\nпросмотра и составления расписания \r\nсотрудников производства компании \r\nmountain... \r\n";
            // 
            // registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 681);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(middleNametextBox);
            Controls.Add(toAuth);
            Controls.Add(toRegister);
            Controls.Add(iconimg);
            Controls.Add(closeBtnRegister);
            Controls.Add(registerBtn);
            Controls.Add(repasswordtextBox3);
            Controls.Add(passwordtextBox);
            Controls.Add(logintextBox);
            Controls.Add(lastnameTextbox);
            Controls.Add(nameTextbox);
            Controls.Add(registerTextSupForm);
            Controls.Add(toAuthinRegistration);
            Controls.Add(toRegisterinRegistration);
            Controls.Add(logoiconRegister);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1200, 720);
            Name = "registration";
            Text = "Регистрация";
            Load += registration_Load;
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoiconRegister;
        private Label toAuthinRegistration;
        private Label toRegisterinRegistration;
        private Label registerTextSupForm;
        private TextBox nameTextbox;
        private TextBox lastnameTextbox;
        private TextBox logintextBox;
        private TextBox passwordtextBox;
        private TextBox repasswordtextBox3;
        private Button registerBtn;
        private PictureBox pictureInBodyRegister;
        private Label toAuth;
        private Label toRegister;
        private Button iconimg;
        private Button closeBtnRegister;
        private TextBox middleNametextBox;
        private Label label1;
    }
}