using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Enum
{
    public enum VoiceType
    {
        Welcom = 0,
        ScanFirstGoods = 1,
        SelectPayMode = 2, ScanPaycode = 3,
        InsertBankCard = 4,
        InsertVIPCard = 5,
        RepeatScan = 6,
        Bye = 7,
        CardInvert = 8,
        PayFail = 9,
        InsertCZK = 10,
        PutGoods = 11,
        MallCardInsert = 12,
        GradePay = 13,
        InsertOrScanVIP = 14,
    }
}
