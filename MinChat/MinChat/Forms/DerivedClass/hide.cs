using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MinChat.Forms.DerivedClass
{
    /// <summary>
    /// 吸附窗体
    /// </summary>
    class hide
    {
        private Form frm1;
        private Timer timer1;
        /// <summary>
        /// 吸附窗体
        /// </summary>
        /// <param name="frm">要吸附的窗体</param>
        /// <param name="timer">计时器对象</param>
        public hide(Form frm, Timer timer)
        {
            this.frm1 = frm;
            this.timer1 = timer;
            this.frm1.LocationChanged += new EventHandler(frm1_LocationChanged);
            this.frm1.TopMost = true;
            this.timer1.Enabled = true;
            this.timer1.Interval = 100;
            this.timer1.Tick += new EventHandler(timer1_Tick);
            this.timer1.Start();

        }
        internal AnchorStyles stopAnchor = AnchorStyles.None;
        /// <summary>
        /// 计时器控制函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void timer1_Tick(object sender, EventArgs e)
        {
            if (frm1.Bounds.Contains(Cursor.Position))
            {
                switch (this.stopAnchor)
                {
                    case AnchorStyles.Top:
                        frm1.Location = new Point(frm1.Location.X, 0);
                        break;
                    case AnchorStyles.Left:
                        frm1.Location = new Point(0, frm1.Location.Y);
                        break;
                    case AnchorStyles.Right:
                        frm1.Location = new Point(Screen.PrimaryScreen.Bounds.Width - frm1.Width, frm1.Location.Y);
                        break;
                    case AnchorStyles.Bottom:
                        frm1.Location = new Point(frm1.Location.X, Screen.PrimaryScreen.Bounds.Height - frm1.Height);
                        break;
                }
            }
            else
            {
                switch (this.stopAnchor)
                {
                    case AnchorStyles.Top:
                        frm1.Location = new Point(frm1.Location.X, (frm1.Height - 2) * (-1));
                        break;
                    case AnchorStyles.Left:
                        frm1.Location = new Point((-1) * (frm1.Width - 2), frm1.Location.Y);
                        break;
                    case AnchorStyles.Right:
                        frm1.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 2, frm1.Location.Y);
                        break;
                    case AnchorStyles.Bottom:
                        frm1.Location = new Point(frm1.Location.X, (Screen.PrimaryScreen.Bounds.Height - 2));
                        break;
                }
            }
        }
      
        private void mStopAnchor()
        {
            if (frm1.Top <= 0 && frm1.Left <= 0)
            {
                stopAnchor = AnchorStyles.None;
            }
            else if (frm1.Top <= 0)
            {
                stopAnchor = AnchorStyles.Top;
            }
            else if (frm1.Left <= 0)
            {
                stopAnchor = AnchorStyles.Left;
            }
            else if (frm1.Left >= Screen.PrimaryScreen.Bounds.Width - frm1.Width)
            {
                stopAnchor = AnchorStyles.Right;
            }
            else if (frm1.Top >= Screen.PrimaryScreen.Bounds.Height - frm1.Height)
            {
                stopAnchor = AnchorStyles.Bottom;
            }
            else
            {
                stopAnchor = AnchorStyles.None;
            }
        }

        /// <summary>
        /// 窗体移动触发函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm1_LocationChanged(object sender, EventArgs e)
        {
            this.mStopAnchor();
        }

    }
}
