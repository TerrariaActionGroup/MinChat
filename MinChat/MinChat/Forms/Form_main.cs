using CCWin;
using CCWin.SkinClass;
using CCWin.SkinControl;
using CCWin.Win32;
using ESPlus.Application;
using ESPlus.Application.CustomizeInfo;
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
    public partial class Form_main : CCSkinMain,ICustomizeHandler
    {        
        #region 变量
        /// <summary>
        /// ID
        /// </summary>
        string ID;//用户的ID
        Form_main main;
        #endregion     
        public Form_main()
        {
            InitializeComponent();
        }
        #region 引擎接口实现
        /// <summary>
        /// 处理接收到的信息（包括大数据块信息）。
        /// </summary>
        /// <param name="sourceUserID">发出信息的用户ID。如果为null，表示信息来自服务端。</param>
        /// <param name="informationType">自定义信息类型</param>
        /// <param name="info">信息</param>
        public void HandleInformation(string sourceUserID, int informationType, byte[] info) { }

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
            if (es.Button == MouseButtons.Right)
            {
                return;
            }
            ChatListSubItem item = e.SelectSubItem;
            item.IsTwinkle = false;

            //bool isFormexist;
            string windowsName = "与 " + item.NicName + " 对话中";
            IntPtr handle = NativeMethods.FindWindow(null, windowsName);
            if (handle != IntPtr.Zero)
            {
                Form frm = (Form)Form.FromHandle(handle);
                frm.Activate();
            }
            else
            {
                //ipSend为从列表中取出，要发送的对象的IP
                Form_Chat fChat = new Form_Chat(item);
                fChat.Text = "与 " + item.NicName + " 对话中";
                fChat.Show();
            }
        }
        #endregion


    }
}
