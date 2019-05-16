using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class FinishCertify : Utils.Object2JsonUtil
    {
        public string operators { get; set; }//操作员号
        public string flow_no { get; set; }//流水号
        public string uidlist { get; set; }//所有商品guid拼接而成
        public string puidlist { get; set; }//所有付款的guid拼接而成
        public string consumers_id { get; set; }//
        public string memo { get; set; }//备用
    }
}
