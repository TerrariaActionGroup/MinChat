using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MinChat.Communications;

namespace MinChat.Works.db
{
    class SessionDB
    {

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
            string dbPath = Environment.CurrentDirectory + "/db/" + userId + "/group.db";
            conn = new SQLiteConnection(dbPath);
            string cmdString = @"CREATE TABLE IF NOT EXISTS session(sessionId integer, senderId varchar(20), senderName varchar(40), type varchar(40),
content text, date time, notReadCount integer,receiverId varchar(20),isDispose integer);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
        }
        #region 添加会话
        public bool addSession(Session ss){
            string cmdString = @"INSERT TO session VALUES (" +
                ss.getId() + "," +
                ss.getFrom() + "," +
                ss.getFrom_user() + "," +
                ss.getType() + "," +
                ss.getContent() + "," +
                ss.date + "," +
                ss.getNotReadCount() + "," +
                ss.getTo() + "," +
                ss.getIsdispose() + "," +
                ");";
            SQLiteCommand sqlAddSession = new SQLiteCommand(cmdString, conn);
            sqlAddSession.ExecuteNonQuery();
            sqlAddSession.Dispose();
            return true;
        }
        #endregion
        #region 删除会话
        public bool deleteSession(int sessionId)
        {
            string cmdString = "DELETE FROM session WHERE sessionId = " + sessionId + ");";
            SQLiteCommand sqlDeleteSession = new SQLiteCommand(cmdString, conn);
            sqlDeleteSession.ExecuteNonQuery();
            sqlDeleteSession.Dispose();
            return true;
        }
        #endregion
        //public bool readMsg(int sessionId)
        //{

        //    return true;
        //}
        public void Close()
        {
            if (null != conn)
            {
                conn.Close();
                conn = null;
            }
        }
    }
}
