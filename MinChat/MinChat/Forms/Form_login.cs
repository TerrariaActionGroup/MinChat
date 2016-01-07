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
using ESPlus.Rapid;
using ESPlus.Application.CustomizeInfo;
using ESPlus.Application.Basic;
using MinChat.Settings;
using MinChat.Works.db;

namespace MinChat.Forms
{
    public partial class Form_login : Skin_Mac
    {   
        #region 变量
        /// <summary>
        /// 客户端引擎
        /// </summary>
        IRapidPassiveEngine engine;

        //配置类
        private SystemSettings settings;

        /// <summary>
        /// 自定义消息处理器
        /// </summary>
        Form_main _main;
        #endregion  
   
        #region 窗口构造函数
        public Form_login(IRapidPassiveEngine rapidPassiveEngine,Form_main formMain)
        {
            this.engine = rapidPassiveEngine;
            this._main = formMain;
            this.settings = SystemSettings.Singleton;
            InitializeComponent();
            initTxt();
        }
        #endregion

        /// <summary>
        /// 初始化账号密码等
        /// </summary>
        private void initTxt()
        {
            if (this.settings.Remember == true)
            {
                this.ckMen.Checked = true;
                this.txtId.Text = this.settings.UserId;
                this.txtPwd.Text = this.settings.Password;
            }
        }

        #region 登陆事件
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text.Trim().Length == 0)
            {
                lbl_error.Text = "账号不能为空";
                return;
            }
            if (this.txtPwd.Text.Trim().Length == 0)
            {
                lbl_error.Text = "密码不能为空";
                return;
            }
            this.settings.UserId = this.txtId.Text.Trim();
            this.settings.Password = this.txtPwd.Text.Trim();
            this.settings.Save();
            login();
        }
        private void login()
        {
            initDB(this.txtId.Text);
            LogonResult logonResult;
            logonResult = login(this.txtId.Text, this.txtPwd.Text);

            if (logonResult == LogonResult.Failed)
            {
                lbl_error.Text="用户名或密码错误！";
                return;
            }

            if (logonResult == LogonResult.HadLoggedOn)
            {
                lbl_error.Text="已经在其它地方登陆！";
                return;
            }
            tray.Visible = false;
            //初始化数据库
            
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
        //初始化数据库
        void initDB(string ID)
        {            
            //建立数据库的链接
            SystemMsgDB.OpenSysMsgDB(ID);
            MsgDB.OpenMsgDB(ID);
            FriendDB.OpenDB(ID);
        }
        private void ckMen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckMen.Checked == true)
            {
                settings.Remember = true;
            }
            else
            {
                settings.Remember = false;
            }
        }

        private void Form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.settings.Save();
        }
    }
}


