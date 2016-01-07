using System;
using MinChat.Communications;
using System.Data.SQLite;

namespace MinChat.Works.db
{
    class SessionDB
    {
        protected string userId;
        protected SQLiteConnection conn;
        protected static SessionDB uniqueInstance;
        public static SessionDB OpenSessionDB(string userId)
        {
            if (null == uniqueInstance)
            {
                uniqueInstance = new SessionDB(userId);
            }
            return uniqueInstance;
        }
        public SessionDB(string userId)
        {
            this.userId = userId;
            string path = Environment.CurrentDirectory + "\\db\\" + userId;
            string dbPath = path + "\\session.db";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            if (!System.IO.File.Exists(dbPath))
            {
                System.IO.File.Create(dbPath);
            }
            conn = new SQLiteConnection("Data Source=" + dbPath);

            string cmdString = @"CREATE TABLE IF NOT EXISTS session(sessionId integer, senderId varchar(20), senderName varchar(40), type integer,
content text, date time, notReadCount integer,receiverId varchar(20),isDispose integer);";
            conn.Open();
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
            conn.Close();
        }
        #region 添加会话
        public bool addSession(Session ss){
            string cmdString = @"INSERT INTO session VALUES (" +
                ss.Id + "," +
                ss.From + "," +
                ss.From_user + "," +
                ss.Type + "," +
                ss.Content + "," +
                ss.Date + "," +
                ss.NotReadCount + "," +
                ss.To + "," +
                ss.Isdispose + "," +
                ");";
            conn.Open();
            SQLiteCommand sqlAddSession = new SQLiteCommand(cmdString, conn);
            sqlAddSession.ExecuteNonQuery();
            sqlAddSession.Dispose();
            conn.Close();
            return true;
        }
        #endregion
        #region 删除会话
        public bool deleteSession(int sessionId)
        {
            string cmdString = "DELETE FROM session WHERE sessionId = " + sessionId + ";";
            conn.Open();
            SQLiteCommand sqlDeleteSession = new SQLiteCommand(cmdString, conn);
            sqlDeleteSession.ExecuteNonQuery();
            sqlDeleteSession.Dispose();
            conn.Close();
            return true;
        }
        #endregion
        #region 标记会话消息为已读
        public bool readSessionMsg(int sessionId)
        {
            MsgDB msgdb = MsgDB.OpenMsgDB(userId);
            msgdb.readMsg(sessionId);

            return true;
        }
        #endregion
    }
}
