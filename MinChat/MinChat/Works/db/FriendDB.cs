using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinChat.Communications.bean;
using System.Data.SQLite;
using MinChat.Settings;

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
            string path = Environment.CurrentDirectory + "\\db\\" + userId;
            string dbPath = path + "\\friend.db";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            if (!System.IO.File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }
            conn = new SQLiteConnection("Data Source=" + dbPath);
            string cmdString = @"CREATE TABLE IF NOT EXISTS friend(userId varchar(20) PRIMARY KEY, userName varchar(40), sex integer, age integer, birthday varchar(40), remark varchar(40),
address varchar(100), time varchar(40), mGroupId integer);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString,conn);
            conn.Open();
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
            conn.Close();
        }
        public bool addFriend(Friend fr){
            string cmdString = "INSERT INTO friend VALUES(\'"+
                fr.UserId + "\',\'" +
                fr.UserName + "\'," +
                fr.Sex+","+
                fr.Age + ",\'" +
                fr.Birthday + "\',\'" +
                fr.Remark + "\',\'" +
                fr.Address + "\',\'" +
                fr.Time + "\'," +
                fr.MGroupId+");";
            conn.Open();
            SQLiteCommand cmdAddFriend = new SQLiteCommand(cmdString, conn);

            cmdAddFriend.ExecuteNonQuery();
            cmdAddFriend.Dispose();
            conn.Close();
            return true;
        }
        public bool deleteFriend(string friendId)
        {
            string cmdString = "DELETE FROM friend WHERE userId =" + friendId + ";";
            SQLiteCommand sqlDeleteFriend = new SQLiteCommand(cmdString, conn);
            conn.Open();
            sqlDeleteFriend.ExecuteNonQuery();
            sqlDeleteFriend.Dispose();
            conn.Close();
            return true;
        }
        public bool changeRemark(string friendId, string newRemark)
        {
            string cmdString = "UPDATE friend SET remark =\'"+newRemark+
                "\'WHERE userId =" + friendId + ";";
            SQLiteCommand sqlChangeRemark = new SQLiteCommand(cmdString, conn);
            conn.Open();
            sqlChangeRemark.ExecuteNonQuery();
            sqlChangeRemark.Dispose();
            conn.Close();
            return true;
        }
        public bool changeMGroup(string friendId, string newMGroupName)
        {
            string cmdString = "UPDATE friend SET mGroupName ="+newMGroupName+
                "WHERE friendId =" + friendId + ";";
            SQLiteCommand sqlChangeMGroup = new SQLiteCommand(cmdString, conn);
            conn.Open();
            sqlChangeMGroup.ExecuteNonQuery();
            sqlChangeMGroup.Dispose();
            conn.Open();
            return true;
        }
        public List<Friend> queryFriends()
        {
            string cmdString = "SELECT * FROM friend";
            List<Friend> ls = new List<Friend>();
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Friend fr=new Friend();
                fr.UserId = dr[0].ToString();
                fr.UserName = dr[1].ToString();
                fr.Sex =Convert.ToInt32(dr[2]);
                fr.Age = Convert.ToInt32(dr[3]);
                fr.Birthday = dr[4].ToString();
                fr.Remark = dr[5].ToString();
                fr.Address = dr[6].ToString();
                fr.Time = dr[7].ToString();
                fr.MGroupId = Convert.ToInt32(dr[8]);
                ls.Add(fr);
            }
            conn.Close();
            return ls;
        }
       
    }
}
