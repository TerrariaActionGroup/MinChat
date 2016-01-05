using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChatServer.db
{
    class FileHelper
    {
        public bool createDbDirectory()
        {
            bool result = true;
            try
            {
                string basePath = Environment.CurrentDirectory + "\\";
                createDirectory(basePath + "data");
                basePath += "data\\";
                createDirectory(basePath + "globalDb");
                createDirectory(basePath + "groupDb");
                createDirectory(basePath + "userDb");
            }
            catch (Exception e)
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// 创建存放用户头像的文件夹
        /// </summary>
        /// <returns></returns>
        public bool createAvatarDirectory()
        {
            string path = Environment.CurrentDirectory + "\\data\\avatar";
            if (createDirectory(path) == true)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 创建一个目录
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool createDirectory(string path)
        {
            try
            {
                if(Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                    return true;
                }
                
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }

        /// <summary>
        /// 创建一个文件
        /// </summary>
        /// <param name="path">文件名或者带路径的文件名</param>
        /// <returns></returns>
        public void createFile(string path)
        {
            try
            {
                if (File.Exists(path) == false)
                {
                    File.Create(path);
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}
