using CCWin;
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

namespace MinChat.Forms
{
    public partial class Form_userInfo : CCSkinMain
    {
        #region 变量
        private ChatListSubItem item;
        private Point point;
        #endregion
        #region 窗口构造函数
        public Form_userInfo()
        {
            InitializeComponent();
        }
        #endregion
        #region 用户信息及位置赋值
        /// <summary>
        /// 用户信息及位置赋值
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="point"></param>
        public void SetUserData(ChatListSubItem Item, Point point)
        {
            this.Item = Item;
            this.Location = this.point = point;
        }
        #endregion
        #region 用户信息
        public ChatListSubItem Item
        {
            get
            {
                return item;
            }
            set
            {
                if (item != value)
                {
                    item = value;
                    lbl_userName.Text = item.NicName;
                    lbl_PersonalMsg.Text = item.PersonalMsg;
                    picBox.Image = item.QQShow;
                }
            }
        }
        #endregion
        #region 悬浮至好友Q名时
        private void lblChatName_MouseEnter(object sender, EventArgs e)
        {
            lbl_userName.Font = new Font("微软雅黑", 16F, FontStyle.Underline);
        }
        #endregion
        #region 离开好友Q名时
        private void lblChatName_MouseLeave(object sender, EventArgs e)
        {
            lbl_userName.Font = new Font("微软雅黑", 16F);
        }
        #endregion
        #region 窗口加载时
        private void FrmInformation_Load(object sender, EventArgs e)
        {
            //初始化窗口出现位置
            this.Location = point;
        }
        #endregion
        #region 窗体重绘时
        private void FrmUserInformation_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush sb = new SolidBrush(Color.FromArgb(100, 255, 255, 255));
            g.FillRectangle(sb, new Rectangle(new Point(1, Height - 103), new Size(Width - 2, 80)));
        }
        #endregion  
        #region 计时器
        public bool isMove = false;
        private void timShow_Tick(object sender, EventArgs e)
        {

        }

        private bool isFMove = false;

        public bool IsFMove
        {
            get 
            { 
                return isFMove; 
            }
            set
            {
                isFMove = value;
                timMove.Enabled = value;
            }
        }
        private void timMove_Tick(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
