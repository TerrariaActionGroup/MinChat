using ESBasic;
using ESFramework.Server.UserManagement;
using ESPlus.Application.Basic.Server;
using ESPlus.Rapid;
using MinChatServer.db.bean;
using MinChatServer.db.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MinChatServer.es
{
    public class BasicHandler : IBasicHandler
    {
        #region UserManager
        /// <summary>
        /// 在线用户管理器。
        /// </summary> 
        private IUserManager userManager;
        public IUserManager UserManager
        {
            set { userManager = value; }
        }

        //服务端引擎
        IRapidServerEngine engine = null;      

        //数据库操纵对象
        UserDBManager userDBManager = null;

        #endregion

        /// <summary>
        /// 初始化基础功能
        /// </summary>
        /// <param name="engine"></param>
        public void InitBasicFunction(IRapidServerEngine serverEngine)
        {
            this.engine = serverEngine;
            this.userDBManager = UserDBManager.getInstance();

            //用户上线事件
            this.engine.UserManager.SomeOneConnected += new CbGeneric<UserData>(SomeOneConnect);
        }

        /// <summary>
        /// 此处验证用户的账号和密码。返回true表示通过验证。
        /// </summary>  
        public bool VerifyUser(string systemToken, string userID, string password, out string failureCause)
        {
            UserDBManager userDBManager = UserDBManager.getInstance();
            if (userDBManager.varifyUser(userID, password) == false)
            {
                failureCause = "账号或密码错误";
                return false;
            }
            failureCause = "";
            return true;
        }

        /// <summary>
        /// 处理用户上线事件
        /// </summary>
        /// <param name="userData"></param>
        private void SomeOneConnect(UserData userData){
            //获得UserID
            string userID = userData.UserID;
            //转发其离线消息
            List<string> msgs = userDBManager.queryMsgs(userID);
            if (msgs.Count > 0)
            {
                foreach (string s in msgs)
                {
                    //得到：类型号 SPLIT 内容
                    string[] msg = Regex.Split(s, Constant.SPLIT, RegexOptions.IgnoreCase);
                    int infoType = int.Parse(msg[1]);
                    if (infoType == 2)        //图片消息
                    {
                        byte[] info = System.Text.Encoding.UTF8.GetBytes(msg[0]);
                        CbGeneric<byte[], string> cb = new CbGeneric<byte[], string>(this.SendBlobThread);
                        cb.BeginInvoke(info, userID, null, null);
                    }
                    else                      //文本格式消息，不单纯是文本消息
                    {
                        byte[] info = System.Text.Encoding.UTF8.GetBytes(msg[0]);
                        this.engine.CustomizeController.Send(userID, infoType, info);
                    }
                }
                //清空未读消息
                userDBManager.deleteMsg(userID);
            }
        }

        /// <summary>
        /// 异步调用的方式
        /// </summary>
        /// <param name="blob"></param>
        /// <param name="destUserID"></param>
        private void SendBlobThread(byte[] blob, string destUserID)
        {
            this.engine.CustomizeController.SendBlob(destUserID, 2, blob, 2048);
        }
    }
}
