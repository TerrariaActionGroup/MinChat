using ESPlus.Application.CustomizeInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinChatServer.db.bean;
using System.Text.RegularExpressions;
using MinChatServer.db.dao;
using MinChat.Works.util;
using System.Windows.Forms;
using ESFramework.Server.UserManagement;
using ESPlus.Rapid;

namespace MinChatServer.es
{
    public class CustomizeHandler : ICustomizeHandler
    {
        //数据库操作对象
        GroupDBManager groupDBManager = null;
        UserDBManager userDBManager = null;

        //引擎对象以及在线用户管理器
        private IRapidServerEngine engin = null;
        //在线用户管理器。
        private IUserManager userManager;
        public IUserManager UserManager
        {
            set { userManager = value; }
        }


        public CustomizeHandler(IRapidServerEngine serverEngine)
        {
            //初始化时获得操纵数据库对象,保证不为空
            groupDBManager = GroupDBManager.getInstance();
            userDBManager = UserDBManager.getInstance();
            //获得引擎
            this.engin = serverEngine;
        }

        /// <summary>
        /// 处理来自客户端的消息。
        /// </summary> 
        public void HandleInformation(string sourceUserID, int informationType, byte[] info)
        {
            string friendID;
            switch (informationType)
            {
                case Constant.MSG_OFFLINEMSGTEXT:   //离线文本消息.解析：接收者ID SPLIT 消息内容（不拆分）
                    string message = System.Text.Encoding.UTF8.GetString(info);
                    string[] msgs = Regex.Split(message, Constant.SPLIT, RegexOptions.IgnoreCase);
                    //插入未读消息
                    userDBManager.addMsg(msgs[0], msgs[1], Constant.MSG_OFFLINEMSGTEXT);
                    break;

                case Constant.MSG_OFFLINEMSGIMG:    //离线图片消息.解析：接收者ID SPLIT 消息内容（不拆分）
                    string message2 = System.Text.Encoding.UTF8.GetString(info);
                    string[] msgs2 = Regex.Split(message2, Constant.SPLIT, RegexOptions.IgnoreCase);
                    //插入未读消息
                    userDBManager.addMsg(msgs2[0], msgs2[1], Constant.MSG_OFFLINEMSGIMG);
                    break;

                case Constant.MSG_ADDFRIEND_APPLY:    //申请添加好友。解析：另一方ID
                    friendID = System.Text.Encoding.UTF8.GetString(info);
                    byte[] applyUserData = null;
                    User apply_user = userDBManager.queryUser(sourceUserID);
                    string data = User.UserData2String(apply_user);
                    applyUserData = System.Text.Encoding.UTF8.GetBytes(data);
                    if (userManager.IsUserOnLine(friendID) == true)     //如果申请的用户在线,直接发送
                    {
                        this.engin.CustomizeController.Send(friendID, Constant.MSG_ADDFRIEND_APPLY, applyUserData);
                    }
                    else
                    {
                        userDBManager.addMsg(friendID, data, Constant.MSG_ADDFRIEND_APPLY);
                    }
                    break;

                case Constant.MSG_ADDFRIEND_AGREE:     //同意添加好友。解析：另一方ID
                    friendID = System.Text.Encoding.UTF8.GetString(info);
                    userDBManager.addFriend(sourceUserID, friendID);
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// 处理来自客户端的同步调用请求。
        /// </summary>       
        public byte[] HandleQuery(string sourceUserID, int informationType, byte[] info)
        {
            string friendID;
            User user;
            string userData;

            switch (informationType)
            {
                case Constant.MSG_QUERYUSER:   //查找好友
                    friendID = System.Text.Encoding.UTF8.GetString(info);

                    user = userDBManager.queryUser(friendID);
                    userData = User.UserData2String(user);
                    
                    List<string> query_data = new List<string>();
                    query_data.Add(userData);
                    return ObjSerial.serializeObject(query_data);
                    break;

                default:
                    break;
            }
            return null;
        } 
    }
}
