using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Settings
{
    [Serializable]
    class SystemSettings
    {
        //配置文件路径
        private static string SystemSettingsFilePath = "SystemSettings.dat";

        #region
        //账号
        private string userId;
        public string UserId 
        {
            get { return userId; }
            set { userId = value; }
        }

        //密码
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        //记住密码
        private bool remember;
        public bool Remember
        {
            get { return remember; }
            set { remember = value; }
        }

        //是否自动登录
        private bool autoLogin = false;
        public bool AutoLogin
        {
            get { return autoLogin; }
            set { autoLogin = value; }
        }

        #endregion

        #region
        private static SystemSettings singleton;
        /// <summary>
        /// 单例模式,获取配置信息类。
        /// </summary>
        public static SystemSettings Singleton
        {
            get
            {
                if (SystemSettings.singleton == null)
                {
                    SystemSettings.singleton = SystemSettings.Load();
                    if (SystemSettings.singleton == null)
                    {
                        SystemSettings.singleton = new SystemSettings();
                    }
                }

                return SystemSettings.singleton;
            }
        }

        private SystemSettings() { }

        public static void UserChanged()
        {
            SystemSettings.singleton = new SystemSettings();
        }
        #endregion

        #region
        /// <summary>
        /// 加载配置信息类
        /// </summary>
        /// <returns></returns>
        private static SystemSettings Load()
        {
            try
            {
                if (!File.Exists(SystemSettingsFilePath))
                {
                    return null;
                }

                byte[] data = ESBasic.Helpers.FileHelper.ReadFileReturnBytes(SystemSettingsFilePath);
                return (SystemSettings)ESBasic.Helpers.SerializeHelper.DeserializeBytes(data, 0, data.Length);
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);
                return null;
            }
        }

        /// <summary>
        /// 保存配置信息
        /// </summary>
        public void Save()
        {
            byte[] data = ESBasic.Helpers.SerializeHelper.SerializeObject(this);
            ESBasic.Helpers.FileHelper.WriteBuffToFile(data, SystemSettingsFilePath);
        }
        #endregion
    }
}
