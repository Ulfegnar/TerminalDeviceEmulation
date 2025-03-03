using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUU.Data_
{
    public class StateControlDevice
    {
        public bool Line1 { get; set; }
        public bool Line2 { get; set; }
        public bool Line3 { get; set; }
        public bool Line4 { get; set; }
        public bool Line5 { get; set; }
        public bool Line6 { get; set; }
        public bool Line7 { get; set; }
        public bool Line8 { get; set; }

        public bool NSD { get; set; }
        public bool LegalAccess { get; set; }
        public bool PowerLoose { get; set; }
        public bool PowerAccumLow { get; set; }
        public bool SoundReset { get; set; }
        public bool SoundError { get; set; }
        public bool DisplayError { get; set; }
        public bool FiderError { get; set; }
        public bool TerminalDeviceError { get; set; }
        public bool TemperatureHight { get; set; }
        public bool TemperatureLow { get; set;}
        
        public string ArmIpAddress { get; set; }
        public int ArmTCP {  get; set; }

        public bool ControlDeviceOn { get; set; }
        public bool SirenOn { get; set; }
        public bool VoiceOn { get; set; }
        public bool Timeout { get; set; }
        public bool Error { get; set; }
        public bool NoSeance { get; set; }

        public bool NotificationSuccess { get; set; }

        public StateControlDevice(bool line1, bool line2, bool line3, bool line4, bool line5, bool line6,
            bool line7, bool line8, bool nsd, bool legalAccess, bool powerLoose, bool powerAccumLow,
            bool soundReset, bool soundError, bool displayError, bool fiderError, 
            bool terminalDeviceError, bool temperatureHight, bool temperatureLow, bool cobtrolDeviceOn,
            bool sirenOn, bool voiceOn, bool timeout, bool error, bool noSeance, string armIpAddress, 
            int armTCP)
        {
            Line1 = line1;
            Line2 = line2;
            Line3 = line3;
            Line4 = line4;
            Line5 = line5;
            Line6 = line6;
            Line7 = line7;                
            Line8 = line8;
            NSD = nsd;
            LegalAccess = legalAccess;
            PowerLoose = powerLoose;
            PowerAccumLow = powerAccumLow;
            SoundReset = soundReset;
            SoundError = soundError;
            DisplayError = displayError;
            FiderError = fiderError;
            TerminalDeviceError = terminalDeviceError;
            TemperatureHight = temperatureHight;
            TemperatureLow = temperatureLow;

            ControlDeviceOn = cobtrolDeviceOn;
            SirenOn = sirenOn;
            VoiceOn = voiceOn;
            Timeout = timeout;
            Error = error;
            NoSeance = noSeance;        

            ArmIpAddress = armIpAddress;
            ArmTCP = armTCP;            
        }

        public StateControlDevice(bool line1, bool line2, bool line3, bool line4, bool line5, bool line6,
            bool line7, bool line8, bool nsd, bool legalAccess, bool powerLoose, bool powerAccumLow,
            bool soundReset, bool soundError, bool displayError, bool fiderError,
            bool terminalDeviceError, bool temperatureHight, bool temperatureLow)
        {
            Line1 = line1;
            Line2 = line2;
            Line3 = line3;
            Line4 = line4;
            Line5 = line5;
            Line6 = line6;
            Line7 = line7;
            Line8 = line8;
            NSD = nsd;
            LegalAccess = legalAccess;
            PowerLoose = powerLoose;
            PowerAccumLow = powerAccumLow;
            SoundReset = soundReset;
            SoundError = soundError;
            DisplayError = displayError;
            FiderError = fiderError;
            TerminalDeviceError = terminalDeviceError;
            TemperatureHight = temperatureHight;
            TemperatureLow = temperatureLow;            
        }
    }
}
