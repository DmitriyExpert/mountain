namespace WinFormsApp1
{
    partial class index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logoicon = new PictureBox();
            closeBtn = new Button();
            iconimg = new Button();
            toRegister = new Label();
            toAuth = new Label();
            indexText = new Label();
            ((System.ComponentModel.ISupportInitialize)logoicon).BeginInit();
            SuspendLayout();
            // 
            // logoicon
            // 
            logoicon.Image = Properties.Resources.SCHEDULE_mountain;
            logoicon.Location = new Point(42, 12);
            logoicon.Name = "logoicon";
            logoicon.Size = new Size(298, 37);
            logoicon.TabIndex = 0;
            logoicon.TabStop = false;
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
            closeBtn.Location = new Point(1789, 12);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 66);
            closeBtn.TabIndex = 1;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(1709, 18);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 2;
            iconimg.UseVisualStyleBackColor = true;
            iconimg.Click += iconimg_Click;
            // 
            // toRegister
            // 
            toRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toRegister.AutoSize = true;
            toRegister.Cursor = Cursors.Hand;
            toRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toRegister.Location = new Point(1497, 30);
            toRegister.Name = "toRegister";
            toRegister.Size = new Size(189, 25);
            toRegister.TabIndex = 3;
            toRegister.Text = "Зарегистрироваться";
            toRegister.Click += toRegister_Click;
            // 
            // toAuth
            // 
            toAuth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toAuth.AutoSize = true;
            toAuth.Cursor = Cursors.Hand;
            toAuth.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toAuth.Location = new Point(1413, 31);
            toAuth.Name = "toAuth";
            toAuth.Size = new Size(54, 23);
            toAuth.TabIndex = 4;
            toAuth.Text = "Войти";
            toAuth.Click += toAuth_Click;
            // 
            // indexText
            // 
            indexText.AutoSize = true;
            indexText.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            indexText.ForeColor = Color.Red;
            indexText.Location = new Point(42, 192);
            indexText.Name = "indexText";
            indexText.Size = new Size(530, 57);
            indexText.TabIndex = 5;
            indexText.Text = "Необходима авторизация";
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 1041);
            ControlBox = false;
            Controls.Add(indexText);
            Controls.Add(toAuth);
            Controls.Add(toRegister);
            Controls.Add(iconimg);
            Controls.Add(closeBtn);
            Controls.Add(logoicon);
            Name = "index";
            Text = "not auth";
            Load += index_Load;
            ((System.ComponentModel.ISupportInitialize)logoicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoicon;
        private Button closeBtn;
        private Button iconimg;
        private Label toRegister;
        private Label toAuth;
        private Label indexText;
    }
}
