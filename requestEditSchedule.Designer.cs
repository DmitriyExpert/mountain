namespace WinFormsApp1
{
    partial class requestEditSchedule
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
            comboBoxSelectedDate = new ComboBox();
            richTextBoxForRequest = new RichTextBox();
            textBoxForNewTimeStart = new TextBox();
            textBoxForNewTimeEnd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            pushButton = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(452, 28);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 58;
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
            closeBtnRegister.Location = new Point(532, 22);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 57;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(357, 32);
            label1.TabIndex = 59;
            label1.Text = "Запрос на смену расписания";
            // 
            // comboBoxSelectedDate
            // 
            comboBoxSelectedDate.FormattingEnabled = true;
            comboBoxSelectedDate.Location = new Point(12, 140);
            comboBoxSelectedDate.Name = "comboBoxSelectedDate";
            comboBoxSelectedDate.Size = new Size(224, 23);
            comboBoxSelectedDate.TabIndex = 60;
            // 
            // richTextBoxForRequest
            // 
            richTextBoxForRequest.Location = new Point(12, 310);
            richTextBoxForRequest.Name = "richTextBoxForRequest";
            richTextBoxForRequest.Size = new Size(502, 225);
            richTextBoxForRequest.TabIndex = 61;
            richTextBoxForRequest.Text = "";
            // 
            // textBoxForNewTimeStart
            // 
            textBoxForNewTimeStart.Location = new Point(12, 197);
            textBoxForNewTimeStart.Name = "textBoxForNewTimeStart";
            textBoxForNewTimeStart.Size = new Size(328, 23);
            textBoxForNewTimeStart.TabIndex = 62;
            // 
            // textBoxForNewTimeEnd
            // 
            textBoxForNewTimeEnd.Location = new Point(12, 258);
            textBoxForNewTimeEnd.Name = "textBoxForNewTimeEnd";
            textBoxForNewTimeEnd.Size = new Size(328, 23);
            textBoxForNewTimeEnd.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 64;
            label2.Text = "Выберите дату";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(328, 15);
            label3.TabIndex = 65;
            label3.Text = "Напишите новое время начала смены в формате 00:00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 240);
            label4.Name = "label4";
            label4.Size = new Size(319, 15);
            label4.TabIndex = 66;
            label4.Text = "Напишите новое время конца смены в формате 00:00";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(358, 594);
            button1.Name = "button1";
            button1.Size = new Size(156, 28);
            button1.TabIndex = 67;
            button1.Text = "Очистить все поля";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pushButton
            // 
            pushButton.BackColor = Color.Green;
            pushButton.BackgroundImageLayout = ImageLayout.None;
            pushButton.Cursor = Cursors.Hand;
            pushButton.FlatAppearance.BorderSize = 0;
            pushButton.FlatStyle = FlatStyle.Flat;
            pushButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            pushButton.ForeColor = SystemColors.ButtonHighlight;
            pushButton.Location = new Point(397, 541);
            pushButton.Name = "pushButton";
            pushButton.Size = new Size(117, 38);
            pushButton.TabIndex = 68;
            pushButton.Text = "Отправить";
            pushButton.UseVisualStyleBackColor = false;
            pushButton.Click += pushButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 541);
            label5.Name = "label5";
            label5.Size = new Size(337, 15);
            label5.TabIndex = 69;
            label5.Text = "Опишите кратко проблему, почему хотите сменить время";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 564);
            label6.Name = "label6";
            label6.Size = new Size(141, 15);
            label6.TabIndex = 70;
            label6.Text = "Лимит - 1000 символов\r\n";
            // 
            // requestEditSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(619, 634);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pushButton);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxForNewTimeEnd);
            Controls.Add(textBoxForNewTimeStart);
            Controls.Add(richTextBoxForRequest);
            Controls.Add(comboBoxSelectedDate);
            Controls.Add(label1);
            Controls.Add(iconimg);
            Controls.Add(closeBtnRegister);
            Name = "requestEditSchedule";
            Text = "Запрос на смену расписания";
            Load += requestEditSchedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button iconimg;
        private Button closeBtnRegister;
        private Label label1;
        private ComboBox comboBoxSelectedDate;
        private RichTextBox richTextBoxForRequest;
        private TextBox textBoxForNewTimeStart;
        private TextBox textBoxForNewTimeEnd;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button pushButton;
        private Label label5;
        private Label label6;
    }
}