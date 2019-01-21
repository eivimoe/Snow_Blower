namespace Remote_Control_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnFullStop = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLift = new System.Windows.Forms.Button();
            this.btnRotation = new System.Windows.Forms.Button();
            this.btnAngle = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStopSnowBlower = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHeader.BackColor = System.Drawing.Color.LightGray;
            this.pnlHeader.Controls.Add(this.lblEvent);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnMinMax);
            this.pnlHeader.Controls.Add(this.lblClock);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 38);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.Location = new System.Drawing.Point(397, 10);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(0, 18);
            this.lblEvent.TabIndex = 6;
            this.lblEvent.Visible = false;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(0, 0);
            this.lblClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(77, 31);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "clock";
            // 
            // btnForward
            // 
            this.btnForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.ForeColor = System.Drawing.SystemColors.Control;
            this.btnForward.Location = new System.Drawing.Point(630, 218);
            this.btnForward.Margin = new System.Windows.Forms.Padding(2);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(50, 50);
            this.btnForward.TabIndex = 5;
            this.btnForward.Text = "W";
            this.btnForward.UseVisualStyleBackColor = false;
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLeft.Location = new System.Drawing.Point(559, 281);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(50, 50);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "A";
            this.btnLeft.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(630, 281);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "S";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRight.Location = new System.Drawing.Point(701, 281);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(50, 50);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "D";
            this.btnRight.UseVisualStyleBackColor = false;
            // 
            // btnFullStop
            // 
            this.btnFullStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFullStop.BackColor = System.Drawing.Color.Red;
            this.btnFullStop.FlatAppearance.BorderSize = 0;
            this.btnFullStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullStop.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFullStop.Location = new System.Drawing.Point(606, 348);
            this.btnFullStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnFullStop.Name = "btnFullStop";
            this.btnFullStop.Size = new System.Drawing.Size(100, 50);
            this.btnFullStop.TabIndex = 9;
            this.btnFullStop.Text = "Stop";
            this.btnFullStop.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Remote_Control_App.Properties.Resources._546323_200_1_1;
            this.pictureBox2.Location = new System.Drawing.Point(485, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remote_Control_App.Properties.Resources.photo_1;
            this.pictureBox1.Location = new System.Drawing.Point(118, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(701, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 38);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinMax.FlatAppearance.BorderSize = 0;
            this.btnMinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMinMax.Image")));
            this.btnMinMax.Location = new System.Drawing.Point(734, 0);
            this.btnMinMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(33, 38);
            this.btnMinMax.TabIndex = 4;
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(767, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLift
            // 
            this.btnLift.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnLift.FlatAppearance.BorderSize = 0;
            this.btnLift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLift.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLift.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLift.Location = new System.Drawing.Point(47, 183);
            this.btnLift.Margin = new System.Windows.Forms.Padding(2);
            this.btnLift.Name = "btnLift";
            this.btnLift.Size = new System.Drawing.Size(50, 50);
            this.btnLift.TabIndex = 12;
            this.btnLift.Text = "Lift";
            this.btnLift.UseVisualStyleBackColor = false;
            // 
            // btnRotation
            // 
            this.btnRotation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnRotation.FlatAppearance.BorderSize = 0;
            this.btnRotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRotation.Location = new System.Drawing.Point(189, 183);
            this.btnRotation.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotation.Name = "btnRotation";
            this.btnRotation.Size = new System.Drawing.Size(50, 50);
            this.btnRotation.TabIndex = 14;
            this.btnRotation.Text = "Rot";
            this.btnRotation.UseVisualStyleBackColor = false;
            // 
            // btnAngle
            // 
            this.btnAngle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnAngle.FlatAppearance.BorderSize = 0;
            this.btnAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAngle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAngle.Location = new System.Drawing.Point(118, 183);
            this.btnAngle.Margin = new System.Windows.Forms.Padding(2);
            this.btnAngle.Name = "btnAngle";
            this.btnAngle.Size = new System.Drawing.Size(50, 50);
            this.btnAngle.TabIndex = 13;
            this.btnAngle.Text = "Angl";
            this.btnAngle.UseVisualStyleBackColor = false;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRun.Location = new System.Drawing.Point(118, 120);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(50, 50);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            // 
            // btnStopSnowBlower
            // 
            this.btnStopSnowBlower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStopSnowBlower.BackColor = System.Drawing.Color.Red;
            this.btnStopSnowBlower.FlatAppearance.BorderSize = 0;
            this.btnStopSnowBlower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopSnowBlower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopSnowBlower.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStopSnowBlower.Location = new System.Drawing.Point(93, 237);
            this.btnStopSnowBlower.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopSnowBlower.Name = "btnStopSnowBlower";
            this.btnStopSnowBlower.Size = new System.Drawing.Size(100, 50);
            this.btnStopSnowBlower.TabIndex = 15;
            this.btnStopSnowBlower.Text = "Stop";
            this.btnStopSnowBlower.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(93, 300);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 50);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStopSnowBlower);
            this.Controls.Add(this.btnLift);
            this.Controls.Add(this.btnRotation);
            this.Controls.Add(this.btnAngle);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnFullStop);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnFullStop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLift;
        private System.Windows.Forms.Button btnRotation;
        private System.Windows.Forms.Button btnAngle;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStopSnowBlower;
        private System.Windows.Forms.Button btnReset;
    }
}

