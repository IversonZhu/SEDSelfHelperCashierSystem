using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class PayMent
    {
        public string rowno { get; set; }//行号
        public string paycode { get; set; }//付款码
        public string name { get; set; }//付款名称
        public string rqsj { get; set; }//小票产生是时间
        public string consumers_id { get; set; }//
        public float total { get; set; }//付款金额
        public float tatalfrac { get; set; }//损益金额
        public string reference { get; set; }//参考号
        public string terminalid { get; set; }//终端号
        public string merchantid { get; set; }//商户号
        public string batchno { get; set; }//批次号
        public string Trace { get; set; }//
        public string memo { get; set; }//备用
    }
}
