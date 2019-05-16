using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Entity.Fuji
{
    //储值卡查询信息返回
    public class ValueCardInfoRtn : Utils.Object2JsonUtil
    {
        public string recode { get; set; }
        public string retmsg { get; set; }//
        public string cardno { get; set; }//卡号
        public string cardname { get; set; }//持卡人
        public string cardpwd { get; set; }//卡密码
        public string status { get; set; }//卡状态
        public string ispw { get; set; }//是否输入密码
        public string func { get; set; }//其他功能
        public float ye { get; set; }//余额
        public string money { get; set; }//面值
        public string value1 { get; set; }//备用
        public string value2 { get; set; }//备用

        public string value3 { get; set; }//备用
        public string memo { get; set; }//备注
        public string str1 { get; set; }//查询有效期
        public string str2 { get; set; }//柜组限制
        public string str3 { get; set; }//说明信息
        public string str4 { get; set; }//备用
        public string num1 { get; set; }//备用

        public string num2 { get; set; }//备用
        public string num3 { get; set; }//备用
        public string pwdje { get; set; }//零钞免密限额
    }
}
