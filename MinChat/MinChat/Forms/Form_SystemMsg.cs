using CCWin;
using ESPlus.Rapid;
using MinChat.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinChat.Forms
{
    public partial class Form_SystemMsg : Skin_Mac
    {
        string userId;
        IRapidPassiveEngine rapidPassiveEngine;
        public Form_SystemMsg(IRapidPassiveEngine rapidPassiveEngine,string id)
        {   
            userId = id;
            this.rapidPassiveEngine = rapidPassiveEngine;
            InitializeComponent();
        }

        private void Form_SystemMsg_Load(object sender, EventArgs e)
        {
            lbl_userInfo.Text = userId;
            lbl_userName.Text = userId + " 请求加您为好友";
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            if(radioBtn_agree.Checked==true)
            {
                rapidPassiveEngine.CustomizeOutter.Send(Constant.MSG_ADDFRIEND_AGREE, System.Text.Encoding.UTF8.GetBytes(userId));
                this.Close();
            }
            else//拒绝
            {
                this.Close();
            }
        }

        private void btn_ignore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
