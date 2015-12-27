using CCWin;
using CCWin.SkinClass;
using CCWin.SkinControl;
using CCWin.Win32;
using ESBasic;
using ESPlus.Application;
using ESPlus.Application.CustomizeInfo;
using ESPlus.Rapid;
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
    public partial class Form_main : Skin_Mac,ICustomizeHandler
    {        
        #region 变量
        /// <summary>
        /// 用户的ID
        /// </summary>
        string ID;//用户的ID
        /// <summary>
        /// 用户的昵称
        /// </summary>
        string name;
        /// <summary>
        /// 用户的状态
        /// </summary>
        string status;
        /// <summary>
        /// 客户端引擎
        /// </summary>
        IRapidPassiveEngine rapidPassiveEngine;
        #endregion     
        public Form_main()
        {
            
            InitializeComponent();
            //InitMain();
        }
        public void InitMain(IRapidPassiveEngine rapidPassiveEngine)
        {
            this.rapidPassiveEngine = rapidPassiveEngine;
            //加载分组
            //ChatListItem gp = new ChatListItem();//new一个分组
            //chatListBox.Items.Add(gp);//添加到list中
            //预订接收到广播消息的处理事件
<<<<<<< HEAD
            CbGeneric<string, string, int, byte[]> a = new CbGeneric<string, string, int, byte[]>(GroupOutter_BroadcastReceived);
            //this.rapidPassiveEngine.GroupOutter.BroadcastReceived += new CbGeneric<string, string, int, byte[]>(GroupOutter_BroadcastReceived);
=======
            this.rapidPassiveEngine.GroupOutter.BroadcastReceived += new CbGeneric<string, string, int, byte[]>(GroupOutter_BroadcastReceived);
        
>>>>>>> 2e7ebb01c3da006db8cbed36fb65c91a63d41c42
        }


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
<<<<<<< HEAD
=======


>>>>>>> 2e7ebb01c3da006db8cbed36fb65c91a63d41c42
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
                MessageBox.Show("收到消息");
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
            //if (es.Button == MouseButtons.Right)
            //{
            //    return;
            //}
            ChatListSubItem item = e.SelectSubItem;//获取选中的好友

            item.IsTwinkle = false; //取消头像闪烁状态
            string windowsName = "与 " + item.NicName + " 对话中";//聊天窗口的标题
            IntPtr handle = NativeMethods.FindWindow(null, windowsName);//查找是否已经存在窗口
            if (handle != IntPtr.Zero)//窗口已存在，激活
            {
                Form frm = (Form)Form.FromHandle(handle);
                frm.Activate();
            }
            else//窗口不存在，new
            {
                Form_Chat fChat = new Form_Chat(this.rapidPassiveEngine,item);
                fChat.Text = "与 " + item.NicName + " 对话中";
                fChat.Show();
            }
        }
        #endregion


    }
}
