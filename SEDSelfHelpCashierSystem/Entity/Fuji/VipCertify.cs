using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class VipCertify : Utils.Object2JsonUtil
    {
        public string operators { get; set; }//操作员号
        public string flow_no { get; set; }//当前流水号
        public string vipno { get; set; }//会员卡磁条信息
        public string certifytype { get; set; }//默认传erp
    }
}
