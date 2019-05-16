using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    public class GoodsInfoRtn : Utils.Object2JsonUtil
    {
        public string guid { get; set; }//商品唯一标识
        public string retmsg { get; set; }//返回的信息
        public string retflag { get; set; }//返回标志
        public string popflag { get; set; }//促销返回标志
        public string flow_id { get; set; }//行号
        public string incode { get; set; }//商品编码
        public string barcode { get; set; }//商品条码
        public string fname { get; set; }//商品名称
        public string specs { get; set; }//规格
        public string units { get; set; }//单位
        public float unitprice { get; set; }//原零售价
        public float price { get; set; }//实际售价
        public float qty { get; set; }//数量
        public float disc { get; set; }//折扣
        public float total { get; set; }//总金额
        public float dsctotal { get; set; }//优惠总金额
        public string dsctype { get; set; }//默认0
        public float weight { get; set; }//商品重量 plutype=0 Plutype=1返回商品重量
        public string goodsno { get; set; }//商品条码
        public string flow_no { get; set; }//当前流水
        public string memo { get; set; }//备用
        public string plutype { get; set; }

        public string p_price
        {
            get
            {
                return unitprice.ToString("F3");
            }
        }

        public string p_discount
        {
            get
            {
                return dsctotal.ToString("F3");
            }
        }

        public string p_total
        {
            get
            {
                return price.ToString();
            }
        }

        public string p_qty
        {
            get
            {
                return qty.ToString("F3");
            }
        }

        public string p_barcode
        {
            get
            {
                return goodsno;
            }
        }

        public string p_name
        {
            get
            {
                return fname;
            }
        }

        public int p_flow_id
        {
            get
            {
                return int.Parse(flow_id);
            }
        }

        public string p_plutype
        {
            get
            {
                return plutype;
            }
        }

        public string p_weight
        {
            get
            {
                return weight.ToString("F3");
            }
        }
    }
}
