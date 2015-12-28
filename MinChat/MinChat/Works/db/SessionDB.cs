using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MinChat.Communications;

namespace MinChat.Works
{
    class SessionDB
    {

        protected SQLiteConnection conn;
        protected static SessionDB uniqueInstance;
        public static SessionDB OpenDB(string userId)
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
content text, date date, time time, notReadCount integer,receiverId varchar(20),isDispose integer);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
        }
        public bool addSession(Session ss){
            return true;
        }
        public bool deleteSession(int sessionId)
        {
            return true;
        }
        public bool readMsg()
        {
            return true;
        }
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
