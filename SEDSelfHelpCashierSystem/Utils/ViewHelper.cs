using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SEDSelfHelpCashierSystem.Utils
{
    public class ViewHelper : INotifyPropertyChanged
    {
        private static ViewHelper viewHelper = new ViewHelper();

        public static ViewHelper Instance
        {
            get
            {
                return viewHelper;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void PropertyChangedMethod(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(name));
            }
        }
        private Stack<Utils.ReleaseSourceUtil> BackStack = new Stack<ReleaseSourceUtil>();

        public void AddPage(Utils.ReleaseSourceUtil releaseRourceUtil)
        {
            BackStack.Push(releaseRourceUtil);
            PropertyChangedMethod("CurrentPage");
        }

        public void GoBack()
        {
            if (BackStack.Count > 1)
            {
                BackStack.Pop().Dispose();
                PropertyChangedMethod("CurrentPage");
            }
        }

        public void GoHomePage()
        {
            Utils.LogHelper.log.Info("返回主页");
            while (BackStack.Count > 1)
            {
                BackStack.Pop().Dispose();
            }
            PropertyChangedMethod("CurrentPage");
            //空闲状态
            Utils.LedControlUtil.Instance.LED_Sparing();
        }

        public string version { get; set; }

        #region 广百富基数据
        public int delay_time = int.Parse(Utils.ConfigHelper.IniReadValue("Software", "delay_time"));
        #endregion
        #region 富基后台配置数据
        public string pos_id = Utils.ConfigHelper.IniReadValue("POS", "pos_id");
        public string cashier_id = Utils.ConfigHelper.IniReadValue("POS", "cashier_id");
        public string shop_id = Utils.ConfigHelper.IniReadValue("POS", "shop_id");
        public string preview_list_id = "";
        public string deal_id { get; set; }//单号
        private string m_list_id = "";//流水号
        public string list_id
        {
            get
            {
                return m_list_id;
            }
            set
            {
                m_list_id = value;
                //PropertyChangedMethod("list_id");

            }
        }//流水号
        public string privilege_passwd = Utils.ConfigHelper.IniReadValue("POS", "privilege_passwd");
        #endregion

        public bool adminIn = false;


        
       
    }
}
