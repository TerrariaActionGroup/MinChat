using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinChat.Works.util
{
    class SystemMsgUtil
    {
        private static List<string> friendAlarms = new List<string>();
        private static int systemAlarms;

        /// <summary>
        /// 新来的消息放入到系统消息队列中
        /// </summary>
        /// <param name="userId"></param>
        public static void putMsg(string userId)
        {
            //如果是系统通知的消息
            if (userId.Equals("10000") == true)
            {
                systemAlarms++;
            }   
            else
            {
                //删除队列中已经含有该用户发来的消息
                friendAlarms.Remove(userId);
                friendAlarms.Insert(0, userId);
            }
        }

        /// <summary>
        /// 获得最新的系统消息
        /// </summary>
        /// <returns></returns>
        public static string getNewestMsg()
        {
            if (friendAlarms.Count > 0)
            {
                return getMsgUserId();
            }
            else if(systemAlarms > 0)
            {
                return "10000";
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 查看下一条提醒消息
        /// </summary>
        /// <returns></returns>
        public static string checkNext()
        {
            if (friendAlarms.Count > 0)
            {
                return friendAlarms[0];
            }
            else if (systemAlarms > 0)
            {
                return "10000";
            }
            return null;
        }

        /// <summary>
        /// 查看下一条提醒消息
        /// </summary>
        /// <returns></returns>
        public static string checkNext()
        {
            if (friendAlarms.Count > 0)
            {
                return friendAlarms[0];
            }
            else if (systemAlarms > 0)
            {
                return "10000";
            }
            return null;
        }

        /// <summary>
        /// 获得用户发来消息队列中的消息
        /// </summary>
        /// <returns></returns>
        public static string getMsgUserId()
        {
            if (friendAlarms.Count > 0)
            {
                string userID = friendAlarms[0];
                friendAlarms.RemoveAt(0);
                return userID;
            }
            return null;
        }

        /// <summary>
        /// 获得系统消息队列中的消息
        /// </summary>
        /// <returns></returns>
        public static string getSystemUserId()
        {
            if (systemAlarms > 0)
            {
                systemAlarms--;
                return "10000";
            }
            return null;
        }

        /// <summary>
        /// 删除用户发来消息队列中某个用户的消息
        /// </summary>
        /// <param name="userId"></param>
        public static void delFriendAlarm(string userId)
        {
            friendAlarms.Remove(userId);
        }

        /// <summary>
        /// 减少一条系统提醒
        /// </summary>
        public static void decreSystemAlarm()
        {
            if(systemAlarms > 0)
                systemAlarms--;
        }

        /// <summary>
        /// 清空所有提醒
        /// </summary>
        public static void clearAlarms(){
            friendAlarms.Clear();
            systemAlarms = 0;
        }
    }
}
