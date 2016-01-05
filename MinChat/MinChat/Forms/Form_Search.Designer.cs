namespace MinChat.Forms
{
    partial class Form_Search
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
            this.Btn_search = new CCWin.SkinControl.SkinButton();
            this.searchId = new CCWin.SkinControl.SkinTextBox();
            this.searchList = new CCWin.SkinControl.ChatListBox();
            this.SuspendLayout();
            // 
            // Btn_search
            // 
            this.Btn_search.BackColor = System.Drawing.Color.White;
            this.Btn_search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_search.DownBack = null;
            this.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_search.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_search.Location = new System.Drawing.Point(400, 64);
            this.Btn_search.MouseBack = null;
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.NormlBack = null;
            this.Btn_search.Size = new System.Drawing.Size(66, 38);
            this.Btn_search.TabIndex = 0;
            this.Btn_search.Text = "查找";
            this.Btn_search.UseVisualStyleBackColor = false;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // searchId
            // 
            this.searchId.BackColor = System.Drawing.Color.Transparent;
            this.searchId.DownBack = null;
            this.searchId.Icon = null;
            this.searchId.IconIsButton = false;
            this.searchId.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.searchId.IsPasswordChat = '\0';
            this.searchId.IsSystemPasswordChar = false;
            this.searchId.Lines = new string[0];
            this.searchId.Location = new System.Drawing.Point(114, 64);
            this.searchId.Margin = new System.Windows.Forms.Padding(0);
            this.searchId.MaxLength = 32767;
            this.searchId.MinimumSize = new System.Drawing.Size(28, 28);
            this.searchId.MouseBack = null;
            this.searchId.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.searchId.Multiline = true;
            this.searchId.Name = "searchId";
            this.searchId.NormlBack = null;
            this.searchId.Padding = new System.Windows.Forms.Padding(5);
            this.searchId.ReadOnly = false;
            this.searchId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchId.Size = new System.Drawing.Size(241, 38);
            // 
            // 
            // 
            this.searchId.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchId.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchId.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchId.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.searchId.SkinTxt.Multiline = true;
            this.searchId.SkinTxt.Name = "BaseText";
            this.searchId.SkinTxt.Size = new System.Drawing.Size(231, 28);
            this.searchId.SkinTxt.TabIndex = 0;
            this.searchId.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.searchId.SkinTxt.WaterText = "";
            this.searchId.TabIndex = 1;
            this.searchId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchId.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.searchId.WaterText = "";
            this.searchId.WordWrap = true;
            // 
            // searchList
            // 
            this.searchList.BackColor = System.Drawing.Color.White;
            this.searchList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchList.ForeColor = System.Drawing.Color.Black;
            this.searchList.FriendsMobile = true;
            this.searchList.ListSubItemMenu = null;
            this.searchList.Location = new System.Drawing.Point(7, 133);
            this.searchList.Name = "searchList";
            this.searchList.SelectSubItem = null;
            this.searchList.Size = new System.Drawing.Size(623, 277);
            this.searchList.SubItemMenu = null;
            this.searchList.TabIndex = 2;
            // 
            // Form_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 417);
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.searchId);
            this.Controls.Add(this.Btn_search);
            this.Name = "Form_Search";
            this.Text = "查找好友";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton Btn_search;
        private CCWin.SkinControl.SkinTextBox searchId;
        private CCWin.SkinControl.ChatListBox searchList;

    }
}