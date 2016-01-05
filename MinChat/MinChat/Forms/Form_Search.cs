using CCWin;
using CCWin.SkinControl;
using ESPlus.Application;
using ESPlus.Rapid;
using MinChat.Communications;
using MinChat.Forms.DerivedClass;
using MinChat.Settings;
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
        
        CallbackHandler ReceiveUserList = new CallbackHandler(diaplayUser);//实例化收到消息时回调方法的委托
        #endregion
        
        public Form_Search(IRapidPassiveEngine rapidPassiveEngine, ChatListSubItem myInfo)
        {
            this.myInfo = myInfo;
            this.rapidPassiveEngine = rapidPassiveEngine;
            InitializeComponent();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            object tag=new object();
            string msg = searchId.Text;
            this.rapidPassiveEngine.CustomizeOutter.Query(null, Constant.MSG_QUERYUSER, System.Text.Encoding.UTF8.GetBytes(msg), ReceiveUserList, tag);
        }
        
        //返回消息时回调的方法
        public static void diaplayUser(Exception ee, byte[] response, object tag)
        {
            //string info = System.Text.Encoding.UTF8.GetString(response);

            //ChatListItem gp = new ChatListItem();//新建一个组
            //gp.Text = "查询结果";
            ////获取在线用户的ID
            //List<string> list = ;
            //foreach (string user in list)
            //{
            //    string[] userinfo = Regex.Split(user, Constant.SPLIT, RegexOptions.IgnoreCase);
            //}
            //chatListBox_contacts.Items.Add(gp);//添加到listBox中
        }
        
    }
}
