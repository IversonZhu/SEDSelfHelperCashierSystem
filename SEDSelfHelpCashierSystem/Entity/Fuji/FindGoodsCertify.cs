using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class FindGoodsCertify : Utils.Object2JsonUtil
    {
        public string operators { get; set; }//操作员号
        public string flow_no { get; set; } //当前流水号
        public string barcode { get; set; }//商品条码
        public string qty { get; set; }//数量
        public string flow_id { get; set; }//商品行号
        public string consumers_id { get; set; }//会员id
        public string consumers_type { get; set; }//会员类型
        public string consumers_trgs { get; set; }//会员标志
        public string consumers_cardno { get; set; }//会员卡号
        public string calc_mode { get; set; }//默认传0
        public string memo { get; set; }//备用
    }
}
