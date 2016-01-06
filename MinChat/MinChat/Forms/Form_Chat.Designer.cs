namespace MinChat.Forms
{
    partial class Form_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Chat));
            this.btnSend = new CCWin.SkinControl.SkinButton();
            this.chatBox_history = new System.Windows.Forms.RichTextBox();
            this.chatBoxSend = new System.Windows.Forms.RichTextBox();
            this.pnl_Tool = new CCWin.SkinControl.SkinPanel();
            this.pnl_Tool2 = new CCWin.SkinControl.SkinPanel();
            this.pnl_Tool2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnSend.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSend.DownBack = ((System.Drawing.Image)(resources.GetObject("btnSend.DownBack")));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(502, 8);
            this.btnSend.Margin = new System.Windows.Forms.Padding(0);
            this.btnSend.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnSend.MouseBack")));
            this.btnSend.Name = "btnSend";
            this.btnSend.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnSend.NormlBack")));
            this.btnSend.Palace = true;
            this.btnSend.Radius = 6;
            this.btnSend.RoundStyle = CCWin.SkinClass.RoundStyle.Left;
            this.btnSend.Size = new System.Drawing.Size(61, 24);
            this.btnSend.TabIndex = 136;
            this.btnSend.Text = "发送(&S)";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // chatBox_history
            // 
            this.chatBox_history.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBox_history.BackColor = System.Drawing.Color.White;
            this.chatBox_history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox_history.Location = new System.Drawing.Point(5, 30);
            this.chatBox_history.Margin = new System.Windows.Forms.Padding(0);
            this.chatBox_history.Name = "chatBox_history";
            this.chatBox_history.Size = new System.Drawing.Size(563, 300);
            this.chatBox_history.TabIndex = 137;
            this.chatBox_history.Text = "";
            // 
            // chatBoxSend
            // 
            this.chatBoxSend.BackColor = System.Drawing.Color.White;
            this.chatBoxSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBoxSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatBoxSend.Location = new System.Drawing.Point(5, 364);
            this.chatBoxSend.Margin = new System.Windows.Forms.Padding(0);
            this.chatBoxSend.Name = "chatBoxSend";
            this.chatBoxSend.Size = new System.Drawing.Size(558, 110);
            this.chatBoxSend.TabIndex = 138;
            this.chatBoxSend.Text = "";
            this.chatBoxSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chatBoxSend_KeyPress);
            // 
            // pnl_Tool
            // 
            this.pnl_Tool.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Tool.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnl_Tool.DownBack = null;
            this.pnl_Tool.Location = new System.Drawing.Point(0, 332);
            this.pnl_Tool.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Tool.MouseBack = null;
            this.pnl_Tool.Name = "pnl_Tool";
            this.pnl_Tool.NormlBack = null;
            this.pnl_Tool.Size = new System.Drawing.Size(568, 32);
            this.pnl_Tool.TabIndex = 0;
            // 
            // pnl_Tool2
            // 
            this.pnl_Tool2.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Tool2.Controls.Add(this.btnSend);
            this.pnl_Tool2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnl_Tool2.DownBack = null;
            this.pnl_Tool2.Location = new System.Drawing.Point(0, 474);
            this.pnl_Tool2.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Tool2.MouseBack = null;
            this.pnl_Tool2.Name = "pnl_Tool2";
            this.pnl_Tool2.NormlBack = null;
            this.pnl_Tool2.Size = new System.Drawing.Size(568, 36);
            this.pnl_Tool2.TabIndex = 1;
            // 
            // Form_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CaptionHeight = 26;
            this.ClientSize = new System.Drawing.Size(569, 510);
            this.CloseBoxSize = new System.Drawing.Size(30, 30);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.ControlBoxOffset = new System.Drawing.Point(0, 0);
            this.ControlBoxSpace = 0;
            this.Controls.Add(this.chatBoxSend);
            this.Controls.Add(this.chatBox_history);
            this.Controls.Add(this.pnl_Tool2);
            this.Controls.Add(this.pnl_Tool);
            this.InnerBorderColor = System.Drawing.Color.Maroon;
            this.MaxDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxDownBack")));
            this.MaxMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxMouseBack")));
            this.MaxNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxNormlBack")));
            this.MaxSize = new System.Drawing.Size(30, 30);
            this.MdiAutoScroll = false;
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MinimumSize = new System.Drawing.Size(568, 510);
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(30, 30);
            this.Name = "Form_Chat";
            this.Radius = 2;
            this.RestoreDownBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreDownBack")));
            this.RestoreMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreMouseBack")));
            this.RestoreNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreNormlBack")));
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.Text = "Form_Chat";
            this.TitleOffset = new System.Drawing.Point(0, 0);
            this.Load += new System.EventHandler(this.Form_Chat_Load);
            this.Resize += new System.EventHandler(this.Form_Chat_Resize);
            this.pnl_Tool2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnSend;
        private System.Windows.Forms.RichTextBox chatBox_history;
        private System.Windows.Forms.RichTextBox chatBoxSend;
        private CCWin.SkinControl.SkinPanel pnl_Tool;
        private CCWin.SkinControl.SkinPanel pnl_Tool2;
    }
}