using TestUU;
using TestUU.Data;
using TestUU.Data_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUU
{
    public partial class MainForm : Form
    {
        public EventHandler Connect {  get; set; }
        public EventHandler<ControlDevice> SaveControlDevice { get; set; }
        public EventHandler Disconnect { get; set; }
        public EventHandler<NotificationState> B4ConfirmClick { get; set; }
        public EventHandler<StateControlDevice> B14AnswerStatusRequestClick { get; set; }
        public EventHandler<StateControlDevice> B23SensorStatusClick {  get; set; }
        public EventHandler<bool> B3Change {  get; set; }
        public EventHandler B23ErrorClick { get; set; }

        public EventHandler B3AutoConfirmClick { get; set; }

        private List<LogData> _Log;
        private bool start = false;


        public MainForm()
        {
            InitializeComponent();  
            _Log = new List<LogData>();            
        }

        private void DataViewAddRow(LogData log)
        {
            //DataGridViewRow row = (DataGridViewRow)dataGridViewLog.Rows[0].Clone() ;
            var row = new DataGridViewRow();
            var dateTimeCell = new DataGridViewTextBoxCell 
            {
                Value = log.DateTime.ToLongTimeString()
            };
            var commandCell = new DataGridViewTextBoxCell
            {
                Value = log.Command
            };

            row.Cells.Add(dateTimeCell);
            row.Cells.Add(commandCell);

            dataGridViewLog.Invoke(new Action(() => dataGridViewLog.Rows.Add(row)));
            //dataGridViewLog.Rows.Add(row);            
        }

        public bool SaveDevice()
        {   
            if (start)
            {
                try
                {
                    ControlDevice controlDevice = new ControlDevice(int.Parse(textBoxTCP.Text),
                    int.Parse(textBoxTcpUS.Text), int.Parse(textBoxUDP.Text), ipAddressControl.Text,
                    ipAddressARM.Text, GetLines(), GetSensors());

                    SaveControlDevice(this, controlDevice);
                    return true;
                }
                catch
                {
                    MessageBox.Show("Не все данные сетевого подключения введееы", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else return false;
        }

        public void SaveDevice(object sender, EventArgs e)
        {
            ControlDevice controlDevice = new ControlDevice(int.Parse(textBoxTCP.Text),
            int.Parse(textBoxTcpUS.Text), int.Parse(textBoxUDP.Text), ipAddressControl.Text,
            ipAddressARM.Text, GetLines(), GetSensors());

            SaveControlDevice(this, controlDevice);
        }

        private List<bool> GetSensors()
        {
            return new List<bool>() {
                checkBoxSensor1.Checked, checkBoxSensor2.Checked, checkBoxSensor3.Checked,
                checkBoxSensor4.Checked, checkBoxSensor5.Checked, checkBoxSensor6.Checked,
                checkBoxSensor7.Checked, checkBoxSensor8.Checked, checkBoxSensor9.Checked,
                checkBoxSensor10.Checked, checkBoxSensor11.Checked, cbSensor12.Checked,
                cbSensor13.Checked, cbSensor14.Checked, cbSensor15.Checked,
                cbSensor16.Checked,cbSensor17.Checked};            
        }

        private List<bool> GetLines()
        {
            return new List<bool>() {
                cbLine1.Checked, cbLine2.Checked, cbLine3.Checked, cbLine4.Checked,
                cbLine5.Checked, cbLine6.Checked, cbLine7.Checked, cbLine8.Checked};
        }


        private void buttonConnect_Click(object sender, EventArgs e)
        {
            start = true;
            if (SaveDevice())
            {
                Connect(this, new EventArgs());
            }
        }

        public void DataLoad(ControlDevice device)
        {
            if (device != null)
            {
                textBoxUDP.Text = device.UDP.ToString();
                textBoxTCP.Text = device.TcpCommand.ToString();
                ipAddressControl.Text = device.IPAddressUU;
                ipAddressARM.Text = device.IPAddressArm;
                textBoxTcpUS.Text = device.TcpUnsolicitedSignal.ToString();

                cbLine1.Checked = device.Lines[0];
                cbLine2.Checked = device.Lines[1];
                cbLine3.Checked = device.Lines[2];
                cbLine4.Checked = device.Lines[3];
                cbLine5.Checked = device.Lines[4];
                cbLine6.Checked = device.Lines[5];
                cbLine7.Checked = device.Lines[6];
                cbLine8.Checked = device.Lines[7];

                checkBoxSensor1.Checked = device.Sensors[0];
                checkBoxSensor2.Checked = device.Sensors[1];
                checkBoxSensor3.Checked = device.Sensors[2];
                checkBoxSensor4.Checked = device.Sensors[3];
                checkBoxSensor5.Checked = device.Sensors[4];
                checkBoxSensor6.Checked = device.Sensors[5];
                checkBoxSensor7.Checked = device.Sensors[6];
                checkBoxSensor8.Checked = device.Sensors[7];
                checkBoxSensor9.Checked = device.Sensors[8];
                checkBoxSensor10.Checked = device.Sensors[9];
                checkBoxSensor11.Checked = device.Sensors[10];
                cbSensor12.Checked = device.Sensors[11];
                cbSensor13.Checked = device.Sensors[12];
                cbSensor14.Checked = device.Sensors[13];
                cbSensor15.Checked = device.Sensors[14];
                cbSensor16.Checked = device.Sensors[15];
                cbSensor17.Checked = device.Sensors[16];

                checkBoxB3Auto.Checked = device.B3Auto;
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect(this, new EventArgs());
        }

        private void buttonB4_Click(object sender, EventArgs e)
        {            
            B4ConfirmClick.Invoke(this, new NotificationState(cbSensor19.Checked, cbSensor17.Checked, cbSensor18.Checked));
        }

        private void buttonB14_Click(object sender, EventArgs e)
        {
            StateControlDevice state = new StateControlDevice(
                cbLine1.Checked, cbLine2.Checked, cbLine3.Checked,
                cbLine4.Checked, cbLine5.Checked, cbLine6.Checked,
                cbLine7.Checked, cbLine8.Checked, checkBoxSensor1.Checked, 
                checkBoxSensor2.Checked, checkBoxSensor3.Checked, checkBoxSensor4.Checked, 
                checkBoxSensor5.Checked, checkBoxSensor6.Checked, checkBoxSensor7.Checked, 
                checkBoxSensor8.Checked, checkBoxSensor9.Checked, checkBoxSensor10.Checked, 
                checkBoxSensor11.Checked);
            B14AnswerStatusRequestClick.Invoke(this, state);
        }

        private void buttonB23_Click(object sender, EventArgs e)
        {
            StateControlDevice state = new StateControlDevice(
                cbLine1.Checked, cbLine2.Checked, cbLine3.Checked,
                cbLine4.Checked, cbLine5.Checked, cbLine6.Checked,
                cbLine7.Checked, cbLine8.Checked, checkBoxSensor1.Checked,
                checkBoxSensor2.Checked, checkBoxSensor3.Checked, checkBoxSensor4.Checked,
                checkBoxSensor5.Checked, checkBoxSensor6.Checked, checkBoxSensor7.Checked,
                checkBoxSensor8.Checked, checkBoxSensor9.Checked, checkBoxSensor10.Checked,
                checkBoxSensor11.Checked, cbSensor12.Checked, cbSensor13.Checked, cbSensor14.Checked,
                cbSensor15.Checked, cbSensor16.Checked, cbSensor17.Checked,
                ipAddressARM.Text, int.Parse(textBoxTcpUS.Text));
            B23SensorStatusClick(this, state);
        }


        internal void DataWiewRefresh(object sender, LogData log)
        {
            _Log.Add(log);
            DataViewAddRow(log);            
        }

        private void buyttonB3_Click(object sender, EventArgs e)
        {
            B3AutoConfirmClick.Invoke(this, new EventArgs());  
        }

        public void tcpConnected(object sender, EventArgs e)
        {
            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = true;
        }

        public void tcpDisconnect(object sender, EventArgs e)
        { 
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //Connect(this, new EventArgs());
        }

        private void buttonLogClear_Click(object sender, EventArgs e)
        {
            _Log.Clear();

            dataGridViewLog.Rows.Clear();            
        }

        /// <summary>
        /// нет сеанса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSensor17_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor17.Checked) cbSensor19.Checked = false;
            SaveDevice();
        }

        /// <summary>
        /// другое оповещение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSensor18_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor18.Checked) cbSensor19.Checked = false;
            SaveDevice();
        }

        /// <summary>
        /// оповещение успешно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSensor19_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor19.Checked)
            {
                cbSensor17.Checked = false;
                cbSensor18.Checked = false;
            }
            SaveDevice();
        }

        private void checkBoxSensor1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSensor1.Checked)
            {
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor13.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void checkBoxSensor2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSensor2.Checked)
            {
                checkBoxSensor1.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor13.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void checkBoxSensor3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSensor3.Checked)
            {
                checkBoxSensor2.Checked = false;
                checkBoxSensor1.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor13.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void checkBoxSensor4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSensor4.Checked)
            {
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor1.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor13.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void checkBoxSensor5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSensor5.Checked)
            {
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor1.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor13.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void checkBoxSensor6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSensor6.Checked)
            {
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor1.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor13.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void checkBoxSensor7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSensor7.Checked)
            {
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor1.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor13.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void checkBoxSensor8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSensor8.Checked)
            {
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor1.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor13.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void checkBoxSensor9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSensor9.Checked)
            {
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor1.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor13.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void checkBoxSensor10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSensor10.Checked)
            {
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor1.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor13.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void checkBoxSensor11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSensor11.Checked)
            {
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor1.Checked = false;
                cbSensor12.Checked = false;
                cbSensor13.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void cbSensor12_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor12.Checked)
            {
                checkBoxSensor1.Checked = false;
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;                
                cbSensor13.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void cbSensor13_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor13.Checked)
            {
                checkBoxSensor1.Checked = false;
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void cbSensor14_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor14.Checked)
            {
                checkBoxSensor1.Checked = false;
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor13.Checked = false;
                cbSensor15.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void cbSensor15_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor15.Checked)
            {
                checkBoxSensor1.Checked = false;
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor14.Checked = false;
                cbSensor13.Checked = false;
                cbSensor16.Checked = false;
            }
            SaveDevice();
        }

        private void cbSensor16_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor16.Checked)
            {
                checkBoxSensor1.Checked = false;
                checkBoxSensor2.Checked = false;
                checkBoxSensor3.Checked = false;
                checkBoxSensor4.Checked = false;
                checkBoxSensor5.Checked = false;
                checkBoxSensor6.Checked = false;
                checkBoxSensor7.Checked = false;
                checkBoxSensor8.Checked = false;
                checkBoxSensor9.Checked = false;
                checkBoxSensor10.Checked = false;
                checkBoxSensor11.Checked = false;
                cbSensor12.Checked = false;
                cbSensor14.Checked = false;
                cbSensor15.Checked = false;
                cbSensor13.Checked = false;
            }
            SaveDevice();
        }

        private void cbLine1_CheckedChanged(object sender, EventArgs e)
        {
            SaveDevice();
        }

        private void cbLine2_CheckedChanged(object sender, EventArgs e)
        {
            SaveDevice();
        }

        private void cbLine3_CheckedChanged(object sender, EventArgs e)
        {
            SaveDevice();
        }

        private void cbLine4_CheckedChanged(object sender, EventArgs e)
        {
            SaveDevice();
        }

        private void cbLine5_CheckedChanged(object sender, EventArgs e)
        {
            SaveDevice();
        }

        private void cbLine6_CheckedChanged(object sender, EventArgs e)
        {
            SaveDevice();
        }

        private void cbLine7_CheckedChanged(object sender, EventArgs e)
        {
            SaveDevice();
        }

        private void cbLine8_CheckedChanged(object sender, EventArgs e)
        {
            SaveDevice();
        }
    }
}
