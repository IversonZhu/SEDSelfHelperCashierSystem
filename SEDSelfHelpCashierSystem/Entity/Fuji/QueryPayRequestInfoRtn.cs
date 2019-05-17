using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class QueryPayRequestInfoRtn : Utils.Object2JsonUtil
    {
        public string retflag { get; set; }//返回标志
        public string retmsg { get; set; }//返回的信息
        public string popflag { get; set; }//促销返回标志 0没有促销规则 1需要选择的促销规则
        public float qty { get; set; }//数量合计（重量）
        public float total { get; set; }//应付总金额
        public float sjtotal { get; set; }//实际总金额
        public float totaldsc { get; set; }//优惠金额
        public float sswr { get; set; }//整单四舍五入
        public string flow_no { get; set; }//当前流水号
        public string memo { get; set; }//备用
        public string memo1 { get; set; }//备用1
    }
}
