using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Utils
{
    public class Object2JsonUtil
    {
        public string GetInfo()
        {
            return this.GetType().Name + '$' + Component.JsonHelper.GetJsonStr(this);
        }
    }
}
