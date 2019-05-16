using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class ResetCertify : Utils.Object2JsonUtil
    {
        public string operators { get; set; }//操作员号
        public string flag { get; set; }//默认为0
        public string flow_no { get; set; }//交易单号
    }
}
