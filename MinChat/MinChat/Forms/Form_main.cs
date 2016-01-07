using CCWin;
using CCWin.SkinControl;
using CCWin.Win32;
using ESBasic;
using ESPlus.Application.CustomizeInfo;
using ESPlus.Rapid;
using MinChat.Communications;
using MinChat.Communications.bean;
using MinChat.Forms.DerivedClass;
using MinChat.Settings;
using MinChat.Works.db;
using MinChat.Works.util;
using MinChat.Works.utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MinChat.Forms
{
    public partial class Form_main : Skin_Mac,ICustomizeHandler
    {        
        #region 变量
        public ChatListSubItem myInfo;//客户端用户的个人信息
        IRapidPassiveEngine rapidPassiveEngine;// 客户端引擎
        Form_Search form_search;
        Form_setting form_setting;

        private int action;
        Icon icon_normal = Properties.Resources.crab;
        Icon icon_trans = Properties.Resources.trans;
        Icon icon_systemMsg = Properties.Resources.systemMsg;
        private Icon[] flashSystemMsg = { Properties.Resources.systemMsg, Properties.Resources.trans };
        #endregion     
        #region 窗口构造函数
        public Form_main()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        #endregion
        #region 初始化窗口时
        public void InitMain(IRapidPassiveEngine rapidPassiveEngine)
        {
            tray.Visible = true;        //显示托盘
            this.rapidPassiveEngine = rapidPassiveEngine; //传入引擎
            
            hide hide1 = new hide(this, timer_Adsorption);  //吸附窗口边缘
            if (this.myInfo == null)
            {
                this.myInfo = new ChatListSubItem();
            }
            this.myInfo.ID = Convert.ToUInt32(rapidPassiveEngine.CurrentUserID);
            lbl_userName.Text = myInfo.ID.ToString();
            MsgDB db = MsgDB.OpenMsgDB(myInfo.ID.ToString());
            displayFriend();
            //预订接收到广播消息的处理事件
            this.rapidPassiveEngine.GroupOutter.BroadcastReceived += new CbGeneric<string, string, int, byte[]>(GroupOutter_BroadcastReceived);
            //预订断线处理事件
            this.rapidPassiveEngine.ConnectionInterrupted += new CbGeneric(rapidPassiveEngine_ConnectionInterrupted); 
            //好友下线处理事件
            this.rapidPassiveEngine.FriendsOutter.FriendOffline += new CbGeneric<string>(FriendOffline);
            //好友上线处理事件
            this.rapidPassiveEngine.FriendsOutter.FriendConnected += new CbGeneric<string>(FriendConnected);
        }
        #endregion
        #region 加载好友列表
        void displayFriend()
        {
            this.chatListBox_contacts.Items[0].SubItems.Clear();
            FriendDB frDB = FriendDB.OpenDB(myInfo.ID.ToString());
            List<Friend> frList = frDB.queryFriends();
            foreach (Friend fr in frList)
            {
                ChatListSubItem people = new ChatListSubItem();
                people.ID = Convert.ToUInt32(fr.UserId);
                people.NicName = fr.UserName;
                people.DisplayName = fr.UserName;
                this.chatListBox_contacts.Items[0].SubItems.Add(people);
            }
        }
        #endregion
        #region 处理好友上下线
        void FriendOffline(string friendId)
        {
            ChatListSubItem[] list= chatListBox_contacts.GetSubItemsById(Convert.ToUInt32(friendId));
            if (list.Length > 0)
            {
                list[0].Status = ChatListSubItem.UserStatus.OffLine;
            }
        }
        void FriendConnected(string friendId)
        {
            ChatListSubItem[] list = chatListBox_contacts.GetSubItemsById(Convert.ToUInt32(friendId));
            if (list.Length > 0)
            {
                list[0].Status = ChatListSubItem.UserStatus.Online;
            }
        }
        #endregion
        #region 处理掉线
        void rapidPassiveEngine_ConnectionInterrupted()
        {
            MessageBox.Show("你已掉线");

        }
        #endregion
        #region 处理广播消息
        void GroupOutter_BroadcastReceived(string broadcastID, string groupID, int broadcastType, byte[] broadcastContent)
        {
            // if (broadcastType == InformationTypes.Broadcast)
            //{
            //    string broadcastText = System.Text.Encoding.UTF8.GetString(broadcastContent);
            //    broadcastText += "   这是" + broadcastID + "发送过来的广播消息"; 
            //    MessageBox.Show(broadcastText);
            //}
            MessageBox.Show("xxxxx");
            
        }  
        #endregion
        #region 接收消息处理
        /// <summary>
        /// 处理接收到的信息（包括大数据块信息）。
        /// </summary>
        /// <param name="sourceUserID">发出信息的用户ID。如果为null，表示信息来自服务端。</param>
        /// <param name="informationType">自定义信息类型</param>
        /// <param name="info">信息</param>
        public void HandleInformation(string sourceUserID, int informationType, byte[] info) 
        {
            MsgDB db = MsgDB.OpenMsgDB(myInfo.ID.ToString());
            if (sourceUserID != null)
            {
                switch (informationType)
                {
                    case Constant.MSGTEXT://处理文本消息

                        //文本消息格式：接收者ID卍发送者ID卍消息内容卍发送时间卍发送人名字
                        string message = System.Text.Encoding.UTF8.GetString(info);
                        string[] msgs = Regex.Split(message, Constant.SPLIT, RegexOptions.IgnoreCase);//得到含有5个元素的数组
                        Msg msg = new Msg(msgs, 0, 0);                                  //消息存在msg对象中

                        ChatListSubItem[] items = chatListBox_contacts.GetSubItemsById(Convert.ToUInt32(sourceUserID));//按照ID查找listbox中的subItem

                        string windowsName = items[0].NicName + ' ' + items[0].ID;      //聊天窗口的标题
                        IntPtr handle = NativeMethods.FindWindow(null, windowsName);    //查找是否已经存在窗口
                        if (handle != IntPtr.Zero)//聊天窗口已存在
                        {
                            msg.IsReaded = 1;
                            Form frm = (Form)Form.FromHandle(handle);
                            frm.Activate();                                             //激活
                            this.OnReceive(msg);                                        //传送消息到聊天窗口
                        }
                        else
                        {
                            twinkle(chatListBox_contacts, Convert.ToUInt32(sourceUserID));//头像闪烁
                        }
                        //消息存入数据库
                        db.addMsg(msg);
                        break;
                    case Constant.MSGIMG://处理图片
                        MsgImg msgimg = ImageUtil.bytesToIdImg(info);
                        ImageUtil.ImgSave(msgimg.Id, msgimg.Img);//存储图片
                        break;
                }
            }
            else//来自服务器的消息
            {
                switch (informationType)
                {
                    case Constant.MSG_ADDFRIEND_APPLY:
                        string infostr = System.Text.Encoding.UTF8.GetString(info);
                        //接收者ID卍发送者ID卍消息内容卍发送时间卍发送人名字
                        string[] systemMsgs = { myInfo.ID.ToString(), "10000",infostr," ", "10000" };
                        Msg systemMsg = new Msg(systemMsgs, 0, 0);
                        db.addMsg(systemMsg);
                        //SystemMsgUtil.putMsg("10000");
                        //this.timer_tray.Enabled = true;    //托盘闪烁
                        break;
                    case Constant.MSG_ADDFRIEND_AGREE:
                        //ID卍昵称卍性别卍生日卍地址卍注册时间
                        string userInfo= System.Text.Encoding.UTF8.GetString(info);
                        string[] userInfos = Regex.Split(userInfo, Constant.SPLIT, RegexOptions.IgnoreCase);
                        
                        //把消息存进数据库
                        //接收者ID卍发送者ID卍消息内容卍发送时间卍发送人名字
                        string[] systemMsgsADDFRIEND_AGREE = { myInfo.ID.ToString(), "10000", userInfos[0]+"同意加你为好友", " ", "10000" };
                        Msg systemMsgADDFRIEND_AGREE = new Msg(systemMsgsADDFRIEND_AGREE, 0, 0);
                        db.addMsg(systemMsgADDFRIEND_AGREE);
                        
                        //把好友存进数据库
                        Friend fr=new Friend();
                        fr.UserId=userInfos[0];
                        fr.UserName=userInfos[1];
                        fr.Sex=Convert.ToInt32(userInfos[2]);
                        fr.Birthday=userInfos[3];
                        fr.Address=userInfos[4];
                        fr.Time=userInfos[5];

                        FriendDB Fdb = FriendDB.OpenDB(myInfo.ID.ToString());
                        Fdb.addFriend(fr);
                        break;
                }
            }
        }

        /// <summary>
        /// 处理接收到的请求并返回应答信息。
        /// </summary>
        /// <param name="sourceUserID">发送请求信息的用户ID。如果为null，表示信息来自服务端。</param>     
        /// <param name="informationType">自定义请求信息的类型</param>  
        /// <param name="info">请求信息</param>
        /// <returns>应答信息</returns>
        public byte[] HandleQuery(string sourceUserID, int informationType, byte[] info) 
        { 
            return new byte[1]; 
        }
        #endregion
        #region 双击好友弹出对话框
        private void chatListBox_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es)
        {
            ChatListSubItem contactInfo = e.SelectSubItem;//获取选中的好友
            contactInfo.IsTwinkle = false; //取消头像闪烁状态
            string windowsName = contactInfo.NicName + ' ' + contactInfo.ID;//聊天窗口的标题
            IntPtr handle = NativeMethods.FindWindow(null, windowsName);//查找是否已经存在窗口
            if (handle != IntPtr.Zero)//窗口已存在
            {
                Form frm = (Form)Form.FromHandle(handle);
                frm.Activate();//激活
            }
            else//窗口不存在
            {
                Form_Chat fChat = new Form_Chat(this.rapidPassiveEngine, contactInfo, this.myInfo, this);
                fChat.Text = contactInfo.NicName + ' ' + contactInfo.ID;
                fChat.Show();
            }
        }
        #endregion
        #region 处理接收消息
        //头像闪烁
        private void twinkle(ChatListBox listBox,uint id)
        {
            ChatListSubItem[] items=listBox.GetSubItemsById(id);//按照ID查找listbox中的用户
            items[0].IsTwinkle = true;//开启闪烁
        }
        #endregion
        #region 接收传送消息到chat的委托
        public delegate void ReceiveEventHandler(object sender, EventArgs e, Msg msg);//声明关于事件的委托
        public event ReceiveEventHandler Receive;//声明事件
        //引发事件的函数；
        public void OnReceive(Msg msg)
        {
            if (this.Receive != null)
            {
                //MessageBox.Show("发出信号");
                this.Receive(this, new EventArgs(), msg);
            }
        }
        #endregion
        #region 各种按钮
        private void btn_systemMsg_Click(object sender, EventArgs e)
        {
            Form_SystemMsg form_systemMsg = new Form_SystemMsg(rapidPassiveEngine, myInfo);
            form_systemMsg.Show();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if(form_search!=null)
            {
                if (form_search.IsDisposed)
                {
                    form_search = new Form_Search(rapidPassiveEngine, myInfo);
                    form_search.Show();
                }
                else
                {
                    form_search.Activate();
                }
            }
            else 
            {
                form_search = new Form_Search(rapidPassiveEngine,myInfo);
                form_search.Show();
            }
        }
        private void btn_setting_Click(object sender, EventArgs e)
        {
            if (form_setting != null)
            {
                if (form_setting.IsDisposed)
                {
                    form_setting = new Form_setting();
                    form_setting.Show();
                }
                else
                {
                    form_setting.Activate();
                }
            }
            else
            {
                form_setting = new Form_setting();
                form_setting.Show();
            }
        }
        #endregion
        #region 托盘

        private void timer_tray_Tick(object sender, EventArgs e)
        {
            this.tray.Icon = this.flashSystemMsg[(this.action++ % 2)];
        }
        private void tray_Click(object sender, EventArgs e)
        {
            if (this.timer_tray.Enabled == true)
            {

                //string msgId = SystemMsgUtil.getNewestMsg();
                //if (msgId == "10000")
                //{
                    //Form_SystemMsg form_systemMsg = new Form_SystemMsg(rapidPassiveEngine, myInfo);
                    //form_systemMsg.Show();
                //}
                //this.timer_tray.Enabled = false;    //计时器停止
                //tray.Icon = icon_normal;
            }
        }
        #endregion   
    }
}
