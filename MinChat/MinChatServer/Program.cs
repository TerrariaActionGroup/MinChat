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

            //创建数据库目录以及存放头像文件
            FileHelper fileHelper = new FileHelper();
            fileHelper.createDbDirectory();
            fileHelper.createAvatarDirectory();
            fileHelper = null;

            //创建全局数据库
            DBManager dbManager = DBManager.getInstance();
            dbManager.createGlobalDb();
            dbManager.createGroupTable();
            dbManager.createUserTable();
            dbManager.createGroupDb();

            //设置好友管理器
            FriendsManager friendManager = new FriendsManager();
            RapidServerEngine.FriendsManager = friendManager;

            //设置分组管理器
            GroupManager groupManager = new GroupManager();
            RapidServerEngine.GroupManager = groupManager;

            //设置基础管理器和消息管理器
            BasicHandler basicHandler = new BasicHandler();
            CustomizeHandler customizeHandler = new CustomizeHandler(RapidServerEngine);

            //初始化服务端引擎
            RapidServerEngine.Initialize(4530, customizeHandler, basicHandler);
            //RapidServerEngine初始化成功后，其UserManager属性才可用。
            friendManager.UserManager = RapidServerEngine.UserManager; 
            groupManager.UserManager = RapidServerEngine.UserManager;
            basicHandler.UserManager = RapidServerEngine.UserManager;
            customizeHandler.UserManager = RapidServerEngine.UserManager;

            //基础功能初始化
            basicHandler.InitBasicFunction(RapidServerEngine);

            //设置重登陆模式
            RapidServerEngine.UserManager.RelogonMode = RelogonMode.ReplaceOld;

            FormMain formMain = new FormMain(RapidServerEngine);
            Application.Run(formMain);
        }
    }
}
