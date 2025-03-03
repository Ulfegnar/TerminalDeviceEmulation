using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUU.Data
{
    /// <summary>
    /// Состояние оповещения при отправке Б.4
    /// </summary>
    public class NotificationState
    {
        public bool Success { get; set; }
        public bool NoSeance {  get; set; }
        public bool OtherNotification { get; set; }
        
        public NotificationState(bool success, bool noSence, bool otherNotification) 
        { 
            Success = success;
            NoSeance = noSence;
            OtherNotification = otherNotification;
        }
    }
}
