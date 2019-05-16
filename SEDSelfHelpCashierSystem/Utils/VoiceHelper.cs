using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Utils
{
    public class VoiceHelper
    {
        private static VoiceHelper voiceHelper = new VoiceHelper();

        private VoiceHelper()
        {

        }

        public static VoiceHelper Instance
        {
            get
            {
                return voiceHelper;
            }
        }

        private SoundPlayer player = new SoundPlayer();
        private string[] VoicePath = new string[]
        {
            "Voice/Welcome.wav",//欢迎
            "Voice/ScanFirstGoods.wav",//扫描第一件商品
            "Voice/SelectPayMode.wav",//选择付款方式
            "Voice/scancode.wav",//扫描条码
            "Voice/InsertBankCard.wav",//插入银行卡
            "Voice/InserVIPCard.wav",//插入会员卡
            "Voice/repeatScan.wav",//重复扫描
            "Voice/Bye.wav",//付款成功
            "Voice/CardInvert.wav",//卡插反了
            "Voice/PayFail.wav",//付款失败
            "Voice/InsertCZK.wav",//插入储值卡
            "Voice/PutGoods.wav",//把商品放到称台上 11
            "Voice/MallCardInsert.wav",//购物卡支付提示 12
            "Voice/GradePay.wav",//积分支付语音提示 13
            "Voice/InserOrScanVIP.wav",//插入或者扫描会员卡
        };

        //同步播放
        public void PlaySync(Enum.VoiceType voiceType)
        {
            try
            {
                player.SoundLocation = VoicePath[(int)voiceType];
                player.PlaySync();
            } catch(Exception e)
            {
                Utils.LogHelper.log.Error(e.ToString());
            }
        }

        //播放
        public void Play(Enum.VoiceType voiceType)
        {
            try
            {
                player.SoundLocation = VoicePath[(int)voiceType];
                player.Play();
            }
            catch (Exception e)
            {
                Utils.LogHelper.log.Error(e.ToString());
            }
        }
    }
}
