using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Communications
{
    public class Msg
    {
        private int msgId;             //id
        public int sessionId           //sid
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
        private String fromUser;       //发送者Id
        private String toUser;         //接收者Id
        private String fromUserName;   //发送者名字
        private int type;              //信息类型
        private String content;        //信息内容
        private int isComing;          //0表接收的消息，1表发送的消息
        private String date;           //时间
        private int isReaded;          //是否已读 0为未读，1为已读

        private String bak1;//扩展1
        private String bak2;//扩展2
        private String bak3;//扩展3
        private String bak4;//扩展4
        private String bak5;//扩展5
        private String bak6;//扩展6

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

        #region
        public int getMsgId()
        {
            return msgId;
        }
        public void setMsgId(int msgId)
        {
            this.msgId = msgId;
        }
        public String getFromUser()
        {
            return fromUser;
        }
        public void setFromUser(String fromUser)
        {
            this.fromUser = fromUser;
        }

        public String getFromUserName()
        {
            return fromUserName;
        }

        public void setFromUserName(String fromUserName)
        {
            this.fromUserName = fromUserName;
        }

        public String getToUser()
        {
            return toUser;
        }
        public void setToUser(String toUser)
        {
            this.toUser = toUser;
        }
        public int getType()
        {
            return type;
        }
        public void setType(int type)
        {
            this.type = type;
        }
        public String getContent()
        {
            return content;
        }
        public void setContent(String content)
        {
            this.content = content;
        }

        public int getIsComing()
        {
            return isComing;
        }
        public void setIsComing(int isComing)
        {
            this.isComing = isComing;
        }

        public String getDate()
        {
            return date;
        }
        public void setDate(String date)
        {
            this.date = date;
        }
        public String getBak1()
        {
            return bak1;
        }
        public void setBak1(String bak1)
        {
            this.bak1 = bak1;
        }
        public String getBak2()
        {
            return bak2;
        }
        public void setBak2(String bak2)
        {
            this.bak2 = bak2;
        }
        public String getBak3()
        {
            return bak3;
        }
        public void setBak3(String bak3)
        {
            this.bak3 = bak3;
        }
        public String getBak4()
        {
            return bak4;
        }
        public void setBak4(String bak4)
        {
            this.bak4 = bak4;
        }
        public String getBak5()
        {
            return bak5;
        }
        public void setBak5(String bak5)
        {
            this.bak5 = bak5;
        }
        public String getBak6()
        {
            return bak6;
        }
        public void setBak6(String bak6)
        {
            this.bak6 = bak6;
        }
        public int getIsReaded()
        {
            return isReaded;
        }
        public void setIsReaded(int isReaded)
        {
            this.isReaded = isReaded;
        }
        #endregion
    }
}
