using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Communications
{
    class Session
    {
        public String id
        {
            get{
                return id;
            }
            set
            {
                id = value;
            }
        }
        public String from		    //发送人
        {
            get
            {
                return from;
            }
            set
            {
                from = value;
            }
        }
        public String from_user    //发送人可识别名字
        {
            get
            {
                return from_user;
            }
            set
            {
                from_user = value;
            }
        }
        public int type		        //消息类型
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
        public String time		    //接收时间
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
        public String content		//发送内容
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
        public int notReadCount    //未读记录
        {
            get
            {
                return notReadCount;
            }
            set
            {
                notReadCount = value;
            }
        }
        public String to		    //接收人
        {
            get
            {
                return to;
            }
            set
            {
                to = value;
            }
        }
        public int isdispose      //是否已处理 0未处理，1已处理
        {
            get
            {
                return isdispose;
            }
            set
            {
                isdispose = value;
            }
        }

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
    }
}
