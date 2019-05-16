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

        //获取唯一的32位订单号 
        //生成规则 10位门店号 + 10位pos机号 + 6位日期 + 6位小票号
       
    }
}
