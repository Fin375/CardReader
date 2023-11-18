using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace czytnik_kart_magnetycznych
{
    enum State
    {
        DISCONNECTED,
        CONNECTED
    }

    class CardReader
    {
        public SerialPort sp;
        public State State { get; set; }
        public string Port { get; set; }

        byte selectKeyboard = 0xA8;
        byte selectReader = 0xAA;
        byte turnOnGreenLed = 0xA4;
        byte turnOnYellowLed = 0xA2;
        byte turnOnRedLed = 0xA1;
        byte stop = 0xFF;

        public CardReader(string port)
        {
            Port = port;
            State = State.DISCONNECTED;
            SetPortParams(Port);
        }

        public void SetPortParams(string comPort)
        {
            int baudRate = 2400;
            int timeout = 10000; // timeout w milisekundach
            Parity parity = Parity.Even;
            int stopBits = 1;
            sp = new SerialPort(comPort, baudRate, parity, 8, (StopBits)stopBits);
            sp.ReadTimeout = timeout;

            sp.WriteTimeout = 10000;
        }
        
        public void TurnOnLeds(byte turnOnLed)
        {
            var command = new byte[] { selectKeyboard, stop, turnOnLed, stop };
            sp.Open();
            Thread.Sleep(1000);
            State = State.CONNECTED;
            if (sp.IsOpen)
            {
                SendCommand(command);
                Thread.Sleep(1000);
            }
            sp.Close();
            State = State.DISCONNECTED;
        }
        public void TurnOnGreenLeds()
        {
            TurnOnLeds(turnOnGreenLed);
        }
        public void TurnOnYellowLeds()
        {
            TurnOnLeds(turnOnYellowLed);
        }
        public void TurnOnRedLeds()
        {
            TurnOnLeds(turnOnRedLed);
        }

        public byte[] GetPinData()
        {
            byte[] command = new byte[] { selectKeyboard, stop, turnOnGreenLed, stop }; 
            int bytesToReceive = 15;
            byte[] answer = new byte[] { };

            try
            {
                sp.Open();
                State = State.CONNECTED;
                Thread.Sleep(1000);

                if (sp.IsOpen)
                    answer = SendCommandAndReceiveData(command, bytesToReceive);
            }
            catch (TimeoutException) { }
            finally
            {
                sp.Close();
                State = State.DISCONNECTED;
            }          

            return answer;

        }

        public byte[] GetCardData()
        {
            byte[] command = new byte[] { selectReader, stop, turnOnGreenLed, stop };
            int bytesToReceive = 27;
            byte[] answer = new byte[] { };

            try
            {
                sp.Open();
                State = State.CONNECTED;
                Thread.Sleep(1000);

                if (sp.IsOpen)
                    answer = SendCommandAndReceiveData(command, bytesToReceive);
            }
            catch (TimeoutException) { }
            finally
            {
                sp.Close();
                State = State.DISCONNECTED;
            }
            
            return answer;
        }

        public byte[] SendCommandAndReceiveData(byte[] command, int bytesToReceive)
        {
            Thread.Sleep(1000);
            SendCommand(command);
            Thread.Sleep(1000);
            
            //byte[] receivedData = ReadFromPort(bytesToReceive);
            //return receivedData;
            
            List<byte> receivedData = ReadFromPortAgain(bytesToReceive);
            byte[] resultArray = receivedData.ToArray();
            return resultArray;
        }

        

        private void SendCommand(byte[] command)
        {
            sp.Write(command, 0, command.Length);
        }

        byte[] ReadFromPort(int numberOfBytes)
        {
            byte[] buffer = new byte[] { };

            if (State == State.DISCONNECTED)
            {
                return buffer;
            }

            try
            {
                sp.Read(buffer, 0, numberOfBytes);
            }
            catch (TimeoutException) { }

            return buffer;
        }
        List<byte> ReadFromPortAgain(int numberOfBytes)
        {
            List<byte> buffer = new List<byte>();

            if (State == State.DISCONNECTED)
            {
                return buffer;
            }

            try
            {
                byte[] tempBuffer = new byte[numberOfBytes];
                sp.Read(tempBuffer, 0, numberOfBytes);
                buffer.AddRange(tempBuffer);
            }
            catch (TimeoutException) { }

            return buffer;
        }

        
    }
}
