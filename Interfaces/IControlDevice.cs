using TestUU.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUU.Interfaces
{
    public interface IControlDevice
    {        
        int TcpCommand {  get; }
        int TcpUnsolicitedSignal { get; }
        int UDP { get; }
        NotificationStatus Status { get; }        
    }
}
