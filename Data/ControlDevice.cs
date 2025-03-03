using TestUU.Enums;
using TestUU.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestUU
{
    public class ControlDevice : IControlDevice, INetworkSettings
    {        

        [JsonPropertyName("IPAddressUU")]
        public string IPAddressUU { get; set; }

        [JsonPropertyName("IPAddressArm")]
        public string IPAddressArm {  get; set; }
        [JsonPropertyName("TcpCommand")]
        public int TcpCommand {  get; set; }
        [JsonPropertyName("TcpUnsolicitedSignal")]
        public int TcpUnsolicitedSignal { get; set; }

        [JsonPropertyName("UDP")]
        public int UDP { get; set; }

        [JsonPropertyName("Status")]
        public NotificationStatus Status { get; set; } = NotificationStatus.Unknown;
        [JsonPropertyName("Lines")]
        public List<bool> Lines { get; set; } = new List<bool>() { false, false, false, false,
        false, false, false, false};
        [JsonPropertyName("Sensors")] 
        public List<bool> Sensors { get; set; } = new List<bool> { false, false, false, false,
        false, false, false, false, false, false, false, false, false, false, false, false, false,};
        [JsonPropertyName("B3Auto")]
        public bool B3Auto {  get; set; }
        

        [JsonConstructor]
        public ControlDevice(string ipAddressUU, int tcpCommand, string ipAddressARM, 
            int tcpUnsolicitedSignal, int udp, NotificationStatus status, 
            List<bool> lines, List<bool> sensors, bool b3Auto) 
        {   
            IPAddressUU = ipAddressUU; 
            TcpCommand = tcpCommand;
            IPAddressArm = ipAddressARM;
            TcpUnsolicitedSignal = tcpUnsolicitedSignal;
            UDP = udp; 
            Status = status;
            if (lines.Count > 0)
            {
                Lines.Clear();
                Lines.AddRange(lines);
            }
            if (sensors.Count > 0)
            {
                Sensors.Clear();
                Sensors.AddRange(sensors);
            }            
            B3Auto = b3Auto;
        }

        public ControlDevice(int tcpCommand, int tcpUS, int udp, string ipAddress,
            string ipAddressARM, List<bool> lines, List<bool> sensors) 
        {
            IPAddressUU = ipAddress;
            TcpCommand = tcpCommand;            
            TcpUnsolicitedSignal = tcpUS;
            IPAddressArm = ipAddressARM;
            UDP = udp;
            Lines.Clear();
            Lines.AddRange(lines);
            Sensors.Clear();
            Sensors.AddRange(sensors);
        }

        public void Copy(ControlDevice other)
        {            
            IPAddressUU = other.IPAddressUU;
            IPAddressArm = other.IPAddressArm;
            TcpCommand = other.TcpCommand;
            TcpUnsolicitedSignal = other.TcpUnsolicitedSignal;
            UDP = other.UDP;
            Status = other.Status;
            Lines.Clear();
            Lines.AddRange(other.Lines);
            Sensors.Clear();
            Sensors.AddRange(other.Sensors);
            B3Auto |= other.B3Auto;
        }
    }
}
