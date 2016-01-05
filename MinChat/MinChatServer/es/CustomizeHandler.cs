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

namespace MinChatServer.es
{
    public class CustomizeHandler : ICustomizeHandler
    {
        //数据库操作对象
        GroupDBManager groupDBManager = null;
        UserDBManager userDBManager = null;

        public CustomizeHandler()
        {
            //初始化时获得操纵数据库对象,保证不为空
            groupDBManager = GroupDBManager.getInstance();
            userDBManager = UserDBManager.getInstance();
        }

        /// <summary>
        /// 处理来自客户端的消息。
        /// </summary> 
        public void HandleInformation(string sourceUserID, int informationType, byte[] info)
        {
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
            switch (informationType)
            {
                case Constant.MSG_ADDFRIEND:    //添加好友。解析：另一方ID
                    friendID = System.Text.Encoding.UTF8.GetString(info);
                    userDBManager.addFriend(sourceUserID, friendID);
                    break;

                case Constant.MSG_DELFRIEND:    //删除好友。解析：另一方ID
                    friendID = System.Text.Encoding.UTF8.GetString(info);
                    userDBManager.deleteFriend(sourceUserID, friendID);
                    break;

                case Constant.MSG_QUERYUSER:   //查找好友
                    friendID = System.Text.Encoding.UTF8.GetString(info);
                    MessageBox.Show("bbb");
                    User user = userDBManager.queryUser(friendID);
                    string userData = User.UserData2String(user);
                    
                    List<string> data = new List<string>();
                    data.Add(userData);
                    return ObjSerial.serializeObject(data);
                    break;

                default:
                    break;
            }
            return null;
        } 
    }
}
