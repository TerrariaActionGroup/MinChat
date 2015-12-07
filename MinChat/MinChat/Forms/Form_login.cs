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

namespace MinChat.Forms
{
    public partial class Form_login : CCSkinMain
    {   
        #region 变量
        /// <summary>
        /// 主窗体
        /// </summary>
        Form_login main;

        /// <summary>
        /// 登陆处理器
        /// </summary>
        LoginHandler lghandler;
        #endregion     
        
        public Form_login(IRapidPassiveEngine rapidPassiveEngine, ICustomizeHandler customizeHandler)
        {
            lghandler = new LoginHandler(rapidPassiveEngine, customizeHandler);
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
            logonResult=lghandler.login(this.txtId.Text, this.txtPwd.Text);

            if (logonResult == LogonResult.Failed)
            {
                //MessageBox.Show("用户名或密码错误！");
                return;
            }

            if (logonResult == LogonResult.HadLoggedOn)
            {
                //MessageBox.Show("已经在其它地方登陆！");
                return;
            }
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
            if (main != null)
            {
                main.Show();
            }
            else
            {
                this.Show();
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion



    }
}
