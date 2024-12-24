namespace WinFormsApp1
{
    partial class myRequestBrowser
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
            dataGridViewRequests = new DataGridView();
            labelNotRequest = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            SuspendLayout();
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(490, 18);
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
            closeBtnRegister.Location = new Point(570, 12);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 55;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(436, 32);
            label1.TabIndex = 60;
            label1.Text = "Мои запросы на смену расписания";
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Location = new Point(12, 108);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.Size = new Size(629, 452);
            dataGridViewRequests.TabIndex = 61;
            // 
            // labelNotRequest
            // 
            labelNotRequest.AutoSize = true;
            labelNotRequest.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelNotRequest.ForeColor = Color.Maroon;
            labelNotRequest.Location = new Point(12, 581);
            labelNotRequest.Name = "labelNotRequest";
            labelNotRequest.Size = new Size(389, 25);
            labelNotRequest.TabIndex = 62;
            labelNotRequest.Text = "У вас нет запросов на смену расписания";
            // 
            // myRequestBrowser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(657, 667);
            ControlBox = false;
            Controls.Add(labelNotRequest);
            Controls.Add(dataGridViewRequests);
            Controls.Add(label1);
            Controls.Add(iconimg);
            Controls.Add(closeBtnRegister);
            MaximumSize = new Size(673, 706);
            MinimumSize = new Size(673, 706);
            Name = "myRequestBrowser";
            Text = "Обозреватель запросов";
            Load += myRequestBrowser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button iconimg;
        private Button closeBtnRegister;
        private Label label1;
        private DataGridView dataGridViewRequests;
        private Label labelNotRequest;
    }
}