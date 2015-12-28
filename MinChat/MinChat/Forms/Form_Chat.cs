using CCWin;
using CCWin.SkinClass;
using CCWin.SkinControl;
using ESPlus.Rapid;
using MinChat.Communications;
using MinChat.Settings;
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
    public partial class Form_Chat : Skin_Mac
    {
        #region 变量
        /// <summary>
        /// 文本格式
        /// </summary>
        private Font messageFont = new Font("微软雅黑", 9);
        
        /// <summary>
        /// 聊天对象信息
        /// </summary>
        ChatListSubItem item;

        /// <summary>
        /// 用户user
        /// </summary>
        ChatListSubItem userItem;

        /// <summary>
        /// 客户端引擎
        /// </summary>
        IRapidPassiveEngine rapidPassiveEngine;

        #endregion
        #region 窗口构造函数
        public Form_Chat(IRapidPassiveEngine rapidPassiveEngine, ChatListSubItem item, ChatListSubItem userItem, Form_main main)
        {
            main.Receive += new Form_main.ReceiveEventHandler(ChatHandleReceive);//注册收到信息时的事件处理程序ChatHandleReceive
            this.userItem = userItem;
            this.item = item;
            this.rapidPassiveEngine = rapidPassiveEngine;
            InitializeComponent();
        }
        #endregion
        #region 发送消息封装
        /// <summary>
        /// 发送信息文本到内容框
        /// </summary>
        /// <param name="userName">名字</param>
        /// <param name="originTime">时间</param>
        /// <param name="content">发送内容</param>
        /// <param name="color">字体颜色</param>
        /// <param name="followingWords">是否有用户名</param>
        private void AppendChatBoxContent(string userName, DateTime? originTime, ChatBoxContent content, Color color, bool followingWords)
        {
            this.AppendChatBoxContent(userName, originTime, content, color, followingWords, originTime != null);
        }

        /// <summary>
        /// 发送信息文本到内容框
        /// </summary>
        /// <param name="userName">名字</param>
        /// <param name="originTime">时间</param>
        /// <param name="content">发送内容</param>
        /// <param name="color">字体颜色</param>
        /// <param name="followingWords">是否有用户名</param>
        /// <param name="offlineMessage">是否在线消息</param>
        private void AppendChatBoxContent(string userName, DateTime? originTime, ChatBoxContent content, Color color, bool followingWords, bool offlineMessage)
        {
            if (!followingWords)
            {
                string showTime = DateTime.Now.ToLongTimeString();
                if (!offlineMessage && originTime != null)
                {
                    showTime = originTime.Value.ToString();
                }
                this.chatBox_history.AppendRichText(string.Format("{0}  {1}\n", userName, showTime), new Font(this.messageFont, FontStyle.Regular), color);
                if (originTime != null && offlineMessage)
                {
                    this.chatBox_history.AppendText(string.Format("    [{0} 离线消息] ", originTime.Value.ToString()));
                }
                else
                {
                    this.chatBox_history.AppendText("    ");
                }
            }
            else
            {
                this.chatBox_history.AppendText("   .");
            }

            this.chatBox_history.AppendChatBoxContent(content);
            this.chatBox_history.AppendText("\n");
            this.chatBox_history.Select(this.chatBox_history.Text.Length, 0);
            this.chatBox_history.ScrollToCaret();
        }

        /// <summary>
        /// 发送信息文本到内容框
        /// </summary>
        /// <param name="userName">名称</param>
        /// <param name="color">字体颜色</param>
        /// <param name="msg">信息</param>
        private void AppendMessage(string userName, Color color, string msg)
        {
            DateTime showTime = DateTime.Now;
            this.chatBox_history.AppendRichText(string.Format("{0}  {1}\n", userName, showTime.ToLongTimeString()), new Font(this.messageFont, FontStyle.Regular), color);
            this.chatBox_history.AppendText("    ");

            this.chatBox_history.AppendText(msg);
            this.chatBox_history.Select(this.chatBox_history.Text.Length, 0);
            this.chatBox_history.ScrollToCaret();
        }

        /// <summary>
        /// 发送系统消息
        /// </summary>
        /// <param name="msg">信息</param>
        public void AppendSysMessage(string msg)
        {
            this.AppendMessage("系统", Color.Gray, msg);
            this.chatBox_history.AppendText("\n");
        }
        #endregion
        #region 发送信息
        private void send()
        {
            ChatBoxContent content = this.chatBoxSend.GetContent();
            if (content.Text != "" && content.Text != "\n")
            {
                //将内容更新到上方面板
                this.AppendChatBoxContent(userItem.NicName, null, content, Color.SeaGreen, false);
                //发送信息
                //取出收到的消息,.接收者ID卍发送者ID卍消息内容卍发送时间卍发送人名字
                string split = Constant.SPLIT;
                string receiveId = item.ID.ToString();
                string sendId = userItem.ID.ToString();
                string msgText = content.Text;
                string date = DateTime.Now.ToString();
                string sendName = userItem.NicName;
                string msg = receiveId + split + sendId + split + msgText + split + date + split + sendName;
                this.rapidPassiveEngine.CustomizeOutter.Send(receiveId, 1, System.Text.Encoding.UTF8.GetBytes(msg));
            }
            //清空发送输入框
            this.chatBoxSend.Text = string.Empty;
            this.chatBoxSend.Focus();
            
        }
        private void chatBoxSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                send();
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            send();
        }
        #endregion
        #region 处理事件的程序
        void ChatHandleReceive(object sender, EventArgs e, Msg msg)//处理事件的程序
        {
            if (Convert.ToUInt32(msg.getFromUser()) == item.ID)
            {
                ChatBoxContent content = new ChatBoxContent();
                content.Text = msg.getContent();
                this.AppendChatBoxContent(item.NicName, null, content, Color.SeaGreen, false);
            }
        }
        #endregion
    }
}
