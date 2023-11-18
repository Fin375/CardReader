using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices.WindowsRuntime;


namespace czytnik_kart_magnetycznych
{
    public partial class Form1 : Form
    {
        CardReader reader;
        string comPort = "COM15";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetCard_Click(object sender, EventArgs e)
        {
            reader = new CardReader(comPort);
            var data = reader.GetCardData();
            var stringData = ByteParser.DumpBytesToString(data);
            textBoxReceived.Text = stringData;
        }

        private void buttonGetPin_Click(object sender, EventArgs e)
        {
            //var exemplaryData = new byte[] { 0xf8, 0xff, 0xf8, 0xff, 0xfe, 0x0b, 0x10, 0x02, 0x08, 0x10, 0x07, 0x01, 0x02, 0x08, 0x16, 0x19, 0x15, 0x01, 0x15, 0x16, 0x16, 0x15, 0x1f, 0x19, 0xff, 0xfa, 0xff };
            
            reader = new CardReader(comPort);
            var data = reader.GetPinData();
            var stringData = ByteParser.DumpBytesToString(data);
            textBoxReceived.Text = stringData;

            //var stringData = ByteParser.DumpBytesToString(exemplaryData);
            //textBoxReceived.Text = stringData;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            reader = new CardReader(comPort);
            reader.TurnOnGreenLeds();
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            reader = new CardReader(comPort);
            reader.TurnOnYellowLeds();
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            reader = new CardReader(comPort);
            reader.TurnOnRedLeds();
        }

        
    }
}
