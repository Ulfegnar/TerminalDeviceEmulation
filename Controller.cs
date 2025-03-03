using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TestUU.Voice;
using System.Threading.Tasks;
using System.Windows;
using TestUU.Data;
using System.Collections;


namespace TestUU
{
    public class Controller
    {
        Server _Server;
       
        public Client ClientCommand { get; set; }
        private Logger Logger { get; set; }
        List<LogData> _log = new List<LogData>();

        public EventHandler<LogData> GetNewMessage {  get; set; }
        public EventHandler<LogData> SendMessage { get; set; }
        public EventHandler<ControlDevice> ControlDeviceLoad { get; set; }
        public EventHandler serverConnected { get; set; }
        public EventHandler serverDisconnected { get; set; }
        private ControlDevice ControlDevice { get; set; }
        private IPAddress _IPAddress {  get; set; }

        private InputVoice _voice;
        private bool _inNotification;
        private bool _connect = false;

        private PackageHandler _packageHandler;
        private bool _autoconfirmGet = false;


        public Controller()
        {
            ControlDevice = JSON.Read();        
            _inNotification = false;
            _IPAddress = System.Net.IPAddress.Parse(ControlDevice.IPAddressUU);
            _packageHandler = new PackageHandler();
            Logger = new Logger();
        }

        /// <summary>
        /// Подключаемся к сети
        /// </summary>
        /// <param name="o"></param>
        /// <param name="controlDevice"></param>
        public void Connect(object o,  EventArgs e)
        {
            ClientForUncolicitedSignalConnect();
            ServerForCommandConnect();            
        }

        private void ClientForUncolicitedSignalConnect()
        {
            var iPAddress = IPAddress.Parse(ControlDevice.IPAddressUU);
            ClientCommand = new Client(Logger);
            ClientCommand.DataReceived += _Client_DataReceived;
            _ = ClientCommand.ConnectAsync(
                        new IPEndPoint(IPAddress.Parse(ControlDevice.IPAddressArm), ControlDevice.TcpUnsolicitedSignal));            
            
        }
        
        /// <summary>
        /// принимаем реакцию на НС - то есть Б.3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Client_DataReceived(object sender, byte[] e)
        {
            var isValid = _packageHandler.ValidatePackage(e);
            if (isValid)
            {
                var package = _packageHandler.Parse(e);
                if (package is AutoConfirmation answer)
                {
                    _log.Add(new LogData(DateTime.Now, "Автоматическое подтверждение Б.3"));
                    _autoconfirmGet = true;
                }
            }
        }
                

        private void ServerForCommandConnect()
        {
            _log.Add(new LogData(DateTime.Now, "Подключаемся..."));
            GetNewMessage(this, _log.Last());

            _Server = new Server(Logger);

            _Server.DataReceived += DataReceived;

            _= _Server.StartAsync(new IPEndPoint(IPAddress.Parse(ControlDevice.IPAddressUU), 
                                                    ControlDevice.TcpCommand));

            _log.Add(new LogData(DateTime.Now, $"Порт TcpCommand = {ControlDevice.TcpCommand}")); ;
            GetNewMessage(this, _log.Last());

            
            serverConnected(this, new EventArgs());
            _log.Add(new LogData(DateTime.Now, "Ожидание данных"));
            GetNewMessage(this, _log.Last());

            if (_voice == null)
            {
                _voice = new InputVoice(_IPAddress, ControlDevice.UDP);
                _log.Add(new LogData(DateTime.Now, $"Порт UDP = {ControlDevice.UDP}")); ;
                GetNewMessage(this, _log.Last());
            }

            _connect = true;
        }

        public void Disconnect(object o, EventArgs e) 
        {
            if (_Server != null)
            {
                _Server.CloseConnection();
            }                
            serverDisconnected(this, new EventArgs());
            _log.Add(new LogData(DateTime.Now, "Отключились от сети"));
            GetNewMessage(this, _log.Last());
            _connect= false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataReceived(object sender, byte[] data)
        {            
            Package package = DataToPacket.GetPacket(data);

            switch (package)
            {
                case IncomingNotification incomingNotification: B1_EnterNotificationGet(incomingNotification);  break;
                case StartSoundNotification _: B6_StartVoiceGet(); break;
                case StopSoundNotification _: B7_StopVoiceGet(); break;
                case CheckWithoutActivation checkWithoutActivation: B11_CheckWithoutDeviceGet(checkWithoutActivation); break;
                case CheckWithActivation checkWithActivation: B12_CheckWithDeviceGet(checkWithActivation); break;
                case StateRequest _: B13_StatusRequestGet(); break;
                case EndSession _: A6_SeanceCanceledGet(); break;
                case Reset _: A7_ResetGet(); break;

                case AutoConfirmation autoConfirmation: GetCvitSignal(); break;                    
            }
        }
                

        private void A7_ResetGet()
        {
            _log.Add(new LogData(DateTime.Now,
                $"А7: Сброс"));
            SendMessage(this, _log.Last());
        }

        private void A6_SeanceCanceledGet()
        {
            _log.Add(new LogData(DateTime.Now,
                $"А6: Завершение сеанса"));
            SendMessage(this, _log.Last());
        }

        private void B13_StatusRequestGet()
        {
            _log.Add(new LogData(DateTime.Now,
                $"Б13: запрос состояния"));
            SendMessage(this, _log.Last());
            StatusDeviceSend();
        }

        private void B12_CheckWithDeviceGet(Package package)
        {
            if (package is CheckWithActivation command)
            {                
                _log.Add(new LogData(DateTime.Now,
                $"Б12: Проверка с включением оконечных устройств, номер абонента " +
                $"{command.AbonentNumber}"));
                SendMessage(this, _log.Last());
            }                        
        }

        /// <summary>
        /// отвечаем, что живы
        /// </summary>
        /// <param name="package"></param>
        private void B11_CheckWithoutDeviceGet(Package package)
        {
            if (package is CheckWithoutActivation command)
            {
                _log.Add(new LogData(DateTime.Now,
                $"Б11: Проверка без включения оконечных устройств, номер абонента " +
                $"{command.AbonentNumber}"));
                SendMessage(this, _log.Last());
                AutoConfirmSend(this, new EventArgs());
            }            
        }

        private void B7_StopVoiceGet()
        {
            _log.Add(new LogData(DateTime.Now, "Б7: Остановка звукового сообщения"));
            SendMessage(this, _log.Last());

            if (ControlDevice.B3Auto)
                AutoConfirmSend(this, new EventArgs());

            if (_voice != null)
                    _voice.Stop();
        }

        private void B6_StartVoiceGet()
        {
            _log.Add(new LogData(DateTime.Now, "Б6: Старт звукового сообщения"));
            SendMessage(this, _log.Last());

            if (ControlDevice.B3Auto)
                AutoConfirmSend(this, new EventArgs());
            _voice.Start();
        }

        private void B1_EnterNotificationGet(Package package)
        {   
            if (package is IncomingNotification command)
            {
                _inNotification = true;

                if ((int)command.Mode == (int)NotificationMode.SirenIntermittent)
                {
                    _log.Add(new LogData(DateTime.Now,
                        "Б1: входящее оповещение в режиме сирены прерывисто")); 
                }
                else if ((int)command.Mode == (int)NotificationMode.SirenContinously)
                {
                    _log.Add(new LogData(DateTime.Now,
                        "Б1: входящее оповещение в режиме сирены непрерывно")); 
                }
                else if ((int)command.Mode == (int)NotificationMode.Sound)
                {
                    _log.Add(new LogData(DateTime.Now, "Б1: входящее оповещение в режиме речи"));
                }
                
                SendMessage(this, _log.Last());

                if (ControlDevice.B3Auto)
                    AutoConfirmSend(this, new EventArgs());
            }   
        }

        private void GetCvitSignal()
        {            
            GetNewMessage(this, _log.Last());
        }

        private void B3_AutoConfirmGet()
        {
            _log.Add(new LogData(DateTime.Now, "Б3: Автоматическое подтверждение"));
        }

        /// <summary>
        /// Б.4 Подтверждение оконечным устрйоством. Статус квитанции в 3-ем байте 
        /// и код ошибки в 4-ом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="state"></param>
        internal void ConfirmSignalSend(object sender, NotificationState state)
        {
            var stateDevice = new TerminalDeviceConfirmation();
            stateDevice.StartSuccessful = state.Success;
            if (state.OtherNotification) stateDevice.ErrorCode = ControlDeviceCodes.InNotification;
            else if (state.NoSeance) stateDevice.ErrorCode = ControlDeviceCodes.NoSeance;
                        
            _= _Server.SendAnswerAsync(stateDevice);
            _log.Add(new LogData(DateTime.Now, "Отправлен Б4: Сигнал подтверждения отправлен"));
            SendMessage(this, _log.Last());
        }

        internal void StatusDeviceSend(object sender, StateControlDevice state)
        {
            var stateDevice = new RecieptStateRequest();

            stateDevice.StateInputSignals_1_8 = GetSensorByte(new bool[] { state.NSD,state.LegalAccess, 
                                                        state.PowerLoose, state.PowerAccumLow, 
                                                        state.SoundReset, state.SoundError, 
                                                        state.DisplayError, state.FiderError});
            stateDevice.StateInputSignals_9_16 = GetSensorByte(new bool[] { state.TerminalDeviceError,
                                                        state.TemperatureHight, state.TemperatureLow});
            stateDevice.StateOutputSignals_1_8 = GetSensorByte(new bool[] { state.Line1, state.Line2, 
                                                        state.Line3, state.Line4, state.Line5, state.Line6, 
                                                        state.Line7, state.Line8});

            _= _Server.SendAnswerAsync(stateDevice);            
            
            _log.Add(new LogData(DateTime.Now, "Статус устройства управления отправлен"));
            SendMessage(this, _log.Last());
        }

        internal void StatusDeviceSend()
        {
            var stateDevice = new RecieptStateRequest();

            var state1_8 = new bool[8];
            ControlDevice.Sensors.CopyTo(0, state1_8, 0, 8);            
            var state9_16 = new bool[8];
            ControlDevice.Sensors.CopyTo(8, state9_16, 0, 8);
            var line1_8 = new bool[8];
            ControlDevice.Lines.CopyTo(0, line1_8, 0, 8);

            Print(state1_8);
            Print(state9_16);
            Print(line1_8);

            stateDevice.StateInputSignals_1_8 = GetSensorByte(state1_8);
            stateDevice.StateInputSignals_9_16 = GetSensorByte(state9_16);
            stateDevice.StateOutputSignals_1_8 = GetSensorByte(line1_8);

            _ = _Server.SendAnswerAsync(stateDevice);            

            _log.Add(new LogData(DateTime.Now, "Статус устройства управления отправлен"));
            SendMessage(this, _log.Last());
        }

        private void Print(bool[] _byte)
        {
            foreach (bool b in _byte)
                Console.Write(b + " ");
            Console.WriteLine();
        }

        private byte GetSensorByte(bool[] state)
        {            
            BitArray sensors = new BitArray(8);

            for ( int i = 0; i< state.Length; i++)
                sensors[i] = state[i];
            
            byte[] s = new byte[2];
            sensors.CopyTo(s, 0);

            return s[0];
        }

        /// <summary>
        /// передача Б23 во время оповещения (при поступлении ошибки) 
        /// или в держурном режиме (при изменении состояния одного из датчиков)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="state"></param>
        internal async void StatusSensorSendInUnsolicitedSignal(object sender, StateControlDevice state)
        {
            if (_inNotification)
            {
                ErrorSendInUnsolicitedSignal();
            }
            else
            {
                SendUnsolicitedSignal(state);                
            }
        }

        /// <summary>
        /// Отправляем по сигналу на каждый "сработавший" датчик
        /// Есть текущие статусы. Сравниваем с ними, формируем реестр изменений
        /// По этому реестру отправляем Б23 (каждый после получения Б.3)
        /// </summary>
        /// <param name="state"></param>
        private async void SendUnsolicitedSignal(StateControlDevice state)
        {
            byte sensorNumber = 0x00;
            //приходит только один чекбокс - находим передаём его
            if (state.NSD) sensorNumber = ControlDeviceCodes.NSD;
            else if (state.LegalAccess) sensorNumber = ControlDeviceCodes.SD;
            else if (state.PowerLoose) sensorNumber = ControlDeviceCodes.PowerOut;
            else if (state.PowerAccumLow) sensorNumber = ControlDeviceCodes.AccumulatorPowerLow;
            else if (state.SoundReset) sensorNumber = ControlDeviceCodes.BoosterSoundTranslationOverload;
            else if (state.SoundError) sensorNumber = ControlDeviceCodes.BoosterSoundTranslationError;
            else if (state.DisplayError) sensorNumber = ControlDeviceCodes.TabloError;
            else if (state.FiderError) sensorNumber = ControlDeviceCodes.FiderError;
            else if (state.TerminalDeviceError) sensorNumber = ControlDeviceCodes.TerminalDeviceError;
            else if (state.TemperatureHight) sensorNumber = ControlDeviceCodes.TemperatureTooHight;
            else if (state.TemperatureLow) sensorNumber = ControlDeviceCodes.TemperatureTooLow;
            else if (state.ControlDeviceOn) sensorNumber = ControlDeviceCodes.ControlDeviceOn;
            else if (state.SirenOn) sensorNumber = ControlDeviceCodes.SirenOn;
            else if (state.VoiceOn) sensorNumber = ControlDeviceCodes.VoiceOn;
            else if (state.Timeout) sensorNumber = ControlDeviceCodes.StandbyModeByTimer;
            else if (state.Error) sensorNumber = ControlDeviceCodes.StandbyModeByError;
            else if (state.NoSeance) sensorNumber = ControlDeviceCodes.NoSeance;
            
            SendB23(sensorNumber);
            //Передача нескольких сообщений по выделенным чекбоксам - на будущее
            //var b23buffer = new List<byte>();
            //if (state.NSD != ControlDevice.Sensors[0]) b23buffer.Add(ControlDeviceCodes.NSD);
            //else if (state.LegalAccess != ControlDevice.Sensors[1]) b23buffer.Add(ControlDeviceCodes.SD);
            //else if (state.PowerLoose != ControlDevice.Sensors[2]) b23buffer.Add(ControlDeviceCodes.PowerOut);
            //else if (state.PowerAccumLow != ControlDevice.Sensors[3]) b23buffer.Add(ControlDeviceCodes.AccumulatorPowerLow);
            //else if (state.SoundReset != ControlDevice.Sensors[4]) b23buffer.Add(ControlDeviceCodes.BoosterSoundTranslationOverload);
            //else if (state.SoundError != ControlDevice.Sensors[5]) b23buffer.Add(ControlDeviceCodes.BoosterSoundTranslationError);
            //else if (state.DisplayError != ControlDevice.Sensors[6]) b23buffer.Add(ControlDeviceCodes.TabloError);
            //else if (state.FiderError != ControlDevice.Sensors[7]) b23buffer.Add(ControlDeviceCodes.FiderError);
            //else if (state.TerminalDeviceError != ControlDevice.Sensors[8]) b23buffer.Add(ControlDeviceCodes.TerminalDeviceError);
            //else if (state.TemperatureHight != ControlDevice.Sensors[9]) b23buffer.Add(ControlDeviceCodes.TemperatureTooHight);
            //else if (state.TemperatureLow != ControlDevice.Sensors[10]) b23buffer.Add(ControlDeviceCodes.TemperatureTooLow);
            //else if (state.ControlDeviceOn != ControlDevice.Sensors[11]) b23buffer.Add(ControlDeviceCodes.ControlDeviceOn);
            //else if (state.SirenOn != ControlDevice.Sensors[12]) b23buffer.Add(ControlDeviceCodes.SirenOn);
            //else if (state.VoiceOn != ControlDevice.Sensors[13]) b23buffer.Add(ControlDeviceCodes.VoiceOn);
            //else if (state.Timeout != ControlDevice.Sensors[14]) b23buffer.Add(ControlDeviceCodes.StandbyModeByTimer);
            //else if (state.Error != ControlDevice.Sensors[15]) b23buffer.Add(ControlDeviceCodes.StandbyModeByError);
            //else if (state.NoSeance != ControlDevice.Sensors[16]) b23buffer.Add(ControlDeviceCodes.NoSeance);

            //foreach (var sensor in b23buffer)
            //{
            //    await SendB23(sensor);
            //}
        }

        private async void SendB23(byte sensor)
        {
            var signal = new UnsolicitedSignal();
            signal.SensorNumber = sensor;
            signal.SensorNotified = true;
            //_= _Server?.SendAnswerAsync(signal);            
            await ClientCommand.SendPackageAsync(signal);
        }


        /// <summary>
        /// Передача незапрашиваемого сигнала с ошибкой во время оповещения
        /// </summary>
        internal void ErrorSendInUnsolicitedSignal()
        {
            var signal = new UnsolicitedSignal();
            signal.SensorNumber = ControlDeviceCodes.StandbyModeByError;
            signal.SensorNotified = true;

            _ = _Server.SendAnswerAsync(signal);
            
            _log.Add(new LogData(DateTime.Now, "Сообщение об ошибке отправлено!"));
            SendMessage(this, _log.Last());
        }

        public void AutoConfirmSend(object sender, EventArgs e)
        {
            _ = _Server.SendAnswerAsync(new AutoConfirmation());            
                        
            _log.Add(new LogData(DateTime.Now, "Сигнал автоматического подтверждения отправлен"));
            SendMessage(this, _log.Last());
        }

        public void ControlDeviceSave(object sender, ControlDevice controlDevice)
        {
            _= JSON.Write(controlDevice);
            ControlDevice.Copy(controlDevice);
        }

        public void ConrolDeviceSaveBeforeClosing(object o, EventArgs e)
        {
            JSON.Write(ControlDevice);
            Disconnect(this, new EventArgs());
            Environment.Exit(0);
        }

        public ControlDevice GetControlDevice()
        {   
            return new ControlDevice(ControlDevice.IPAddressUU,
                ControlDevice.TcpCommand, ControlDevice.IPAddressArm, ControlDevice.TcpUnsolicitedSignal, 
                ControlDevice.UDP, ControlDevice.Status, ControlDevice.Lines, ControlDevice.Sensors, 
                ControlDevice.B3Auto);
        }

        internal void B3Changed(object sender, bool e)
        {
            ControlDevice.B3Auto = e;
        }
    }
}
