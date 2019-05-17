using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDSelfHelpCashierSystem.Utils
{
    public class TicketHelper
    {

        private static TicketHelper ticketHelper = new TicketHelper();

        private TicketHelper()
        {

        }

        public static TicketHelper Instance
        {
            get
            {
                return ticketHelper;
            }
        }
        private Entity.Fuji.TicketInfo ticketInfo = new Entity.Fuji.TicketInfo();
        /// <summary>
        /// 保存小票信息到文件
        /// </summary>
        /// <param name="ticket"></param>
        /// <param name="en"></param>
        /// <param name="file_path"></param>
        public static void SaveTicketFile(string ticket, Encoding en, string file_path = "print.txt")
        {
            try
            {
                var stream = new System.IO.FileStream(file_path, System.IO.FileMode.Open);
                var buffer = en.GetBytes(ticket);
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
                stream.Close();
            }
            catch(Exception e)
            {
                Utils.LogHelper.log.Error(e.ToString());
            }
        }

        /// <summary>
        /// 获取小票信息
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="en"></param>
        /// <returns></returns>
        public static string GetTicketFile(string filePath, Encoding en)
        {
            try
            {
                var stream = new System.IO.FileStream(filePath, System.IO.FileMode.Open);
                var buffer = new byte[stream.Length];//缓冲区
                stream.Read(buffer, 0, buffer.Length);
                stream.Flush();
                stream.Close();
                //万国码编码
                return en.GetString(buffer);
            }
            catch (Exception e)
            {
                Utils.LogHelper.log.Error(e.ToString());
            }
            return "";
        }

        public string GetTicket()
        {
            try
            {
                string title = ticketInfo.header + "\r\n";
                string detail = "交易时间:" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "\r\n";
                //detail += "交易号:" + string.Format("{0,-10}",Utils.ViewHelper.Instance);
            }
            catch(Exception e)
            {

            }
            
            return "";
        }
    }
}
