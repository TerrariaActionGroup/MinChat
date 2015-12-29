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
        /// 创建一个目录
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public void createDirectory(string path)
        {
            try
            {
                if(Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                }
                
            }
            catch (Exception e)
            {
                
            }
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
