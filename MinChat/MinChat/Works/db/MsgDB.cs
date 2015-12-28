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
        public static MsgDB OpenDB(string userId)
        {
            if (null == uniqueInstance)
            {
                uniqueInstance = new MsgDB(userId);
            }
            return uniqueInstance;
        }
        private MsgDB(string userId)
        {
            string dbPath = Environment.CurrentDirectory + "/db/" + userId + "/group.db";
            conn = new SQLiteConnection(dbPath);
            string cmdString = @"CREATE TABLE IF NOT EXISTS msg(msgId integer,sessionId integer, senderId varchar(20), receiverId varchar(20), senderName varchar(40), type integer,
content text, isComing integer, date date, time time, isRead integer, bak1 text, bak2 text, bak3 text, bak4 text, bak5 text, bak6 text);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
        }
        public bool readMsg()
        {
            return true;
        }
        public bool addMsg(Msg m)
        {
            return true;
        }
        public bool deleteMsg()
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
