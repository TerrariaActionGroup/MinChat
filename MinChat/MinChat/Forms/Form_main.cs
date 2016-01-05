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
using MinChat.Works.utils;
using System;
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
            if (this.myInfo == null)
            {
                this.myInfo = new ChatListSubItem();
            }
            this.rapidPassiveEngine = rapidPassiveEngine;
            this.myInfo.ID = Convert.ToUInt32(rapidPassiveEngine.CurrentUserID);
            //加载分组
            ChatListItem gp = new ChatListItem();//new一个分组
            gp.Text = "TestList";
            ChatListSubItemExtend people = new ChatListSubItemExtend();
            if(myInfo.ID==10086)
            {
                people.Sex = ChatListSubItemExtend.UserSex.Man;
                people.ID = 10010;
                people.NicName = "联通";
                people.DisplayName="联不通";
            }
            else if(myInfo.ID==10010)
            {
                people.Sex = ChatListSubItemExtend.UserSex.Man;
                people.ID = 10010;
                people.NicName = "移动";
                people.DisplayName="移不动";
            }
            gp.SubItems.Add(people);

            //获取在线用户的ID
            List<string> list=rapidPassiveEngine.FriendsOutter.GetAllOnlineFriends();
            foreach(string friendId in list)
            {
                if (friendId != myInfo.ID.ToString() && chatListBox_contacts.GetSubItemsById(Convert.ToUInt32(friendId)).Length==0)
                {
                    ChatListSubItemExtend contact = new ChatListSubItemExtend();
                    contact.ID = Convert.ToUInt32(friendId);
                    contact.NicName = friendId;
                    //contact.Sex = ChatListSubItemSex.UserSex.Man;//性别
                    gp.SubItems.Add(contact);
                }
            }
            chatListBox_contacts.Items.Add(gp);//添加到listBox中
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
        #region 处理好友上下线
        void FriendOffline(string friendId)
        {
            //chatListBox_contacts.GetSubItemsById(Convert.ToUInt32(friendId))[0].Status = ChatListSubItem.UserStatus.OffLine;
        }
        void FriendConnected(string friendId)
        {
            //chatListBox_contacts.GetSubItemsById(Convert.ToUInt32(friendId))[0].Status = ChatListSubItem.UserStatus.Online;
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
        #region 引擎接口实现
        /// <summary>
        /// 处理接收到的信息（包括大数据块信息）。
        /// </summary>
        /// <param name="sourceUserID">发出信息的用户ID。如果为null，表示信息来自服务端。</param>
        /// <param name="informationType">自定义信息类型</param>
        /// <param name="info">信息</param>
        public void HandleInformation(string sourceUserID, int informationType, byte[] info) 
        {
            if (sourceUserID != null)
            {
                switch (informationType)
                {
                    case Constant.MSGTEXT://普通文本消息
                        //取出收到的消息,接收者ID卍发送者ID卍消息内容卍发送时间卍发送人名字
                        string message = System.Text.Encoding.UTF8.GetString(info);

                        string[] msgs = Regex.Split(message, Constant.SPLIT, RegexOptions.IgnoreCase);//得到含有5个元素的数组
                        Msg msg = new Msg(msgs, 0, 0);//消息存在msg对象中

                        ChatListSubItem[] items = chatListBox_contacts.GetSubItemsById(Convert.ToUInt32(sourceUserID));//按照ID查找listbox中的用户
                        string windowsName = items[0].NicName + ' ' + items[0].ID;//聊天窗口的标题
                        IntPtr handle = NativeMethods.FindWindow(null, windowsName);//查找是否已经存在窗口
                        if (handle != IntPtr.Zero)//如果聊天窗口已存在
                        {
                            msg.IsReaded = 1;
                            Form frm = (Form)Form.FromHandle(handle);
                            frm.Activate();//激活
                            this.OnReceive(msg);//传送消息到聊天窗口
                        }
                        else//聊天窗口不存在
                        {
                            twinkle(chatListBox_contacts, Convert.ToUInt32(sourceUserID));//头像闪烁
                        }
                        //把msg存入数据库
                        MsgDB db = MsgDB.OpenMsgDB(myInfo.ID.ToString());
                        db.addMsg(msg);
                        break;
                    case Constant.MSGIMG://图片
                        MsgImg msgimg = ImageUtil.bytesToIdImg(info);
                        ImageUtil.ImgSave(msgimg.Id, msgimg.Img);//存储图片
                        //MessageBox.Show(msgimg.Img.Tag.ToString());
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
        public byte[] HandleQuery(string sourceUserID, int informationType, byte[] info) { return new byte[1]; }
        #endregion
        #region 双击好友弹窗对话框
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
    }
}
