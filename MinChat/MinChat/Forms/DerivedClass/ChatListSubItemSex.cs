using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Forms.DerivedClass
{
    class ChatListSubItemSex : ChatListSubItem
    {
        public ChatListSubItemSex.UserSex Sex { get; set; }
        //private int sex;
        //public int Sex             //id
        //{
        //    get
        //    {
        //        return sex;
        //    }
        //    set
        //    {
        //        sex = value;
        //    }
        //}
        public enum UserSex
        {
            Man = 1,
            Women = 2,
            secret = 3,
        }
    }
}
