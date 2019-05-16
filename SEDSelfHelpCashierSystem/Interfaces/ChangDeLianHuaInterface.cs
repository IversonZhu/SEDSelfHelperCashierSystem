using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Interfaces
{
    public class ChangDeLianHuaInterface
    {
        private static ChangDeLianHuaInterface changDeLianHuaInterface = new ChangDeLianHuaInterface();

        private ChangDeLianHuaInterface()
        {

        }

        public static ChangDeLianHuaInterface Instance
        {
            get
            {
                return changDeLianHuaInterface;
            }
        }
    }
}
