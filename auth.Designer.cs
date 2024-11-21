namespace WinFormsApp1
{
    partial class auth
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
            logoicon = new PictureBox();
            toAuth = new Label();
            toRegister = new Label();
            iconimg = new Button();
            closeBtn = new Button();
            registerTextSupForm = new Label();
            loginBtn = new Button();
            bodyRegisterTextBox = new RichTextBox();
            passwordtextBox = new TextBox();
            logintextBox = new TextBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)logoicon).BeginInit();
            SuspendLayout();
            // 
            // logoicon
            // 
            logoicon.Image = Properties.Resources.SCHEDULE_mountain;
            logoicon.Location = new Point(27, 24);
            logoicon.Name = "logoicon";
            logoicon.Size = new Size(298, 37);
            logoicon.TabIndex = 1;
            logoicon.TabStop = false;
            // 
            // toAuth
            // 
            toAuth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toAuth.AutoSize = true;
            toAuth.Cursor = Cursors.Hand;
            toAuth.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toAuth.Location = new Point(1429, 42);
            toAuth.Name = "toAuth";
            toAuth.Size = new Size(54, 23);
            toAuth.TabIndex = 8;
            toAuth.Text = "Войти";
            toAuth.Click += toAuth_Click;
            // 
            // toRegister
            // 
            toRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toRegister.AutoSize = true;
            toRegister.Cursor = Cursors.Hand;
            toRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toRegister.Location = new Point(1508, 42);
            toRegister.Name = "toRegister";
            toRegister.Size = new Size(189, 25);
            toRegister.TabIndex = 7;
            toRegister.Text = "Зарегистрироваться";
            toRegister.Click += toRegister_Click;
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(1720, 30);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 6;
            iconimg.UseVisualStyleBackColor = true;
            iconimg.Click += iconimg_Click;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.FlatAppearance.BorderColor = Color.White;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatAppearance.MouseDownBackColor = Color.White;
            closeBtn.FlatAppearance.MouseOverBackColor = Color.White;
            closeBtn.FlatStyle = FlatStyle.Popup;
            closeBtn.ForeColor = SystemColors.ButtonHighlight;
            closeBtn.Image = Properties.Resources.close;
            closeBtn.Location = new Point(1800, 24);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 66);
            closeBtn.TabIndex = 5;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // registerTextSupForm
            // 
            registerTextSupForm.AutoSize = true;
            registerTextSupForm.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registerTextSupForm.Location = new Point(230, 290);
            registerTextSupForm.Name = "registerTextSupForm";
            registerTextSupForm.Size = new Size(97, 32);
            registerTextSupForm.TabIndex = 12;
            registerTextSupForm.Text = "Войти";
            registerTextSupForm.Click += registerTextSupForm_Click;
            // 
            // loginBtn
            // 
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginBtn.Location = new Point(230, 456);
            loginBtn.Name = "loginBtn";
            loginBtn.Padding = new Padding(10);
            loginBtn.Size = new Size(214, 54);
            loginBtn.TabIndex = 16;
            loginBtn.Text = "Войти";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // bodyRegisterTextBox
            // 
            bodyRegisterTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            bodyRegisterTextBox.BackColor = Color.White;
            bodyRegisterTextBox.BorderStyle = BorderStyle.None;
            bodyRegisterTextBox.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bodyRegisterTextBox.Location = new Point(989, 343);
            bodyRegisterTextBox.Name = "bodyRegisterTextBox";
            bodyRegisterTextBox.ReadOnly = true;
            bodyRegisterTextBox.Size = new Size(645, 220);
            bodyRegisterTextBox.TabIndex = 18;
            bodyRegisterTextBox.Text = "SCHEDULE mountain - сервис для просмотра и составления расписания сотрудников производства компании mountain... ";
            // 
            // passwordtextBox
            // 
            passwordtextBox.Cursor = Cursors.IBeam;
            passwordtextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordtextBox.Location = new Point(230, 390);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.PlaceholderText = "Пароль";
            passwordtextBox.Size = new Size(269, 26);
            passwordtextBox.TabIndex = 20;
            passwordtextBox.TextChanged += passwordtextBox_TextChanged;
            // 
            // logintextBox
            // 
            logintextBox.Cursor = Cursors.IBeam;
            logintextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logintextBox.Location = new Point(230, 343);
            logintextBox.Name = "logintextBox";
            logintextBox.PlaceholderText = "Логин";
            logintextBox.Size = new Size(269, 26);
            logintextBox.TabIndex = 19;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(230, 422);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 20);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // auth
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1904, 1041);
            ControlBox = false;
            Controls.Add(checkBox1);
            Controls.Add(passwordtextBox);
            Controls.Add(logintextBox);
            Controls.Add(bodyRegisterTextBox);
            Controls.Add(loginBtn);
            Controls.Add(registerTextSupForm);
            Controls.Add(toAuth);
            Controls.Add(toRegister);
            Controls.Add(iconimg);
            Controls.Add(closeBtn);
            Controls.Add(logoicon);
            Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "auth";
            Text = "auth";
            Load += auth_Load;
            ((System.ComponentModel.ISupportInitialize)logoicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoicon;
        private Label toAuth;
        private Label toRegister;
        private Button iconimg;
        private Button closeBtn;
        private Label registerTextSupForm;
        private Button loginBtn;
        private RichTextBox bodyRegisterTextBox;
        private TextBox passwordtextBox;
        private TextBox logintextBox;
        private CheckBox checkBox1;
    }
}