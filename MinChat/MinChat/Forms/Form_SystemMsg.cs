using CCWin;
using CCWin.SkinControl;
using ESPlus.Rapid;
using MinChat.Communications;
using MinChat.Settings;
using MinChat.Works.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MinChat.Forms
{
    public partial class Form_SystemMsg : Skin_Mac
    {
        string soucerUserId;
        ChatListSubItem myInfo;
        IRapidPassiveEngine rapidPassiveEngine;
        public Form_SystemMsg(IRapidPassiveEngine rapidPassiveEngine, ChatListSubItem myInfo)
        {
            this.myInfo = myInfo;
            this.rapidPassiveEngine = rapidPassiveEngine;
            InitializeComponent();
        }

        private void Form_SystemMsg_Load(object sender, EventArgs e)
        {
            MsgDB db = MsgDB.OpenMsgDB(myInfo.ID.ToString());
            Msg systemMsg=db.readSystemMsg();

            //ID卍昵称卍性别卍生日卍地址卍注册时间
            string[] userInfo = Regex.Split(systemMsg.Content, Constant.SPLIT, RegexOptions.IgnoreCase);

            lbl_userInfo.Text = userInfo[0] + "\n" + userInfo[1];
            lbl_userName.Text = userInfo[1] + " 请求加您为好友";
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            if(radioBtn_agree.Checked==true)
            {
                rapidPassiveEngine.CustomizeOutter.Send(Constant.MSG_ADDFRIEND_AGREE, System.Text.Encoding.UTF8.GetBytes(soucerUserId));
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
