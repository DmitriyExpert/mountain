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
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // toClient
            // 
            toClient.AutoSize = true;
            toClient.Cursor = Cursors.Hand;
            toClient.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toClient.Location = new Point(1409, 35);
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
            iconimg.Location = new Point(1700, 26);
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
            closeBtnRegister.Location = new Point(1780, 20);
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
            // 
            // roleSearchField
            // 
            roleSearchField.FormattingEnabled = true;
            roleSearchField.Location = new Point(37, 297);
            roleSearchField.Name = "roleSearchField";
            roleSearchField.Size = new Size(284, 23);
            roleSearchField.TabIndex = 66;
            // 
            // redacUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 1041);
            ControlBox = false;
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
            Name = "redacUsers";
            Text = "redacUsers";
            Load += redacUsers_Load;
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
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
    }
}