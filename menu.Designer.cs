namespace WinFormsApp1
{
    partial class menu
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
            logoiconRegister = new PictureBox();
            iconimg = new Button();
            closeBtnRegister = new Button();
            pictureToCabinet = new PictureBox();
            toPanelAdm = new Label();
            pictureBox2 = new PictureBox();
            devWrapper = new PictureBox();
            developersTitle = new Label();
            labelName1 = new Label();
            labelName2 = new Label();
            labelName3 = new Label();
            labelGroup = new Label();
            menuWrapper = new PictureBox();
            menuTitle = new Label();
            toCabinet = new Label();
            toContact = new Label();
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureToCabinet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)devWrapper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuWrapper).BeginInit();
            SuspendLayout();
            // 
            // logoiconRegister
            // 
            logoiconRegister.Image = Properties.Resources.SCHEDULE_mountain;
            logoiconRegister.Location = new Point(28, 26);
            logoiconRegister.Name = "logoiconRegister";
            logoiconRegister.Size = new Size(298, 37);
            logoiconRegister.TabIndex = 2;
            logoiconRegister.TabStop = false;
            // 
            // iconimg
            // 
            iconimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconimg.Cursor = Cursors.Hand;
            iconimg.FlatStyle = FlatStyle.Popup;
            iconimg.Image = Properties.Resources.icon_menu;
            iconimg.Location = new Point(1277, 32);
            iconimg.Name = "iconimg";
            iconimg.Size = new Size(62, 54);
            iconimg.TabIndex = 23;
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
            closeBtnRegister.Location = new Point(1357, 26);
            closeBtnRegister.Name = "closeBtnRegister";
            closeBtnRegister.Size = new Size(75, 66);
            closeBtnRegister.TabIndex = 22;
            closeBtnRegister.UseVisualStyleBackColor = true;
            closeBtnRegister.Click += closeBtnRegister_Click;
            // 
            // pictureToCabinet
            // 
            pictureToCabinet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureToCabinet.BackgroundImage = Properties.Resources.user__icon;
            pictureToCabinet.BackgroundImageLayout = ImageLayout.Center;
            pictureToCabinet.Cursor = Cursors.Hand;
            pictureToCabinet.Location = new Point(1118, 18);
            pictureToCabinet.Name = "pictureToCabinet";
            pictureToCabinet.Size = new Size(74, 74);
            pictureToCabinet.TabIndex = 24;
            pictureToCabinet.TabStop = false;
            pictureToCabinet.Click += pictureToCabinet_Click;
            // 
            // toPanelAdm
            // 
            toPanelAdm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toPanelAdm.AutoSize = true;
            toPanelAdm.Cursor = Cursors.Hand;
            toPanelAdm.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toPanelAdm.Location = new Point(878, 44);
            toPanelAdm.Name = "toPanelAdm";
            toPanelAdm.Size = new Size(185, 25);
            toPanelAdm.TabIndex = 25;
            toPanelAdm.Text = "Панель управления";
            toPanelAdm.Click += toPanelAdm_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.W5Fh769EYAU_1;
            pictureBox2.Location = new Point(0, 102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1464, 834);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // devWrapper
            // 
            devWrapper.BackColor = Color.Gray;
            devWrapper.Location = new Point(100, 308);
            devWrapper.Name = "devWrapper";
            devWrapper.Size = new Size(469, 605);
            devWrapper.TabIndex = 27;
            devWrapper.TabStop = false;
            // 
            // developersTitle
            // 
            developersTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            developersTitle.AutoSize = true;
            developersTitle.BackColor = Color.Gray;
            developersTitle.Cursor = Cursors.Hand;
            developersTitle.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            developersTitle.ForeColor = SystemColors.Control;
            developersTitle.Location = new Point(232, 335);
            developersTitle.Name = "developersTitle";
            developersTitle.Size = new Size(199, 37);
            developersTitle.TabIndex = 28;
            developersTitle.Text = "Разработчики";
            // 
            // labelName1
            // 
            labelName1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelName1.AutoSize = true;
            labelName1.BackColor = Color.Gray;
            labelName1.Cursor = Cursors.Hand;
            labelName1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName1.ForeColor = SystemColors.Control;
            labelName1.Location = new Point(127, 460);
            labelName1.Name = "labelName1";
            labelName1.Size = new Size(170, 25);
            labelName1.TabIndex = 29;
            labelName1.Text = "Демаков Дмитрий";
            // 
            // labelName2
            // 
            labelName2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelName2.AutoSize = true;
            labelName2.BackColor = Color.Gray;
            labelName2.Cursor = Cursors.Hand;
            labelName2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            labelName2.ForeColor = SystemColors.Control;
            labelName2.Location = new Point(127, 531);
            labelName2.Name = "labelName2";
            labelName2.Size = new Size(157, 25);
            labelName2.TabIndex = 30;
            labelName2.Text = "Маслова Ксения";
            // 
            // labelName3
            // 
            labelName3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelName3.AutoSize = true;
            labelName3.BackColor = Color.Gray;
            labelName3.Cursor = Cursors.Hand;
            labelName3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            labelName3.ForeColor = SystemColors.Control;
            labelName3.Location = new Point(127, 603);
            labelName3.Name = "labelName3";
            labelName3.Size = new Size(174, 25);
            labelName3.TabIndex = 31;
            labelName3.Text = "Тимофей Мусатов";
            // 
            // labelGroup
            // 
            labelGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelGroup.AutoSize = true;
            labelGroup.BackColor = Color.Gray;
            labelGroup.Cursor = Cursors.Hand;
            labelGroup.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            labelGroup.ForeColor = SystemColors.Control;
            labelGroup.Location = new Point(127, 757);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(190, 25);
            labelGroup.TabIndex = 32;
            labelGroup.Text = "Группа: Т-233901-НТ";
            // 
            // menuWrapper
            // 
            menuWrapper.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuWrapper.BackColor = Color.Gray;
            menuWrapper.Location = new Point(608, 181);
            menuWrapper.Name = "menuWrapper";
            menuWrapper.Size = new Size(713, 704);
            menuWrapper.TabIndex = 33;
            menuWrapper.TabStop = false;
            // 
            // menuTitle
            // 
            menuTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuTitle.AutoSize = true;
            menuTitle.BackColor = Color.Gray;
            menuTitle.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menuTitle.ForeColor = SystemColors.Control;
            menuTitle.Location = new Point(849, 356);
            menuTitle.Name = "menuTitle";
            menuTitle.Size = new Size(249, 90);
            menuTitle.TabIndex = 34;
            menuTitle.Text = "Меню";
            // 
            // toCabinet
            // 
            toCabinet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toCabinet.AutoSize = true;
            toCabinet.BackColor = Color.Gray;
            toCabinet.Cursor = Cursors.Hand;
            toCabinet.Font = new Font("Arial Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toCabinet.ForeColor = SystemColors.Control;
            toCabinet.Location = new Point(889, 492);
            toCabinet.Name = "toCabinet";
            toCabinet.Size = new Size(152, 41);
            toCabinet.TabIndex = 36;
            toCabinet.Text = "Кабинет";
            toCabinet.Click += toCabinet_Click;
            // 
            // toContact
            // 
            toContact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toContact.AutoSize = true;
            toContact.BackColor = Color.Gray;
            toContact.Cursor = Cursors.Hand;
            toContact.Font = new Font("Arial Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toContact.ForeColor = SystemColors.Control;
            toContact.Location = new Point(878, 576);
            toContact.Name = "toContact";
            toContact.Size = new Size(173, 41);
            toContact.TabIndex = 37;
            toContact.Text = "Контакты";
            toContact.Click += toContact_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1464, 936);
            ControlBox = false;
            Controls.Add(toContact);
            Controls.Add(toCabinet);
            Controls.Add(menuTitle);
            Controls.Add(menuWrapper);
            Controls.Add(labelGroup);
            Controls.Add(labelName3);
            Controls.Add(labelName2);
            Controls.Add(labelName1);
            Controls.Add(developersTitle);
            Controls.Add(devWrapper);
            Controls.Add(toPanelAdm);
            Controls.Add(pictureToCabinet);
            Controls.Add(iconimg);
            Controls.Add(closeBtnRegister);
            Controls.Add(logoiconRegister);
            Controls.Add(pictureBox2);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1480, 975);
            Name = "menu";
            Text = "Главное меню";
            Load += menu_Load;
            ((System.ComponentModel.ISupportInitialize)logoiconRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureToCabinet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)devWrapper).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuWrapper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoiconRegister;
        private Button iconimg;
        private Button closeBtnRegister;
        private PictureBox pictureToCabinet;
        private Label toPanelAdm;
        private PictureBox pictureBox2;
        private PictureBox devWrapper;
        private Label developersTitle;
        private Label labelName1;
        private Label labelName2;
        private Label labelName3;
        private Label labelGroup;
        private PictureBox menuWrapper;
        private Label menuTitle;
        private Label toCabinet;
        private Label toContact;
    }
}