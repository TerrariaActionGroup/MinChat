﻿using CCWin;
using CCWin.SkinClass;
using CCWin.SkinControl;
using ESBasic;
using ESPlus.Rapid;
using MinChat.Communications;
using MinChat.Communications.bean;
using MinChat.Settings;
using MinChat.Works.db;
using MinChat.Works.util;
using MinChat.Works.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        MsgDB msgDB;
        #endregion
        #region 窗口构造函数
        public Form_Chat(IRapidPassiveEngine rapidPassiveEngine, ChatListSubItem contactInfo, ChatListSubItem myInfo, Form_main main)
        {
            //注册收到信息时的事件处理程序ChatHandleReceive
            main.Receive += new Form_main.ReceiveEventHandler(ChatHandleReceive);
            
            //传入变量
            this.contactInfo = contactInfo;
            this.myInfo = myInfo;
            this.rapidPassiveEngine = rapidPassiveEngine;
            
            InitializeComponent();
        }
        #endregion
        #region 载入窗口时
        private void Form_Chat_Load(object sender, EventArgs e)
        {
            //连接数据库
            msgDB = MsgDB.OpenMsgDB(myInfo.ID.ToString());

            //取出聊天记录
            List<Msg> msgs = msgDB.readMsg(contactInfo.ID.ToString(), myInfo.ID.ToString());
            ChatBoxContent content = new ChatBoxContent();
            foreach (Msg msg in msgs)
            {
                AppendChatBoxContent(msg);
                displayPicture();
            }
        }
        #endregion
        #region 调整窗口大小时
        private void Form_Chat_Resize(object sender, EventArgs e)
        {
            pnl_Tool2.Top=this.Height-pnl_Tool2.Height;
            pnl_Tool2.Width=this.Width;

            chatBoxSend.Left=5;
            chatBoxSend.Top = this.Height-(chatBoxSend.Height+pnl_Tool2.Height);
            chatBoxSend.Width=this.Width-5;

            pnl_Tool.Top=this.Height-(pnl_Tool.Height+chatBoxSend.Height+pnl_Tool2.Height);
            pnl_Tool.Width=this.Width;

            chatBox_history.Left = 5;
            chatBox_history.Top = this.CaptionHeight + 4;
            chatBox_history.Width = this.Width-5;
            chatBox_history.Height = pnl_Tool.Top - chatBox_history.Top;
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
        /// <summary>
        /// 显示图片
        /// </summary>
        void displayPicture()
        {
            Image img;
            chatBox_history.ReadOnly = false;
            for (int i = 0; i < chatBox_history.TextLength; i++)
            {
                chatBox_history.Select(i, 5);
                if (chatBox_history.SelectedText == "<img>")
                {
                    chatBox_history.Select(i + 5, 16);
                    string serialNumber = chatBox_history.SelectedText;
                    try
                    {
                        img = Image.FromFile(serialNumber + ".png");
                        Clipboard.SetImage(img);
                        chatBox_history.Select(i, 16 + 5 + 6);
                        chatBox_history.Paste();
                    }
                    catch
                    {
                        
                    }    
                    
                }
            }
            chatBox_history.ReadOnly = true;
            chatBox_history.SelectionStart = chatBox_history.TextLength;
            chatBox_history.ScrollToCaret();
        }
        #endregion
        #region 发送图片封装
        /// <summary>
        /// 发送图片消息
        /// </summary>
        /// <param name="img">待发送的Img对象</param>
        /// <param name="imgId">Img对象的ID</param>
        /// <param name="destUserID">目的ID</param>
        public void SendImage(Image img,string imgId,string destUserID)
        {
            //根据ID和img生成byte数组
            byte[] blob = ImageUtil.customizeImg(imgId, img);
            
            //通过委托异步调用
            CbGeneric<byte[], string> cb = new CbGeneric<byte[], string>(this.SendBlobThread);
            cb.BeginInvoke(blob, destUserID, null, null);
        }
        private void SendBlobThread(byte[] blob, string destUserID)
        {
            this.rapidPassiveEngine.CustomizeOutter.SendBlob(destUserID, Constant.MSGIMG, blob, 2048);
        }
        #endregion
        #region 发送文本
        /// <summary>
        /// 发送文本消息
        /// </summary>
        private void sendText()
        {   
            chatBoxSend.Text = chatBoxSend.Text.TrimEnd('\n');
            if (chatBoxSend.Text != "" && chatBoxSend.Text != "\n")
            {
                //消息格式：接收者ID卍发送者ID卍消息内容卍发送时间卍发送人名字
                string split = Constant.SPLIT;
                string receiveId = contactInfo.ID.ToString();
                string sendId = myInfo.ID.ToString();
                string msgText = chatBoxSend.Text;
                string date = DateTime.Now.ToString();
                string sendName = myInfo.NicName;
                string msg = receiveId + split + sendId + split + msgText + split + date + split + sendName;

                //发送在线消息
                if (contactInfo.Status == CCWin.SkinControl.ChatListSubItem.UserStatus.Online)
                {
                    this.rapidPassiveEngine.CustomizeOutter.Send(receiveId, Constant.MSGTEXT, System.Text.Encoding.UTF8.GetBytes(msg));
                }
                //发送离线消息
                else if (contactInfo.Status == CCWin.SkinControl.ChatListSubItem.UserStatus.OffLine)
                {
                    this.rapidPassiveEngine.CustomizeOutter.Send(Constant.MSG_OFFLINEMSGTEXT, System.Text.Encoding.UTF8.GetBytes(msg));
                }
                
                //存入数据库
                string[] msgs = new string[] {receiveId,sendId,msgText,date,sendName};
                Msg aMsg = new Msg(msgs,1,1);
                msgDB.addMsg(aMsg);
                
                //将内容更新到上方面板
                this.AppendChatBoxContent(aMsg);
                

            }
            //清空发送输入框
            this.chatBoxSend.Text = string.Empty;
            this.chatBoxSend.Focus();
        }
        #endregion
        #region 发送图片
        /// <summary>
        /// 发送前处理图片
        /// </summary>
        void imgProcessing()
        {
            string stamp = timeUtil.GetTimeStamp();
            
            //图片序号
            int imgNum=0;

            //缓存剪贴板中现有内容
            RichTextBox clipboardTmp = new RichTextBox();
            clipboardTmp.Paste();

            for (int i = 0; i < chatBoxSend.TextLength; i++)
            {
                chatBoxSend.Select(i, 1);                                           //依次选中
                RichTextBoxSelectionTypes rt = chatBoxSend.SelectionType;           //获取当前选中 内容的类型
                if (rt == RichTextBoxSelectionTypes.Object)                         //图片是object
                {
                    chatBoxSend.Copy();                                             //复制到剪贴板
                    Image img = Clipboard.GetImage();                               //从剪贴板中建立Img对象
                    string serialNumber = string.Format("{0}{1:d6}", stamp,imgNum); //格式化生成图片序列号
                    if (img != null)
                    {
                        ImageUtil.ImgSave(serialNumber, img);                       //存储图片，并加入后缀
                        img.Tag=serialNumber;
                        SendImage(img, serialNumber, contactInfo.ID.ToString());    //发送图片
                        img.Dispose();
                    }
                    chatBoxSend.SelectedText = "<img>" + serialNumber + "</img>";
                    imgNum++;
                }
            }
            //将原来剪贴板中的内容放回去
            clipboardTmp.SelectAll();
            clipboardTmp.Copy();
        }
        #endregion
        #region 发送事件
        private void chatBoxSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                imgProcessing();
                sendText();
                displayPicture();
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            imgProcessing();
            sendText();
            displayPicture();
        }
        #endregion
        #region 处理接收消息事件的程序
        void ChatHandleReceive(object sender, EventArgs e, Msg msg)//处理事件的程序
        {
            if (Convert.ToUInt32(msg.FromUserId) == contactInfo.ID)
            {
                this.AppendChatBoxContent(msg);
                displayPicture();
            }
        }
        #endregion
    }
}
