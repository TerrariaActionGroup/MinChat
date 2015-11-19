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
namespace MinChat.Forms
{
    public partial class Form_login : CCSkinMain
    {
        public Form_login()
        {
            InitializeComponent();
        }
        #region 变量
        /// <summary>
        /// 主窗体
        /// </summary>
        Form_login main;
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
