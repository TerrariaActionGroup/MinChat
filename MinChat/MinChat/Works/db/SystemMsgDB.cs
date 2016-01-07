using MinChat.Communications.bean;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace MinChat.Works.db
{
    class SystemMsgDB
    {
        private string userId;
        public static SystemMsgDB instance = null;
        protected SQLiteConnection conn;

        /// <summary>
        /// 打开数据库
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static SystemMsgDB OpenSysMsgDB(string userId)
        {
            if (instance == null)
            {
                instance = new SystemMsgDB(userId);
            }
            return instance;
        }

        public SystemMsgDB(string userId)
        {
            this.userId = userId;
            string path = Environment.CurrentDirectory + "\\db\\" + userId;
            string dbPath = path + "\\sysmsg.db";
            if (System.IO.Directory.Exists(path) == false)//不存在目录则创建
            {
                System.IO.Directory.CreateDirectory(path);
            }

            if (System.IO.File.Exists(dbPath) == false)
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            conn = new SQLiteConnection("Data Source=" + dbPath);
            conn.Open();
            string cmdString = "CREATE TABLE IF NOT EXISTS sysmsg(msgId integer PRIMARY KEY AUTOINCREMENT,type integer, content varchar(128), isRead integer, bak1 text);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
            conn.Close();
        }

        /// <summary>
        /// 添加系统消息
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool addSystemMsg(string content, int type)
        {
            string cmdString = @"INSERT INTO sysmsg (type, content, isRead, bak1)" +
                    " VALUES (" +
                type + "," +
                "'" + content + "'" + "," +
                0 + "," +
                "''"+  
                ");";
            conn.Open();
            SQLiteCommand sqlAddMsg = new SQLiteCommand(cmdString, conn);
            sqlAddMsg.ExecuteNonQuery();
            sqlAddMsg.Dispose();
            conn.Close();
            return true;
        }

        /// <summary>
        /// 获得最新的系统消息
        /// </summary>
        /// <returns></returns>
        public SysMsg getASysMsg()
        {
            string msgId;
            string cmdString = "SELECT * FROM sysmsg where isRead = 0 order by msgId desc limit 1;";
            conn.Open();
            SQLiteCommand sql = new SQLiteCommand(cmdString, conn);
            SQLiteDataReader result = sql.ExecuteReader();
            if (result.Read())
            {
                SysMsg sysMsg = new SysMsg();
                msgId = result[0].ToString();
                sysMsg.Type = int.Parse(result[1].ToString());
                sysMsg.Content = result[2].ToString();
                result.Close();
                sql.CommandText = "UPDATE sysmsg SET isRead = 1 WHERE msgId=" + msgId + ";";
                sql.ExecuteNonQuery();
                sql.Dispose();
                conn.Close();
                return sysMsg;
            }
            else//没有结果
            {
                result.Close();
                sql.Dispose();
                conn.Close();
                return null;
            }
        }
    }
}
