using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChatServer.db.bean
{
    class Constant
    {
        //数据库路径
        public static string globalDbPath = ".\\data\\globalDb\\";
        public static string groupDbPath = ".\\data\\groupDb\\";
        public static string userDbPath = ".\\data\\userDb\\";

        //客户端发给服务器的消息类型
        public const int MSG_ADDFRIEND = 0;       //添加好友,同步请求
        public const int MSG_DELFRIEND = 1;       //删除好友,同步请求
        public const int MSG_ADDMGROUP = 2;       //新建分组
        public const int MSG_DELMGROUP = 3;       //删除分组
        public const int MSG_MOVEFRIEND = 4;      //移动好友到某个分组
        public const int MSG_AVATAR = 5;          //更换头像,同步请求
        public const int MSG_ADDGROUP = 6;        //添加群组,同步请求
        public const int MSG_DELGROUP = 7;        //删除群组,同步请求
        public const int MSG_LEAVEGROUP = 8;      //退出群组,同步请求
        public const int MSG_JOINGROUP = 9;       //加入群组
        public const int MSG_OFFLINEMSG = 10;     //离线消息
    }
}
