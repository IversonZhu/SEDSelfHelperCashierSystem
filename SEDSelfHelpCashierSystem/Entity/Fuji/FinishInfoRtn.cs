using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class FinishInfoRtn : Utils.Object2JsonUtil
    {
        public string retflag { get; set; }//返回标志
        public string retmsg { get; set; }//返回的信息
        public string change { get; set; }//找零
        public float jf { get; set; }//积分 180427 revise
        public float curjf { get; set; }//当前积分
        public List<CouponGain> coupon_gain { get; set; }//返券 /积分结果
    }
}
