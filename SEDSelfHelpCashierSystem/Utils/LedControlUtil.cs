using System;
using System.IO.Ports;

namespace SEDSelfHelpCashierSystem.Utils
{
    public class LedControlUtil
    {
        private static LedControlUtil ledControlUtil = new LedControlUtil();
        private SerialPort serialPort = new SerialPort();

        public static LedControlUtil Instance
        {
            get
            {
                return ledControlUtil;
            }
        }

        private LedControlUtil()
        {
            try
            {
                //LED灯管的端口号
                serialPort.PortName = Utils.ConfigHelper.IniReadValue("RGBLed", "port");
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.ReadTimeout = 500;
                serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;
                serialPort.Open();
            }
            catch (Exception e)
            {
                Utils.LogHelper.log.Error("三色灯管串口异常:" + e.ToString());
            }
        }

        //全部关闭
        public void LED_CloseAll()
        {

        }

        //空闲状态
        public void LED_Sparing()
        {

        }

        //正在使用中 绿灯闪烁
        public void LED_Using()
        {

        }

        //错误状态
        public void LED_Error()
        {

        }

        //管理员管理
        public void LED_AdminIn()
        {

        }
        /// <summary>
        /// 三色灯通讯协议
        /// </summary>
        /// <param name="ledColor"></param>
        /// <param name="ledStatus"></param>
        private void LedOperate(Enum.LedColor ledColor, Enum.LedStatus ledStatus)
        {
            byte[] sendBuffer = new byte[] { 0x1b, 0x06, 0x00, 0x00, 0x00, 0x00 };
            int sum = 0;
            sendBuffer[3] = (byte)ledColor;//设置灯的颜色
            sendBuffer[4] = (byte)ledStatus;//设置灯的状态
            for (int i = 0; i < sendBuffer.Length - 1; i++)
                sum ^= sendBuffer[i];
            sendBuffer[sendBuffer.Length - 1] = (byte)sum;
            serialPort.Write(sendBuffer, 0, sendBuffer.Length);
        }
    }
}
