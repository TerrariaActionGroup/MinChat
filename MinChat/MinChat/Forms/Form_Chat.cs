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
        private void AppendChatBoxContent(string NicName,ChatBoxContent content)
        {
            Color NicNameColor = Color.SeaGreen;
            Color textColor = Color.Black;
            string showTime = DateTime.Now.ToString();

            this.chatBox_history.AppendRichText(string.Format("\n{0}  {1}\n", NicName, showTime), new Font(this.messageFont, FontStyle.Regular), NicNameColor);
            this.chatBox_history.AppendRichText(string.Format("{0}", content.Text), content.Font, textColor);

            //chatBox_history//GoToLineAndColumn(chatBox_history, chatBox_history.Lines.Length, 0);
            chatBox_history.SelectionStart = chatBox_history.TextLength;
            chatBox_history.ScrollToCaret();
        }
        #endregion
        #region 发送信息
        private void send()
        {   
            chatBoxSend.Text = chatBoxSend.Text.TrimEnd('\n');
            ChatBoxContent content = this.chatBoxSend.GetContent();
            if (content.Text != "" && content.Text != "\n")
            {
                //
                //chatBoxSend.Text = chatBoxSend.Text.Remove(chatBoxSend.Text.Length - 1);
                //if(chatBoxSend.Text[chatBoxSend.Text.Length-1]=='\n')
                //{
                //    chatBoxSend.Text = chatBoxSend.Text.Remove(chatBoxSend.Text.Length - 2);
                //}
                //将内容更新到上方面板
                this.AppendChatBoxContent(userItem.NicName, content);
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
            if (Convert.ToUInt32(msg.fromUser) == item.ID)
            {
                ChatBoxContent content = new ChatBoxContent();
                content.Text = msg.content;
                this.AppendChatBoxContent(item.NicName,content);
            }
        }
        #endregion
    }
}
