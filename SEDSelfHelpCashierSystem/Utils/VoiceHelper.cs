using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Utils
{
    public class VoiceHelper
    {
        private static VoiceHelper voiceHelper = new VoiceHelper();

        public static VoiceHelper Instance
        {
            get
            {
                return voiceHelper;
            }
        }

        public enum VoiceType
        {
            welcome = 0,
            scanFirstGoods = 1,
        }
    }
}
