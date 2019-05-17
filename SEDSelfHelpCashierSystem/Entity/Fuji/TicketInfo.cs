using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class TicketInfo
    {
        public string header { get; set; }//抬头
        public string ticket_date { get; set; }//交易日期
        public string pos_no { get; set; }//pos机号
        public string ticket_no { get; set; }//小票号码
        public decimal ticket_total { get; set; }//金额
        public string ticket_content { get; set; }//小票内容
        public string last_para { get; set; }//最后一段内容
        public TicketInfo()
        {
            try
            {
                header = Utils.ConfigHelper.IniReadValue("Ticket", "header");
                last_para = Utils.ConfigHelper.IniReadValue("Ticket", "last_para");
            }
            catch (Exception ex)
            {
                //记录错误信息
                Utils.LogHelper.log.Info(ex.ToString());
            }
        }
    }
}
