using ESPlus.Rapid;
using MinChat.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinChat.Works.db;
using MinChat.Communications.bean;

namespace MinChat
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IRapidPassiveEngine rapidPassiveEngine = ESPlus.Rapid.RapidEngineFactory.CreatePassiveEngine();
            Form_main mainForm = new Form_main();
            Form_login loginForm = new Form_login(rapidPassiveEngine, mainForm); //在LoginForm中初始化客户端引擎RapidPassiveEngine
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                mainForm.InitMain(rapidPassiveEngine);
                Application.Run(mainForm);
            }
        }
    }
}
