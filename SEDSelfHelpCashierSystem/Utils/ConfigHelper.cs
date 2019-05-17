using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Utils
{
    public class ConfigHelper
    {
        private static string path = "Config/Configuration.ini";

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString();

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern uint GetPrivateProfileSection(string lpAppName, IntPtr lpReturnedString, uint nSize, string lpFileName);

        public static string IniReadValue(string section, string key)
        {
            StringBuilder sb = new StringBuilder(500);
            int i = GetPrivateProfileString(section,key,"",sb,500,path);
            if (i == 0)
            {
                throw new Exception("读取配置文件失败:缺少" + section + "->" + key + "字段");
            }
            return sb.ToString();
        }
    }
}
