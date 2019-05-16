using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class PosCertify : Utils.Object2JsonUtil
    {
        public string operators { get; set; }//操作员号
        public string vmkt { get; set; }//门店好
        public string vsyjh { get; set; }//收银机号
        public string vjzrq { get; set; }//日期
        public string cdkey { get; set; }//测试期间不传
        public string djlb { get; set; }//单据类别
        public string Fphm { get; set; }//发票号码
        public string yys { get; set; }//运营商
        public string flag { get; set; }//默认为0
    }
}
