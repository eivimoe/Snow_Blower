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

        void Reset()
        {
            lblResponse.Text = "";
            RXWINDOW.Clear();
        }

        // Add text to textbox
        private void DisplayText(object sender, EventArgs e)
        {
            richTextBox1.AppendText(RxString);
            //lblResponse.Text += RxString;
        }

        // Go Forward 
        private void btnForward_Click(object sender, EventArgs e)
        {
            goForward();
        }

        // Turn left
        private void btnLeft_Click(object sender, EventArgs e)
        {
            goLeft();
        }

        // Go backward
        private void btnBack_Click(object sender, EventArgs e)
        {
            goBack();
        }

        // Turn right
        private void btnRight_Click(object sender, EventArgs e)
        {
            goRight();
        }

        // Full stop
        private void btnFullStop_Click(object sender, EventArgs e)
        {
            FullStop();
        }

        private void FullStop()
        {
            I_comPort.Write("ms_");
            Reset();
        }

        // Stop snowblower
        private void btnStopSnowBlower_Click(object sender, EventArgs e)
        {
            StopSnowBlower();
        }

        // Run snowblower
        private void btnRun_Click(object sender, EventArgs e)
        {
            RunSnowBlower();
        }

        private void RunSnowBlower()
        {
            string tx = RXWINDOW.Text;
            if (tx == string.Empty) tx = "100";
            I_comPort.Write("sr_" + tx);
            Reset();
        }

        // Reset snowblower
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            I_comPort.Write("sR_");
        }

        // Lift snowblower
        private void btnLift_Click(object sender, EventArgs e)
        {
            string tx = RXWINDOW.Text;
            I_comPort.Write("sl_" + tx);
            Reset();
        }

        // Set chute angle
        private void btnAngle_Click(object sender, EventArgs e)
        {
            string tx = RXWINDOW.Text;
            I_comPort.Write("sa_" + tx);
            Reset();
        }

        // Set chute rotation
        private void btnRotation_Click(object sender, EventArgs e)
        {
            string tx = RXWINDOW.Text;
            I_comPort.Write("sd_" + tx);
            Reset();
        }

        private void btnStopBrush_Click(object sender, EventArgs e)
        {
            I_comPort.Write("bs_");
            Reset();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ScrollToCaret();
        }

        private void goRight()
        {
            string tx = txtVel.Text;
            if (tx == string.Empty) tx = "100";
            I_comPort.Write("mr_" + tx);
        }

        private void goBack()
        {
            string tx = txtVel.Text;
            if (tx == string.Empty) tx = "100";
            I_comPort.Write("mb_" + tx);
        }

        private void goLeft()
        {
            string tx = txtVel.Text;
            if (tx == string.Empty) tx = "100";
            I_comPort.Write("ml_" + tx);
        }

        private void goForward()
        {
            string tx = txtVel.Text;
            if (tx == string.Empty) tx = "100";
            I_comPort.Write("mf_" + tx);
        }

        private void StopSnowBlower()
        {
            I_comPort.Write("ss_");
            Reset();
        }

        // Hot keys handler

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (RXWINDOW.Focused == false && txtVel.Focused == false)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        goForward();
                        break;
                    case Keys.A:
                        goLeft();
                        break;
                    case Keys.S:
                        goBack();
                        break;
                    case Keys.D:
                        goRight();
                        break;
                    case Keys.Space:
                        FullStop();
                        break;
                    default:
                        FullStop();
                        break;
                }
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
        }
    }
}
