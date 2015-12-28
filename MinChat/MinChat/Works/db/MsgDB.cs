using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MinChat.Communications;

namespace MinChat.Works.db
{
    class MsgDB
    {
        protected SQLiteConnection conn;
        protected static MsgDB uniqueInstance;
        #region 获取数据库
        /// <summary>
        /// 获取数据库，单例
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>数据库引用</returns>
        public static MsgDB OpenDB(string userId)
        {
            if (null == uniqueInstance)
            {
                uniqueInstance = new MsgDB(userId);
            }
            return uniqueInstance;
        }
        #endregion
        #region 构造方法，不会给你用
        /// <summary>
        /// 单例模式的实际构造方法
        /// </summary>
        /// <param name="userId">用户ID</param>
        private MsgDB(string userId)
        {
            string dbPath = Environment.CurrentDirectory + "/db/" + userId + "/group.db";
            conn = new SQLiteConnection(dbPath);
            string cmdString = @"CREATE TABLE IF NOT EXISTS msg(msgId integer,sessionId integer, senderId varchar(20), receiverId varchar(20), senderName varchar(40), type integer,
content text, isComing integer, date time, isRead integer, bak1 text, bak2 text, bak3 text, bak4 text, bak5 text, bak6 text);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
        }
        #endregion
        #region 读消息
        /// <summary>
        /// 把一次会话未读消息标记为已读
        /// </summary>
        /// <param name="sessionId">会话ID</param>
        /// <returns>是否成功</returns>
        public bool readMsg(int sessionId)
        {
            string cmdString = "UPDATE msg SET isRead = 1 WHERE isRead = 0 AND sessionId = " + sessionId + ");";
            SQLiteCommand sqlInsertMsg = new SQLiteCommand(cmdString, conn);
            sqlInsertMsg.ExecuteNonQuery();
            sqlInsertMsg.Dispose();
            return true;
        }
        public bool readMsg(string senderId)
        {
            string cmdString = "UPDATE msg SET isRead = 1 WHERE isRead = 0 AND senderId = " + senderId + ");";
            SQLiteCommand sqlInsertMsg = new SQLiteCommand(cmdString, conn);
            sqlInsertMsg.ExecuteNonQuery();
            sqlInsertMsg.Dispose();
            return true;
        }
        #endregion
        #region 添加消息
        /// <summary>
        /// 向数据库中添加消息
        /// </summary>
        /// <param name="m">消息</param>
        /// <returns>是否成功</returns>
        public bool addMsg(Msg m)
        {
            string cmdString = @"INSERT TO msg VALUES (" +
                m.getMsgId() + "," +
                m.sessionId + "," +
                m.getFromUser() + "," +
                m.getToUser() + "," +
                m.getFromUserName() + "," +
                m.getType() + "," +
                m.getContent() + "," +
                m.getIsComing() + "," +
                m.getDate() + "," + "," +
                m.getIsReaded() + "," +
                m.getBak1() + "," +
                m.getBak2() + "," +
                m.getBak3() + "," +
                m.getBak4() + "," +
                m.getBak5() + "," +
                m.getBak6() + "," +
                ");";
            SQLiteCommand sqlInsertMsg = new SQLiteCommand(cmdString, conn);
            sqlInsertMsg.ExecuteNonQuery();
            sqlInsertMsg.Dispose();
            return true;
        }
        #endregion
        #region 删除消息
        /// <summary>
        /// 删除会话的消息，可能需要以SessionID再次查找群组资料
        /// </summary>
        /// <param name="sessionId">会话ID</param>
        /// <returns>是否成功</returns>
        public bool deleteMsg(int sessionId)
        {
            string cmdString = "DELETE FROM msg WHERE sessionId = " + sessionId + ");";
            SQLiteCommand sqlInsertMsg = new SQLiteCommand(cmdString, conn);
            sqlInsertMsg.ExecuteNonQuery();
            sqlInsertMsg.Dispose();
            return true;
        }
        public bool deleteMsg(int senderId)
        {
            string cmdString = "DELETE FROM msg WHERE senderId = " + senderId + ");";
            SQLiteCommand sqlInsertMsg = new SQLiteCommand(cmdString, conn);
            sqlInsertMsg.ExecuteNonQuery();
            sqlInsertMsg.Dispose();
            return true;
        }
        #endregion
        #region 关闭数据库
        /// <summary>
        /// 关闭数据库连接，务必调用
        /// </summary>
        public void Close()
        {
            if (null != conn)
            {
                conn.Close();
                conn = null;
            }
        }
        #endregion
    }
}
