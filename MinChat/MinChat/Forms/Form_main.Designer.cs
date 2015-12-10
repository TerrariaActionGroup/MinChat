namespace MinChat.Forms
{
    partial class Form_main
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
            CCWin.SkinControl.ChatListItem chatListItem1 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem1 = new CCWin.SkinControl.ChatListSubItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            CCWin.SkinControl.ChatListItem chatListItem2 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListItem chatListItem3 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListItem chatListItem4 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListItem chatListItem5 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListItem chatListItem6 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            this.chatListBox3 = new CCWin.SkinControl.ChatListBox();
            this.chatListBox2 = new CCWin.SkinControl.ChatListBox();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.lblName = new CCWin.SkinControl.SkinLabel();
            this.btnState = new CCWin.SkinControl.SkinButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chatListBox1 = new CCWin.SkinControl.ChatListBox();
            this.TabMain = new CCWin.SkinControl.SkinTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imgLogo = new CCWin.SkinControl.SkinPictureBox();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // chatListBox3
            // 
            this.chatListBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chatListBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox3.ForeColor = System.Drawing.Color.Black;
            this.chatListBox3.FriendsMobile = true;
            chatListItem1.Bounds = new System.Drawing.Rectangle(0, 1, 272, 79);
            chatListItem1.IsOpen = true;
            chatListItem1.IsTwinkleHide = false;
            chatListItem1.OwnerChatListBox = this.chatListBox3;
            chatListSubItem1.Bounds = new System.Drawing.Rectangle(0, 27, 272, 53);
            chatListSubItem1.DisplayName = "包包包包包包工头";
            chatListSubItem1.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem1.HeadImage")));
            chatListSubItem1.HeadRect = new System.Drawing.Rectangle(5, 33, 40, 40);
            chatListSubItem1.ID = ((uint)(0u));
            chatListSubItem1.IpAddress = null;
            chatListSubItem1.IsTwinkle = false;
            chatListSubItem1.IsTwinkleHide = false;
            chatListSubItem1.IsVip = false;
            chatListSubItem1.NicName = "工头";
            chatListSubItem1.OwnerListItem = chatListItem1;
            chatListSubItem1.PersonalMsg = "Personal Message ...";
            chatListSubItem1.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem1.QQShow = null;
            chatListSubItem1.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem1.Tag = null;
            chatListSubItem1.TcpPort = 0;
            chatListSubItem1.UpdPort = 0;
            chatListItem1.SubItems.AddRange(new CCWin.SkinControl.ChatListSubItem[] {
            chatListSubItem1});
            chatListItem1.Tag = null;
            chatListItem1.Text = "好友";
            chatListItem1.TwinkleSubItemNumber = 0;
            chatListItem2.Bounds = new System.Drawing.Rectangle(0, 81, 272, 25);
            chatListItem2.IsTwinkleHide = false;
            chatListItem2.OwnerChatListBox = this.chatListBox3;
            chatListItem2.Tag = null;
            chatListItem2.Text = "陌生人";
            chatListItem2.TwinkleSubItemNumber = 0;
            chatListItem3.Bounds = new System.Drawing.Rectangle(0, 107, 272, 25);
            chatListItem3.IsTwinkleHide = false;
            chatListItem3.OwnerChatListBox = this.chatListBox3;
            chatListItem3.Tag = null;
            chatListItem3.Text = "黑名单";
            chatListItem3.TwinkleSubItemNumber = 0;
            this.chatListBox3.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem1,
            chatListItem2,
            chatListItem3});
            this.chatListBox3.ListSubItemMenu = null;
            this.chatListBox3.Location = new System.Drawing.Point(3, 3);
            this.chatListBox3.Name = "chatListBox3";
            this.chatListBox3.SelectSubItem = null;
            this.chatListBox3.Size = new System.Drawing.Size(272, 258);
            this.chatListBox3.SubItemMenu = null;
            this.chatListBox3.TabIndex = 0;
            this.chatListBox3.Text = "chatListBox3";
            this.chatListBox3.DoubleClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.chatListBox_DoubleClickSubItem);
            // 
            // chatListBox2
            // 
            this.chatListBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chatListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox2.ForeColor = System.Drawing.Color.Black;
            this.chatListBox2.FriendsMobile = true;
            chatListItem4.Bounds = new System.Drawing.Rectangle(0, 1, 272, 25);
            chatListItem4.IsTwinkleHide = false;
            chatListItem4.OwnerChatListBox = this.chatListBox2;
            chatListItem4.Tag = null;
            chatListItem4.Text = "Item";
            chatListItem4.TwinkleSubItemNumber = 0;
            chatListItem5.Bounds = new System.Drawing.Rectangle(0, 27, 272, 25);
            chatListItem5.IsTwinkleHide = false;
            chatListItem5.OwnerChatListBox = this.chatListBox2;
            chatListItem5.Tag = null;
            chatListItem5.Text = "Item";
            chatListItem5.TwinkleSubItemNumber = 0;
            chatListItem6.Bounds = new System.Drawing.Rectangle(0, 53, 272, 25);
            chatListItem6.IsTwinkleHide = false;
            chatListItem6.OwnerChatListBox = this.chatListBox2;
            chatListItem6.Tag = null;
            chatListItem6.Text = "Item";
            chatListItem6.TwinkleSubItemNumber = 0;
            this.chatListBox2.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem4,
            chatListItem5,
            chatListItem6});
            this.chatListBox2.ListSubItemMenu = null;
            this.chatListBox2.Location = new System.Drawing.Point(3, 3);
            this.chatListBox2.Name = "chatListBox2";
            this.chatListBox2.SelectSubItem = null;
            this.chatListBox2.Size = new System.Drawing.Size(272, 258);
            this.chatListBox2.SubItemMenu = null;
            this.chatListBox2.TabIndex = 1;
            this.chatListBox2.Text = "chatListBox2";
            // 
            // skinPanel1
            // 
            this.skinPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 59);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(278, 23);
            this.skinPanel1.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.BorderColor = System.Drawing.Color.Black;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.ForeColorSuit = true;
            this.lblName.Location = new System.Drawing.Point(7, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 131;
            this.lblName.Text = "学霸hu";
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.Transparent;
            this.btnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnState.BackRectangle = new System.Drawing.Rectangle(4, 4, 4, 4);
            this.btnState.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnState.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnState.DownBack = ((System.Drawing.Image)(resources.GetObject("btnState.DownBack")));
            this.btnState.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnState.Image = ((System.Drawing.Image)(resources.GetObject("btnState.Image")));
            this.btnState.ImageSize = new System.Drawing.Size(13, 13);
            this.btnState.Location = new System.Drawing.Point(79, 31);
            this.btnState.Margin = new System.Windows.Forms.Padding(0);
            this.btnState.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnState.MouseBack")));
            this.btnState.Name = "btnState";
            this.btnState.NormlBack = null;
            this.btnState.Size = new System.Drawing.Size(22, 22);
            this.btnState.TabIndex = 134;
            this.btnState.Tag = "1";
            this.btnState.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chatListBox3);
            this.tabPage2.Location = new System.Drawing.Point(0, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(278, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "联系人";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chatListBox2);
            this.tabPage1.Controls.Add(this.chatListBox1);
            this.tabPage1.Location = new System.Drawing.Point(0, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(278, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "会话";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chatListBox1
            // 
            this.chatListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(231)))), ((int)(((byte)(248)))));
            this.chatListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox1.ForeColor = System.Drawing.Color.Black;
            this.chatListBox1.FriendsMobile = true;
            this.chatListBox1.ListSubItemMenu = null;
            this.chatListBox1.Location = new System.Drawing.Point(3, 3);
            this.chatListBox1.Margin = new System.Windows.Forms.Padding(0);
            this.chatListBox1.Name = "chatListBox1";
            this.chatListBox1.SelectSubItem = null;
            this.chatListBox1.Size = new System.Drawing.Size(272, 258);
            this.chatListBox1.SubItemMenu = null;
            this.chatListBox1.TabIndex = 0;
            this.chatListBox1.Text = "chatListBox1";
            // 
            // TabMain
            // 
            this.TabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.TabMain.Animation = animation1;
            this.TabMain.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.TabMain.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.TabMain.Controls.Add(this.tabPage1);
            this.TabMain.Controls.Add(this.tabPage2);
            this.TabMain.Controls.Add(this.tabPage3);
            this.TabMain.HeadBack = null;
            this.TabMain.ImgSize = new System.Drawing.Size(22, 22);
            this.TabMain.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.TabMain.ItemSize = new System.Drawing.Size(91, 36);
            this.TabMain.ItemStretch = true;
            this.TabMain.Location = new System.Drawing.Point(0, 85);
            this.TabMain.Margin = new System.Windows.Forms.Padding(0);
            this.TabMain.Name = "TabMain";
            this.TabMain.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("TabMain.PageArrowDown")));
            this.TabMain.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("TabMain.PageArrowHover")));
            this.TabMain.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("TabMain.PageCloseHover")));
            this.TabMain.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("TabMain.PageCloseNormal")));
            this.TabMain.PageDown = ((System.Drawing.Image)(resources.GetObject("TabMain.PageDown")));
            this.TabMain.PageHover = ((System.Drawing.Image)(resources.GetObject("TabMain.PageHover")));
            this.TabMain.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.TabMain.PageNorml = null;
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(278, 300);
            this.TabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabMain.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(278, 264);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "群组";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Enabled = false;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(7, 1);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(42, 18);
            this.imgLogo.TabIndex = 142;
            this.imgLogo.TabStop = false;
            // 
            // Form_main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.BackLayout = false;
            this.BackShade = false;
            this.BackToColor = false;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.CaptionHeight = 30;
            this.ClientSize = new System.Drawing.Size(280, 527);
            this.CloseBoxSize = new System.Drawing.Size(30, 30);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.ControlBoxOffset = new System.Drawing.Point(0, 0);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.TabMain);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.InnerBorderColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(543, 764);
            this.MaxSize = new System.Drawing.Size(30, 30);
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MinimumSize = new System.Drawing.Size(280, 527);
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(30, 30);
            this.Name = "Form_main";
            this.Radius = 2;
            this.ShadowWidth = 5;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_main";
            this.TopMost = true;
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel lblName;
        private CCWin.SkinControl.SkinButton btnState;
        private System.Windows.Forms.TabPage tabPage2;
        private CCWin.SkinControl.ChatListBox chatListBox3;
        private System.Windows.Forms.TabPage tabPage1;
        private CCWin.SkinControl.ChatListBox chatListBox2;
        private CCWin.SkinControl.ChatListBox chatListBox1;
        private CCWin.SkinControl.SkinTabControl TabMain;
        private CCWin.SkinControl.SkinPictureBox imgLogo;
        private System.Windows.Forms.TabPage tabPage3;
    }
}