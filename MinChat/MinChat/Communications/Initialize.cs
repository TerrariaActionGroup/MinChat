using ESPlus.Rapid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Communications
{
    class Initialize
    {
         public static IRapidPassiveEngine initMinchat(){
             IRapidPassiveEngine engine = RapidEngineFactory.CreatePassiveEngine();

             return engine;
        } 
    }
}
