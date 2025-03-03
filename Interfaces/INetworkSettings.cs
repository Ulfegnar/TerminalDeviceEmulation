using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUU.Interfaces
{
    public interface INetworkSettings
    {
        string IPAddressUU { get; set; }
        int TcpCommand { get; set; }
        int UDP { get; set; }
    }
}
