using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MinChat.Communications.bean;

namespace MinChat.Works.db
{
    class FriendDB
    {
        protected string userId;
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
            this.userId = userId; 

            string dbPath = Environment.CurrentDirectory + "/db/" + userId + "/friend.db";
            conn = new SQLiteConnection(dbPath);
            string cmdString = @"CREATE TABLE IF NOT EXISTS friend(userId varchar(20), userName varchar(40), sex integer, age integer, birthday date, remark varchar(40),
address varchar(100), time date, mGroupId integer);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
        }
        public bool addFriend(Friend fr){
            string cmdString = "INSERT TO friend VALUES("+
                fr.userId+","+
                fr.userName+","+
                fr.sex+","+
                fr.age+","+
                fr.birthday+","+
                fr.remark+","+
                fr.address+","+
                fr.time+","+
                fr.mGroupId+");";
            SQLiteCommand cmdAddFriend = new SQLiteCommand(cmdString, conn);
            cmdAddFriend.ExecuteNonQuery();
            cmdAddFriend.Dispose();
            return true;
        }
        public bool deleteFriend(string friendId)
        {
            string cmdString = "DELETE FROM friend WHERE friendId =" + friendId + ";";
            SQLiteCommand sqlDeleteFriend = new SQLiteCommand(cmdString, conn);
            sqlDeleteFriend.ExecuteNonQuery();
            sqlDeleteFriend.Dispose();
            return true;
        }
        public bool changeRemark(string friendId, string newRemark)
        {
            string cmdString = "UPDATE friend SET remark ="+newRemark+
                "WHERE friendId =" + friendId + ";";
            SQLiteCommand sqlChangeRemark = new SQLiteCommand(cmdString, conn);
            sqlChangeRemark.ExecuteNonQuery();
            sqlChangeRemark.Dispose();
            return true;
        }
        public bool changeMGroup(string friendId, string newMGroupName)
        {
            string cmdString = "UPDATE friend SET mGroupName ="+newMGroupName+
                "WHERE friendId =" + friendId + ";";
            SQLiteCommand sqlChangeMGroup = new SQLiteCommand(cmdString, conn);
            sqlChangeMGroup.ExecuteNonQuery();
            sqlChangeMGroup.Dispose();
            return true;
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
