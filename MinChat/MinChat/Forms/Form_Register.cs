using CCWin;
using MinChat.Settings;
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
    public partial class Form_Register : Skin_Mac
    {
        public Form_Register()
        {
            InitializeComponent();
            this.radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nickName = this.textBox1.Text;
            string pwd = this.textBox2.Text;
            string age = this.textBox3.Text;
            string birthday = this.textBox4.Text;
            string addr = this.textBox5.Text;
            int sex = 1;
            if (this.radioButton2.Checked == true)
            {
                sex = 0;
            }
            string split = Constant.SPLIT;
            string sendStr = pwd + split + nickName + split + sex + split + age + split + birthday + split + addr;
            //拼接方式：密码卍昵称卍性别卍年龄卍生日卍地址
        }
    }
}
