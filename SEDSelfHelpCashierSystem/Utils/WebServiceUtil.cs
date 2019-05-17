using System;
using Microsoft.CSharp;
using System.CodeDom;
using System.IO;
using System.Net;
using System.Web.Services.Description;
using System.CodeDom.Compiler;
using System.Reflection;

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

        private string req_url = Utils.ConfigHelper.IniReadValue("Software","ws_url");
        //private WebReference.LogicExposeService webService = new WebReference.LogicExposeService();
        //封装webService请求
        public T ReqWaitResponse<T>(string str_send, int timeout_ms = 30000)
        {
            //webService.Timeout = timeout_ms;
            Utils.LogHelper.log.Debug(str_send);
            T temp = default(T);
            try
            {
                //string str = webService.callMethod(str_send);
                string str = (string)Invoke(req_url, "callMethod", new object[] { str_send });
                temp = Utils.JsonHelper.GetObject<T>(str.Split('$')[1]);
                Utils.LogHelper.log.Debug(str);
            } catch(Exception e)
            {
                Utils.LogHelper.log.Error(e.ToString());
            }
            return temp;
        }

        private object Invoke(string url, string methodName, object[] parameters)
        {
            string ns = string.Format("ProxyServiceReference");
            WebClient wc = new WebClient();
            Stream stream = wc.OpenRead(url + "?WSDL");
            ServiceDescription sd = ServiceDescription.Read(stream);//服务的描述信息都可以通过ServiceDescription获取  
            string classname = sd.Services[0].Name;

            ServiceDescriptionImporter sdi = new ServiceDescriptionImporter();
            sdi.AddServiceDescription(sd, "", "");
            CodeNamespace cn = new CodeNamespace(ns);

            //生成客户端代理类代码  
            CodeCompileUnit ccu = new CodeCompileUnit();
            ccu.Namespaces.Add(cn);
            sdi.Import(cn, ccu);
            CSharpCodeProvider csc = new CSharpCodeProvider();

            //设定编译参数  
            CompilerParameters cplist = new CompilerParameters();
            cplist.GenerateExecutable = false;
            cplist.GenerateInMemory = true;
            cplist.ReferencedAssemblies.Add("System.dll");
            cplist.ReferencedAssemblies.Add("System.XML.dll");
            cplist.ReferencedAssemblies.Add("System.Web.Services.dll");
            cplist.ReferencedAssemblies.Add("System.Data.dll");

            //编译代理类  
            CompilerResults cr = csc.CompileAssemblyFromDom(cplist, ccu);
            if (cr.Errors.HasErrors == true)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (System.CodeDom.Compiler.CompilerError ce in cr.Errors)
                {
                    sb.Append(ce.ToString());
                    sb.Append(System.Environment.NewLine);
                }
                throw new Exception(sb.ToString());
            }

            //生成代理实例，并调用方法  
            Assembly assembly = cr.CompiledAssembly;
            Type t = assembly.GetType(ns + "." + classname, true, true);
            object obj = Activator.CreateInstance(t);

            MethodInfo call = t.GetMethod(methodName);

            return call.Invoke(obj, parameters);
        }
    }
}
