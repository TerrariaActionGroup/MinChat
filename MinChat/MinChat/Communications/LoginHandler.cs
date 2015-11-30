using ESPlus.Application.Basic;
using ESPlus.Application.CustomizeInfo;
using ESPlus.Rapid;
using MinChat.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*功能：处理登录操作
 *时间：2015-11-23
 *作者：胡伟龙*/

namespace MinChat.Communications
{
    class LoginHandler
    {
        /*客户端Rapid引擎. 自定义消息处理器*/
        private IRapidPassiveEngine rapidPassiveEngine;
        private ICustomizeHandler customizeHandler;

        /*构造方法
         *参数：客户端Rapid引擎*/
        public LoginHandler(IRapidPassiveEngine engine, ICustomizeHandler handler)
        {
            this.rapidPassiveEngine = engine;
            this.customizeHandler = handler;
        }

        /*登录的方法
         *参数：经过检验的账号，密码*/
        public LogonResult login(string userID, string pwd)
        {
            //一个枚举类型，登录的标志，数字类型
            LogonResult logonResult = LogonResult.Succeed;

            try
            {
                //系统标志。引擎在初始化时会提交给服务器验证客户端是否是正确的系统
                this.rapidPassiveEngine.SystemToken = "";

                /*初始化引擎并登录，返回登录结果。如果登陆成功，引擎将与当前用户绑定,如果连接失败，则抛出异常
                 *完成客户端引擎的初始化，与服务器建立TCP连接，连接成功后立即验证用户密码。。
                 *参数1：当前登录的用户ID
                 *参数2：用户登陆密码
                 *参数3：服务器的IP地址
                 *参数4：服务器的端口       
                 *参数5：自定义处理器customizeHandler，用于处理服务器或其它用户发送过来的消息*/
                logonResult = this.rapidPassiveEngine.Initialize(userID, pwd, Constant.serverIP, Constant.serverPort, this.customizeHandler).LogonResult;
            }
            catch (Exception ee)
            {
                //MessageBox.Show(string.Format("连接服务器失败。{0}", ee.Message));
                //return;
            }
            return logonResult;

            //if (logonResult == LogonResult.Failed)
            //{
            //    MessageBox.Show("用户名或密码错误！");
            //    return;
            //}

            //if (logonResult == LogonResult.HadLoggedOn)
            //{
            //    MessageBox.Show("已经在其它地方登陆！");
            //    return;
            //}
        }
    }
}
