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
            CCWin.SkinControl.ChatListItem chatListItem2 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListItem chatListItem3 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListItem chatListItem4 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListItem chatListItem5 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.chatListBox_contacts = new CCWin.SkinControl.ChatListBox();
            this.chatListBox1 = new CCWin.SkinControl.ChatListBox();
            this.lbl_userName = new CCWin.SkinControl.SkinLabel();
            this.btn_search = new CCWin.SkinControl.SkinButton();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chatListBox2 = new CCWin.SkinControl.ChatListBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timer_Adsorption = new System.Windows.Forms.Timer(this.components);
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer_tray = new System.Windows.Forms.Timer(this.components);
            this.skinTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatListBox_contacts
            // 
            this.chatListBox_contacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.chatListBox_contacts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chatListBox_contacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBox_contacts.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox_contacts.ForeColor = System.Drawing.Color.Black;
            this.chatListBox_contacts.FriendsMobile = true;
            chatListItem2.Bounds = new System.Drawing.Rectangle(0, 1, 280, 25);
            chatListItem2.IsOpen = true;
            chatListItem2.IsTwinkleHide = true;
            chatListItem2.OwnerChatListBox = this.chatListBox_contacts;
            chatListItem2.Tag = null;
            chatListItem2.Text = "好友";
            chatListItem2.TwinkleSubItemNumber = 0;
            chatListItem3.Bounds = new System.Drawing.Rectangle(0, 27, 280, 25);
            chatListItem3.IsTwinkleHide = false;
            chatListItem3.OwnerChatListBox = this.chatListBox_contacts;
            chatListItem3.Tag = null;
            chatListItem3.Text = "陌生人";
            chatListItem3.TwinkleSubItemNumber = 0;
            chatListItem4.Bounds = new System.Drawing.Rectangle(0, 53, 280, 25);
            chatListItem4.IsTwinkleHide = false;
            chatListItem4.OwnerChatListBox = this.chatListBox_contacts;
            chatListItem4.Tag = null;
            chatListItem4.Text = "黑名单";
            chatListItem4.TwinkleSubItemNumber = 0;
            this.chatListBox_contacts.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem2,
            chatListItem3,
            chatListItem4});
            this.chatListBox_contacts.ListSubItemMenu = null;
            this.chatListBox_contacts.Location = new System.Drawing.Point(0, 0);
            this.chatListBox_contacts.Margin = new System.Windows.Forms.Padding(0);
            this.chatListBox_contacts.Name = "chatListBox_contacts";
            this.chatListBox_contacts.SelectSubItem = null;
            this.chatListBox_contacts.Size = new System.Drawing.Size(280, 395);
            this.chatListBox_contacts.SubItemMenu = null;
            this.chatListBox_contacts.TabIndex = 4;
            // 
            // chatListBox1
            // 
            this.chatListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.chatListBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chatListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox1.ForeColor = System.Drawing.Color.Black;
            this.chatListBox1.FriendsMobile = true;
            this.chatListBox1.IconSizeMode = CCWin.SkinControl.ChatListItemIcon.Small;
            chatListItem5.Bounds = new System.Drawing.Rectangle(0, 1, 280, 25);
            chatListItem5.IsTwinkleHide = false;
            chatListItem5.OwnerChatListBox = this.chatListBox1;
            chatListItem5.Tag = null;
            chatListItem5.Text = "我的群组";
            chatListItem5.TwinkleSubItemNumber = 0;
            this.chatListBox1.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem5});
            this.chatListBox1.ListSubItemMenu = null;
            this.chatListBox1.Location = new System.Drawing.Point(0, 0);
            this.chatListBox1.Margin = new System.Windows.Forms.Padding(0);
            this.chatListBox1.Name = "chatListBox1";
            this.chatListBox1.SelectSubItem = null;
            this.chatListBox1.Size = new System.Drawing.Size(280, 395);
            this.chatListBox1.SubItemMenu = null;
            this.chatListBox1.TabIndex = 5;
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
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_search.DownBack = null;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_search.Location = new System.Drawing.Point(198, 497);
            this.btn_search.MouseBack = null;
            this.btn_search.Name = "btn_search";
            this.btn_search.NormlBack = null;
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "查找";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // skinTabControl1
            // 
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
            this.skinTabControl1.Animation = animation1;
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.tabPage1);
            this.skinTabControl1.Controls.Add(this.tabPage2);
            this.skinTabControl1.Controls.Add(this.tabPage3);
            this.skinTabControl1.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.IcoStateSwitch = true;
            this.skinTabControl1.ImageList = this.imageList;
            this.skinTabControl1.ImgSize = new System.Drawing.Size(22, 22);
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ImgTxtSpace = 0;
            this.skinTabControl1.ItemSize = new System.Drawing.Size(92, 38);
            this.skinTabControl1.ItemStretch = true;
            this.skinTabControl1.Location = new System.Drawing.Point(0, 61);
            this.skinTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.Padding = new System.Drawing.Point(0, 0);
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageArrowVisble = false;
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.Radius = 1;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(280, 433);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chatListBox_contacts);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(0, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(280, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chatListBox1);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(0, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(280, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chatListBox2);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(0, 38);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(280, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chatListBox2
            // 
            this.chatListBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.chatListBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chatListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox2.ForeColor = System.Drawing.Color.Black;
            this.chatListBox2.FriendsMobile = true;
            this.chatListBox2.ListSubItemMenu = null;
            this.chatListBox2.Location = new System.Drawing.Point(0, 0);
            this.chatListBox2.Margin = new System.Windows.Forms.Padding(0);
            this.chatListBox2.Name = "chatListBox2";
            this.chatListBox2.SelectSubItem = null;
            this.chatListBox2.Size = new System.Drawing.Size(280, 395);
            this.chatListBox2.SubItemMenu = null;
            this.chatListBox2.TabIndex = 5;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "icon_contacts_normal3X.png");
            this.imageList.Images.SetKeyName(1, "icon_group_normal3X.png");
            this.imageList.Images.SetKeyName(2, "icon_last_normal3X.png");
            this.imageList.Images.SetKeyName(3, "00.png");
            // 
            // tray
            // 
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "tray";
            this.tray.Click += new System.EventHandler(this.tray_Click);
            // 
            // timer_tray
            // 
            this.timer_tray.Interval = 500;
            this.timer_tray.Tick += new System.EventHandler(this.timer_tray_Tick);
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
            this.Controls.Add(this.skinTabControl1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_userName);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.EffectWidth = 0;
            this.ForeColor = System.Drawing.Color.Black;
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
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form_main";
            this.TitleOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel lbl_userName;
        private CCWin.SkinControl.SkinButton btn_search;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private CCWin.SkinControl.ChatListBox chatListBox_contacts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage tabPage3;
        private CCWin.SkinControl.ChatListBox chatListBox1;
        private CCWin.SkinControl.ChatListBox chatListBox2;
        private System.Windows.Forms.Timer timer_Adsorption;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.Timer timer_tray;

    }
}