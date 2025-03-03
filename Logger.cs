using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUU
{
    public class Logger : ILoggerWrapper
    {
        public void Debug(string message)
        {
            
        }

        public void Error(string message)
        {
            
        }

        public void Error(Exception exception)
        {
            
        }

        public void Error(Exception exception, string message)
        {
            
        }

        public void Fatal(Exception excepton)
        {
            
        }

        public void Fatal(Exception exception, string message)
        {
            
        }

        public void Info(string message)
        {
            
        }

        public void Verbose(string message)
        {
            
        }

        public void Warn(string format, params object[] args)
        {
            
        }

        public void Warn(Exception exception)
        {
            
        }

        public void Warn(Exception exception, string message, params object[] args)
        {
            
        }

        public Logger() { }
    }
}
