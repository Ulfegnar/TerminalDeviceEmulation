using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUU
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            Controller controller = new Controller();
            mainForm.DataLoad(controller.GetControlDevice());

            mainForm.Connect += controller.Connect;
            mainForm.SaveControlDevice += controller.ControlDeviceSave;            
            mainForm.Disconnect += controller.Disconnect;
            mainForm.B3AutoConfirmClick += controller.AutoConfirmSend;
            mainForm.B4ConfirmClick += controller.ConfirmSignalSend;
            mainForm.B14AnswerStatusRequestClick += controller.StatusDeviceSend;
            mainForm.B23SensorStatusClick += controller.StatusSensorSendInUnsolicitedSignal;           
            mainForm.FormClosing += mainForm.SaveDevice;
            mainForm.FormClosing += controller.ConrolDeviceSaveBeforeClosing;
            mainForm.B3Change += controller.B3Changed;

            controller.GetNewMessage += mainForm.DataWiewRefresh;
            controller.SendMessage += mainForm.DataWiewRefresh;
            controller.serverConnected += mainForm.tcpConnected;
            controller.serverDisconnected += mainForm.tcpDisconnect;
                        
            Application.Run(mainForm);            
        }
    }
}
