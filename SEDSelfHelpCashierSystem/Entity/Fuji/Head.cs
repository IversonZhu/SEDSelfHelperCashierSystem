using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class Head : Utils.Object2JsonUtil
    {
        public string operators { get; set; }//收银员
        public string vmkt { get; set; }//门店号
        public string vsyjh { get; set; }//收银机号
        public string yys { get; set; }//运营商名称
        public string fphm { get; set; }//小票号
        public string rqsj { get; set; }//小票产生时间
        public string sswr { get; set; }//整单四舍五入
        public string hycid { get; set; }//会员id
        public string hykh { get; set; }//会员卡号
        public string hytype { get; set; }//会员类型
    }
}
