﻿using System;
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
        #region 变量
        protected string userId;
        protected SQLiteConnection conn;
        public static MsgDB uniqueInstance;
        #endregion
        #region 获取数据库
        /// <summary>
        /// 获取数据库，单例
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>数据库引用</returns>
        public static MsgDB OpenMsgDB(string userId)
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
            this.userId = userId;
            string path = Environment.CurrentDirectory + "\\db\\" + userId;
            string dbPath = path+"\\msg.db";
            if(System.IO.Directory.Exists(path)==false)//不存在目录则创建
            {
                System.IO.Directory.CreateDirectory(path);
            }
            
            if (System.IO.File.Exists(dbPath)==false)
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            conn = new SQLiteConnection("Data Source="+dbPath);
            conn.Open();
            string cmdString = "CREATE TABLE IF NOT EXISTS msg(msgId integer PRIMARY KEY AUTOINCREMENT,sessionId integer, senderId varchar(20), receiverId varchar(20), senderName varchar(40), type integer,content text, isComing integer, date varchar(40), isRead integer, bak1 text, bak2 text, bak3 text, bak4 text, bak5 text, bak6 text);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
            conn.Close();
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
            string cmdString = "UPDATE msg SET isRead = 1 WHERE isRead = 0 AND sessionId = " + sessionId + ")";
            conn.Open();
            SQLiteCommand sqlReadMsg = new SQLiteCommand(cmdString, conn);
            sqlReadMsg.ExecuteNonQuery();
            sqlReadMsg.Dispose();
            conn.Close();
            return true;
        }
        public List<Msg> readMsg(string senderId, string receiverId)//读取两者之间的所有消息
        {
            string cmdString = "SELECT * FROM msg where senderId =" + senderId + " and receiverId=" + receiverId + " or senderId = " + receiverId + " and receiverId=" + senderId + ";";
            conn.Open();
            SQLiteCommand sql = new SQLiteCommand(cmdString, conn);
            SQLiteDataReader result = sql.ExecuteReader();
            List<Msg> a = new List<Msg>();
            while(result.Read())
            {
                string[] msgs = new string[] { result[3].ToString(), result[2].ToString(), result[6].ToString(), result[8].ToString(), result[4].ToString() };
                Msg aMsg = new Msg(msgs, 1, 1);
                a.Add(aMsg);
            }
            result.Close();
            
            sql.CommandText = "UPDATE msg SET isRead = 1 WHERE isRead = 0 AND senderId = " + senderId + ";";
            sql.ExecuteNonQuery();
            sql.Dispose();
            conn.Close();
            return a;
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
            string cmdString = @"INSERT INTO msg (sessionId, senderId, receiverId, senderName, type, content, isComing,date, isRead, bak1, bak2, bak3, bak4, bak5, bak6)" +
                    " VALUES (" +
                m.SessionId + "," +
                m.FromUserId + "," +
                m.ToUserId + "," +
                "'" + m.FromUserName + "'" + "," +
                m.Type + "," +
                "'" + m.Content + "'" + "," +
                m.IsComing + "," +
                "'" + m.Date + "'" + "," +
                m.IsReaded + "," +
                "'" + m.Bak1 + "'" + "," +
                "'" + m.Bak2 + "'" + "," +
                "'" + m.Bak3 + "'" + "," +
                "'" + m.Bak4 + "'" + "," +
                "'" + m.Bak5 + "'" + "," +
                "'" + m.Bak6 + "'" +
                ");";
            conn.Open();
            SQLiteCommand sqlAddMsg = new SQLiteCommand(cmdString, conn);
            sqlAddMsg.ExecuteNonQuery();
            sqlAddMsg.Dispose();
            conn.Close();
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
            string cmdString = "DELETE FROM msg WHERE sessionId = " + sessionId + ")";
            conn.Open();
            SQLiteCommand sqlDeleteMsg = new SQLiteCommand(cmdString, conn);
            sqlDeleteMsg.ExecuteNonQuery();
            sqlDeleteMsg.Dispose();
            conn.Close();
            return true;
        }
        public bool deleteMsg(string senderId)
        {
            string cmdString = "DELETE FROM msg WHERE senderId = " + senderId + ")";
            conn.Open();
            SQLiteCommand sqlDeleteMsg = new SQLiteCommand(cmdString, conn);
            sqlDeleteMsg.ExecuteNonQuery();
            sqlDeleteMsg.Dispose();
            conn.Close();
            return true;
        }
        #endregion
     
    }
}
