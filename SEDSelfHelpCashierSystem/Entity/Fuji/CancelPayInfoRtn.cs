using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class CancelPayInfoRtn : Utils.Object2JsonUtil
    {
        public string retflag { get; set; }//返回标志
        public string retmsg { get; set; }//返回的信息
        public string flow_no { get; set; }//当前的流水号
    }
}
