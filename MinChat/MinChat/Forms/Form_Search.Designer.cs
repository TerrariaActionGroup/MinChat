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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Search));
            this.searchId = new CCWin.SkinControl.SkinTextBox();
            this.searchList = new CCWin.SkinControl.ChatListBox();
            this.Btn_search = new CCWin.SkinControl.SkinButton();
            this.btn_add = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
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
            this.searchList.Size = new System.Drawing.Size(623, 242);
            this.searchList.SubItemMenu = null;
            this.searchList.TabIndex = 2;
            // 
            // Btn_search
            // 
            this.Btn_search.BackColor = System.Drawing.Color.Transparent;
            this.Btn_search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_search.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_search.DownBack")));
            this.Btn_search.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_search.ForeColor = System.Drawing.Color.White;
            this.Btn_search.Location = new System.Drawing.Point(390, 68);
            this.Btn_search.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_search.MouseBack")));
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_search.NormlBack")));
            this.Btn_search.Size = new System.Drawing.Size(59, 30);
            this.Btn_search.TabIndex = 4;
            this.Btn_search.TabStop = false;
            this.Btn_search.Text = "查找";
            this.Btn_search.UseVisualStyleBackColor = false;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_add.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_add.DownBack")));
            this.btn_add.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(538, 381);
            this.btn_add.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_add.MouseBack")));
            this.btn_add.Name = "btn_add";
            this.btn_add.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_add.NormlBack")));
            this.btn_add.Size = new System.Drawing.Size(77, 29);
            this.btn_add.TabIndex = 5;
            this.btn_add.TabStop = false;
            this.btn_add.Text = "加为好友";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 417);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.searchId);
            this.Name = "Form_Search";
            this.Text = "查找好友";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox searchId;
        private CCWin.SkinControl.ChatListBox searchList;
        private CCWin.SkinControl.SkinButton Btn_search;
        private CCWin.SkinControl.SkinButton btn_add;

    }
}