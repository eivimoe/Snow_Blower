using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace serialcom
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string RxString;
        

        private void CONNECT_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM11"; 
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
         
            if (!serialPort1.IsOpen) return;
            CONNECT.Enabled = false;

            MessageBox.Show("Connected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void DISCONNECT_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            serialPort1.Close();
            CONNECT.Enabled = true;
            MessageBox.Show("Disconnected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SEND_Click(object sender, EventArgs e)
        {
            
            string tx = TXWINDOW.Text;
            serialPort1.Write(tx);
            TXWINDOW.Clear();
          
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           RxString = serialPort1.ReadExisting();
           this.Invoke(new EventHandler(DisplayText));
           
        }
        private void DisplayText(object sender, EventArgs e)
        {
            RXWINDOW.AppendText(RxString);

        }

        private void RXWINDOW_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void timer1_Tick(object sender, EventArgs e) 
        {
           
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
           
        }

 

    }
}
