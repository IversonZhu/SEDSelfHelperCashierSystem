using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    class AuthorizationCertify : Utils.Object2JsonUtil
    {
        public string operators { get; set; }//操作员号
        public string cardno { get; set; }//卡号或条码号
        public string pwd { get; set; }//密码
        public string sqff { get; set; }//授权方法
    }
}
