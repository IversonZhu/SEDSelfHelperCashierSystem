using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class SendFP : Utils.Object2JsonUtil
    {
        public string flow_no { get; set; }//流水号
        public string typeflag { get; set; }//默认为0
        public Head salehead { get; set; }//小票的头部
        public List<PayMent> salepayment { get; set; }//小票的账单
        public List<Goods> salegoods { get; set; }//小票的商品列表
    }
}
