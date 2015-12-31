using ESFramework.Server.UserManagement;
using MinChatServer.db;
using MinChatServer.es;
using MinChatServer.form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinChatServer.db.dao;
using MinChatServer.db.bean;

namespace MinChatServer
{
    static class Program
    {
        //获取服务器引擎
        private static ESPlus.Rapid.IRapidServerEngine RapidServerEngine = ESPlus.Rapid.RapidEngineFactory.CreateServerEngine();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //如果是其它类型的授权用户，请使用下面的语句设定正确的授权用户ID和密码。              
            ESPlus.GlobalUtil.SetAuthorizedUser("FreeUser", "");

            //创建数据库目录
            FileHelper fileHelper = new FileHelper();
            fileHelper.createDbDirectory();
            fileHelper = null;

            //创建全局数据库
            DBManager dbManager = DBManager.getInstance();
            dbManager.createGlobalDb();
            dbManager.createGroupTable();
            dbManager.createUserTable();
            dbManager.createGroupDb();

            //测试使用
            dbManager.createUserDb("2928851885");
            dbManager.createRelationTable("2928851885");

            //设置好友管理器
            FriendsManager friendManager = new FriendsManager();
            RapidServerEngine.FriendsManager = friendManager;

            //设置分组管理器
            GroupManager groupManager = new GroupManager();
            RapidServerEngine.GroupManager = groupManager;

            //初始化服务端引擎
            RapidServerEngine.Initialize(4530, new CustomizeHandler(), new BasicHandler());
            //RapidServerEngine初始化成功后，其UserManager属性才可用。
            friendManager.UserManager = RapidServerEngine.UserManager; 
            groupManager.UserManager = RapidServerEngine.UserManager;

            //设置重登陆模式
            RapidServerEngine.UserManager.RelogonMode = RelogonMode.ReplaceOld;

            FormMain formMain = new FormMain(RapidServerEngine);
            Application.Run(formMain);
        }
    }
}
