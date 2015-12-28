using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MinChat.Communications.bean;

namespace MinChat.Works.db
{
    class MGroupDB
    {
        protected string userId;
        protected SQLiteConnection conn;
        protected static MGroupDB uniqueInstance;
        public static MGroupDB OpenDB(string userId)
        {
            if (null == uniqueInstance)
            {
                uniqueInstance = new MGroupDB(userId);
            }
            return uniqueInstance;
        }
        public MGroupDB(string userId)
        {
            this.userId = userId; 

            string dbPath = Environment.CurrentDirectory + "/db/" + userId + "/mgroup.db";
            conn = new SQLiteConnection(dbPath);
            string cmdString = "CREATE TABLE IF NOT EXISTS mgroup(mGroupId integer, mGroupName varchar(40), num integer);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
        }
        public bool addMGroup(MGroup mg){
            string cmdString = "INSERT TO mgroup VALUES(" +
                mg.mGroupId + "," +
                mg.mGroupName + "," +
                mg.num + "," + ");";
            SQLiteCommand cmdAddMGroup = new SQLiteCommand(cmdString, conn);
            cmdAddMGroup.ExecuteNonQuery();
            cmdAddMGroup.Dispose();
            return true;
        }
        public bool deleteMGroup(string mGroupName)
        {
            string cmdString = "DELETE FROM mgroup WHERE mGroupName =" + mGroupName + ";";
            SQLiteCommand sqlDeleteMGroup = new SQLiteCommand(cmdString, conn);
            sqlDeleteMGroup.ExecuteNonQuery();
            sqlDeleteMGroup.Dispose();
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
