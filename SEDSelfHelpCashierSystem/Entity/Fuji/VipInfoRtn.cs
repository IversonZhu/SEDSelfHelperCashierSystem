using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    //会员卡信息（返回）
    public class VipInfoRtn : Utils.Object2JsonUtil
    {
        public string vipno { get; set; }//会员卡号
        public string vipid { get; set; }//会员id
        public string viptype { get; set; }//会员类型
        public string trgs { get; set; }//会员标志
        public string jfgrade { get; set; }//积分
        public string retflag { get; set; }//返回标志
        public string retmsg { get; set; }//返回的信息
    }
}
