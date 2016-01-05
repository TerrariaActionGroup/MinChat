using MinChat.Communications.bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MinChat.Works.util
{
    class ObjSerial<T>
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

        public T deserializeBytes(byte[] info)
        {
            return (T)ESBasic.Helpers.SerializeHelper.DeserializeBytes(info, 0, info.Length);
        }
    }
}
