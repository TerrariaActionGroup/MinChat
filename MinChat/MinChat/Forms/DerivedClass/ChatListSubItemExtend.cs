using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Forms.DerivedClass
{
    class ChatListSubItemExtend : ChatListSubItem
    {
        public ChatListSubItemExtend.UserSex Sex { get; set; }
        string birth;
        string registrationDate;
        string address;
        public string Birth
        {
            get { return birth; }
            set { birth = value; }
        }
        public string RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }  
        public enum UserSex
        {
            Man = 1,
            Women = 2,
            secret = 3,
        }
    }
}
