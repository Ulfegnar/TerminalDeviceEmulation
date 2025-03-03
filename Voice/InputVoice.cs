using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace TestUU.Voice
{
    public class InputVoice
    {
        private bool connected;
        private bool plaing;
        Socket listerningSocket;
        WaveOut output;
        Thread _tInVoice;
        BufferedWaveProvider bufferStream;
        IPAddress _ipAddress;
        int _udpPort;
        public InputVoice(IPAddress iPAddress, int UDP) 
        { 
            output = new WaveOut();
            bufferStream = new BufferedWaveProvider(new WaveFormat(8000, 8, 1));
            output.Init(bufferStream);

            listerningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 
                ProtocolType.Udp);            
            _ipAddress = iPAddress;
            _udpPort = UDP;
            connected = true;
            plaing = false;
            _tInVoice = new Thread(new ThreadStart(Listerning));
            _tInVoice.Start();
        }

        public void Start()
        {
            plaing = true;
        }

        public void Stop()
        {
            plaing = false;
        }

        public void Dispose()
        {
            connected = false;
            listerningSocket.Close();
            listerningSocket?.Dispose();

            if (output != null)
            {
                output.Stop();
                output.Dispose();
                output = null;
            }
            bufferStream = null;
        }

        private void Listerning()
        {
            IPEndPoint ip = new IPEndPoint(_ipAddress, _udpPort);
            listerningSocket.Bind(ip);
            output.Play();

            EndPoint remoteIp = new IPEndPoint(IPAddress.Any, 0);

            while (connected == true)
            {
                if (plaing)
                {
                    try
                    {
                        byte[] data = new byte[65535];
                        int received = listerningSocket.ReceiveFrom(data, ref remoteIp);
                        bufferStream.AddSamples(data, 0, received);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }                
            }
        }
    }
}
