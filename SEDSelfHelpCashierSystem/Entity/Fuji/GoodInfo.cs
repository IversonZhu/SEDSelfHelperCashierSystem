using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class GoodInfo
    {
        public int flow_id { get; set; }//商品行号
        public string incode { get; set; }//商品编码
        public string fname { get; set; }//商品名称
        public string specs { get; set; }//规格
        public string units { get; set; }//单位
        public float unitprice { get; set; }//原零售价
        public float price { get; set; }//实际售价
        public float qty { get; set; }//数量
        public float disc { get; set; }//折扣
        public float total { get; set; }//总金额
        public float dsctotal { get; set; }//优惠金额（暂无）
        public string dsctype { get; set; }//优惠方式（默认0）
        public string plutype { get; set; }//是否称重标志
        public float weight { get; set; }//商品重量
        public string goodsno { get; set; }//商品条码
    }
}
