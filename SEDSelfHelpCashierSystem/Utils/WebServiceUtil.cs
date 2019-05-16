using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Utils
{
    public class WebServiceUtil
    {
        private static WebServiceUtil webServiceUtil = new WebServiceUtil();

        public static WebServiceUtil Instance
        {
            get
            {
                return webServiceUtil;
            }
        }

        public WebServiceUtil(){ }

        private WebReference.LogicExposeService webService = new WebReference.LogicExposeService();
        //封装webService请求
        public T ReqWaitResponse<T>(string str_send, int timeout_ms = 30000)
        {
            webService.Timeout = timeout_ms;
            T temp = default(T);
            try
            {
                string str = webService.callMethod(str_send);
                temp = Utils.JsonHelper.GetObject<T>(str.Split('$')[1]);
            } catch(Exception e)
            {
                Utils.LogHelper.log.Error(e.ToString());
            }
            
            return temp;
        }
    }
}
