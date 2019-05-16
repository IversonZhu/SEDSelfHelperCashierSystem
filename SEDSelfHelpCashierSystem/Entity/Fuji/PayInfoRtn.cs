using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class PayInfoRtn : Utils.Object2JsonUtil
    {
        public string payno { get; set; }//付款方式
        public float total { get; set; }//应付款总金额
        public float totalfrac { get; set; }//收银损益
        public float sjfk { get; set; }//实际付款
        public float change { get; set; }//找零
        public string payid { get; set; }//付款卡号
        public string guid { get; set; }//唯一标识
        public string retflag { get; set; }//返回标志
        public string retmsg { get; set; }//返回的信息
        public string flow_no { get; set; }//当前的流水号
        public string memo { get; set; }//备用
        public string memo1 { get; set; }//备用1
    }
}
