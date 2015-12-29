using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChatServer.db
{
    class DBcolumns
    {
        #region
        /**
         *  用户信息表，全局一张
         */
        public static String TABLE_USER = "table_user";
        public static String USER_ID = "userId";
        public static String USER_PWD = "userPwd";
        public static String USER_NAME = "userName";
        public static String USER_SEX = "userSex";
        public static String USER_AGE = "userAge";
        public static String USER_BIRTHDAY = "userBirthday";
        public static String USER_ADDRESS = "userAddr";
        public static String USER_TIME = "userTime";               //注册时间 

        /**
         *  群组信息表，全局一张总的，每个用户也有自己的
         */
        public static String TABLE_GROUP = "table_group";
        public static String GROUP_ID = "groupId";
        public static String GROUP_NAME = "groupName";
        public static String GROUP_NUM = "groupNum";
        public static String GROUP_TIME = "groupTime";
        public static String GROUP_NOTICE = "groupNotice";
        public static String GROUP_TYPE = "groupType";


        /**
         *  群成员信息表，全个群一张
         */
        public static String TABLE_GROUP_PERSON = "table_group_person";
        public static String GROUP_USER_ID = "groupUserId";
        public static String GROUP_IN_TIME = "groupInTime";
        public static String GROUP_STATU_TYPE = "groupStatuType";             //0为群主，1为管理员，2为普通

        #endregion

        #region
        /**
         * 未读信息表,每个用户一张
         */
        public static String TABLE_MSG = "table_msg";
        public static String MSG_ID = "msg_id";
        public static String MSG_TO = "msg_to";
        public static String MSG_CONTENT = "msg_content";

        /**
         *  好友关系表,每个用户一张
         */
        public static String TABLE_RELATION = "table_relation";
        public static String RELATION_ID = "relationId";
        public static String RELATION_USER_ID = "relation_user_id";    //对方
        public static String FGROUP_ID = "fgroup_id";                  //用户自定义分组
        public static String RELATION_TIME = "relationTime";           //添加好友时间            


        /**
         *  用户好友分组表，每个用户一张
         */
        public static String TABLE_MGROUP = "table_mgroup";
        public static String MGROUP_ID = "mgroup_Id";
        public static String MGROUP_NAME = "mgroup_Name";
        public static String MGROUP_NUM = "mgroup_num";

        #endregion

    }
}
