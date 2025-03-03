using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUU
{
    public class LogData
    {
        public DateTime DateTime {  get;}
        public string Command { get;}

        public LogData(DateTime dateTime, string command)
        {
            DateTime = dateTime;
            Command = command;
        }
    }
}
