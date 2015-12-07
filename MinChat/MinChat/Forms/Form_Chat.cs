using CCWin;
using CCWin.SkinClass;
using CCWin.SkinControl;
using MinChat.Communications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinChat.Forms
{
    public partial class Form_Chat : CCSkinMain
    {
        public Form_Chat()
        {
            InitializeComponent();
        }
        #region 发送信息
        private void btnSend_Click(object sender, EventArgs e)
        {
            //将内容更新到上方面板
            //this.AppendChatBoxContent("乔克斯", null, content, Color.SeaGreen, false);
            
            //清空发送输入框
            this.chatBoxSend.Text = string.Empty;
            this.chatBoxSend.Focus();
            //请求小黄鸡回复
            //System.Threading.ThreadPool.QueueUserWorkItem((s) => GoChat(content.Text));
        }
        #endregion
    }
}
