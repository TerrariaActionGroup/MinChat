using MinChat.Communications.bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MinChat.Works.util
{
    class ImgTextParser
    {
        /// <summary>
        /// 序列化对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] serializeObject(object obj)
        {
            byte[] data = ESBasic.Helpers.SerializeHelper.SerializeObject(obj);
            return data;
        }

        public static List<ImgText> deserializeBytes(byte[] info)
        {
            return (List<ImgText>)ESBasic.Helpers.SerializeHelper.DeserializeBytes(info, 0, info.Length);
        }
    }
}
