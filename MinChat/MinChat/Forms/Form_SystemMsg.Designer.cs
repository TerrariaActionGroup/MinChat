namespace MinChat.Forms
{
    partial class Form_SystemMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SystemMsg));
            this.pnlImgTx = new CCWin.SkinControl.SkinPanel();
            this.lbl_userInfo = new CCWin.SkinControl.SkinLabel();
            this.btn_yes = new CCWin.SkinControl.SkinButton();
            this.btn_ignore = new CCWin.SkinControl.SkinButton();
            this.radioBtn_agree = new CCWin.SkinControl.SkinRadioButton();
            this.radioBtn_refuse = new CCWin.SkinControl.SkinRadioButton();
            this.txbBox_Msg = new CCWin.SkinControl.SkinTextBox();
            this.lbl_userName = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // pnlImgTx
            // 
            this.pnlImgTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlImgTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImgTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlImgTx.DownBack = null;
            this.pnlImgTx.Location = new System.Drawing.Point(29, 47);
            this.pnlImgTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImgTx.MouseBack = null;
            this.pnlImgTx.Name = "pnlImgTx";
            this.pnlImgTx.NormlBack = ((System.Drawing.Image)(resources.GetObject("pnlImgTx.NormlBack")));
            this.pnlImgTx.Radius = 4;
            this.pnlImgTx.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.pnlImgTx.Size = new System.Drawing.Size(80, 80);
            this.pnlImgTx.TabIndex = 14;
            // 
            // lbl_userInfo
            // 
            this.lbl_userInfo.AutoSize = true;
            this.lbl_userInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userInfo.BorderColor = System.Drawing.Color.White;
            this.lbl_userInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_userInfo.Location = new System.Drawing.Point(26, 136);
            this.lbl_userInfo.Name = "lbl_userInfo";
            this.lbl_userInfo.Size = new System.Drawing.Size(20, 17);
            this.lbl_userInfo.TabIndex = 0;
            this.lbl_userInfo.Text = "xx";
            // 
            // btn_yes
            // 
            this.btn_yes.BackColor = System.Drawing.Color.Transparent;
            this.btn_yes.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_yes.DownBack = null;
            this.btn_yes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_yes.Location = new System.Drawing.Point(254, 248);
            this.btn_yes.MouseBack = null;
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.NormlBack = null;
            this.btn_yes.Size = new System.Drawing.Size(75, 23);
            this.btn_yes.TabIndex = 15;
            this.btn_yes.Text = "确定";
            this.btn_yes.UseVisualStyleBackColor = false;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_ignore
            // 
            this.btn_ignore.BackColor = System.Drawing.Color.Transparent;
            this.btn_ignore.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_ignore.DownBack = null;
            this.btn_ignore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ignore.Location = new System.Drawing.Point(335, 248);
            this.btn_ignore.MouseBack = null;
            this.btn_ignore.Name = "btn_ignore";
            this.btn_ignore.NormlBack = null;
            this.btn_ignore.Size = new System.Drawing.Size(75, 23);
            this.btn_ignore.TabIndex = 16;
            this.btn_ignore.Text = "忽略";
            this.btn_ignore.UseVisualStyleBackColor = false;
            this.btn_ignore.Click += new System.EventHandler(this.btn_ignore_Click);
            // 
            // radioBtn_agree
            // 
            this.radioBtn_agree.AutoSize = true;
            this.radioBtn_agree.BackColor = System.Drawing.Color.Transparent;
            this.radioBtn_agree.Checked = true;
            this.radioBtn_agree.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.radioBtn_agree.DownBack = null;
            this.radioBtn_agree.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtn_agree.Location = new System.Drawing.Point(165, 132);
            this.radioBtn_agree.MouseBack = null;
            this.radioBtn_agree.Name = "radioBtn_agree";
            this.radioBtn_agree.NormlBack = null;
            this.radioBtn_agree.SelectedDownBack = null;
            this.radioBtn_agree.SelectedMouseBack = null;
            this.radioBtn_agree.SelectedNormlBack = null;
            this.radioBtn_agree.Size = new System.Drawing.Size(50, 21);
            this.radioBtn_agree.TabIndex = 17;
            this.radioBtn_agree.TabStop = true;
            this.radioBtn_agree.Text = "同意";
            this.radioBtn_agree.UseVisualStyleBackColor = false;
            // 
            // radioBtn_refuse
            // 
            this.radioBtn_refuse.AutoSize = true;
            this.radioBtn_refuse.BackColor = System.Drawing.Color.Transparent;
            this.radioBtn_refuse.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.radioBtn_refuse.DownBack = null;
            this.radioBtn_refuse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtn_refuse.Location = new System.Drawing.Point(165, 153);
            this.radioBtn_refuse.MouseBack = null;
            this.radioBtn_refuse.Name = "radioBtn_refuse";
            this.radioBtn_refuse.NormlBack = null;
            this.radioBtn_refuse.SelectedDownBack = null;
            this.radioBtn_refuse.SelectedMouseBack = null;
            this.radioBtn_refuse.SelectedNormlBack = null;
            this.radioBtn_refuse.Size = new System.Drawing.Size(50, 21);
            this.radioBtn_refuse.TabIndex = 18;
            this.radioBtn_refuse.Text = "拒绝";
            this.radioBtn_refuse.UseVisualStyleBackColor = false;
            // 
            // txbBox_Msg
            // 
            this.txbBox_Msg.BackColor = System.Drawing.Color.Transparent;
            this.txbBox_Msg.DownBack = null;
            this.txbBox_Msg.Icon = null;
            this.txbBox_Msg.IconIsButton = false;
            this.txbBox_Msg.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txbBox_Msg.IsPasswordChat = '\0';
            this.txbBox_Msg.IsSystemPasswordChar = false;
            this.txbBox_Msg.Lines = new string[0];
            this.txbBox_Msg.Location = new System.Drawing.Point(165, 63);
            this.txbBox_Msg.Margin = new System.Windows.Forms.Padding(0);
            this.txbBox_Msg.MaxLength = 32767;
            this.txbBox_Msg.MinimumSize = new System.Drawing.Size(28, 28);
            this.txbBox_Msg.MouseBack = null;
            this.txbBox_Msg.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txbBox_Msg.Multiline = true;
            this.txbBox_Msg.Name = "txbBox_Msg";
            this.txbBox_Msg.NormlBack = null;
            this.txbBox_Msg.Padding = new System.Windows.Forms.Padding(5);
            this.txbBox_Msg.ReadOnly = false;
            this.txbBox_Msg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBox_Msg.Size = new System.Drawing.Size(201, 64);
            // 
            // 
            // 
            this.txbBox_Msg.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBox_Msg.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbBox_Msg.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txbBox_Msg.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txbBox_Msg.SkinTxt.Multiline = true;
            this.txbBox_Msg.SkinTxt.Name = "BaseText";
            this.txbBox_Msg.SkinTxt.Size = new System.Drawing.Size(191, 54);
            this.txbBox_Msg.SkinTxt.TabIndex = 0;
            this.txbBox_Msg.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txbBox_Msg.SkinTxt.WaterText = "";
            this.txbBox_Msg.TabIndex = 19;
            this.txbBox_Msg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbBox_Msg.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txbBox_Msg.WaterText = "";
            this.txbBox_Msg.WordWrap = true;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userName.BorderColor = System.Drawing.Color.White;
            this.lbl_userName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_userName.Location = new System.Drawing.Point(168, 37);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(96, 17);
            this.lbl_userName.TabIndex = 20;
            this.lbl_userName.Text = "xx 请求加为好友";
            // 
            // Form_SystemMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 278);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.txbBox_Msg);
            this.Controls.Add(this.radioBtn_refuse);
            this.Controls.Add(this.radioBtn_agree);
            this.Controls.Add(this.btn_ignore);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.lbl_userInfo);
            this.Controls.Add(this.pnlImgTx);
            this.Name = "Form_SystemMsg";
            this.Text = "Form_SystemMsg";
            this.Load += new System.EventHandler(this.Form_SystemMsg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel pnlImgTx;
        private CCWin.SkinControl.SkinLabel lbl_userInfo;
        private CCWin.SkinControl.SkinButton btn_yes;
        private CCWin.SkinControl.SkinButton btn_ignore;
        private CCWin.SkinControl.SkinRadioButton radioBtn_agree;
        private CCWin.SkinControl.SkinRadioButton radioBtn_refuse;
        private CCWin.SkinControl.SkinTextBox txbBox_Msg;
        private CCWin.SkinControl.SkinLabel lbl_userName;
    }
}