using CCWin;
using CCWin.SkinControl;
using CCWin.Win32;
using ESBasic;
using ESPlus.Application.CustomizeInfo;
using ESPlus.Rapid;
using MinChat.Communications;
using MinChat.Settings;
using MinChat.Works.db;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MinChat.Forms
{
    public partial class Form_main : Skin_Mac,ICustomizeHandler
    {        
        #region 变量
        //ChatListSubItem UserItem { get; set; }//好友列表
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
            if(this.myInfo==null)
            {
                this.myInfo = new ChatListSubItem();
            }
            this.rapidPassiveEngine = rapidPassiveEngine;
            this.myInfo.ID = Convert.ToUInt32(rapidPassiveEngine.CurrentUserID);
            
            //加载分组
            ChatListItem gp = new ChatListItem();//new一个分组
            gp.Text = "TestList";
            ChatListSubItem people = new ChatListSubItem();

            if (myInfo.ID == 10010)
            {
                lbl_userName.Text = "联通";
                people.ID = 10086;//ID
                people.NicName = "移动";//昵称
                people.DisplayName = "X";//备注名
                people.PersonalMsg = "买买买买买";
            }
            else if(myInfo.ID==10086)
            {
                lbl_userName.Text = "移动";
                people.ID = 10010;//ID
                people.NicName = "联通";//昵称
                people.DisplayName = "X";//备注名
                people.PersonalMsg = "买买买买买";
            }
            gp.SubItems.Add(people);
            //chatListBox_contacts.GetSubItemsById();//按照ID查找listbox中的用户

            chatListBox_contacts.Items.Add(gp);//添加到listBox中

            //预订接收到广播消息的处理事件
            this.rapidPassiveEngine.GroupOutter.BroadcastReceived += new CbGeneric<string, string, int, byte[]>(GroupOutter_BroadcastReceived);
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
            if(sourceUserID!=null)
            {
                switch (informationType)
                {
                    case 1://普通文本消息
                        //取出收到的消息,接收者ID卍发送者ID卍消息内容卍发送时间卍发送人名字
                        string message = System.Text.Encoding.UTF8.GetString(info);

                        string[] msgs = Regex.Split(message, Constant.SPLIT, RegexOptions.IgnoreCase);//得到含有5个元素的数组
                        Msg msg = new Msg(msgs, 1, 0);//消息存在msg对象中

                        ChatListSubItem[] items = chatListBox_contacts.GetSubItemsById(Convert.ToUInt32(sourceUserID));//按照ID查找listbox中的用户
                        string windowsName = items[0].NicName + ' ' + items[0].ID;//聊天窗口的标题
                        IntPtr handle = NativeMethods.FindWindow(null, windowsName);//查找是否已经存在窗口
                        if (handle != IntPtr.Zero)//如果聊天窗口已存在
                        {
                            Form frm = (Form)Form.FromHandle(handle);
                            frm.Activate();//激活
                            this.OnReceive(msg);//传送消息到聊天窗口
                        }
                        else//聊天窗口不存在
                        {
                            MsgDB db = MsgDB.OpenMsgDB(myInfo.ID.ToString());
                            db.addMsg(msg);
                            twinkle(chatListBox_contacts, Convert.ToUInt32(sourceUserID));//头像闪烁
                        }
                        break;
                    case 2:
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
            ChatListSubItem item = e.SelectSubItem;//获取选中的好友
            item.IsTwinkle = false; //取消头像闪烁状态
            string windowsName = item.NicName + ' ' + item.ID;//聊天窗口的标题
            IntPtr handle = NativeMethods.FindWindow(null, windowsName);//查找是否已经存在窗口
            if (handle != IntPtr.Zero)//窗口已存在
            {
                Form frm = (Form)Form.FromHandle(handle);
                frm.Activate();//激活
            }
            else//窗口不存在
            {
                Form_Chat fChat = new Form_Chat(this.rapidPassiveEngine,item,this.myInfo,this);
                fChat.Text =item.NicName+' '+item.ID;
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
        //#region 好友列表悬浮头像时
        //private Form_userInfo userInfo;
        //private void chatShow_MouseEnterHead(object sender, ChatListEventArgs e)
        //{
        //    if (userInfo == null || userInfo.IsDisposed)//不存在就new一个
        //    {
        //        userInfo = new Form_userInfo();
        //    }
        //    //定位
        //    int top = this.Top + this.chatTab.Top + this.chatTab.ItemSize.Height + (e.MouseOnSubItem.HeadRect.Y - this.chatListBox_contacts.chatVScroll.Value);
        //    int left = this.Left - 279 - 5;
        //    int ph = Screen.GetWorkingArea(this).Height;

        //    if (top + 181 > ph)
        //    {
        //        top = ph - 181 - 5;
        //    }

        //    if (left < 0)
        //    {
        //        left = this.Right + 5;
        //    }
        //    userInfo.IsFMove = false;
        //    this.userInfo.Item = e.MouseOnSubItem;
        //    this.userInfo.SetUserData(e.MouseOnSubItem, new Point(left, top));
        //    this.userInfo.Show();
        //}
        //#endregion
        //#region 好友列表离开头像时
        //private void chatShow_MouseLeaveHead(object sender, ChatListEventArgs e)
        //{
        //    if (userInfo != null && !userInfo.IsDisposed)
        //    {
        //        userInfo.IsFMove = true;
        //    }
        //}
        //#endregion
        //#region Q名悬浮离开时信息框
        ////悬浮时
        //private void lblName_MouseHover(object sender, EventArgs e)
        //{
        //    if (userInfo == null || userInfo.IsDisposed)
        //    {
        //        userInfo = new Form_userInfo();
        //    }
        //    int top = this.Top + lbl_userName.Top;
        //    int left = this.Left - 279 - 5;
        //    int ph = Screen.GetWorkingArea(this).Height;

        //    if (top + 181 > ph)
        //    {
        //        top = ph - 181 - 5;
        //    }

        //    if (left < 0)
        //    {
        //        left = this.Right + 5;
        //    }
        //    userInfo.IsFMove = false;
        //    this.userInfo.Item = UserItem;
        //    this.userInfo.SetUserData(UserItem, new Point(left, top));
        //    this.userInfo.Show();
        //}

        ////离开时
        //private void lblName_MouseLeave(object sender, EventArgs e)
        //{
        //    if (userInfo != null && !userInfo.IsDisposed)
        //    {
        //        userInfo.IsFMove = true;
        //    }
        //}
        //#endregion
    }
}
