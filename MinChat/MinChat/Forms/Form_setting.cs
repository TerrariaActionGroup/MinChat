﻿using CCWin;
using MinChat.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinChat.Forms
{
    public partial class Form_setting : Skin_Mac
    {
        //配置类
        private SystemSettings settings;

        public Form_setting()
        {
            InitializeComponent();
            this.settings = SystemSettings.Singleton;
            initSettings();
        }

        //初始化
        public void initSettings(){
            if (this.settings.AutoLogin == true)
            {
                this.skinRadioButton1.Checked = true;
            }
            if (this.settings.FrontOfOther == true)
            {
                this.skinRadioButton2.Checked = true;
            }
            if (this.settings.FriendOnlineAlarm == true)
            {
                this.skinRadioButton5.Checked = true;
            }
            this.skinTextBox1.Text = settings.FilePath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void skinLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form_setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.settings.Save();
        }

        /// <summary>
        /// 自动登录选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.skinRadioButton1.Checked == true)
            {
                this.settings.AutoLogin = true;
            }
            else
            {
                this.settings.AutoLogin = false;
            }
        }

        //保持在其他窗口前端
        private void skinRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.skinRadioButton2.Checked == true)
            {
                this.settings.FrontOfOther = true;
            }
            else
            {
                this.settings.FrontOfOther = false;
            }
        }

        //好友上线
        private void skinRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.skinRadioButton5.Checked == true)
            {
                this.settings.FriendOnlineAlarm = true;
            }
            else
            {
                this.settings.FriendOnlineAlarm = false;
            }
        }

        //选择文件夹
        private void skinButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.skinTextBox1.Text = fbd.SelectedPath;
                this.settings.FilePath = fbd.SelectedPath;
            }
        }
    }
}
