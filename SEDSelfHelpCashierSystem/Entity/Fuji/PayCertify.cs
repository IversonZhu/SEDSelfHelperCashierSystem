using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class PayCertify : Utils.Object2JsonUtil
    {
        public string operators { get; set; }//操作员号
        public string flow_no { get; set; }//当前流水号
        public string payno { get; set; }//付款方式代码 
        public float total { get; set; }//付款金额
        public float totalfrac { get; set; }//收银损益
        public string payid { get; set; }//付款卡号 储值卡卡号 微信交易单号
        public string paymm { get; set; }//支付密码 默认不穿
        public string vertifycode { get; set; }//校验码
        public string trace { get; set; }//银联流水号
        public string terminalid { get; set; }//终端号
        public string merchantid { get; set; }//机构号
        public string batchno { get; set; }//批次号
        public string reference { get; set; }//银行卡交易号
        public string flag { get; set; }//是否立即支付 默认位0
        public string memo { get; set; }//备用
        public string memo1 { get; set; }//备用1
    }
}
