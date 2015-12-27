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
            this.components = new System.ComponentModel.Container();
            CCWin.SkinControl.ChatListItem chatListItem1 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem1 = new CCWin.SkinControl.ChatListSubItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            CCWin.SkinControl.ChatListItem chatListItem2 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListItem chatListItem3 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListItem chatListItem4 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem2 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListItem chatListItem5 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem3 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListItem chatListItem6 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            this.chatListBox_contacts = new CCWin.SkinControl.ChatListBox();
            this.chatListBox1 = new CCWin.SkinControl.ChatListBox();
            this.chatTab = new CCWin.SkinControl.SkinTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lbl_userName = new CCWin.SkinControl.SkinLabel();
            this.chatTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatListBox_contacts
            // 
            this.chatListBox_contacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chatListBox_contacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBox_contacts.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox_contacts.ForeColor = System.Drawing.Color.Black;
            this.chatListBox_contacts.FriendsMobile = true;
            chatListItem1.Bounds = new System.Drawing.Rectangle(0, 1, 266, 79);
            chatListItem1.IsOpen = true;
            chatListItem1.IsTwinkleHide = true;
            chatListItem1.OwnerChatListBox = this.chatListBox_contacts;
            chatListSubItem1.Bounds = new System.Drawing.Rectangle(0, 27, 266, 53);
            chatListSubItem1.DisplayName = "TTEST";
            chatListSubItem1.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem1.HeadImage")));
            chatListSubItem1.HeadRect = new System.Drawing.Rectangle(5, 33, 40, 40);
            chatListSubItem1.ID = ((uint)(3055u));
            chatListSubItem1.IpAddress = null;
            chatListSubItem1.IsTwinkle = false;
            chatListSubItem1.IsTwinkleHide = false;
            chatListSubItem1.IsVip = false;
            chatListSubItem1.NicName = "TEST";
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
            chatListItem2.Bounds = new System.Drawing.Rectangle(0, 81, 266, 25);
            chatListItem2.IsTwinkleHide = false;
            chatListItem2.OwnerChatListBox = this.chatListBox_contacts;
            chatListItem2.Tag = null;
            chatListItem2.Text = "陌生人";
            chatListItem2.TwinkleSubItemNumber = 0;
            chatListItem3.Bounds = new System.Drawing.Rectangle(0, 107, 266, 25);
            chatListItem3.IsTwinkleHide = false;
            chatListItem3.OwnerChatListBox = this.chatListBox_contacts;
            chatListItem3.Tag = null;
            chatListItem3.Text = "黑名单";
            chatListItem3.TwinkleSubItemNumber = 0;
            this.chatListBox_contacts.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem1,
            chatListItem2,
            chatListItem3});
            this.chatListBox_contacts.ListSubItemMenu = null;
            this.chatListBox_contacts.Location = new System.Drawing.Point(3, 3);
            this.chatListBox_contacts.Name = "chatListBox_contacts";
            this.chatListBox_contacts.SelectSubItem = null;
            this.chatListBox_contacts.Size = new System.Drawing.Size(266, 428);
            this.chatListBox_contacts.SubItemMenu = null;
            this.chatListBox_contacts.TabIndex = 0;
            this.chatListBox_contacts.DoubleClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.chatListBox_DoubleClickSubItem);
            // 
            // chatListBox1
            // 
            this.chatListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chatListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox1.ForeColor = System.Drawing.Color.Black;
            this.chatListBox1.FriendsMobile = true;
            chatListItem4.Bounds = new System.Drawing.Rectangle(0, 1, 266, 79);
            chatListItem4.IsOpen = true;
            chatListItem4.IsTwinkleHide = true;
            chatListItem4.OwnerChatListBox = this.chatListBox1;
            chatListSubItem2.Bounds = new System.Drawing.Rectangle(0, 27, 266, 53);
            chatListSubItem2.DisplayName = "TTEST22";
            chatListSubItem2.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem2.HeadImage")));
            chatListSubItem2.HeadRect = new System.Drawing.Rectangle(5, 33, 40, 40);
            chatListSubItem2.ID = ((uint)(0u));
            chatListSubItem2.IpAddress = null;
            chatListSubItem2.IsTwinkle = false;
            chatListSubItem2.IsTwinkleHide = false;
            chatListSubItem2.IsVip = false;
            chatListSubItem2.NicName = "TEST";
            chatListSubItem2.OwnerListItem = chatListItem4;
            chatListSubItem2.PersonalMsg = "Personal Message ...";
            chatListSubItem2.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem2.QQShow = null;
            chatListSubItem2.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem2.Tag = null;
            chatListSubItem2.TcpPort = 0;
            chatListSubItem2.UpdPort = 0;
            chatListItem4.SubItems.AddRange(new CCWin.SkinControl.ChatListSubItem[] {
            chatListSubItem2});
            chatListItem4.Tag = null;
            chatListItem4.Text = "好友";
            chatListItem4.TwinkleSubItemNumber = 0;
            chatListItem5.Bounds = new System.Drawing.Rectangle(0, 81, 266, 79);
            chatListItem5.IsOpen = true;
            chatListItem5.IsTwinkleHide = false;
            chatListItem5.OwnerChatListBox = this.chatListBox1;
            chatListSubItem3.Bounds = new System.Drawing.Rectangle(0, 107, 266, 53);
            chatListSubItem3.DisplayName = "TEST3";
            chatListSubItem3.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem3.HeadImage")));
            chatListSubItem3.HeadRect = new System.Drawing.Rectangle(5, 113, 40, 40);
            chatListSubItem3.ID = ((uint)(3u));
            chatListSubItem3.IpAddress = null;
            chatListSubItem3.IsTwinkle = false;
            chatListSubItem3.IsTwinkleHide = false;
            chatListSubItem3.IsVip = false;
            chatListSubItem3.NicName = "nicName";
            chatListSubItem3.OwnerListItem = chatListItem5;
            chatListSubItem3.PersonalMsg = "Personal Message ...";
            chatListSubItem3.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem3.QQShow = null;
            chatListSubItem3.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem3.Tag = null;
            chatListSubItem3.TcpPort = 0;
            chatListSubItem3.UpdPort = 0;
            chatListItem5.SubItems.AddRange(new CCWin.SkinControl.ChatListSubItem[] {
            chatListSubItem3});
            chatListItem5.Tag = null;
            chatListItem5.Text = "陌生人";
            chatListItem5.TwinkleSubItemNumber = 0;
            chatListItem6.Bounds = new System.Drawing.Rectangle(0, 161, 266, 25);
            chatListItem6.IsTwinkleHide = false;
            chatListItem6.OwnerChatListBox = this.chatListBox1;
            chatListItem6.Tag = null;
            chatListItem6.Text = "黑名单";
            chatListItem6.TwinkleSubItemNumber = 0;
            this.chatListBox1.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem4,
            chatListItem5,
            chatListItem6});
            this.chatListBox1.ListSubItemMenu = null;
            this.chatListBox1.Location = new System.Drawing.Point(3, 3);
            this.chatListBox1.Name = "chatListBox1";
            this.chatListBox1.SelectSubItem = null;
            this.chatListBox1.Size = new System.Drawing.Size(266, 428);
            this.chatListBox1.SubItemMenu = null;
            this.chatListBox1.TabIndex = 1;
            // 
            // chatTab
            // 
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 0.3F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.chatTab.Animation = animation1;
            this.chatTab.AnimationStart = false;
            this.chatTab.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlideAndRotate;
            this.chatTab.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.chatTab.Controls.Add(this.tabPage1);
            this.chatTab.Controls.Add(this.tabPage2);
            this.chatTab.Controls.Add(this.tabPage3);
            this.chatTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chatTab.HeadBack = null;
            this.chatTab.ImageList = this.imageList;
            this.chatTab.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.chatTab.ItemSize = new System.Drawing.Size(80, 36);
            this.chatTab.Location = new System.Drawing.Point(4, 53);
            this.chatTab.Multiline = true;
            this.chatTab.Name = "chatTab";
            this.chatTab.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("chatTab.PageArrowDown")));
            this.chatTab.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("chatTab.PageArrowHover")));
            this.chatTab.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("chatTab.PageCloseHover")));
            this.chatTab.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("chatTab.PageCloseNormal")));
            this.chatTab.PageDown = ((System.Drawing.Image)(resources.GetObject("chatTab.PageDown")));
            this.chatTab.PageHover = ((System.Drawing.Image)(resources.GetObject("chatTab.PageHover")));
            this.chatTab.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.chatTab.PageNorml = null;
            this.chatTab.SelectedIndex = 0;
            this.chatTab.Size = new System.Drawing.Size(272, 470);
            this.chatTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.chatTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chatListBox_contacts);
            this.tabPage1.Location = new System.Drawing.Point(0, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(272, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "联系人";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chatListBox1);
            this.tabPage2.Location = new System.Drawing.Point(0, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(272, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "会话";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(272, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "群/讨论组";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "icon_contacts_normal3X.png");
            this.imageList.Images.SetKeyName(1, "icon_group_normal3X.png");
            this.imageList.Images.SetKeyName(2, "icon_last_normal3X.png");
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userName.BorderColor = System.Drawing.Color.White;
            this.lbl_userName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_userName.Location = new System.Drawing.Point(4, 33);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(68, 17);
            this.lbl_userName.TabIndex = 1;
            this.lbl_userName.Text = "userName";
            // 
            // Form_main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BackLayout = false;
            this.BackShade = false;
            this.BackToColor = false;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.CaptionHeight = 26;
            this.ClientSize = new System.Drawing.Size(280, 527);
            this.CloseBoxSize = new System.Drawing.Size(30, 30);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.ControlBoxOffset = new System.Drawing.Point(0, 0);
            this.ControlBoxSpace = 0;
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.chatTab);
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
            this.Text = "Form_main";
            this.chatTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.ChatListBox chatListBox_contacts;
        private CCWin.SkinControl.SkinTabControl chatTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private CCWin.SkinControl.SkinLabel lbl_userName;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage tabPage1;
        private CCWin.SkinControl.ChatListBox chatListBox1;

    }
}