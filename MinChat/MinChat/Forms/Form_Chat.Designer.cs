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
            this.chatBoxSend = new CCWin.SkinControl.SkinChatRichTextBox();
            this.chatBox_history = new CCWin.SkinControl.SkinChatRichTextBox();
            this.SuspendLayout();
            // 
            // chatBoxSend
            // 
            this.chatBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBoxSend.BackColor = System.Drawing.Color.White;
            this.chatBoxSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBoxSend.ContextMenuMode = CCWin.SkinControl.ChatBoxContextMenuMode.None;
            this.chatBoxSend.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chatBoxSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chatBoxSend.Location = new System.Drawing.Point(7, 306);
            this.chatBoxSend.Name = "chatBoxSend";
            this.chatBoxSend.PopoutImageWhenDoubleClick = false;
            this.chatBoxSend.Size = new System.Drawing.Size(337, 87);
            this.chatBoxSend.TabIndex = 1;
            this.chatBoxSend.Text = "";
            // 
            // chatBox_history
            // 
            this.chatBox_history.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBox_history.BackColor = System.Drawing.Color.White;
            this.chatBox_history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox_history.ContextMenuMode = CCWin.SkinControl.ChatBoxContextMenuMode.None;
            this.chatBox_history.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chatBox_history.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chatBox_history.Location = new System.Drawing.Point(7, 31);
            this.chatBox_history.Name = "chatBox_history";
            this.chatBox_history.PopoutImageWhenDoubleClick = false;
            this.chatBox_history.ReadOnly = true;
            this.chatBox_history.Size = new System.Drawing.Size(337, 267);
            this.chatBox_history.TabIndex = 2;
            this.chatBox_history.Text = "";
            // 
            // Form_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 400);
            this.Controls.Add(this.chatBox_history);
            this.Controls.Add(this.chatBoxSend);
            this.Name = "Form_Chat";
            this.Text = "Form_Chat";
            this.ResumeLayout(false);

        }

        #endregion

        public CCWin.SkinControl.SkinChatRichTextBox chatBoxSend;
        private CCWin.SkinControl.SkinChatRichTextBox chatBox_history;
    }
}