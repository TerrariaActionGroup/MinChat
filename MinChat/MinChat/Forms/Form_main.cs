using CCWin;
using CCWin.SkinControl;
using CCWin.Win32;
using ESBasic;
using ESPlus.Application;
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
using System.Threading;
using System.Windows.Forms;

namespace MinChat.Forms
{
    public partial class Form_main : Skin_Mac,ICustomizeHandler
    {        
        #region 变量
        //客户端用户的个人信息
        public ChatListSubItemExtend myInfo;
        CallbackHandler ReceiveMyInfo;
        // 客户端引擎
        IRapidPassiveEngine rapidPassiveEngine;

        //窗口
        Form_Search form_search;
        Form_setting form_setting;
        private Form_Error fromError;

        //托盘相关变量
        private int action;
        Icon icon_normal = Properties.Resources.crab;
        Icon icon_trans = Properties.Resources.trans;
        Icon icon_systemMsg = Properties.Resources.systemMsg;
        private Icon[] flashSystemMsg = { Properties.Resources.systemMsg, Properties.Resources.trans };


        #endregion     

        #region 窗口构造函数
        public Form_main()
        {
            //关闭线程限制
            CheckForIllegalCrossThreadCalls = false;

            //初始化窗口控件
            InitializeComponent();
        }
        #endregion

        #region 初始化窗口
        public void InitMain(IRapidPassiveEngine rapidPassiveEngine)
        {   
            //显示托盘
            tray.Visible = true;  
     
            //传入通信引擎
            this.rapidPassiveEngine = rapidPassiveEngine; 
            
            //吸附窗口边缘
            hide hide1 = new hide(this, timer_Adsorption);  

            //获取个人信息
            if (this.myInfo == null)
            {
                this.myInfo = new ChatListSubItemExtend();
            }
            this.myInfo.ID = Convert.ToUInt32(rapidPassiveEngine.CurrentUserID);

            //窗口显示用户ID
            this.ReceiveMyInfo = new CallbackHandler(diaplayUser);//实例化收到消息时回调方法的委托
            this.rapidPassiveEngine.CustomizeOutter.Query(null, Constant.MSG_QUERYUSER, System.Text.Encoding.UTF8.GetBytes(myInfo.ID.ToString()), ReceiveMyInfo, new Object());
            
            //载入好友列表
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
            //清空
            this.chatListBox_contacts.Items[0].SubItems.Clear();
            List<string> OnlineFriends = this.rapidPassiveEngine.FriendsOutter.GetAllOnlineFriends();

            //从数据库读取
            List<Friend> frList = FriendDB.uniqueInstance.queryFriends();
            foreach (Friend fr in frList)
            {
                ChatListSubItem people = new ChatListSubItem();
                people.ID = Convert.ToUInt32(fr.UserId);
                people.NicName = fr.UserName;
                people.DisplayName = fr.UserName;
                people.Status = ChatListSubItem.UserStatus.OffLine;
                this.chatListBox_contacts.Items[0].SubItems.Add(people);
            }
            foreach (string friendId in OnlineFriends)
            {
                ChatListSubItem[] list = chatListBox_contacts.GetSubItemsById(Convert.ToUInt32(friendId));
                if (list.Length > 0)
                {
                    list[0].Status = ChatListSubItem.UserStatus.Online;
                }
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
            this.fromError =  new Form_Error("你已掉线!");
            Thread thread = new Thread(threadPro);
            thread.Start();
        }

        public void threadPro()
        {
            MethodInvoker MethInvo = new MethodInvoker(ShowErrorForm);
            BeginInvoke(MethInvo);
        }
        public void ShowErrorForm()
        {
            this.fromError.Show();
        }
        #endregion

        #region 处理广播消息
        void GroupOutter_BroadcastReceived(string broadcastID, string groupID, int broadcastType, byte[] broadcastContent)
        {
            
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
            SysMsg sysmsg = new SysMsg();
            switch (informationType)
            {   
                //文本消息
                case Constant.MSGTEXT:

                    //文本消息格式：接收者ID卍发送者ID卍消息内容卍发送时间卍发送人名字
                    string message = System.Text.Encoding.UTF8.GetString(info);
                    
                    //得到含有5个元素的数组
                    string[] msgs = Regex.Split(message, Constant.SPLIT, RegexOptions.IgnoreCase);
                    
                    //消息存在msg对象中
                    Msg msg = new Msg(msgs, 0, 0);
                    try
                    {
                        //按照ID查找listbox中的subItem
                        ChatListSubItem[] items = chatListBox_contacts.GetSubItemsById(Convert.ToUInt32(msgs[1]));

                        //聊天窗口的标题
                        string windowsName = items[0].NicName + ' ' + items[0].ID;

                        //查找是否已经存在窗口
                        IntPtr handle = NativeMethods.FindWindow(null, windowsName);

                        //聊天窗口已存在
                        if (handle != IntPtr.Zero)
                        {
                            msg.IsReaded = 1;
                            Form frm = (Form)Form.FromHandle(handle);

                            //激活
                            frm.Activate();

                            //传送消息到聊天窗口
                            this.OnReceive(msg);
                        }
                        else
                        {
                            //头像闪烁
                            twinkle(chatListBox_contacts, Convert.ToUInt32(msgs[1]));
                        }
                        //消息存入数据库
                        MsgDB.uniqueInstance.addMsg(msg);
                    }
                    catch 
                    {
                        MsgDB.uniqueInstance.addMsg(msg); 
                    }
                    break;
                
                //处理图片
                case Constant.MSGIMG:
                    MsgImg msgimg = ImageUtil.bytesToIdImg(info);
                    //存储图片
                    ImageUtil.ImgSave(msgimg.Id, msgimg.Img);
                    break;
                case Constant.MSG_ADDFRIEND_APPLY:
                    string infostr = System.Text.Encoding.UTF8.GetString(info);
                    
                    //info格式:ID卍昵称卍性别卍生日卍地址卍注册时间
                    sysmsg.Content = infostr;
                    sysmsg.Type = Constant.MSG_ADDFRIEND_APPLY;
                    SystemMsgDB.instance.addSystemMsg(sysmsg.Content, sysmsg.Type);//存入数据库
                    break;
                case Constant.MSG_ADDFRIEND_AGREE:
                    //info格式:ID卍昵称卍性别卍生日卍地址卍注册时间
                    string userInfo= System.Text.Encoding.UTF8.GetString(info);

                    //分割info
                    string[] userInfos = Regex.Split(userInfo, Constant.SPLIT, RegexOptions.IgnoreCase);
                        
                    //把消息存进数据库
                    sysmsg.Content = userInfo;
                    sysmsg.Type = Constant.MSG_ADDFRIEND_AGREE;
                    SystemMsgDB.instance.addSystemMsg(sysmsg.Content, sysmsg.Type);

                    //把好友存进数据库
                    Friend fr=new Friend();
                    fr.UserId=userInfos[0];
                    fr.UserName=userInfos[1];
                    fr.Sex=Convert.ToInt32(userInfos[2]);
                    fr.Birthday=userInfos[3];
                    fr.Address=userInfos[4];
                    fr.Time=userInfos[5];

                    FriendDB.uniqueInstance.addFriend(fr);

                    //刷新好友列表
                    displayFriend();
                    break;
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
            //获取选中的好友
            ChatListSubItem contactInfo = e.SelectSubItem;

            //取消头像闪烁状态
            contactInfo.IsTwinkle = false; 
            
            //聊天窗口的标题
            string windowsName = contactInfo.NicName + ' ' + contactInfo.ID;
            
            //查找是否已经存在窗口
            IntPtr handle = NativeMethods.FindWindow(null, windowsName);
            
            //窗口已存在
            if (handle != IntPtr.Zero)
            {
                //激活
                Form frm = (Form)Form.FromHandle(handle);
                frm.Activate();
            }
            else
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
            //按照ID查找listbox中的用户
            ChatListSubItem[] items=listBox.GetSubItemsById(id);
            
            //开启闪烁
            items[0].IsTwinkle = true;
        }
        #endregion

        #region 接收传送消息到chat的委托

        //声明关于事件的委托
        public delegate void ReceiveEventHandler(object sender, EventArgs e, Msg msg);

        //声明事件
        public event ReceiveEventHandler Receive;

        //引发事件的函数；
        public void OnReceive(Msg msg)
        {
            if (this.Receive != null)
            {
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
            this.Show();
            //if (this.timer_tray.Enabled == true)
            //{

            //    //string msgId = SystemMsgUtil.getNewestMsg();
            //    //if (msgId == "10000")
            //    //{
            //        //Form_SystemMsg form_systemMsg = new Form_SystemMsg(rapidPassiveEngine, myInfo);
            //        //form_systemMsg.Show();
            //    //}
            //    //this.timer_tray.Enabled = false;    //计时器停止
            //    //tray.Icon = icon_normal;
            //}
        }
        #endregion   

        #region 返回个人资料时回调的方法
        private void diaplayUser(Exception ee, byte[] response, object tag)
        {
            //反序列化返回的消息生成list
            ObjSerial<List<string>> se = new ObjSerial<List<string>>();
            List<string> list = se.deserializeBytes(response);

            foreach (string srtings in list)
            {
                //string的形式：ID卍昵称卍性别卍生日卍地址卍注册时间
                string[] userInfo = Regex.Split(srtings, Constant.SPLIT, RegexOptions.IgnoreCase);
                this.myInfo.NicName = userInfo[1];
                this.myInfo.DisplayName = userInfo[1];
                if (userInfo[2] == "1")
                {
                    this.myInfo.Sex = ChatListSubItemExtend.UserSex.Man;
                }
                else if (userInfo[2] == "0")
                {
                    this.myInfo.Sex = ChatListSubItemExtend.UserSex.Women;
                }
                this.myInfo.Birth = userInfo[3];
                this.myInfo.Address = userInfo[4];
                this.myInfo.RegistrationDate = userInfo[5];
                lbl_userName.Text =myInfo.NicName +" "+ myInfo.ID.ToString();
            }
        }
        #endregion
        private void skinButton1_Click(object sender, EventArgs e)
        {
            displayFriend();
        }
    }
}
