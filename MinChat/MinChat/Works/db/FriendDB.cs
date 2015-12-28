using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MinChat.Works
{
    class FriendDB
    {
        protected SQLiteConnection conn;
        protected static FriendDB uniqueInstance;
        public static FriendDB OpenDB(string userId)
        {
            if (null == uniqueInstance)
            {
                uniqueInstance = new FriendDB(userId);
            }
            return uniqueInstance;
        }
        public FriendDB(string userId)
        {
            string dbPath = Environment.CurrentDirectory + "/db/" + userId + "/friend.db";
            conn = new SQLiteConnection(dbPath);
            string cmdString = "CREATE TABLE IF NOT EXISTS friend(userId varchar(20), userName varchar(40), sex integer, age integer, birthday date, remark varchar(40), address varchar(100), time date, mGroupId integer);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
        }
        public bool addFriend(string friendId){
            //getUser();
            return true;
        }
        public bool deleteFriend(string friendId)
        {
            return true;
        }
        public bool changeRemark(string friendId, string newRemark)
        {
            return true;
        }
        public bool changeMGroup(string friendId, string newMGroupName)
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
