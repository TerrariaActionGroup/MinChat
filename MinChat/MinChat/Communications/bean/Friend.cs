using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Communications.bean
{
    class Friend
    {
        #endregion

        #region
        public string userId             //用户账号
        {             
            get{
                return userId;
            }
            set{
                userId = value;
            }
        }

        public string userName           //用户昵称
        {          
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public int sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }
        public int age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public string remark
        {
            get
            {
                return remark;
            }
            set
            {
                remark = value;
            }
        }
        public string address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string time              //用户建立好友时间
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
        public int mGroupId             //好友分组Id
        {
            get
            {
                return mGroupId;
            }
            set
            {
                mGroupId = value;
            }
        }          
        #endregion
    }
}
