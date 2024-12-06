namespace WinFormsApp1
{
    partial class redacRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(redacRoles));
            logoiconRegister = new PictureBox();
            AdminPanelLogo = new PictureBox();
            toClient = new Label();
            iconimg = new Button();
            closeBtnRegister = new Button();
            labelRoles = new Label();
            comboBoxRoles = new ComboBox();
            labelShiftTypes = new Label();
            comboBoxShiftTypes = new ComboBox();
            labelPeriodsTime = new Label();
            comboBoxPeriodsTime = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).BeginInit();
            SuspendLayout();
            // 
            // logoiconRegister
            // 
            logoiconRegister.Image = Properties.Resources.SCHEDULE_mountain;
            logoiconRegister.Location = new Point(34, 29);
            logoiconRegister.Name = "logoiconRegister";
            logoiconRegister.Size = new Size(298, 37);
            logoiconRegister.TabIndex = 48;
            logoiconRegister.TabStop = false;
            // 
            // AdminPanelLogo
            // 
            AdminPanelLogo.Image = (Image)resources.GetObject("AdminPanelLogo.Image");
            AdminPanelLogo.Location = new Point(394, 29);
            AdminPanelLogo.Name = "AdminPanelLogo";
            AdminPanelLogo.Size = new Size(298, 37);
            AdminPanelLogo.TabIndex = 51;
            AdminPanelLogo.TabStop = false;
            // 
            // toClient
            // 
            toClient.AutoSize = true;
            toClient.Cursor = Cursors.Hand;
            toClient.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toClient.Location = new Point(1419, 44);
            toClient.Name = "toClient";
            toClient.Size = new Size(222, 29);
            toClient.TabIndex = 54;
            toClient.Text = "Клиентская часть";
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(1710, 35);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 53;
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
            closeBtnRegister.Location = new Point(1790, 29);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 52;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // labelRoles
            // 
            labelRoles.AutoSize = true;
            labelRoles.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRoles.Location = new Point(34, 137);
            labelRoles.Name = "labelRoles";
            labelRoles.Size = new Size(172, 24);
            labelRoles.TabIndex = 55;
            labelRoles.Text = "Выберите роль";
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Location = new Point(34, 189);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(172, 23);
            comboBoxRoles.TabIndex = 56;
            comboBoxRoles.SelectedIndexChanged += comboBoxRoles_SelectedIndexChanged;
            // 
            // labelShiftTypes
            // 
            labelShiftTypes.AutoSize = true;
            labelShiftTypes.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelShiftTypes.Location = new Point(279, 137);
            labelShiftTypes.Name = "labelShiftTypes";
            labelShiftTypes.Size = new Size(325, 24);
            labelShiftTypes.TabIndex = 57;
            labelShiftTypes.Text = "Выберите тип рабочей смены";
            labelShiftTypes.Visible = false;
            // 
            // comboBoxShiftTypes
            // 
            comboBoxShiftTypes.FormattingEnabled = true;
            comboBoxShiftTypes.Location = new Point(279, 189);
            comboBoxShiftTypes.Name = "comboBoxShiftTypes";
            comboBoxShiftTypes.Size = new Size(177, 23);
            comboBoxShiftTypes.TabIndex = 58;
            comboBoxShiftTypes.Visible = false;
            comboBoxShiftTypes.SelectedIndexChanged += comboBoxShiftTypes_SelectedIndexChanged;
            // 
            // labelPeriodsTime
            // 
            labelPeriodsTime.AutoSize = true;
            labelPeriodsTime.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPeriodsTime.Location = new Point(644, 137);
            labelPeriodsTime.Name = "labelPeriodsTime";
            labelPeriodsTime.Size = new Size(369, 24);
            labelPeriodsTime.TabIndex = 59;
            labelPeriodsTime.Text = "Выберите временной промежуток";
            labelPeriodsTime.Visible = false;
            // 
            // comboBoxPeriodsTime
            // 
            comboBoxPeriodsTime.FormattingEnabled = true;
            comboBoxPeriodsTime.Location = new Point(644, 189);
            comboBoxPeriodsTime.Name = "comboBoxPeriodsTime";
            comboBoxPeriodsTime.Size = new Size(177, 23);
            comboBoxPeriodsTime.TabIndex = 60;
            comboBoxPeriodsTime.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(34, 271);
            button1.Name = "button1";
            button1.Size = new Size(136, 38);
            button1.TabIndex = 61;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // redacRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1904, 1041);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(comboBoxPeriodsTime);
            Controls.Add(labelPeriodsTime);
            Controls.Add(comboBoxShiftTypes);
            Controls.Add(labelShiftTypes);
            Controls.Add(comboBoxRoles);
            Controls.Add(labelRoles);
            Controls.Add(toClient);
            Controls.Add(iconimg);
            Controls.Add(closeBtnRegister);
            Controls.Add(AdminPanelLogo);
            Controls.Add(logoiconRegister);
            Name = "redacRoles";
            Text = "redacRoles";
            Load += redacRoles_Load;
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminPanelLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoiconRegister;
        private PictureBox AdminPanelLogo;
        private Label toClient;
        private Button iconimg;
        private Button closeBtnRegister;
        private Label labelRoles;
        private ComboBox comboBoxRoles;
        private Label labelShiftTypes;
        private ComboBox comboBoxShiftTypes;
        private Label labelPeriodsTime;
        private ComboBox comboBoxPeriodsTime;
        private Button button1;
    }
}