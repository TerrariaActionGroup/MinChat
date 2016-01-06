using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Settings
{
    class Constant
    {
        //服务器相关
        #region
        //public static string serverIP = "114.215.103.65";
        public static string serverIP = "127.0.0.1";
        public static int serverPort = 4530;
        #endregion

        //分隔符
        public static string SPLIT = "卍";

        //自定义消息类型
        #region
        public const int MSGREGISTER = 0;
        public const int MSGTEXT = 1;
        public const int MSGIMG = 2;
        //客户端发给服务器的消息类型
        //客户端发给服务器的消息类型
        public const int MSG_ADDFRIEND_APPLY = 0; //申请添加好友,同步请求
        public const int MSG_ADDFRIEND_AGREE = 13;//同意添加好友
        public const int MSG_DELFRIEND = 10;      //删除好友,同步请求
        public const int MSG_ADDMGROUP = 12;      //新建分组
        public const int MSG_DELMGROUP = 3;       //删除分组
        public const int MSG_MOVEFRIEND = 4;      //移动好友到某个分组
        public const int MSG_AVATAR = 5;          //更换头像,同步请求
        public const int MSG_ADDGROUP = 6;        //添加群组,同步请求
        public const int MSG_DELGROUP = 7;        //删除群组,同步请求
        public const int MSG_LEAVEGROUP = 8;      //退出群组,同步请求
        public const int MSG_JOINGROUP = 9;       //加入群组
        public const int MSG_OFFLINEMSGTEXT = 1;  //离线文本消息
        public const int MSG_OFFLINEMSGIMG = 2;   //离线图片消息
        public const int MSG_QUERYUSER = 11;      //查询用户信息


        #endregion

        //用户数据文件夹,相应路径为
        //DATABASE_PATH + userId + 相应类型路径
        public static string DATABASE_PATH = "data//";
        public static string IMAGE_PATH = "//Image//";
        public static string FILE_PATH = "//FileRecv//";
        public static string DB_PATH = "//db//";
    }
}
