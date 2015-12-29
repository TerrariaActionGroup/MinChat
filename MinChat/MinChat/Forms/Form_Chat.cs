using CCWin;
using CCWin.SkinClass;
using CCWin.SkinControl;
using ESPlus.Rapid;
using MinChat.Communications;
using MinChat.Settings;
using MinChat.Works.db;
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
        ChatListSubItem contactInfo;

        /// <summary>
        /// 用户user
        /// </summary>
        ChatListSubItem myInfo;

        /// <summary>
        /// 客户端引擎
        /// </summary>
        IRapidPassiveEngine rapidPassiveEngine;

        #endregion
        #region 窗口构造函数
        public Form_Chat(IRapidPassiveEngine rapidPassiveEngine, ChatListSubItem contactInfo, ChatListSubItem myInfo, Form_main main)
        {
            main.Receive += new Form_main.ReceiveEventHandler(ChatHandleReceive);//注册收到信息时的事件处理程序ChatHandleReceive
            this.contactInfo = contactInfo;
            this.myInfo = myInfo;
            this.rapidPassiveEngine = rapidPassiveEngine;
            InitializeComponent();
        }
        #endregion
        #region 载入窗口时
        private void Form_Chat_Load(object sender, EventArgs e)
        {
            MsgDB db = MsgDB.OpenMsgDB(myInfo.ID.ToString());
            List<Msg> msgs = db.readMsg(contactInfo.ID.ToString(), myInfo.ID.ToString());
            ChatBoxContent content = new ChatBoxContent();
            foreach (Msg msg in msgs)
            {
                AppendChatBoxContent(msg);
            }
        }
        #endregion
        #region 显示消息封装
        private void AppendChatBoxContent(Msg msg)
        {
            Color NicNameColor = Color.SeaGreen;
            Color textColor = Color.Black;
            string showTime = DateTime.Now.ToString();
            appendTextBox(chatBox_history, string.Format("\n{0}  {1}\n", msg.FromUserName, msg.Date), NicNameColor, messageFont);
            appendTextBox(chatBox_history, string.Format("{0}", msg.Content), textColor, messageFont);
            //this.chatBox_history.AppendText(string.Format("\n{0}  {1}\n", msg.FromUserName, msg.Date));
            //this.chatBox_history.AppendText(string.Format("{0}", msg.Content));

            chatBox_history.SelectionStart = chatBox_history.TextLength;
            chatBox_history.ScrollToCaret();
        }
        public void appendTextBox(RichTextBox textBox, string strInput, Color fontColor, Font fontType)
        {
            int p1 = textBox.TextLength;            //取出未添加时的字符串长度 
            textBox.AppendText(strInput);           //保留每行的所有颜色
            int p2 = strInput.Length;               //取出要添加的文本的长度 
            textBox.Select(p1, p2);                 //选中要添加的文本 
            textBox.SelectionColor = fontColor;     //设置要添加的文本的字体色 
            textBox.SelectionFont = fontType;       //设置要添加的文本的字体
        }
        #endregion
        #region 发送信息
        private void send()
        {   
            chatBoxSend.Text = chatBoxSend.Text.TrimEnd('\n');
            if (chatBoxSend.Text != "" && chatBoxSend.Text != "\n")
            {
                //发送信息
                //取出收到的消息,.接收者ID卍发送者ID卍消息内容卍发送时间卍发送人名字
                string split = Constant.SPLIT;
                string receiveId = contactInfo.ID.ToString();
                string sendId = myInfo.ID.ToString();
                string msgText = chatBoxSend.Text;
                string date = DateTime.Now.ToString();
                string sendName = myInfo.NicName;
                string msg = receiveId + split + sendId + split + msgText + split + date + split + sendName;
                this.rapidPassiveEngine.CustomizeOutter.Send(receiveId, 1, System.Text.Encoding.UTF8.GetBytes(msg));
                
                string[] msgs = new string[] { receiveId, sendId, msgText, date, sendName };
                Msg aMsg = new Msg(msgs, 1, 1);

                //将内容更新到上方面板
                this.AppendChatBoxContent(aMsg);

                MsgDB db = MsgDB.OpenMsgDB(myInfo.ID.ToString());
                db.addMsg(aMsg);

                
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
            //缓存剪贴板中现有内容
            RichTextBox clipboardTmp = new RichTextBox();
            clipboardTmp.Paste();

            for (int i = 0; i < chatBoxSend.TextLength; i++)
            {

                chatBoxSend.Select(i, 1);
                RichTextBoxSelectionTypes rt = chatBoxSend.SelectionType;
                //MessageBox.Show(rt.ToString());
                if (rt == RichTextBoxSelectionTypes.Object)
                {
                    //当然也可能是其它的类型
                    //MessageBox.Show("这是一个图片");
                    chatBoxSend.Copy();
                    Image img = Clipboard.GetImage();
                    if (img != null)
                    {
                        img.Save(i.ToString() + ".bmp");
                        img.Dispose();
                    }
                }
            }
            //send();
        }
        #endregion
        #region 处理事件的程序
        void ChatHandleReceive(object sender, EventArgs e, Msg msg)//处理事件的程序
        {
            if (Convert.ToUInt32(msg.FromUserId) == contactInfo.ID)
            {
                this.AppendChatBoxContent(msg);
            }
        }
        #endregion
    }
}
