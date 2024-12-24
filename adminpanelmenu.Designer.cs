namespace WinFormsApp1
{
    partial class adminpanelmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpanelmenu));
            iconimg = new Button();
            closeBtnRegister = new Button();
            AdminPanelLogo = new PictureBox();
            toClient = new Label();
            toRedacUsers = new Label();
            toRedacRoles = new Label();
            logoiconRegister = new PictureBox();
            linktoredacRolesMain = new Label();
            label1 = new Label();
            toRedacSchedule = new Label();
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).BeginInit();
            SuspendLayout();
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(1081, 32);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 49;
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
            closeBtnRegister.Location = new Point(1161, 26);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 48;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // AdminPanelLogo
            // 
            AdminPanelLogo.Image = (Image)resources.GetObject("AdminPanelLogo.Image");
            AdminPanelLogo.Location = new Point(449, 32);
            AdminPanelLogo.Name = "AdminPanelLogo";
            AdminPanelLogo.Size = new Size(298, 37);
            AdminPanelLogo.TabIndex = 50;
            AdminPanelLogo.TabStop = false;
            // 
            // toClient
            // 
            toClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toClient.AutoSize = true;
            toClient.Cursor = Cursors.Hand;
            toClient.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toClient.Location = new Point(790, 41);
            toClient.Name = "toClient";
            toClient.Size = new Size(222, 29);
            toClient.TabIndex = 51;
            toClient.Text = "Клиентская часть";
            toClient.Click += toClient_Click;
            // 
            // toRedacUsers
            // 
            toRedacUsers.AutoSize = true;
            toRedacUsers.Cursor = Cursors.Hand;
            toRedacUsers.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toRedacUsers.ForeColor = SystemColors.MenuHighlight;
            toRedacUsers.Location = new Point(43, 123);
            toRedacUsers.Name = "toRedacUsers";
            toRedacUsers.Size = new Size(243, 19);
            toRedacUsers.TabIndex = 52;
            toRedacUsers.Text = "Управление пользователями";
            toRedacUsers.Click += toRedacUsers_Click;
            // 
            // toRedacRoles
            // 
            toRedacRoles.AutoSize = true;
            toRedacRoles.Cursor = Cursors.Hand;
            toRedacRoles.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toRedacRoles.ForeColor = SystemColors.MenuHighlight;
            toRedacRoles.Location = new Point(330, 123);
            toRedacRoles.Name = "toRedacRoles";
            toRedacRoles.Size = new Size(215, 19);
            toRedacRoles.TabIndex = 53;
            toRedacRoles.Text = "Управление автосменами";
            toRedacRoles.Click += toRedacRoles_Click;
            // 
            // logoiconRegister
            // 
            logoiconRegister.Image = Properties.Resources.SCHEDULE_mountain;
            logoiconRegister.Location = new Point(43, 32);
            logoiconRegister.Name = "logoiconRegister";
            logoiconRegister.Size = new Size(298, 37);
            logoiconRegister.TabIndex = 54;
            logoiconRegister.TabStop = false;
            // 
            // linktoredacRolesMain
            // 
            linktoredacRolesMain.AutoSize = true;
            linktoredacRolesMain.Cursor = Cursors.Hand;
            linktoredacRolesMain.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            linktoredacRolesMain.ForeColor = SystemColors.MenuHighlight;
            linktoredacRolesMain.Location = new Point(594, 123);
            linktoredacRolesMain.Name = "linktoredacRolesMain";
            linktoredacRolesMain.Size = new Size(169, 19);
            linktoredacRolesMain.TabIndex = 55;
            linktoredacRolesMain.Text = "Управление ролями";
            linktoredacRolesMain.Click += linktoredacRolesMain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(819, 123);
            label1.Name = "label1";
            label1.Size = new Size(255, 19);
            label1.TabIndex = 56;
            label1.Text = "Запросы на смену расписания";
            label1.Click += label1_Click;
            // 
            // toRedacSchedule
            // 
            toRedacSchedule.AutoSize = true;
            toRedacSchedule.Cursor = Cursors.Hand;
            toRedacSchedule.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toRedacSchedule.ForeColor = SystemColors.MenuHighlight;
            toRedacSchedule.Location = new Point(43, 190);
            toRedacSchedule.Name = "toRedacSchedule";
            toRedacSchedule.Size = new Size(215, 19);
            toRedacSchedule.TabIndex = 57;
            toRedacSchedule.Text = "Управление расписанием";
            toRedacSchedule.Click += toRedacSchedule_Click;
            // 
            // adminpanelmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1279, 661);
            ControlBox = false;
            Controls.Add(toRedacSchedule);
            Controls.Add(label1);
            Controls.Add(linktoredacRolesMain);
            Controls.Add(logoiconRegister);
            Controls.Add(toRedacRoles);
            Controls.Add(toRedacUsers);
            Controls.Add(toClient);
            Controls.Add(AdminPanelLogo);
            Controls.Add(iconimg);
            Controls.Add(closeBtnRegister);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1295, 700);
            Name = "adminpanelmenu";
            Text = "Админ панель";
            Load += adminpanelmenu_Load;
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button iconimg;
        private Button closeBtnRegister;
        private PictureBox AdminPanelLogo;
        private Label toClient;
        private Label toRedacUsers;
        private Label toRedacRoles;
        private PictureBox logoiconRegister;
        private Label linktoredacRolesMain;
        private Label label1;
        private Label toRedacSchedule;
    }
}