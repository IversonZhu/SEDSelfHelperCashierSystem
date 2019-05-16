using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class PosInfoRtn : Utils.Object2JsonUtil
    {
        public string flow_no { get; set; }//流水号
        public string fphm { get; set; }//小票号
        public string retflag { get; set; }//返回标志 0正常 1异常
        public string retmsg { get; set; }//返回消息
    }
}
