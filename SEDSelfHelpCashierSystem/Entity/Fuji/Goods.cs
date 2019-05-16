using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class Goods
    {
        public string rowno { get; set; }//行号
        public string code { get; set; }//商品编码
        public string name { get; set; }//商品名称
        public float lsj { get; set; }//商品零售价
        public float price { get; set; }//商品销售
        public float sl { get; set; }//数量
        public float total { get; set; }//商品合计金额
        public string plutype { get; set; }//是否是电子秤商品
        public float lszke { get; set; }//折扣额
        public string inputbarcode { get; set; }//输入商品码
    }
}
