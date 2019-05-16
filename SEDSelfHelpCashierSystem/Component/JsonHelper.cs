using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace SEDSelfHelpCashierSystem.Component
{
    public class JsonHelper
    {
        /// <summary>
        /// json字符串反序列化为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public static T GetObject<T>(string jsonStr)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            StringReader stringReader = new StringReader(jsonStr);
            T t = (T)jsonSerializer.Deserialize(stringReader, typeof(T));
            return t;
        }

        /// <summary>
        /// 将对象序列化为json字符串
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string GetJsonStr(object o)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            StringWriter stringWriter = new StringWriter();
            jsonSerializer.Serialize(stringWriter, o);
            return stringWriter.GetStringBuilder().ToString();
        }
    }
}
