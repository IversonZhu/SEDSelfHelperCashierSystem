using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class ValueCardCertify : Utils.Object2JsonUtil
    {
        public string type { get; set; }//交易类型
        public string seqno { get; set; }//交易流水号
        public string termno { get; set; }//终端号
        public string mktcode { get; set; }//门店好
        public string syjh { get; set; }//收银机号
        public string syyh { get; set; }//收银员号
        public string fphm { get; set; }//小票号
        public string invdjlb { get; set; }//小票交易类型 1消费 1消费冲正 5查询
        public string paycode { get; set; }//付款代码
        public string je { get; set; }//交易金额
        public string track1 { get; set; }//磁道翼
        public string track2 { get; set; }//磁道2
        public string track3 { get; set; }//磁道3
        public string passwd { get; set; }//密码
        public string memo { get; set; }//备注  商品编码|商品柜组|商品品类|商品品牌
        public string str1 { get; set; }//备用
        public string str2 { get; set; }//备用
        public string str3 { get; set; }//备用
        public string num1 { get; set; }//备用
        public string num2 { get; set; }//备用
        public string num3 { get; set; }//备用
        public string jygs { get; set; }//经营公司
    }
}
