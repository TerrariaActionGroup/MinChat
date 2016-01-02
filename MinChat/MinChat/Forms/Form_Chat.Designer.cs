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
            this.btnSend.Location = new System.Drawing.Point(497, 478);
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
            this.chatBox_history.BackColor = System.Drawing.Color.White;
            this.chatBox_history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox_history.Location = new System.Drawing.Point(7, 35);
            this.chatBox_history.Name = "chatBox_history";
            this.chatBox_history.Size = new System.Drawing.Size(551, 303);
            this.chatBox_history.TabIndex = 137;
            this.chatBox_history.Text = "";
            // 
            // chatBoxSend
            // 
            this.chatBoxSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBoxSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatBoxSend.Location = new System.Drawing.Point(7, 369);
            this.chatBoxSend.Name = "chatBoxSend";
            this.chatBoxSend.Size = new System.Drawing.Size(551, 106);
            this.chatBoxSend.TabIndex = 138;
            this.chatBoxSend.Text = "";
            this.chatBoxSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chatBoxSend_KeyPress);
            // 
            // Form_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(568, 510);
            this.ControlBoxSpace = 0;
            this.Controls.Add(this.chatBoxSend);
            this.Controls.Add(this.chatBox_history);
            this.Controls.Add(this.btnSend);
            this.Name = "Form_Chat";
            this.ShowDrawIcon = false;
            this.Text = "Form_Chat";
            this.Load += new System.EventHandler(this.Form_Chat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnSend;
        private System.Windows.Forms.RichTextBox chatBox_history;
        private System.Windows.Forms.RichTextBox chatBoxSend;
    }
}