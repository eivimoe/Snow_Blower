using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Control_App
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        string RxString;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                //this.MaximizedBounds = Screen.GetWorkingArea(this).
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // CONNECT
        private void btnConnect_Click(object sender, EventArgs e)
        {
            I_comPort.PortName = RXWINDOW.Text;
            I_comPort.BaudRate = 9600;
            I_comPort.Open();

            if (!I_comPort.IsOpen) return;
           btnConnect.Enabled = false;

            MessageBox.Show("Connected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblComPort.Text = "Connected - " + I_comPort.PortName;
            RXWINDOW.Text = "";
        }

        // DISCONNECT
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (I_comPort.IsOpen)
                I_comPort.Close();
            btnConnect.Enabled = true;
            lblComPort.Text = "Disconnected";
            MessageBox.Show("Disconnected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event for data recieved
        private void I_comPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = I_comPort.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }

        // Add text to textbox
        private void DisplayText(object sender, EventArgs e)
        {
            RXWINDOW.AppendText(RxString);

        }

        // Go Forward 
        private void btnForward_Click(object sender, EventArgs e)
        {
            string tx = RXWINDOW.Text;
            I_comPort.Write("mf_" + tx);
            RXWINDOW.Clear();
        }

        // Turn left
        private void btnLeft_Click(object sender, EventArgs e)
        {
            string tx = RXWINDOW.Text;
            I_comPort.Write("ml_" + tx);
            RXWINDOW.Clear();
        }

        // Go backward
        private void btnBack_Click(object sender, EventArgs e)
        {
            string tx = RXWINDOW.Text;
            I_comPort.Write("mb_" + tx);
            RXWINDOW.Clear();
        }

        // Turn right
        private void btnRight_Click(object sender, EventArgs e)
        {
            string tx = RXWINDOW.Text;
            I_comPort.Write("mr_" + tx);
            RXWINDOW.Clear();
        }

        // Full stop
        private void btnFullStop_Click(object sender, EventArgs e)
        {
            I_comPort.Write("ms");
            RXWINDOW.Clear();
        }

        // Stop snowblower
        private void btnStopSnowBlower_Click(object sender, EventArgs e)
        {
            I_comPort.Write("ss");
            RXWINDOW.Clear();
        }

        // Run snowblower
        private void btnRun_Click(object sender, EventArgs e)
        {
            string tx = RXWINDOW.Text;
            I_comPort.Write("sr_" + tx);
            RXWINDOW.Clear();
        }

        // Reset snowblower
        private void btnReset_Click(object sender, EventArgs e)
        {
            I_comPort.Write("sR");
            RXWINDOW.Clear();
        }

        // Lift snowblower
        private void btnLift_Click(object sender, EventArgs e)
        {
            string tx = RXWINDOW.Text;
            I_comPort.Write("sl_" + tx);
            RXWINDOW.Clear();
        }

        // Set chute angle
        private void btnAngle_Click(object sender, EventArgs e)
        {
            string tx = RXWINDOW.Text;
            I_comPort.Write("sa_" + tx);
            RXWINDOW.Clear();
        }

        // Set chute rotation
        private void btnRotation_Click(object sender, EventArgs e)
        {
            string tx = RXWINDOW.Text;
            I_comPort.Write("sd_" + tx);
            RXWINDOW.Clear();
        }
    }
}
