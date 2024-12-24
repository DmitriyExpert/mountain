namespace WinFormsApp1
{
    partial class redacUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(redacUsers));
            toClient = new Label();
            AdminPanelLogo = new PictureBox();
            iconimg = new Button();
            closeBtnRegister = new Button();
            logoiconRegister = new PictureBox();
            dataGridViewUsers = new DataGridView();
            label1 = new Label();
            buttonIdSearch = new Button();
            idSearchField = new TextBox();
            label2 = new Label();
            label3 = new Label();
            buttonRoleSearch = new Button();
            roleSearchField = new ComboBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            idForRedacUser = new Label();
            idishnik = new Label();
            changedRoles = new Button();
            deleteUser = new Button();
            passAdmText = new TextBox();
            label5 = new Label();
            rolesComboBox = new ComboBox();
            buttonChangeRoles = new Button();
            backtomenu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).BeginInit();
            SuspendLayout();
            // 
            // toClient
            // 
            toClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toClient.AutoSize = true;
            toClient.Cursor = Cursors.Hand;
            toClient.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toClient.Location = new Point(789, 35);
            toClient.Name = "toClient";
            toClient.Size = new Size(222, 29);
            toClient.TabIndex = 56;
            toClient.Text = "Клиентская часть";
            toClient.Click += toClient_Click;
            // 
            // AdminPanelLogo
            // 
            AdminPanelLogo.Image = (Image)resources.GetObject("AdminPanelLogo.Image");
            AdminPanelLogo.Location = new Point(443, 26);
            AdminPanelLogo.Name = "AdminPanelLogo";
            AdminPanelLogo.Size = new Size(298, 37);
            AdminPanelLogo.TabIndex = 55;
            AdminPanelLogo.TabStop = false;
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(1080, 26);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 54;
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
            closeBtnRegister.Location = new Point(1160, 20);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 53;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // logoiconRegister
            // 
            logoiconRegister.Image = Properties.Resources.SCHEDULE_mountain;
            logoiconRegister.Location = new Point(37, 26);
            logoiconRegister.Name = "logoiconRegister";
            logoiconRegister.Size = new Size(298, 37);
            logoiconRegister.TabIndex = 52;
            logoiconRegister.TabStop = false;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(37, 426);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(531, 349);
            dataGridViewUsers.TabIndex = 57;
            dataGridViewUsers.CellContentClick += dataGridViewUsers_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(37, 162);
            label1.Name = "label1";
            label1.Size = new Size(284, 44);
            label1.TabIndex = 58;
            label1.Text = "Пользователи";
            // 
            // buttonIdSearch
            // 
            buttonIdSearch.Cursor = Cursors.Hand;
            buttonIdSearch.Location = new Point(352, 243);
            buttonIdSearch.Name = "buttonIdSearch";
            buttonIdSearch.Size = new Size(75, 23);
            buttonIdSearch.TabIndex = 60;
            buttonIdSearch.Text = "Поиск";
            buttonIdSearch.UseVisualStyleBackColor = true;
            buttonIdSearch.Click += buttonIdSearch_Click_1;
            // 
            // idSearchField
            // 
            idSearchField.Location = new Point(37, 243);
            idSearchField.Name = "idSearchField";
            idSearchField.Size = new Size(284, 23);
            idSearchField.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 225);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 62;
            label2.Text = "Поиск по id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 278);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 63;
            label3.Text = "Поиск по роли";
            // 
            // buttonRoleSearch
            // 
            buttonRoleSearch.Cursor = Cursors.Hand;
            buttonRoleSearch.Location = new Point(352, 296);
            buttonRoleSearch.Name = "buttonRoleSearch";
            buttonRoleSearch.Size = new Size(75, 23);
            buttonRoleSearch.TabIndex = 65;
            buttonRoleSearch.Text = "Поиск";
            buttonRoleSearch.UseVisualStyleBackColor = true;
            buttonRoleSearch.Click += buttonRoleSearch_Click;
            // 
            // roleSearchField
            // 
            roleSearchField.FormattingEnabled = true;
            roleSearchField.Location = new Point(37, 297);
            roleSearchField.Name = "roleSearchField";
            roleSearchField.Size = new Size(284, 23);
            roleSearchField.TabIndex = 66;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ScrollBar;
            pictureBox1.Location = new Point(646, 243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(496, 50);
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ScrollBar;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(658, 255);
            label4.Name = "label4";
            label4.Size = new Size(380, 29);
            label4.TabIndex = 68;
            label4.Text = "Действия с пользователем id: ";
            // 
            // idForRedacUser
            // 
            idForRedacUser.AutoSize = true;
            idForRedacUser.BackColor = SystemColors.ScrollBar;
            idForRedacUser.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            idForRedacUser.Location = new Point(1459, 255);
            idForRedacUser.Name = "idForRedacUser";
            idForRedacUser.Size = new Size(0, 29);
            idForRedacUser.TabIndex = 69;
            // 
            // idishnik
            // 
            idishnik.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            idishnik.AutoSize = true;
            idishnik.BackColor = SystemColors.ScrollBar;
            idishnik.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            idishnik.Location = new Point(1038, 255);
            idishnik.Name = "idishnik";
            idishnik.Size = new Size(35, 29);
            idishnik.TabIndex = 70;
            idishnik.Text = "id";
            idishnik.Visible = false;
            // 
            // changedRoles
            // 
            changedRoles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            changedRoles.Cursor = Cursors.Hand;
            changedRoles.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            changedRoles.Location = new Point(646, 351);
            changedRoles.Name = "changedRoles";
            changedRoles.Size = new Size(174, 47);
            changedRoles.TabIndex = 71;
            changedRoles.Text = "Сменить роль";
            changedRoles.UseVisualStyleBackColor = true;
            changedRoles.Visible = false;
            changedRoles.Click += changedRoles_Click;
            // 
            // deleteUser
            // 
            deleteUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteUser.Cursor = Cursors.Hand;
            deleteUser.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteUser.ForeColor = Color.Red;
            deleteUser.Location = new Point(899, 351);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(218, 47);
            deleteUser.TabIndex = 72;
            deleteUser.Text = "Удалить пользователя";
            deleteUser.UseVisualStyleBackColor = true;
            deleteUser.Visible = false;
            deleteUser.Click += deleteUser_Click;
            // 
            // passAdmText
            // 
            passAdmText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            passAdmText.Location = new Point(646, 462);
            passAdmText.Name = "passAdmText";
            passAdmText.Size = new Size(224, 23);
            passAdmText.TabIndex = 73;
            passAdmText.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(646, 444);
            label5.Name = "label5";
            label5.Size = new Size(187, 15);
            label5.TabIndex = 74;
            label5.Text = "Введите пароль администратора";
            label5.Visible = false;
            // 
            // rolesComboBox
            // 
            rolesComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rolesComboBox.FormattingEnabled = true;
            rolesComboBox.Location = new Point(646, 555);
            rolesComboBox.Name = "rolesComboBox";
            rolesComboBox.Size = new Size(357, 23);
            rolesComboBox.TabIndex = 75;
            rolesComboBox.Visible = false;
            rolesComboBox.SelectedIndexChanged += rolesComboBox_SelectedIndexChanged;
            // 
            // buttonChangeRoles
            // 
            buttonChangeRoles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonChangeRoles.Cursor = Cursors.Hand;
            buttonChangeRoles.Location = new Point(1051, 555);
            buttonChangeRoles.Name = "buttonChangeRoles";
            buttonChangeRoles.Size = new Size(75, 23);
            buttonChangeRoles.TabIndex = 76;
            buttonChangeRoles.Text = "Сменить";
            buttonChangeRoles.UseVisualStyleBackColor = true;
            buttonChangeRoles.Visible = false;
            buttonChangeRoles.Click += buttonChangeRoles_Click;
            // 
            // backtomenu
            // 
            backtomenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backtomenu.BackgroundImage = Properties.Resources.backtomenu;
            backtomenu.Cursor = Cursors.Hand;
            backtomenu.Location = new Point(37, 797);
            backtomenu.Name = "backtomenu";
            backtomenu.Size = new Size(69, 71);
            backtomenu.TabIndex = 77;
            backtomenu.TabStop = false;
            backtomenu.Click += backtomenu_Click;
            // 
            // redacUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1284, 901);
            ControlBox = false;
            Controls.Add(backtomenu);
            Controls.Add(buttonChangeRoles);
            Controls.Add(rolesComboBox);
            Controls.Add(label5);
            Controls.Add(passAdmText);
            Controls.Add(deleteUser);
            Controls.Add(changedRoles);
            Controls.Add(idishnik);
            Controls.Add(idForRedacUser);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(roleSearchField);
            Controls.Add(buttonRoleSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(idSearchField);
            Controls.Add(buttonIdSearch);
            Controls.Add(label1);
            Controls.Add(dataGridViewUsers);
            Controls.Add(toClient);
            Controls.Add(AdminPanelLogo);
            Controls.Add(iconimg);
            Controls.Add(closeBtnRegister);
            Controls.Add(logoiconRegister);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1300, 940);
            Name = "redacUsers";
            Text = "Редактирование пользователей";
            Load += redacUsers_Load;
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label toClient;
        private PictureBox AdminPanelLogo;
        private Button iconimg;
        private Button closeBtnRegister;
        private PictureBox logoiconRegister;
        private DataGridView dataGridViewUsers;
        private Label label1;
        private Button buttonIdSearch;
        private TextBox idSearchField;
        private Label label2;
        private Label label3;
        private Button buttonRoleSearch;
        private ComboBox roleSearchField;
        private PictureBox pictureBox1;
        private Label label4;
        private Label idForRedacUser;
        private Label idishnik;
        private Button changedRoles;
        private Button deleteUser;
        private TextBox passAdmText;
        private Label label5;
        private ComboBox rolesComboBox;
        private Button buttonChangeRoles;
        private PictureBox backtomenu;
    }
}