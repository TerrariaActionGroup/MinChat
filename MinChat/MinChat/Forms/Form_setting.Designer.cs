namespace MinChat.Forms
{
    partial class Form_setting
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
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinRadioButton1 = new CCWin.SkinControl.SkinRadioButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinRadioButton2 = new CCWin.SkinControl.SkinRadioButton();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinRadioButton3 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton4 = new CCWin.SkinControl.SkinRadioButton();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinRadioButton5 = new CCWin.SkinControl.SkinRadioButton();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.skinLabel1.Location = new System.Drawing.Point(7, 45);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(65, 19);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "基本设置";
            this.skinLabel1.Click += new System.EventHandler(this.skinLabel1_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(32, 83);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "登录：";
            // 
            // skinRadioButton1
            // 
            this.skinRadioButton1.AutoSize = true;
            this.skinRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton1.DownBack = null;
            this.skinRadioButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton1.Location = new System.Drawing.Point(91, 81);
            this.skinRadioButton1.MouseBack = null;
            this.skinRadioButton1.Name = "skinRadioButton1";
            this.skinRadioButton1.NormlBack = null;
            this.skinRadioButton1.SelectedDownBack = null;
            this.skinRadioButton1.SelectedMouseBack = null;
            this.skinRadioButton1.SelectedNormlBack = null;
            this.skinRadioButton1.Size = new System.Drawing.Size(158, 21);
            this.skinRadioButton1.TabIndex = 2;
            this.skinRadioButton1.TabStop = true;
            this.skinRadioButton1.Text = "启动MinChat时自动登录";
            this.skinRadioButton1.UseVisualStyleBackColor = false;
            this.skinRadioButton1.CheckedChanged += new System.EventHandler(this.skinRadioButton1_CheckedChanged);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.Black;
            this.skinLabel3.Location = new System.Drawing.Point(20, 131);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 3;
            this.skinLabel3.Text = "主面板：";
            // 
            // skinRadioButton2
            // 
            this.skinRadioButton2.AutoSize = true;
            this.skinRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton2.DownBack = null;
            this.skinRadioButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton2.Location = new System.Drawing.Point(91, 131);
            this.skinRadioButton2.MouseBack = null;
            this.skinRadioButton2.Name = "skinRadioButton2";
            this.skinRadioButton2.NormlBack = null;
            this.skinRadioButton2.SelectedDownBack = null;
            this.skinRadioButton2.SelectedMouseBack = null;
            this.skinRadioButton2.SelectedNormlBack = null;
            this.skinRadioButton2.Size = new System.Drawing.Size(158, 21);
            this.skinRadioButton2.TabIndex = 4;
            this.skinRadioButton2.Text = "始终保持在其他窗口前端";
            this.skinRadioButton2.UseVisualStyleBackColor = false;
            this.skinRadioButton2.CheckedChanged += new System.EventHandler(this.skinRadioButton2_CheckedChanged);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(97, 166);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(92, 17);
            this.skinLabel4.TabIndex = 5;
            this.skinLabel4.Text = "关闭主面板时：";
            // 
            // skinRadioButton3
            // 
            this.skinRadioButton3.AutoSize = true;
            this.skinRadioButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton3.DownBack = null;
            this.skinRadioButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton3.Location = new System.Drawing.Point(116, 186);
            this.skinRadioButton3.MouseBack = null;
            this.skinRadioButton3.Name = "skinRadioButton3";
            this.skinRadioButton3.NormlBack = null;
            this.skinRadioButton3.SelectedDownBack = null;
            this.skinRadioButton3.SelectedMouseBack = null;
            this.skinRadioButton3.SelectedNormlBack = null;
            this.skinRadioButton3.Size = new System.Drawing.Size(146, 21);
            this.skinRadioButton3.TabIndex = 6;
            this.skinRadioButton3.Text = "隐藏到任务栏通知区域";
            this.skinRadioButton3.UseVisualStyleBackColor = false;
            // 
            // skinRadioButton4
            // 
            this.skinRadioButton4.AutoSize = true;
            this.skinRadioButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton4.Checked = true;
            this.skinRadioButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton4.DownBack = null;
            this.skinRadioButton4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton4.Location = new System.Drawing.Point(116, 213);
            this.skinRadioButton4.MouseBack = null;
            this.skinRadioButton4.Name = "skinRadioButton4";
            this.skinRadioButton4.NormlBack = null;
            this.skinRadioButton4.SelectedDownBack = null;
            this.skinRadioButton4.SelectedMouseBack = null;
            this.skinRadioButton4.SelectedNormlBack = null;
            this.skinRadioButton4.Size = new System.Drawing.Size(74, 21);
            this.skinRadioButton4.TabIndex = 7;
            this.skinRadioButton4.TabStop = true;
            this.skinRadioButton4.Text = "退出程序";
            this.skinRadioButton4.UseVisualStyleBackColor = false;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(31, 250);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(44, 17);
            this.skinLabel5.TabIndex = 8;
            this.skinLabel5.Text = "提醒：";
            // 
            // skinRadioButton5
            // 
            this.skinRadioButton5.AutoSize = true;
            this.skinRadioButton5.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton5.DownBack = null;
            this.skinRadioButton5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton5.Location = new System.Drawing.Point(91, 250);
            this.skinRadioButton5.MouseBack = null;
            this.skinRadioButton5.Name = "skinRadioButton5";
            this.skinRadioButton5.NormlBack = null;
            this.skinRadioButton5.SelectedDownBack = null;
            this.skinRadioButton5.SelectedMouseBack = null;
            this.skinRadioButton5.SelectedNormlBack = null;
            this.skinRadioButton5.Size = new System.Drawing.Size(122, 21);
            this.skinRadioButton5.TabIndex = 9;
            this.skinRadioButton5.TabStop = true;
            this.skinRadioButton5.Text = "关闭好友上线提醒";
            this.skinRadioButton5.UseVisualStyleBackColor = false;
            this.skinRadioButton5.CheckedChanged += new System.EventHandler(this.skinRadioButton5_CheckedChanged);
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(7, 301);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(68, 17);
            this.skinLabel6.TabIndex = 10;
            this.skinLabel6.Text = "文件管理：";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(88, 301);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(152, 17);
            this.skinLabel7.TabIndex = 11;
            this.skinLabel7.Text = "默认接收文件保存的文件夹";
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[] {
        "C:/Userdata"};
            this.skinTextBox1.Location = new System.Drawing.Point(79, 333);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = false;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(193, 28);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(183, 18);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.Text = "C:/Userdata";
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 12;
            this.skinTextBox1.Text = "C:/Userdata";
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.Silver;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(91, 375);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 1;
            this.skinButton1.Text = "更改目录";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(197, 375);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(75, 23);
            this.skinButton2.TabIndex = 13;
            this.skinButton2.Text = "打开文件夹";
            this.skinButton2.UseVisualStyleBackColor = false;
            // 
            // Form_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorBottom = System.Drawing.Color.White;
            this.CaptionBackColorTop = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(288, 419);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinTextBox1);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinRadioButton5);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinRadioButton4);
            this.Controls.Add(this.skinRadioButton3);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinRadioButton2);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinRadioButton1);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.MdiBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form_setting";
            this.Text = " ";
            this.TitleColor = System.Drawing.Color.DodgerBlue;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_setting_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton2;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton3;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;

    }
}