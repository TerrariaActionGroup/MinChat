using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Communications.bean
{
    class Group
    {
        //groupId integer, groupName varchar(40), num integer, time date, notice text, type varchar(20)

        #region
        public int groupId
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

        public string groupName
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

        public int num
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

        public string time
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

        public string notice
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

        public string type
        {
            get
            {
                return type;
            }
            set
            {
                type= value;
            }
        }
        #endregion
    }
}
