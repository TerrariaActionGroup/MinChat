using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinChatWeb
{
    class CustomizeUser
    {
        private string userId;
        private string userName;
        private string userPwd;
        private int sex;
        private int age;
        private string birthday;
        private string remark;
        private string address;
        private string time;
        #region
        public string UserId             //用户账号
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }
        public string UserPwd
        {
            get
            {
                return userPwd;
            }
            set
            {
                userPwd = value;
            }
        }
        public string UserName           //用户昵称
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
        public int Sex
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
        public int Age
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
        public string Birthday
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
        public string Remark
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
        public string Address
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
        public string Time              //用户建立好友时间
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
        #endregion
    }
}
