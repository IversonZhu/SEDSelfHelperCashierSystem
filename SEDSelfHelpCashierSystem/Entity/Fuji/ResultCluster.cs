using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    //webService返回的信息集合
    public class ResultCluster
    {

        public Entity.Fuji.PosInfoRtn begin { get; set; }//开始接口返回信息
        public Entity.Fuji.VipInfoRtn vip { get; set; }//会员接口返回信息
        public Entity.Fuji.GoodsInfoRtn last_goods { get; set; }//最后扫描的商品 返回信息
        public Entity.Fuji.TradeInfoRtn trade_info { get; set; }//整笔返回信息
        public Entity.Fuji.QueryPayRequestInfoRtn whole_promote { get; set; }//整单促销
        public Entity.Fuji.CancelPayInfoRtn last_cancel_goods { get; set; }//最后一个删除商品 返回信息
        public Entity.Fuji.PayInfoRtn last_pay { get; set; }//最后一次支付
        public Entity.Fuji.CancelTradeInfoRtn cancel_order { get; set; }//取消订单
        public Entity.Fuji.FinishInfoRtn finish { get; set; }//付款成功
        public Entity.Fuji.ValueCardInfoRtn czk { get; set; }//储值卡信息
    }
}
