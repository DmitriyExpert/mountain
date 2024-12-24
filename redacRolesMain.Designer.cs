namespace WinFormsApp1
{
    partial class redacRolesMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(redacRolesMain));
            logoiconRegister = new PictureBox();
            toClient = new Label();
            AdminPanelLogo = new PictureBox();
            iconimg = new Button();
            closeBtnRegister = new Button();
            label1 = new Label();
            fieldForNameNewRole = new TextBox();
            label2 = new Label();
            addRoleToDataBase = new Button();
            switcherCanEditShedule = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxForDeleteRoles = new ComboBox();
            label5 = new Label();
            buttonForDeleteRoles = new Button();
            label6 = new Label();
            backtomenu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).BeginInit();
            SuspendLayout();
            // 
            // logoiconRegister
            // 
            logoiconRegister.Image = Properties.Resources.SCHEDULE_mountain;
            logoiconRegister.Location = new Point(31, 34);
            logoiconRegister.Name = "logoiconRegister";
            logoiconRegister.Size = new Size(298, 37);
            logoiconRegister.TabIndex = 59;
            logoiconRegister.TabStop = false;
            // 
            // toClient
            // 
            toClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toClient.AutoSize = true;
            toClient.Cursor = Cursors.Hand;
            toClient.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toClient.Location = new Point(763, 43);
            toClient.Name = "toClient";
            toClient.Size = new Size(222, 29);
            toClient.TabIndex = 58;
            toClient.Text = "Клиентская часть";
            toClient.Click += toClient_Click;
            // 
            // AdminPanelLogo
            // 
            AdminPanelLogo.Image = (Image)resources.GetObject("AdminPanelLogo.Image");
            AdminPanelLogo.Location = new Point(437, 34);
            AdminPanelLogo.Name = "AdminPanelLogo";
            AdminPanelLogo.Size = new Size(298, 37);
            AdminPanelLogo.TabIndex = 57;
            AdminPanelLogo.TabStop = false;
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(1054, 34);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 56;
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
            closeBtnRegister.Location = new Point(1134, 28);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 55;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(31, 143);
            label1.Name = "label1";
            label1.Size = new Size(287, 34);
            label1.TabIndex = 60;
            label1.Text = "Добавление ролей";
            // 
            // fieldForNameNewRole
            // 
            fieldForNameNewRole.Location = new Point(31, 235);
            fieldForNameNewRole.Name = "fieldForNameNewRole";
            fieldForNameNewRole.Size = new Size(287, 23);
            fieldForNameNewRole.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(31, 216);
            label2.Name = "label2";
            label2.Size = new Size(214, 16);
            label2.TabIndex = 62;
            label2.Text = "*Введите название новой роли";
            // 
            // addRoleToDataBase
            // 
            addRoleToDataBase.BackColor = Color.LimeGreen;
            addRoleToDataBase.Cursor = Cursors.Hand;
            addRoleToDataBase.FlatStyle = FlatStyle.Flat;
            addRoleToDataBase.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addRoleToDataBase.Location = new Point(31, 285);
            addRoleToDataBase.Name = "addRoleToDataBase";
            addRoleToDataBase.Size = new Size(221, 38);
            addRoleToDataBase.TabIndex = 63;
            addRoleToDataBase.Text = "Добавить роль";
            addRoleToDataBase.UseMnemonic = false;
            addRoleToDataBase.UseVisualStyleBackColor = false;
            addRoleToDataBase.Click += addRoleToDataBase_Click;
            // 
            // switcherCanEditShedule
            // 
            switcherCanEditShedule.DropDownStyle = ComboBoxStyle.DropDownList;
            switcherCanEditShedule.FormattingEnabled = true;
            switcherCanEditShedule.Items.AddRange(new object[] { "Да", "Нет" });
            switcherCanEditShedule.Location = new Point(350, 235);
            switcherCanEditShedule.Name = "switcherCanEditShedule";
            switcherCanEditShedule.Size = new Size(281, 23);
            switcherCanEditShedule.TabIndex = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(350, 216);
            label3.Name = "label3";
            label3.Size = new Size(233, 16);
            label3.TabIndex = 65;
            label3.Text = "*Можно ли изменять расписание?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(31, 475);
            label4.Name = "label4";
            label4.Size = new Size(246, 34);
            label4.TabIndex = 66;
            label4.Text = "Удаление ролей";
            // 
            // comboBoxForDeleteRoles
            // 
            comboBoxForDeleteRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxForDeleteRoles.FormattingEnabled = true;
            comboBoxForDeleteRoles.Location = new Point(31, 561);
            comboBoxForDeleteRoles.Name = "comboBoxForDeleteRoles";
            comboBoxForDeleteRoles.Size = new Size(281, 23);
            comboBoxForDeleteRoles.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(31, 542);
            label5.Name = "label5";
            label5.Size = new Size(209, 16);
            label5.TabIndex = 68;
            label5.Text = "*Выберите роль для удаления";
            // 
            // buttonForDeleteRoles
            // 
            buttonForDeleteRoles.BackColor = Color.Red;
            buttonForDeleteRoles.Cursor = Cursors.Hand;
            buttonForDeleteRoles.FlatStyle = FlatStyle.Flat;
            buttonForDeleteRoles.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonForDeleteRoles.ForeColor = SystemColors.ButtonHighlight;
            buttonForDeleteRoles.Location = new Point(31, 614);
            buttonForDeleteRoles.Name = "buttonForDeleteRoles";
            buttonForDeleteRoles.Size = new Size(221, 38);
            buttonForDeleteRoles.TabIndex = 69;
            buttonForDeleteRoles.Text = "Удалить роль";
            buttonForDeleteRoles.UseMnemonic = false;
            buttonForDeleteRoles.UseVisualStyleBackColor = false;
            buttonForDeleteRoles.Click += buttonForDeleteRoles_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(31, 670);
            label6.Name = "label6";
            label6.Size = new Size(469, 16);
            label6.TabIndex = 70;
            label6.Text = "*С удалением роли, удалятся автосмены и расписания для этой роли";
            // 
            // backtomenu
            // 
            backtomenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backtomenu.BackgroundImage = Properties.Resources.backtomenu;
            backtomenu.Cursor = Cursors.Hand;
            backtomenu.Location = new Point(31, 711);
            backtomenu.Name = "backtomenu";
            backtomenu.Size = new Size(69, 71);
            backtomenu.TabIndex = 71;
            backtomenu.TabStop = false;
            backtomenu.Click += backtomenu_Click;
            // 
            // redacRolesMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1264, 824);
            ControlBox = false;
            Controls.Add(backtomenu);
            Controls.Add(label6);
            Controls.Add(buttonForDeleteRoles);
            Controls.Add(label5);
            Controls.Add(comboBoxForDeleteRoles);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(switcherCanEditShedule);
            Controls.Add(addRoleToDataBase);
            Controls.Add(label2);
            Controls.Add(fieldForNameNewRole);
            Controls.Add(label1);
            Controls.Add(logoiconRegister);
            Controls.Add(toClient);
            Controls.Add(AdminPanelLogo);
            Controls.Add(iconimg);
            Controls.Add(closeBtnRegister);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1280, 860);
            Name = "redacRolesMain";
            Text = "Редактирование ролей";
            Load += redacRolesMain_Load;
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)backtomenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoiconRegister;
        private Label toClient;
        private PictureBox AdminPanelLogo;
        private Button iconimg;
        private Button closeBtnRegister;
        private Label label1;
        private TextBox fieldForNameNewRole;
        private Label label2;
        private Button addRoleToDataBase;
        private ComboBox switcherCanEditShedule;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxForDeleteRoles;
        private Label label5;
        private Button buttonForDeleteRoles;
        private Label label6;
        private PictureBox backtomenu;
    }
}