using CCWin;
using CCWin.SkinControl;
using ESPlus.Application;
using ESPlus.Rapid;
using MinChat.Communications;
using MinChat.Forms.DerivedClass;
using MinChat.Settings;
using MinChat.Works.util;
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
    public partial class Form_Search : Skin_Mac
    {
        #region 变量
        /// <summary>
        /// 用户user
        /// </summary>
        ChatListSubItem myInfo;

        /// <summary>
        /// 客户端引擎
        /// </summary>
        IRapidPassiveEngine rapidPassiveEngine;
        CallbackHandler ReceiveUserList;
        #endregion
        
        public Form_Search(IRapidPassiveEngine rapidPassiveEngine, ChatListSubItem myInfo)
        {
            this.myInfo = myInfo;
            this.rapidPassiveEngine = rapidPassiveEngine;
            this.ReceiveUserList = new CallbackHandler(diaplayUser);//实例化收到消息时回调方法的委托
            InitializeComponent();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            object tag=new object();
            string msg = searchId.Text;
            this.rapidPassiveEngine.CustomizeOutter.Query(null, Constant.MSG_QUERYUSER, System.Text.Encoding.UTF8.GetBytes(msg), ReceiveUserList, tag);
        }
        
        //返回消息时回调的方法
        private void diaplayUser(Exception ee, byte[] response, object tag)
        {
            searchList.Items.Clear();
            //反序列化返回的消息生成list
            ObjSerial<List<string>> se = new ObjSerial<List<string>>();
            List<string> list=se.deserializeBytes(response);

            ChatListItem gp = new ChatListItem();//新建一个组
            gp.Text = "查询结果";
            gp.IsOpen = true;
            ChatListSubItemExtend user = new ChatListSubItemExtend();
            //获取在线用户的ID
            foreach (string srtings in list)
            {
                //string的形式：
                //ID卍昵称卍性别卍生日卍地址卍注册时间
                string[] userInfo = Regex.Split(srtings, Constant.SPLIT, RegexOptions.IgnoreCase);
                user.ID = Convert.ToUInt32(userInfo[0]);
                user.NicName = userInfo[1];
                if(userInfo[2]=="1")
                {
                    user.Sex = ChatListSubItemExtend.UserSex.Man;
                }
                else if(userInfo[2]=="0")
                {
                    user.Sex = ChatListSubItemExtend.UserSex.Women;
                }
                user.Birth = userInfo[3];
                user.Address = userInfo[4];
                user.RegistrationDate = userInfo[5];
                gp.SubItems.Add(user);
            }
            this.searchList.Items.Add(gp);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(searchList.SelectSubItem!=null)
            {
                string id=searchList.SelectSubItem.ID.ToString();
                this.rapidPassiveEngine.CustomizeOutter.Send(Constant.MSG_ADDFRIEND_APPLY, System.Text.Encoding.UTF8.GetBytes(id));
                MessageBox.Show("yes");
            }
        }
        
    }
}
