using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Tools
{
    public class LOG_Tool
    {
        static object _lock = new object();
        static string fileName = Environment.CurrentDirectory + "\\Log\\" + DateTime.Today.ToString("yyyy-MM-dd") + ".log";

        /// <summary>
        /// 写入日志到TXT文件
        /// </summary>
        /// <param name="stationName"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        public static void WriteLogToTxt(string stationName, string message, int type)
        {
            lock (_lock)
            {
                string logType = "";
                if (type == 0)
                {
                    logType = "info";
                }
                else
                {
                    logType = "error";
                }
                FileStream fileStream;
                FileInfo file = new FileInfo(fileName);
                if (!file.Exists)
                {
                    fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                    StreamWriter sw = new StreamWriter(fileStream, System.Text.Encoding.GetEncoding("GB2312"));
                    sw.WriteLine("时间：" + DateTime.Now.ToString() + " 位置：" + stationName + " 类型：" + logType + "  信息： " + message);
                    sw.Flush();
                    sw.Close();

                }
                else
                {
                    fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fileStream, System.Text.Encoding.GetEncoding("GB2312"));
                    sw.WriteLine("时间：" + DateTime.Now.ToString() + " 位置：" + stationName + " 类型：" + logType + "  信息：" + message);
                    sw.Flush();
                    sw.Close();
                }
            }
        }
    }
}
