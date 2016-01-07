using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinChatServer.model.db.bean
{
    class Msg
    {
        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private string content;
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}
