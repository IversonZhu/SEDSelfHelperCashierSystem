using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class QueryPayRequestCertify : Utils.Object2JsonUtil
    {
        public string operators { get; set; }//操作员号
        public string flow_no { get; set; }//当前流水号
        public int count { get; set; }//商品条数
        public float qty { get; set; }//总数量（包含重量）
        public float total { get; set; }//总金额
        public string calc_mode { get; set; }//默认传0
        public string uidlist { get; set; }//所有gui拼接而成以逗号隔开
        public string memo { get; set; }//备用
        public string memo1 { get; set; }//备用1
    }
}
