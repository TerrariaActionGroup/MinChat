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
            this.chatListBox = new CCWin.SkinControl.ChatListBox();
            this.SuspendLayout();
            // 
            // chatListBox
            // 
            this.chatListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chatListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox.ForeColor = System.Drawing.Color.Black;
            this.chatListBox.FriendsMobile = true;
            chatListItem1.Bounds = new System.Drawing.Rectangle(0, 1, 272, 79);
            chatListItem1.IsOpen = true;
            chatListItem1.IsTwinkleHide = true;
            chatListItem1.OwnerChatListBox = this.chatListBox;
            chatListSubItem1.Bounds = new System.Drawing.Rectangle(0, 27, 272, 53);
            chatListSubItem1.DisplayName = "TTEST";
            chatListSubItem1.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem1.HeadImage")));
            chatListSubItem1.HeadRect = new System.Drawing.Rectangle(5, 33, 40, 40);
            chatListSubItem1.ID = ((uint)(0u));
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
            chatListItem2.Bounds = new System.Drawing.Rectangle(0, 81, 272, 25);
            chatListItem2.IsTwinkleHide = false;
            chatListItem2.OwnerChatListBox = this.chatListBox;
            chatListItem2.Tag = null;
            chatListItem2.Text = "陌生人";
            chatListItem2.TwinkleSubItemNumber = 0;
            chatListItem3.Bounds = new System.Drawing.Rectangle(0, 107, 272, 25);
            chatListItem3.IsTwinkleHide = false;
            chatListItem3.OwnerChatListBox = this.chatListBox;
            chatListItem3.Tag = null;
            chatListItem3.Text = "黑名单";
            chatListItem3.TwinkleSubItemNumber = 0;
            this.chatListBox.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem1,
            chatListItem2,
            chatListItem3});
            this.chatListBox.ListSubItemMenu = null;
            this.chatListBox.Location = new System.Drawing.Point(4, 30);
            this.chatListBox.Name = "chatListBox";
            this.chatListBox.SelectSubItem = null;
            this.chatListBox.Size = new System.Drawing.Size(272, 493);
            this.chatListBox.SubItemMenu = null;
            this.chatListBox.TabIndex = 0;
            this.chatListBox.DoubleClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.chatListBox_DoubleClickSubItem);
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
            this.Controls.Add(this.chatListBox);
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
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.ChatListBox chatListBox;

    }
}