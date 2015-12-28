using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MinChat.Works
{
    class MGroupDB
    {
        protected SQLiteConnection conn;
        public MGroupDB(string userId)
        {
            string dbPath = Environment.CurrentDirectory + "/db/" + userId + "/mgroup.db";
            conn = new SQLiteConnection(dbPath);
            string cmdString = "CREATE TABLE IF NOT EXISTS mgroup(mGroupId integer, mGroupName varchar(40), num integer);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
        }
        public ~MGroupDB()
        {
            conn.Close();
        }
        public bool addMGroup(string mGroupName){
            return true;
        }
        public bool deleteMGroup(string mGroupName)
        {
            return true;
        }

    }
}
