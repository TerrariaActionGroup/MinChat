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

namespace MinChatServer.form
{
    public partial class FormMain : Form
    {
        //通信引擎
        IRapidServerEngine rapidServerEngine;

        public FormMain(IRapidServerEngine engine)
        {
            this.rapidServerEngine = engine;
            InitializeComponent();
        }
    }
}
