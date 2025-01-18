using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
    public class EventLogger
    {
        public string path = "D:\\Users\\chevtaykina.vv1700\\Desktop\\pz77";
        public void Log(string message)
        {
            File.AppendAllText(path, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }
    }
}