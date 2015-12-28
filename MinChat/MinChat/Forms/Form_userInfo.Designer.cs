namespace MinChat.Forms
{
    partial class Form_userInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_userInfo));
            this.picBox = new CCWin.SkinControl.SkinPictureBox();
            this.lbl_userName = new CCWin.SkinControl.SkinLabel();
            this.lbl_PersonalMsg = new CCWin.SkinControl.SkinLabel();
            this.timShow = new System.Windows.Forms.Timer(this.components);
            this.timMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox.BackgroundImage")));
            this.picBox.Location = new System.Drawing.Point(7, 8);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(80, 130);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userName.BorderColor = System.Drawing.Color.White;
            this.lbl_userName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_userName.Location = new System.Drawing.Point(93, 8);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(113, 21);
            this.lbl_userName.TabIndex = 1;
            this.lbl_userName.Text = "lbl_userName";
            // 
            // lbl_PersonalMsg
            // 
            this.lbl_PersonalMsg.AutoSize = true;
            this.lbl_PersonalMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PersonalMsg.BorderColor = System.Drawing.Color.White;
            this.lbl_PersonalMsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PersonalMsg.Location = new System.Drawing.Point(94, 29);
            this.lbl_PersonalMsg.Name = "lbl_PersonalMsg";
            this.lbl_PersonalMsg.Size = new System.Drawing.Size(103, 17);
            this.lbl_PersonalMsg.TabIndex = 2;
            this.lbl_PersonalMsg.Text = "lbl_PersonalMsg";
            // 
            // timShow
            // 
            this.timShow.Enabled = true;
            this.timShow.Interval = 800;
            // 
            // timMove
            // 
            this.timMove.Interval = 800;
            // 
            // Form_userInfo
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(275, 145);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_PersonalMsg);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.picBox);
            this.Name = "Form_userInfo";
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox picBox;
        private CCWin.SkinControl.SkinLabel lbl_userName;
        private CCWin.SkinControl.SkinLabel lbl_PersonalMsg;

        private System.Windows.Forms.Timer timShow;
        private System.Windows.Forms.Timer timMove;
    }
}