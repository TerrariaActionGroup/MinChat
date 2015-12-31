using MinChat.Works.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Communications.bean
{
    class MsgImg
    {

        /// <summary>
        /// 类型,如上
        /// </summary>
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// 内容，Image对象
        /// </summary>
        private Image img;

        public Image Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}
