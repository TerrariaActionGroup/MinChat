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
            this.txtId = new CCWin.SkinControl.SkinTextBox();
            this.txtPwd = new CCWin.SkinControl.SkinTextBox();
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.pnlImgTx = new CCWin.SkinControl.SkinPanel();
            this.ckAuto = new CCWin.SkinControl.SkinCheckBox();
            this.ckMen = new CCWin.SkinControl.SkinCheckBox();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu_Tray = new CCWin.SkinControl.SkinContextMenuStrip();
            this.toolShowLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_State = new CCWin.SkinControl.SkinContextMenuStrip();
            this.我在线上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.约吗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.离开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.忙碌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请勿打扰ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.隐身ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Id = new CCWin.SkinControl.SkinContextMenuStrip();
            this.lbl_error = new CCWin.SkinControl.SkinLabel();
            this.menu_Tray.SuspendLayout();
            this.menu_State.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Transparent;
            this.txtId.DownBack = null;
            this.txtId.Icon = null;
            this.txtId.IconIsButton = false;
            this.txtId.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtId.IsPasswordChat = '\0';
            this.txtId.IsSystemPasswordChar = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(69, 174);
            this.txtId.Margin = new System.Windows.Forms.Padding(0);
            this.txtId.MaxLength = 32767;
            this.txtId.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtId.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("txtId.MouseBack")));
            this.txtId.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("txtId.NormlBack")));
            this.txtId.Padding = new System.Windows.Forms.Padding(5);
            this.txtId.ReadOnly = false;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.Size = new System.Drawing.Size(194, 30);
            // 
            // 
            // 
            this.txtId.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtId.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtId.SkinTxt.Multiline = true;
            this.txtId.SkinTxt.Name = "BaseText";
            this.txtId.SkinTxt.Size = new System.Drawing.Size(184, 20);
            this.txtId.SkinTxt.TabIndex = 0;
            this.txtId.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtId.SkinTxt.WaterText = "QQ号码/手机/邮箱";
            this.txtId.SkinTxt.WordWrap = false;
            this.txtId.TabIndex = 1;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtId.WaterText = "QQ号码/手机/邮箱";
            this.txtId.WordWrap = false;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtPwd.DownBack = null;
            this.txtPwd.Icon = null;
            this.txtPwd.IconIsButton = false;
            this.txtPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPwd.IsPasswordChat = '●';
            this.txtPwd.IsSystemPasswordChar = false;
            this.txtPwd.Lines = new string[0];
            this.txtPwd.Location = new System.Drawing.Point(69, 204);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(0);
            this.txtPwd.MaxLength = 32767;
            this.txtPwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPwd.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("txtPwd.MouseBack")));
            this.txtPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPwd.Multiline = false;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("txtPwd.NormlBack")));
            this.txtPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtPwd.ReadOnly = false;
            this.txtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPwd.Size = new System.Drawing.Size(194, 30);
            // 
            // 
            // 
            this.txtPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPwd.SkinTxt.Name = "BaseText";
            this.txtPwd.SkinTxt.PasswordChar = '●';
            this.txtPwd.SkinTxt.Size = new System.Drawing.Size(184, 18);
            this.txtPwd.SkinTxt.TabIndex = 1;
            this.txtPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPwd.SkinTxt.WaterText = "密码";
            this.txtPwd.SkinTxt.WordWrap = false;
            this.txtPwd.TabIndex = 2;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPwd.WaterText = "密码";
            this.txtPwd.WordWrap = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogin.DownBack = ((System.Drawing.Image)(resources.GetObject("btnLogin.DownBack")));
            this.btnLogin.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(70, 267);
            this.btnLogin.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnLogin.MouseBack")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnLogin.NormlBack")));
            this.btnLogin.Size = new System.Drawing.Size(194, 30);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "登 陆";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlImgTx
            // 
            this.pnlImgTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlImgTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImgTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlImgTx.DownBack = null;
            this.pnlImgTx.Location = new System.Drawing.Point(122, 58);
            this.pnlImgTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImgTx.MouseBack = null;
            this.pnlImgTx.Name = "pnlImgTx";
            this.pnlImgTx.NormlBack = ((System.Drawing.Image)(resources.GetObject("pnlImgTx.NormlBack")));
            this.pnlImgTx.Radius = 4;
            this.pnlImgTx.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.pnlImgTx.Size = new System.Drawing.Size(80, 80);
            this.pnlImgTx.TabIndex = 13;
            // 
            // ckAuto
            // 
            this.ckAuto.AutoSize = true;
            this.ckAuto.BackColor = System.Drawing.Color.Transparent;
            this.ckAuto.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ckAuto.DefaultCheckButtonWidth = 13;
            this.ckAuto.DownBack = ((System.Drawing.Image)(resources.GetObject("ckAuto.DownBack")));
            this.ckAuto.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.ckAuto.LightEffect = false;
            this.ckAuto.Location = new System.Drawing.Point(189, 236);
            this.ckAuto.MouseBack = ((System.Drawing.Image)(resources.GetObject("ckAuto.MouseBack")));
            this.ckAuto.Name = "ckAuto";
            this.ckAuto.NormlBack = ((System.Drawing.Image)(resources.GetObject("ckAuto.NormlBack")));
            this.ckAuto.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("ckAuto.SelectedDownBack")));
            this.ckAuto.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("ckAuto.SelectedMouseBack")));
            this.ckAuto.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("ckAuto.SelectedNormlBack")));
            this.ckAuto.Size = new System.Drawing.Size(75, 21);
            this.ckAuto.TabIndex = 4;
            this.ckAuto.TabStop = false;
            this.ckAuto.Text = "自动登录";
            this.ckAuto.UseVisualStyleBackColor = false;
            // 
            // ckMen
            // 
            this.ckMen.AutoSize = true;
            this.ckMen.BackColor = System.Drawing.Color.Transparent;
            this.ckMen.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ckMen.DefaultCheckButtonWidth = 13;
            this.ckMen.DownBack = ((System.Drawing.Image)(resources.GetObject("ckMen.DownBack")));
            this.ckMen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckMen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.ckMen.LightEffect = false;
            this.ckMen.Location = new System.Drawing.Point(69, 236);
            this.ckMen.MouseBack = ((System.Drawing.Image)(resources.GetObject("ckMen.MouseBack")));
            this.ckMen.Name = "ckMen";
            this.ckMen.NormlBack = ((System.Drawing.Image)(resources.GetObject("ckMen.NormlBack")));
            this.ckMen.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("ckMen.SelectedDownBack")));
            this.ckMen.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("ckMen.SelectedMouseBack")));
            this.ckMen.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("ckMen.SelectedNormlBack")));
            this.ckMen.Size = new System.Drawing.Size(75, 21);
            this.ckMen.TabIndex = 3;
            this.ckMen.TabStop = false;
            this.ckMen.Text = "记住密码";
            this.ckMen.UseVisualStyleBackColor = false;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // 隐身ToolStripMenuItem
            // 
            this.隐身ToolStripMenuItem.Name = "隐身ToolStripMenuItem";
            this.隐身ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.隐身ToolStripMenuItem.Text = "隐身";
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
            this.menu_Id.Size = new System.Drawing.Size(61, 4);
            this.menu_Id.SkinAllColor = true;
            this.menu_Id.TitleAnamorphosis = true;
            this.menu_Id.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.menu_Id.TitleRadius = 4;
            this.menu_Id.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error.BorderColor = System.Drawing.Color.White;
            this.lbl_error.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(119, 147);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 17);
            this.lbl_error.TabIndex = 17;
            // 
            // Form_login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackShade = false;
            this.BackToColor = false;
            this.BorderColor = System.Drawing.Color.Transparent;
            this.CanResize = false;
            this.CaptionHeight = 26;
            this.ClientSize = new System.Drawing.Size(330, 330);
            this.CloseBoxSize = new System.Drawing.Size(30, 30);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.ControlBoxOffset = new System.Drawing.Point(0, 0);
            this.ControlBoxSpace = 0;
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.ckMen);
            this.Controls.Add(this.ckAuto);
            this.Controls.Add(this.pnlImgTx);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
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
            this.Text = "Form_login";
            this.TopMost = true;
            this.menu_Tray.ResumeLayout(false);
            this.menu_State.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnLogin;
        private CCWin.SkinControl.SkinTextBox txtId;
        private CCWin.SkinControl.SkinTextBox txtPwd;
        private CCWin.SkinControl.SkinPanel pnlImgTx;
        private CCWin.SkinControl.SkinCheckBox ckAuto;
        private CCWin.SkinControl.SkinCheckBox ckMen;
        private System.Windows.Forms.NotifyIcon tray;
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
        private CCWin.SkinControl.SkinLabel lbl_error;
    }
}