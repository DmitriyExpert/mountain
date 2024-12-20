namespace WinFormsApp1
{
    partial class whowithme
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
            iconimg = new Button();
            closeBtnRegister = new Button();
            label1 = new Label();
            comboBoxDays = new ComboBox();
            label2 = new Label();
            buttonSearchUsers = new Button();
            dataGridViewForUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForUsers).BeginInit();
            SuspendLayout();
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(481, 18);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 30;
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
            closeBtnRegister.Location = new Point(561, 12);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 29;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(409, 29);
            label1.TabIndex = 31;
            label1.Text = "Посмотрите кто работает с вами!";
            label1.Click += label1_Click;
            // 
            // comboBoxDays
            // 
            comboBoxDays.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDays.FormattingEnabled = true;
            comboBoxDays.Location = new Point(12, 114);
            comboBoxDays.Name = "comboBoxDays";
            comboBoxDays.Size = new Size(301, 23);
            comboBoxDays.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(109, 16);
            label2.TabIndex = 33;
            label2.Text = "Выберите день";
            // 
            // buttonSearchUsers
            // 
            buttonSearchUsers.Cursor = Cursors.Hand;
            buttonSearchUsers.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSearchUsers.Location = new Point(12, 161);
            buttonSearchUsers.Name = "buttonSearchUsers";
            buttonSearchUsers.Size = new Size(119, 31);
            buttonSearchUsers.TabIndex = 34;
            buttonSearchUsers.Text = "Найти";
            buttonSearchUsers.UseVisualStyleBackColor = true;
            buttonSearchUsers.Click += buttonSearchUsers_Click_2;
            // 
            // dataGridViewForUsers
            // 
            dataGridViewForUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForUsers.Location = new Point(12, 230);
            dataGridViewForUsers.Name = "dataGridViewForUsers";
            dataGridViewForUsers.Size = new Size(604, 345);
            dataGridViewForUsers.TabIndex = 35;
            // 
            // whowithme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(648, 611);
            ControlBox = false;
            Controls.Add(dataGridViewForUsers);
            Controls.Add(buttonSearchUsers);
            Controls.Add(label2);
            Controls.Add(comboBoxDays);
            Controls.Add(label1);
            Controls.Add(iconimg);
            Controls.Add(closeBtnRegister);
            MaximumSize = new Size(834, 650);
            MinimumSize = new Size(664, 650);
            Name = "whowithme";
            Text = "Кто со мной  в смене?";
            Load += whowithme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewForUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button iconimg;
        private Button closeBtnRegister;
        private Label label1;
        private ComboBox comboBoxDays;
        private Label label2;
        private Button buttonSearchUsers;
        private DataGridView dataGridViewForUsers;
    }
}