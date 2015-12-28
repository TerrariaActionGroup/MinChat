using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Communications
{
    public class Msg
    {
        private int msgId;
        private int sessionId;
        private String fromUser;
        private String toUser;
        private String fromUserName;
        private int type;
        private String content;
        private int isComing;
        private String date;
        private int isReaded;
        private String bak1;
        private String bak2;
        private String bak3;
        private String bak4;
        private String bak5;
        private String bak6;
        public int MsgId             //id
        {
            get
            {
                return msgId;
            }
            set
            {
                msgId = value;
            }
        }
        public int SessionId           //sid
        {
            get
            {
                return sessionId;
            }
            set
            {
                sessionId = value;
            }
        }
        public String FromUser       //发送者Id
        {
            get
            {
                return fromUser;
            }
            set
            {
                fromUser = value;
            }
        }
        public String ToUser         //接收者Id
        {
            get
            {
                return toUser;
            }
            set
            {
                toUser = value;
            }
        }
        public String FromUserName   //发送者名字
        {
            get
            {
                return fromUserName;
            }
            set
            {
                fromUserName = value;
            }
        }
        public int Type              //信息类型
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
        public String Content        //信息内容
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        public int IsComing          //0表接收的消息，1表发送的消息
        {
            get
            {
                return isComing;
            }
            set
            {
                isComing = value;
            }
        }
        public String Date           //时间
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public int IsReaded          //是否已读 0为未读，1为已读
        {
            get
            {
                return isReaded;
            }
            set
            {
                isReaded = value;
            }
        }
        public String Bak1//扩展1
        {
            get
            {
                return bak1;
            }
            set
            {
                bak1 = value;
            }
        }
        public String Bak2//扩展2
        {
            get
            {
                return bak2;
            }
            set
            {
                bak2 = value;
            }
        }
        public String Bak3//扩展3
        {
            get
            {
                return bak3;
            }
            set
            {
                bak3 = value;
            }
        }
        public String Bak4//扩展4
        {
            get
            {
                return bak4;
            }
            set
            {
                bak4 = value;
            }
        }
        public String Bak5//扩展5
        {
            get
            {
                return bak5;
            }
            set
            {
                bak5 = value;
            }
        }
        public String Bak6//扩展6
        {
            get
            {
                return bak6;
            }
            set
            {
                bak6 = value;
            }
        }

        #region
        /// <summary>
        /// 创建消息对象
        /// </summary>
        /// <param name="msgs">由文本消息拆解的消息数组</param>
        /// <param name="isRead">是否已读。1，已读。0，未读</param>
        /// <param name="isComing">接收还是发送。1，发送。0，接收</param>
        public Msg(string[] msgs, int isRead, int isComing)
        {
            //接收者ID卍发送者ID卍消息内容卍发送时间卍发送人名字
            this.fromUser = msgs[1];
            this.toUser = msgs[0];
            this.fromUserName = msgs[4];
            this.type = 1;
            this.content = msgs[2];
            this.isComing = isComing;
            this.date = msgs[3];
            this.isReaded = isRead;
        }
        #endregion

    }
}
