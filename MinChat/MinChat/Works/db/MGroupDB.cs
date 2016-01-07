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
            string path = Environment.CurrentDirectory + "\\db\\" + userId;
            string dbPath = path + "\\mgroup.db";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            if (!System.IO.File.Exists(dbPath))
            {
                System.IO.File.Create(dbPath);
            }
            conn = new SQLiteConnection("Data Source=" + dbPath);
            string cmdString = "CREATE TABLE IF NOT EXISTS mgroup(mGroupId integer, mGroupName varchar(40), num integer)";
            conn.Open();
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
            conn.Close();
        }
        public bool addMGroup(MGroup mg){
            string cmdString = "INSERT INTO mgroup VALUES(" +
                mg.MGroupId + "," +
                mg.MGroupName + "," +
                mg.Num + "," + ");";
            conn.Open();
            SQLiteCommand cmdAddMGroup = new SQLiteCommand(cmdString, conn);
            cmdAddMGroup.ExecuteNonQuery();
            cmdAddMGroup.Dispose();
            conn.Close();
            return true;
        }
        public bool deleteMGroup(string mGroupName)
        {
            string cmdString = "DELETE FROM mgroup WHERE mGroupName =" + mGroupName + ";";
            conn.Open();
            SQLiteCommand sqlDeleteMGroup = new SQLiteCommand(cmdString, conn);
            sqlDeleteMGroup.ExecuteNonQuery();
            sqlDeleteMGroup.Dispose();
            conn.Close();
            return true;
        }
    }
}
