using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class CancelBarcodeCertify : Utils.Object2JsonUtil
    {
        public string guid { get; set; }//商品唯一标识
        public string operators { get; set; }//操作员号
        public string flow_no { get; set; }//当前流水
        public string flow_id { get; set; }//排列序号
        public string barcode { get; set; }//商品条码
    }
}
