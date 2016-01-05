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

        public enum UserSex
        {
            Man = 1,
            Women = 2,
            secret = 3,
        }
    }
}
