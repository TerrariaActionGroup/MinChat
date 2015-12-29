using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChatServer.db.bean
{
    class Constant
    {
        public static string globalDbPath = Environment.CurrentDirectory + "\\data\\globalDb\\";
        public static string groupDbPath = Environment.CurrentDirectory + "data\\groupDb\\";
        public static string userDbPath = Environment.CurrentDirectory + "data\\userDb\\";
    }
}
