using MinChat.Works.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Communications.bean
{
    class ImgText
    {
        public static int TYPE_IMG = 1;
        public static int TYPE_TEXT = 0;

        /// <summary>
        /// 类型,如上
        /// </summary>
        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// 内容，byte数组
        /// </summary>
        private byte[] content;
        public byte[] Content
        {
            get { return content; }
            set { content = value; }
        }

        /// <summary>
        /// 创建纯文本的消息
        /// </summary>
        /// <param name="msg"></param>
        public ImgText(string msg)
        {
            this.Type = TYPE_TEXT;
            this.Content = System.Text.Encoding.UTF8.GetBytes(msg);
        }

        /// <summary>
        /// 创建纯文本的消息
        /// </summary>
        /// <param name="msg"></param>
        public ImgText(Image img)
        {
            this.Type = TYPE_TEXT;
            this.Content = ImageHelper.ImageToBytes(img);
        }
    }
}
