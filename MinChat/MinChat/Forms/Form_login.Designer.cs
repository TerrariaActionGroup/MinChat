namespace MinChat.Forms
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.TxtId = new CCWin.SkinControl.SkinTextBox();
            this.skinAlphaWaterTextBox1 = new CCWin.SkinControl.SkinAlphaWaterTextBox();
            this.TxtPwd = new CCWin.SkinControl.SkinTextBox();
            this.BtnLogin = new CCWin.SkinControl.SkinButton();
            this.PnlImgTx = new CCWin.SkinControl.SkinPanel();
            this.btnState = new CCWin.SkinControl.SkinButton();
            this.CkAuto = new CCWin.SkinControl.SkinCheckBox();
            this.CkMen = new CCWin.SkinControl.SkinCheckBox();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu_Tray = new CCWin.SkinControl.SkinContextMenuStrip();
            this.toolShowLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_State = new CCWin.SkinControl.SkinContextMenuStrip();
            this.我在线上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.约吗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.离开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.忙碌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请勿打扰ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐身ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Id = new CCWin.SkinControl.SkinContextMenuStrip();
            this.TxtId.SuspendLayout();
            this.PnlImgTx.SuspendLayout();
            this.menu_Tray.SuspendLayout();
            this.menu_State.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.Transparent;
            this.TxtId.Controls.Add(this.skinAlphaWaterTextBox1);
            this.TxtId.DownBack = null;
            this.TxtId.Icon = null;
            this.TxtId.IconIsButton = false;
            this.TxtId.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TxtId.IsPasswordChat = '\0';
            this.TxtId.IsSystemPasswordChar = false;
            this.TxtId.Lines = new string[0];
            this.TxtId.Location = new System.Drawing.Point(134, 195);
            this.TxtId.Margin = new System.Windows.Forms.Padding(0);
            this.TxtId.MaxLength = 32767;
            this.TxtId.MinimumSize = new System.Drawing.Size(28, 28);
            this.TxtId.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("TxtId.MouseBack")));
            this.TxtId.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TxtId.Multiline = true;
            this.TxtId.Name = "TxtId";
            this.TxtId.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("TxtId.NormlBack")));
            this.TxtId.Padding = new System.Windows.Forms.Padding(5);
            this.TxtId.ReadOnly = false;
            this.TxtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtId.Size = new System.Drawing.Size(194, 30);
            // 
            // 
            // 
            this.TxtId.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtId.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtId.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TxtId.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TxtId.SkinTxt.Multiline = true;
            this.TxtId.SkinTxt.Name = "BaseText";
            this.TxtId.SkinTxt.Size = new System.Drawing.Size(184, 20);
            this.TxtId.SkinTxt.TabIndex = 0;
            this.TxtId.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TxtId.SkinTxt.WaterText = "QQ号码/手机/邮箱";
            this.TxtId.TabIndex = 9;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtId.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TxtId.WaterText = "QQ号码/手机/邮箱";
            this.TxtId.WordWrap = true;
            // 
            // skinAlphaWaterTextBox1
            // 
            this.skinAlphaWaterTextBox1.BackAlpha = 10;
            this.skinAlphaWaterTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinAlphaWaterTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinAlphaWaterTextBox1.Location = new System.Drawing.Point(65, 9);
            this.skinAlphaWaterTextBox1.Name = "skinAlphaWaterTextBox1";
            this.skinAlphaWaterTextBox1.Size = new System.Drawing.Size(100, 14);
            this.skinAlphaWaterTextBox1.TabIndex = 1;
            this.skinAlphaWaterTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinAlphaWaterTextBox1.WaterFont = new System.Drawing.Font("微软雅黑", 8.5F);
            this.skinAlphaWaterTextBox1.WaterText = "";
            // 
            // TxtPwd
            // 
            this.TxtPwd.BackColor = System.Drawing.Color.Transparent;
            this.TxtPwd.DownBack = null;
            this.TxtPwd.Icon = null;
            this.TxtPwd.IconIsButton = false;
            this.TxtPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TxtPwd.IsPasswordChat = '\0';
            this.TxtPwd.IsSystemPasswordChar = false;
            this.TxtPwd.Lines = new string[0];
            this.TxtPwd.Location = new System.Drawing.Point(134, 225);
            this.TxtPwd.Margin = new System.Windows.Forms.Padding(0);
            this.TxtPwd.MaxLength = 32767;
            this.TxtPwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.TxtPwd.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("TxtPwd.MouseBack")));
            this.TxtPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TxtPwd.Multiline = true;
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("TxtPwd.NormlBack")));
            this.TxtPwd.Padding = new System.Windows.Forms.Padding(5);
            this.TxtPwd.ReadOnly = false;
            this.TxtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPwd.Size = new System.Drawing.Size(194, 30);
            // 
            // 
            // 
            this.TxtPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TxtPwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TxtPwd.SkinTxt.Multiline = true;
            this.TxtPwd.SkinTxt.Name = "BaseText";
            this.TxtPwd.SkinTxt.Size = new System.Drawing.Size(184, 20);
            this.TxtPwd.SkinTxt.TabIndex = 0;
            this.TxtPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TxtPwd.SkinTxt.WaterText = "密码";
            this.TxtPwd.TabIndex = 1;
            this.TxtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TxtPwd.WaterText = "密码";
            this.TxtPwd.WordWrap = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnLogin.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnLogin.DownBack")));
            this.BtnLogin.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(135, 288);
            this.BtnLogin.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnLogin.MouseBack")));
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnLogin.NormlBack")));
            this.BtnLogin.Size = new System.Drawing.Size(194, 30);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "登 陆";
            this.BtnLogin.UseVisualStyleBackColor = false;
            // 
            // PnlImgTx
            // 
            this.PnlImgTx.BackColor = System.Drawing.Color.Transparent;
            this.PnlImgTx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlImgTx.BackgroundImage")));
            this.PnlImgTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlImgTx.Controls.Add(this.btnState);
            this.PnlImgTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.PnlImgTx.DownBack = null;
            this.PnlImgTx.Location = new System.Drawing.Point(44, 195);
            this.PnlImgTx.Margin = new System.Windows.Forms.Padding(0);
            this.PnlImgTx.MouseBack = null;
            this.PnlImgTx.Name = "PnlImgTx";
            this.PnlImgTx.NormlBack = null;
            this.PnlImgTx.Radius = 4;
            this.PnlImgTx.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.PnlImgTx.Size = new System.Drawing.Size(80, 80);
            this.PnlImgTx.TabIndex = 13;
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.Transparent;
            this.btnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnState.BackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.btnState.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnState.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnState.DownBack = ((System.Drawing.Image)(resources.GetObject("btnState.DownBack")));
            this.btnState.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnState.Image = ((System.Drawing.Image)(resources.GetObject("btnState.Image")));
            this.btnState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnState.Location = new System.Drawing.Point(62, 62);
            this.btnState.Margin = new System.Windows.Forms.Padding(0);
            this.btnState.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnState.MouseBack")));
            this.btnState.Name = "btnState";
            this.btnState.NormlBack = null;
            this.btnState.Palace = true;
            this.btnState.Size = new System.Drawing.Size(18, 18);
            this.btnState.TabIndex = 18;
            this.btnState.Tag = "1";
            this.btnState.UseVisualStyleBackColor = false;
            // 
            // CkAuto
            // 
            this.CkAuto.AutoSize = true;
            this.CkAuto.BackColor = System.Drawing.Color.Transparent;
            this.CkAuto.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CkAuto.DefaultCheckButtonWidth = 13;
            this.CkAuto.DownBack = ((System.Drawing.Image)(resources.GetObject("CkAuto.DownBack")));
            this.CkAuto.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CkAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.CkAuto.LightEffect = false;
            this.CkAuto.Location = new System.Drawing.Point(254, 261);
            this.CkAuto.MouseBack = ((System.Drawing.Image)(resources.GetObject("CkAuto.MouseBack")));
            this.CkAuto.Name = "CkAuto";
            this.CkAuto.NormlBack = ((System.Drawing.Image)(resources.GetObject("CkAuto.NormlBack")));
            this.CkAuto.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("CkAuto.SelectedDownBack")));
            this.CkAuto.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("CkAuto.SelectedMouseBack")));
            this.CkAuto.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("CkAuto.SelectedNormlBack")));
            this.CkAuto.Size = new System.Drawing.Size(75, 21);
            this.CkAuto.TabIndex = 15;
            this.CkAuto.Text = "自动登录";
            this.CkAuto.UseVisualStyleBackColor = false;
            // 
            // CkMen
            // 
            this.CkMen.AutoSize = true;
            this.CkMen.BackColor = System.Drawing.Color.Transparent;
            this.CkMen.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CkMen.DefaultCheckButtonWidth = 13;
            this.CkMen.DownBack = ((System.Drawing.Image)(resources.GetObject("CkMen.DownBack")));
            this.CkMen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CkMen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.CkMen.LightEffect = false;
            this.CkMen.Location = new System.Drawing.Point(134, 261);
            this.CkMen.MouseBack = ((System.Drawing.Image)(resources.GetObject("CkMen.MouseBack")));
            this.CkMen.Name = "CkMen";
            this.CkMen.NormlBack = ((System.Drawing.Image)(resources.GetObject("CkMen.NormlBack")));
            this.CkMen.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("CkMen.SelectedDownBack")));
            this.CkMen.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("CkMen.SelectedMouseBack")));
            this.CkMen.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("CkMen.SelectedNormlBack")));
            this.CkMen.Size = new System.Drawing.Size(75, 21);
            this.CkMen.TabIndex = 16;
            this.CkMen.Text = "记住密码";
            this.CkMen.UseVisualStyleBackColor = false;
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.menu_Tray;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "tray";
            this.tray.Visible = true;
            this.tray.DoubleClick += new System.EventHandler(this.toolShowLogin_Click);
            // 
            // menu_Tray
            // 
            this.menu_Tray.Arrow = System.Drawing.Color.Black;
            this.menu_Tray.Back = System.Drawing.Color.White;
            this.menu_Tray.BackRadius = 4;
            this.menu_Tray.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.menu_Tray.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.menu_Tray.Fore = System.Drawing.Color.Black;
            this.menu_Tray.HoverFore = System.Drawing.Color.White;
            this.menu_Tray.ItemAnamorphosis = true;
            this.menu_Tray.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_Tray.ItemBorderShow = true;
            this.menu_Tray.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_Tray.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_Tray.ItemRadius = 4;
            this.menu_Tray.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu_Tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShowLogin,
            this.toolStripSeparator1,
            this.toolExit});
            this.menu_Tray.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_Tray.Name = "Tray_menu";
            this.menu_Tray.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu_Tray.Size = new System.Drawing.Size(137, 54);
            this.menu_Tray.SkinAllColor = true;
            this.menu_Tray.TitleAnamorphosis = true;
            this.menu_Tray.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.menu_Tray.TitleRadius = 4;
            this.menu_Tray.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolShowLogin
            // 
            this.toolShowLogin.Name = "toolShowLogin";
            this.toolShowLogin.Size = new System.Drawing.Size(136, 22);
            this.toolShowLogin.Text = "打开主面板";
            this.toolShowLogin.Click += new System.EventHandler(this.toolShowLogin_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // toolExit
            // 
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(136, 22);
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // menu_State
            // 
            this.menu_State.Arrow = System.Drawing.Color.Black;
            this.menu_State.Back = System.Drawing.Color.White;
            this.menu_State.BackRadius = 4;
            this.menu_State.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.menu_State.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.menu_State.Fore = System.Drawing.Color.Black;
            this.menu_State.HoverFore = System.Drawing.Color.White;
            this.menu_State.ItemAnamorphosis = true;
            this.menu_State.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_State.ItemBorderShow = true;
            this.menu_State.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_State.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_State.ItemRadius = 4;
            this.menu_State.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu_State.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我在线上ToolStripMenuItem,
            this.约吗ToolStripMenuItem,
            this.toolStripSeparator2,
            this.离开ToolStripMenuItem,
            this.忙碌ToolStripMenuItem,
            this.请勿打扰ToolStripMenuItem,
            this.toolStripSeparator3,
            this.隐身ToolStripMenuItem});
            this.menu_State.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_State.Name = "menu_State";
            this.menu_State.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu_State.Size = new System.Drawing.Size(125, 148);
            this.menu_State.SkinAllColor = true;
            this.menu_State.TitleAnamorphosis = true;
            this.menu_State.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.menu_State.TitleRadius = 4;
            this.menu_State.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 我在线上ToolStripMenuItem
            // 
            this.我在线上ToolStripMenuItem.Name = "我在线上ToolStripMenuItem";
            this.我在线上ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.我在线上ToolStripMenuItem.Text = "我在线上";
            // 
            // 约吗ToolStripMenuItem
            // 
            this.约吗ToolStripMenuItem.Name = "约吗ToolStripMenuItem";
            this.约吗ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.约吗ToolStripMenuItem.Text = "约吗";
            // 
            // 离开ToolStripMenuItem
            // 
            this.离开ToolStripMenuItem.Name = "离开ToolStripMenuItem";
            this.离开ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.离开ToolStripMenuItem.Text = "离开";
            // 
            // 忙碌ToolStripMenuItem
            // 
            this.忙碌ToolStripMenuItem.Name = "忙碌ToolStripMenuItem";
            this.忙碌ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.忙碌ToolStripMenuItem.Text = "忙碌";
            // 
            // 请勿打扰ToolStripMenuItem
            // 
            this.请勿打扰ToolStripMenuItem.Name = "请勿打扰ToolStripMenuItem";
            this.请勿打扰ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.请勿打扰ToolStripMenuItem.Text = "请勿打扰";
            // 
            // 隐身ToolStripMenuItem
            // 
            this.隐身ToolStripMenuItem.Name = "隐身ToolStripMenuItem";
            this.隐身ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.隐身ToolStripMenuItem.Text = "隐身";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // menu_Id
            // 
            this.menu_Id.Arrow = System.Drawing.Color.Black;
            this.menu_Id.Back = System.Drawing.Color.White;
            this.menu_Id.BackRadius = 4;
            this.menu_Id.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.menu_Id.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.menu_Id.Fore = System.Drawing.Color.Black;
            this.menu_Id.HoverFore = System.Drawing.Color.White;
            this.menu_Id.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menu_Id.ItemAnamorphosis = true;
            this.menu_Id.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_Id.ItemBorderShow = true;
            this.menu_Id.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_Id.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_Id.ItemRadius = 4;
            this.menu_Id.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu_Id.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_Id.Name = "menu_Id";
            this.menu_Id.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu_Id.Size = new System.Drawing.Size(153, 26);
            this.menu_Id.SkinAllColor = true;
            this.menu_Id.TitleAnamorphosis = true;
            this.menu_Id.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.menu_Id.TitleRadius = 4;
            this.menu_Id.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(178)))), ((int)(((byte)(213)))));
            this.BackShade = false;
            this.BackToColor = false;
            this.BorderColor = System.Drawing.Color.Transparent;
            this.CanResize = false;
            this.CaptionHeight = 30;
            this.ClientSize = new System.Drawing.Size(430, 330);
            this.CloseBoxSize = new System.Drawing.Size(30, 30);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.ControlBoxOffset = new System.Drawing.Point(0, 0);
            this.Controls.Add(this.CkMen);
            this.Controls.Add(this.CkAuto);
            this.Controls.Add(this.PnlImgTx);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPwd);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(30, 30);
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(30, 30);
            this.Name = "Form_login";
            this.Radius = 2;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_login";
            this.TxtId.ResumeLayout(false);
            this.TxtId.PerformLayout();
            this.PnlImgTx.ResumeLayout(false);
            this.menu_Tray.ResumeLayout(false);
            this.menu_State.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton BtnLogin;
        private CCWin.SkinControl.SkinTextBox TxtId;
        private CCWin.SkinControl.SkinTextBox TxtPwd;
        private CCWin.SkinControl.SkinPanel PnlImgTx;
        private CCWin.SkinControl.SkinCheckBox CkAuto;
        private CCWin.SkinControl.SkinCheckBox CkMen;
        private System.Windows.Forms.NotifyIcon tray;
        private CCWin.SkinControl.SkinAlphaWaterTextBox skinAlphaWaterTextBox1;
        private CCWin.SkinControl.SkinButton btnState;
        private CCWin.SkinControl.SkinContextMenuStrip menu_Tray;
        private System.Windows.Forms.ToolStripMenuItem toolShowLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private CCWin.SkinControl.SkinContextMenuStrip menu_State;
        private System.Windows.Forms.ToolStripMenuItem 我在线上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 约吗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 离开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 忙碌ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请勿打扰ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 隐身ToolStripMenuItem;
        private CCWin.SkinControl.SkinContextMenuStrip menu_Id;
    }
}