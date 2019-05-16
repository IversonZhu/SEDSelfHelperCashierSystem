using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    class HeartBackInfoRtn : Utils.Object2JsonUtil
    {
        public string retflag { get; set; }//返回标志
        public string retmsg { get; set; }//返回的信息
    }
}
