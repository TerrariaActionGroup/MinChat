using CCWin;
using CCWin.SkinClass;
using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using MinChat.Communications;
using ESPlus.Rapid;
using ESPlus.Application.CustomizeInfo;
using ESPlus.Application.Basic;
using MinChat.Settings;

namespace MinChat.Forms
{
    public partial class Form_login : Skin_Mac
    {   
        #region 变量
        /// <summary>
        /// 客户端引擎
        /// </summary>
        IRapidPassiveEngine engine;

        /// <summary>
        /// 自定义消息处理器
        /// </summary>
        Form_main _main;
        #endregion     
        
        public Form_login(IRapidPassiveEngine rapidPassiveEngine,Form_main formMain)
        {
            this.engine = rapidPassiveEngine;
            this._main = formMain;

            InitializeComponent();
        }   
        #region 登陆事件
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        {
            LogonResult logonResult;
            logonResult=login(this.txtId.Text, this.txtPwd.Text);

            if (logonResult == LogonResult.Failed)
            {
                MessageBox.Show("用户名或密码错误！");
                return;
            }

            if (logonResult == LogonResult.HadLoggedOn)
            {
                MessageBox.Show("已经在其它地方登陆！");
                return;
            }
            this.DialogResult = DialogResult.OK; 
        }
        #endregion
        #region 托盘菜单事件
        /// <summary>
        /// 托盘图标双击显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolShowLogin_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.DialogResult = DialogResult.Abort; 

        }
        #endregion

        #region 登录方法
        /// <summary>
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="pwd"></param>
        public LogonResult login(string userID, string pwd)
        {
            //一个枚举类型，登录的标志，数字类型
            LogonResult logonResult = LogonResult.Succeed;

            try
            {
                //系统标志。引擎在初始化时会提交给服务器验证客户端是否是正确的系统
                this.engine.SystemToken = "";

                /*初始化引擎并登录，返回登录结果。如果登陆成功，引擎将与当前用户绑定,如果连接失败，则抛出异常
                 *完成客户端引擎的初始化，与服务器建立TCP连接，连接成功后立即验证用户密码。。
                 *参数1：当前登录的用户ID
                 *参数2：用户登陆密码
                 *参数3：服务器的IP地址
                 *参数4：服务器的端口       
                 *参数5：自定义处理器customizeHandler，用于处理服务器或其它用户发送过来的消息*/
                logonResult = this.engine.Initialize(userID, pwd, Constant.serverIP, Constant.serverPort, this._main).LogonResult;
            }
            catch (Exception ee)
            {
                //MessageBox.Show(string.Format("连接服务器失败。{0}", ee.Message));
                //return;
            }
            return logonResult;
        }
        #endregion
    }
}


