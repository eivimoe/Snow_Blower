using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;

namespace Remote_Control_App
{
    class SerialPortProtocol
    {
        _comPort SerialPort;
        public SerialPortProtocol()
        {
            _comPort = SerialPort();
        }


        private void CONNECT_Click(object sender, EventArgs e)
        {
            _comPort.PortName = "COM11";
            _comPort.BaudRate = 9600;
            _comPort.Open();

            if (!_comPort.IsOpen) return;
            CONNECT.Enabled = false;

            MessageBox.Show("Connected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void DISCONNECT_Click(object sender, EventArgs e)
        {

            if (_comPort.IsOpen)
                _comPort.Close();
            CONNECT.Enabled = true;
            MessageBox.Show("Disconnected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Message(string message)
        {
            _comPort.Write(message);
        }

    }
}
