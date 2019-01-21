namespace serialcom
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CONNECT = new System.Windows.Forms.Button();
            this.DISCONNECT = new System.Windows.Forms.Button();
            this.SEND = new System.Windows.Forms.Button();
            this.TXWINDOW = new System.Windows.Forms.TextBox();
            this.RXWINDOW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CONNECT
            // 
            this.CONNECT.Location = new System.Drawing.Point(27, 286);
            this.CONNECT.Name = "CONNECT";
            this.CONNECT.Size = new System.Drawing.Size(75, 23);
            this.CONNECT.TabIndex = 0;
            this.CONNECT.Text = "CONNECT";
            this.CONNECT.UseVisualStyleBackColor = true;
            this.CONNECT.Click += new System.EventHandler(this.CONNECT_Click);
            // 
            // DISCONNECT
            // 
            this.DISCONNECT.Location = new System.Drawing.Point(258, 286);
            this.DISCONNECT.Name = "DISCONNECT";
            this.DISCONNECT.Size = new System.Drawing.Size(88, 23);
            this.DISCONNECT.TabIndex = 1;
            this.DISCONNECT.Text = "DISCONNECT";
            this.DISCONNECT.UseVisualStyleBackColor = true;
            this.DISCONNECT.Click += new System.EventHandler(this.DISCONNECT_Click);
            // 
            // SEND
            // 
            this.SEND.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SEND.Location = new System.Drawing.Point(143, 98);
            this.SEND.Name = "SEND";
            this.SEND.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SEND.Size = new System.Drawing.Size(75, 23);
            this.SEND.TabIndex = 2;
            this.SEND.Text = "SEND";
            this.SEND.UseVisualStyleBackColor = true;
            this.SEND.Click += new System.EventHandler(this.SEND_Click);
            // 
            // TXWINDOW
            // 
            this.TXWINDOW.Location = new System.Drawing.Point(82, 56);
            this.TXWINDOW.Multiline = true;
            this.TXWINDOW.Name = "TXWINDOW";
            this.TXWINDOW.Size = new System.Drawing.Size(197, 20);
            this.TXWINDOW.TabIndex = 3;
            // 
            // RXWINDOW
            // 
            this.RXWINDOW.AllowDrop = true;
            this.RXWINDOW.Location = new System.Drawing.Point(82, 182);
            this.RXWINDOW.Multiline = true;
            this.RXWINDOW.Name = "RXWINDOW";
            this.RXWINDOW.Size = new System.Drawing.Size(197, 44);
            this.RXWINDOW.TabIndex = 4;
            this.RXWINDOW.TextChanged += new System.EventHandler(this.RXWINDOW_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COMMAND WINDOW(TX)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "RECEIVE WINDOW(RX)";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM9";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.SEND;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(358, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RXWINDOW);
            this.Controls.Add(this.TXWINDOW);
            this.Controls.Add(this.SEND);
            this.Controls.Add(this.DISCONNECT);
            this.Controls.Add(this.CONNECT);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Tech Geek ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CONNECT;
        private System.Windows.Forms.Button DISCONNECT;
        private System.Windows.Forms.Button SEND;
        private System.Windows.Forms.TextBox TXWINDOW;
        private System.Windows.Forms.TextBox RXWINDOW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        public System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Timer timer1;
    }
}

