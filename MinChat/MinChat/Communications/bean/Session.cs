using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Communications
{
    class Session
    {
        private String id;
        private String from;		//发送人
        private String from_user;   //发送人可识别名字
        private int type;		    //消息类型
        private String time;		//接收时间
        private String content;		//发送内容

        public String date
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
        private int notReadCount;//未读记录
        private String to;		    //接收人
        private int isdispose;      //是否已处理 0未处理，1已处理

        /// <summary>
        /// 创建会话对象
        /// </summary>
        /// <param name="msgs">由消息组装来的数组</param>
        /// <param name="isDispose">是否处理。1，已处理。0，未处理</param>
        /// <param name="type">消息类型</param>
        public Session(string[] sessions, int isDispose, int type)
        {
            //接收者ID卍发送者ID卍消息内容卍发送时间卍发送人名字
            this.from = sessions[0];
            this.from_user = sessions[1];
            this.type = type;
            this.time = sessions[2];
            this.content = sessions[3];
            this.to = sessions[5];
            this.isdispose = isDispose;
        }

        public String getId()
        {
            return id;
        }
        public void setId(String id)
        {
            this.id = id;
        }
        public String getFrom()
        {
            return from;
        }
        public void setFrom(String from)
        {
            this.from = from;
        }
        public int getType()
        {
            return type;
        }
        public void setType(int type)
        {
            this.type = type;
        }
        public String getTime()
        {
            return time;
        }
        public void setTime(String time)
        {
            this.time = time;
        }
        public String getContent()
        {
            return content;
        }
        public void setContent(String content)
        {
            this.content = content;
        }
        public int getNotReadCount()
        {
            return notReadCount;
        }
        public void setNotReadCount(int notReadCount)
        {
            this.notReadCount = notReadCount;
        }
        public String getTo()
        {
            return to;
        }
        public void setTo(String to)
        {
            this.to = to;
        }
        public int getIsdispose()
        {
            return isdispose;
        }
        public void setIsdispose(int isdispose)
        {
            this.isdispose = isdispose;
        }

        public String getFrom_user()
        {
            return from_user;
        }

        public void setFrom_user(String from_user)
        {
            this.from_user = from_user;
        }
    }
}
