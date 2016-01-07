using CCWin;
using CCWin.SkinControl;
using ESPlus.Rapid;
using MinChat.Communications;
using MinChat.Communications.bean;
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
        string[] userInfo;
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
            SystemMsgDB sysDB = new SystemMsgDB(myInfo.ID.ToString());
            SysMsg sysmsg = sysDB.getASysMsg();
            if (sysmsg != null)
            {
                if (sysmsg.Type == Constant.MSG_ADDFRIEND_APPLY)
                {
                    //ID卍昵称卍性别卍生日卍地址卍注册时间
                    userInfo = Regex.Split(sysmsg.Content, Constant.SPLIT, RegexOptions.IgnoreCase);
                    soucerUserId = userInfo[0];
                    lbl_userInfo.Text = userInfo[0] + "\n" + userInfo[1];
                    lbl_userName.Text = userInfo[1] + " 请求加您为好友";
                }
                else if(sysmsg.Type==Constant.MSG_ADDFRIEND_AGREE)
                {
                    //ID卍昵称卍性别卍生日卍地址卍注册时间
                    userInfo = Regex.Split(sysmsg.Content, Constant.SPLIT, RegexOptions.IgnoreCase);
                    
                    txbBox_Msg.Visible = false;
                    lbl_userInfo.Text = userInfo[0];
                    lbl_userName.Text = "添加" + userInfo[1] + "为好友成功";
                    radioBtn_agree.Visible = false;
                    radioBtn_refuse.Visible = false;
                    btn_yes.Visible = false;
                    btn_ignore.Visible = false;
                }
            }
            else 
            {
                txbBox_Msg.Visible = false;
                lbl_userInfo.Visible = false;
                lbl_userName.Text = "没有未读的系统消息";
                radioBtn_agree.Visible = false;
                radioBtn_refuse.Visible = false;
                btn_yes.Visible = false;
                btn_ignore.Visible = false;
            }
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            if(radioBtn_agree.Checked==true)
            {
                //把好友存进数据库
                Friend fr = new Friend();
                fr.UserId = userInfo[0];
                fr.UserName = userInfo[1];
                fr.Sex = Convert.ToInt32(userInfo[2]);
                fr.Birthday = userInfo[3];
                fr.Address = userInfo[4];
                fr.Time = userInfo[5];

                FriendDB Fdb = FriendDB.OpenDB(myInfo.ID.ToString());
                Fdb.addFriend(fr);

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
