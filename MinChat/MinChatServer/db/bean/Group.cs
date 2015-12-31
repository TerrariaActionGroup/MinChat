using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChatServer.db.bean
{
    public class Group
    {
        //groupId integer, groupName varchar(40), num integer, time date, notice text, type varchar(20)
        private int groupId;
        private string groupName;
        private int num;
        private string time;
        private string notice;
        private string type;
        #region
        public int GroupId
        {
            get
            {
                return groupId;
            }
            set
            {
                groupId = value;
            }
        }

        public string GroupName
        {
            get
            {
                return groupName;
            }
            set
            {
                groupName = value;
            }
        }

        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }

        public string Notice
        {
            get
            {
                return notice;
            }
            set
            {
                notice = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
    }
        #endregion
}
