using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class TradeInfoRtn : Utils.Object2JsonUtil
    {
        public List<GoodInfo> list { get; set; }//商品明细
        public string zdyftotal { get; set; }//整单应付金额
        public string zdsjtotal { get; set; }//整单实际金额
        public string zddsctotal { get; set; }//整单优惠金额
        public string sswr { get; set; }//整单四舍五入金额
        public string retmsg { get; set; }//返回的信息
        public string retflag { get; set; }//返回的标志
        public string guid { get; set; }//商品唯一标识
        public string memo { get; set; }//备用
    }
}
