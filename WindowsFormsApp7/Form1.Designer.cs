namespace WindowsFormsApp7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gboxDeviceSetup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.gboxInitPump = new System.Windows.Forms.GroupBox();
            this.btnAcidFeed = new System.Windows.Forms.Button();
            this.btnBaseFeed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMetalFeed = new System.Windows.Forms.Button();
            this.gboxPhControl = new System.Windows.Forms.GroupBox();
            this.cboxMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gboxThreshold = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnThresholdStop = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tboxLowerLimit = new System.Windows.Forms.TextBox();
            this.tboxUperLimit = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnThresholdStart = new System.Windows.Forms.Button();
            this.gboxAcidPump = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labeltimerAcidPump = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tboxAcidTimer = new System.Windows.Forms.TextBox();
            this.btnAcidOff = new System.Windows.Forms.Button();
            this.tboxAcidFLow = new System.Windows.Forms.TextBox();
            this.btnAcidOn = new System.Windows.Forms.Button();
            this.gboxBasePump = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.labeltimerBasePump = new System.Windows.Forms.Label();
            this.btnBaseOff = new System.Windows.Forms.Button();
            this.btnBaseOn = new System.Windows.Forms.Button();
            this.tboxBaseTimer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxBaseFlow = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gboxMetalSol = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.labeltimerMetalSol = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tboxMetalTimer = new System.Windows.Forms.TextBox();
            this.tboxMetakFlow = new System.Windows.Forms.TextBox();
            this.btnMetalSolOff = new System.Windows.Forms.Button();
            this.btnMetalSolOn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timMetalSol = new System.Windows.Forms.Timer(this.components);
            this.timBasePump = new System.Windows.Forms.Timer(this.components);
            this.timAcidPump = new System.Windows.Forms.Timer(this.components);
            this.gboxPumpStatus = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.labelTotalAcid = new System.Windows.Forms.Label();
            this.labelTotalBase = new System.Windows.Forms.Label();
            this.labelTotalMetal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.timAuto = new System.Windows.Forms.Timer(this.components);
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboxDeviceSetup.SuspendLayout();
            this.gboxInitPump.SuspendLayout();
            this.gboxPhControl.SuspendLayout();
            this.gboxThreshold.SuspendLayout();
            this.gboxAcidPump.SuspendLayout();
            this.gboxBasePump.SuspendLayout();
            this.gboxMetalSol.SuspendLayout();
            this.gboxPumpStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxDeviceSetup
            // 
            this.gboxDeviceSetup.Controls.Add(this.label1);
            this.gboxDeviceSetup.Controls.Add(this.btnStart);
            this.gboxDeviceSetup.Controls.Add(this.portNameComboBox);
            this.gboxDeviceSetup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDeviceSetup.Location = new System.Drawing.Point(12, 123);
            this.gboxDeviceSetup.Name = "gboxDeviceSetup";
            this.gboxDeviceSetup.Size = new System.Drawing.Size(187, 110);
            this.gboxDeviceSetup.TabIndex = 0;
            this.gboxDeviceSetup.TabStop = false;
            this.gboxDeviceSetup.Text = "Device Setup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(52, 57);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "CONNECT";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(52, 30);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(127, 21);
            this.portNameComboBox.TabIndex = 1;
            this.portNameComboBox.SelectedIndexChanged += new System.EventHandler(this.portNameComboBox_SelectedIndexChanged);
            this.portNameComboBox.Click += new System.EventHandler(this.portNameComboBox_Click);
            // 
            // gboxInitPump
            // 
            this.gboxInitPump.Controls.Add(this.btnAcidFeed);
            this.gboxInitPump.Controls.Add(this.btnBaseFeed);
            this.gboxInitPump.Controls.Add(this.label3);
            this.gboxInitPump.Controls.Add(this.label5);
            this.gboxInitPump.Controls.Add(this.label2);
            this.gboxInitPump.Controls.Add(this.label6);
            this.gboxInitPump.Controls.Add(this.btnMetalFeed);
            this.gboxInitPump.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxInitPump.Location = new System.Drawing.Point(12, 239);
            this.gboxInitPump.Name = "gboxInitPump";
            this.gboxInitPump.Size = new System.Drawing.Size(187, 163);
            this.gboxInitPump.TabIndex = 3;
            this.gboxInitPump.TabStop = false;
            this.gboxInitPump.Text = "Initial Pump Setup";
            // 
            // btnAcidFeed
            // 
            this.btnAcidFeed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcidFeed.Location = new System.Drawing.Point(123, 122);
            this.btnAcidFeed.Name = "btnAcidFeed";
            this.btnAcidFeed.Size = new System.Drawing.Size(56, 26);
            this.btnAcidFeed.TabIndex = 14;
            this.btnAcidFeed.Text = "Feed";
            this.btnAcidFeed.UseVisualStyleBackColor = true;
            this.btnAcidFeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAcidFeed_MouseDown);
            this.btnAcidFeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAcidFeed_MouseUp);
            // 
            // btnBaseFeed
            // 
            this.btnBaseFeed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseFeed.Location = new System.Drawing.Point(123, 77);
            this.btnBaseFeed.Name = "btnBaseFeed";
            this.btnBaseFeed.Size = new System.Drawing.Size(56, 26);
            this.btnBaseFeed.TabIndex = 13;
            this.btnBaseFeed.Text = "Feed";
            this.btnBaseFeed.UseVisualStyleBackColor = true;
            this.btnBaseFeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBaseFeed_MouseDown);
            this.btnBaseFeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBaseFeed_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Acid Pump";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Base Pump";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Metal Solution Pump";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 7;
            // 
            // btnMetalFeed
            // 
            this.btnMetalFeed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetalFeed.Location = new System.Drawing.Point(123, 34);
            this.btnMetalFeed.Name = "btnMetalFeed";
            this.btnMetalFeed.Size = new System.Drawing.Size(56, 26);
            this.btnMetalFeed.TabIndex = 3;
            this.btnMetalFeed.Text = "Feed";
            this.btnMetalFeed.UseVisualStyleBackColor = true;
            this.btnMetalFeed.Click += new System.EventHandler(this.button4_Click);
            this.btnMetalFeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.btnMetalFeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // gboxPhControl
            // 
            this.gboxPhControl.Controls.Add(this.cboxMode);
            this.gboxPhControl.Controls.Add(this.label4);
            this.gboxPhControl.Controls.Add(this.gboxThreshold);
            this.gboxPhControl.Controls.Add(this.gboxAcidPump);
            this.gboxPhControl.Controls.Add(this.gboxBasePump);
            this.gboxPhControl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPhControl.Location = new System.Drawing.Point(221, 123);
            this.gboxPhControl.Name = "gboxPhControl";
            this.gboxPhControl.Size = new System.Drawing.Size(217, 457);
            this.gboxPhControl.TabIndex = 7;
            this.gboxPhControl.TabStop = false;
            this.gboxPhControl.Text = "pH Control";
            // 
            // cboxMode
            // 
            this.cboxMode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMode.FormattingEnabled = true;
            this.cboxMode.Items.AddRange(new object[] {
            "AUTO",
            "MANUAL"});
            this.cboxMode.Location = new System.Drawing.Point(76, 23);
            this.cboxMode.Name = "cboxMode";
            this.cboxMode.Size = new System.Drawing.Size(126, 21);
            this.cboxMode.TabIndex = 8;
            this.cboxMode.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "MODE :";
            // 
            // gboxThreshold
            // 
            this.gboxThreshold.Controls.Add(this.label15);
            this.gboxThreshold.Controls.Add(this.btnThresholdStop);
            this.gboxThreshold.Controls.Add(this.label16);
            this.gboxThreshold.Controls.Add(this.tboxLowerLimit);
            this.gboxThreshold.Controls.Add(this.tboxUperLimit);
            this.gboxThreshold.Controls.Add(this.label18);
            this.gboxThreshold.Controls.Add(this.btnThresholdStart);
            this.gboxThreshold.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxThreshold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gboxThreshold.Location = new System.Drawing.Point(15, 54);
            this.gboxThreshold.Name = "gboxThreshold";
            this.gboxThreshold.Size = new System.Drawing.Size(187, 122);
            this.gboxThreshold.TabIndex = 14;
            this.gboxThreshold.TabStop = false;
            this.gboxThreshold.Text = "Threshold Setting";
            this.gboxThreshold.Enter += new System.EventHandler(this.gboxThreshold_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(7, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Lower Limit";
            // 
            // btnThresholdStop
            // 
            this.btnThresholdStop.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThresholdStop.ForeColor = System.Drawing.Color.Black;
            this.btnThresholdStop.Location = new System.Drawing.Point(99, 78);
            this.btnThresholdStop.Name = "btnThresholdStop";
            this.btnThresholdStop.Size = new System.Drawing.Size(83, 26);
            this.btnThresholdStop.TabIndex = 9;
            this.btnThresholdStop.Text = "STOP";
            this.btnThresholdStop.UseVisualStyleBackColor = true;
            this.btnThresholdStop.Click += new System.EventHandler(this.btnThresholdStop_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(7, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Upper Limit";
            // 
            // tboxLowerLimit
            // 
            this.tboxLowerLimit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxLowerLimit.ForeColor = System.Drawing.Color.Black;
            this.tboxLowerLimit.Location = new System.Drawing.Point(115, 45);
            this.tboxLowerLimit.Name = "tboxLowerLimit";
            this.tboxLowerLimit.Size = new System.Drawing.Size(66, 21);
            this.tboxLowerLimit.TabIndex = 6;
            this.tboxLowerLimit.TextChanged += new System.EventHandler(this.tboxLowerLimit_TextChanged);
            this.tboxLowerLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxLowerLimit_KeyPress);
            // 
            // tboxUperLimit
            // 
            this.tboxUperLimit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUperLimit.ForeColor = System.Drawing.Color.Black;
            this.tboxUperLimit.Location = new System.Drawing.Point(115, 19);
            this.tboxUperLimit.Name = "tboxUperLimit";
            this.tboxUperLimit.Size = new System.Drawing.Size(66, 21);
            this.tboxUperLimit.TabIndex = 4;
            this.tboxUperLimit.TextChanged += new System.EventHandler(this.tboxUperLimit_TextChanged);
            this.tboxUperLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxUperLimit_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 14);
            this.label18.TabIndex = 1;
            // 
            // btnThresholdStart
            // 
            this.btnThresholdStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThresholdStart.ForeColor = System.Drawing.Color.Black;
            this.btnThresholdStart.Location = new System.Drawing.Point(11, 78);
            this.btnThresholdStart.Name = "btnThresholdStart";
            this.btnThresholdStart.Size = new System.Drawing.Size(75, 26);
            this.btnThresholdStart.TabIndex = 2;
            this.btnThresholdStart.Text = "START";
            this.btnThresholdStart.UseVisualStyleBackColor = true;
            this.btnThresholdStart.Click += new System.EventHandler(this.btnThresholdStart_Click);
            // 
            // gboxAcidPump
            // 
            this.gboxAcidPump.Controls.Add(this.label13);
            this.gboxAcidPump.Controls.Add(this.labeltimerAcidPump);
            this.gboxAcidPump.Controls.Add(this.label11);
            this.gboxAcidPump.Controls.Add(this.label12);
            this.gboxAcidPump.Controls.Add(this.tboxAcidTimer);
            this.gboxAcidPump.Controls.Add(this.btnAcidOff);
            this.gboxAcidPump.Controls.Add(this.tboxAcidFLow);
            this.gboxAcidPump.Controls.Add(this.btnAcidOn);
            this.gboxAcidPump.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxAcidPump.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gboxAcidPump.Location = new System.Drawing.Point(15, 322);
            this.gboxAcidPump.Name = "gboxAcidPump";
            this.gboxAcidPump.Size = new System.Drawing.Size(187, 122);
            this.gboxAcidPump.TabIndex = 13;
            this.gboxAcidPump.TabStop = false;
            this.gboxAcidPump.Text = "Acid Pump Control";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(17, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Stop";
            // 
            // labeltimerAcidPump
            // 
            this.labeltimerAcidPump.AutoSize = true;
            this.labeltimerAcidPump.ForeColor = System.Drawing.Color.Black;
            this.labeltimerAcidPump.Location = new System.Drawing.Point(132, 101);
            this.labeltimerAcidPump.Name = "labeltimerAcidPump";
            this.labeltimerAcidPump.Size = new System.Drawing.Size(15, 14);
            this.labeltimerAcidPump.TabIndex = 14;
            this.labeltimerAcidPump.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Timer (s) :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(7, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Flow Rate (ml/min) :";
            // 
            // tboxAcidTimer
            // 
            this.tboxAcidTimer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAcidTimer.ForeColor = System.Drawing.Color.Black;
            this.tboxAcidTimer.Location = new System.Drawing.Point(115, 45);
            this.tboxAcidTimer.Name = "tboxAcidTimer";
            this.tboxAcidTimer.Size = new System.Drawing.Size(66, 21);
            this.tboxAcidTimer.TabIndex = 6;
            this.tboxAcidTimer.TextChanged += new System.EventHandler(this.tboxAcidTimer_TextChanged);
            this.tboxAcidTimer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxAcidTimer_KeyPress);
            // 
            // btnAcidOff
            // 
            this.btnAcidOff.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcidOff.ForeColor = System.Drawing.Color.Black;
            this.btnAcidOff.Location = new System.Drawing.Point(99, 72);
            this.btnAcidOff.Name = "btnAcidOff";
            this.btnAcidOff.Size = new System.Drawing.Size(83, 26);
            this.btnAcidOff.TabIndex = 3;
            this.btnAcidOff.Text = "OFF";
            this.btnAcidOff.UseVisualStyleBackColor = true;
            this.btnAcidOff.Click += new System.EventHandler(this.btnAcidOff_Click);
            // 
            // tboxAcidFLow
            // 
            this.tboxAcidFLow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAcidFLow.ForeColor = System.Drawing.Color.Black;
            this.tboxAcidFLow.Location = new System.Drawing.Point(115, 17);
            this.tboxAcidFLow.Name = "tboxAcidFLow";
            this.tboxAcidFLow.Size = new System.Drawing.Size(66, 21);
            this.tboxAcidFLow.TabIndex = 4;
            this.tboxAcidFLow.TextChanged += new System.EventHandler(this.tboxAcidFLow_TextChanged);
            this.tboxAcidFLow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxAcidFLow_KeyPress);
            // 
            // btnAcidOn
            // 
            this.btnAcidOn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcidOn.ForeColor = System.Drawing.Color.Black;
            this.btnAcidOn.Location = new System.Drawing.Point(12, 72);
            this.btnAcidOn.Name = "btnAcidOn";
            this.btnAcidOn.Size = new System.Drawing.Size(75, 26);
            this.btnAcidOn.TabIndex = 2;
            this.btnAcidOn.Text = "ON";
            this.btnAcidOn.UseVisualStyleBackColor = true;
            this.btnAcidOn.Click += new System.EventHandler(this.btnAcidOn_Click);
            // 
            // gboxBasePump
            // 
            this.gboxBasePump.Controls.Add(this.label23);
            this.gboxBasePump.Controls.Add(this.labeltimerBasePump);
            this.gboxBasePump.Controls.Add(this.btnBaseOff);
            this.gboxBasePump.Controls.Add(this.btnBaseOn);
            this.gboxBasePump.Controls.Add(this.tboxBaseTimer);
            this.gboxBasePump.Controls.Add(this.label9);
            this.gboxBasePump.Controls.Add(this.tboxBaseFlow);
            this.gboxBasePump.Controls.Add(this.label10);
            this.gboxBasePump.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxBasePump.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gboxBasePump.Location = new System.Drawing.Point(15, 184);
            this.gboxBasePump.Name = "gboxBasePump";
            this.gboxBasePump.Size = new System.Drawing.Size(187, 131);
            this.gboxBasePump.TabIndex = 13;
            this.gboxBasePump.TabStop = false;
            this.gboxBasePump.Text = "Base Pump Control";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(17, 101);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 16);
            this.label23.TabIndex = 14;
            this.label23.Text = "Stop";
            // 
            // labeltimerBasePump
            // 
            this.labeltimerBasePump.AutoSize = true;
            this.labeltimerBasePump.ForeColor = System.Drawing.Color.Black;
            this.labeltimerBasePump.Location = new System.Drawing.Point(133, 101);
            this.labeltimerBasePump.Name = "labeltimerBasePump";
            this.labeltimerBasePump.Size = new System.Drawing.Size(15, 14);
            this.labeltimerBasePump.TabIndex = 13;
            this.labeltimerBasePump.Text = "0";
            // 
            // btnBaseOff
            // 
            this.btnBaseOff.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseOff.ForeColor = System.Drawing.Color.Black;
            this.btnBaseOff.Location = new System.Drawing.Point(99, 72);
            this.btnBaseOff.Name = "btnBaseOff";
            this.btnBaseOff.Size = new System.Drawing.Size(83, 26);
            this.btnBaseOff.TabIndex = 9;
            this.btnBaseOff.Text = "OFF";
            this.btnBaseOff.UseVisualStyleBackColor = true;
            this.btnBaseOff.Click += new System.EventHandler(this.btnBaseOff_Click);
            // 
            // btnBaseOn
            // 
            this.btnBaseOn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseOn.ForeColor = System.Drawing.Color.Black;
            this.btnBaseOn.Location = new System.Drawing.Point(12, 72);
            this.btnBaseOn.Name = "btnBaseOn";
            this.btnBaseOn.Size = new System.Drawing.Size(75, 26);
            this.btnBaseOn.TabIndex = 8;
            this.btnBaseOn.Text = "ON";
            this.btnBaseOn.UseVisualStyleBackColor = true;
            this.btnBaseOn.Click += new System.EventHandler(this.btnBaseOn_Click);
            // 
            // tboxBaseTimer
            // 
            this.tboxBaseTimer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxBaseTimer.ForeColor = System.Drawing.Color.Black;
            this.tboxBaseTimer.Location = new System.Drawing.Point(115, 45);
            this.tboxBaseTimer.Name = "tboxBaseTimer";
            this.tboxBaseTimer.Size = new System.Drawing.Size(66, 21);
            this.tboxBaseTimer.TabIndex = 6;
            this.tboxBaseTimer.TextChanged += new System.EventHandler(this.tboxBaseTimer_TextChanged);
            this.tboxBaseTimer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxBaseTimer_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Timer (s) :";
            // 
            // tboxBaseFlow
            // 
            this.tboxBaseFlow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxBaseFlow.ForeColor = System.Drawing.Color.Black;
            this.tboxBaseFlow.Location = new System.Drawing.Point(115, 19);
            this.tboxBaseFlow.Name = "tboxBaseFlow";
            this.tboxBaseFlow.Size = new System.Drawing.Size(66, 21);
            this.tboxBaseFlow.TabIndex = 4;
            this.tboxBaseFlow.TextChanged += new System.EventHandler(this.tboxBaseFlow_TextChanged);
            this.tboxBaseFlow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxBaseFlow_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Flow Rate (ml/min) :";
            // 
            // gboxMetalSol
            // 
            this.gboxMetalSol.Controls.Add(this.label21);
            this.gboxMetalSol.Controls.Add(this.labeltimerMetalSol);
            this.gboxMetalSol.Controls.Add(this.label17);
            this.gboxMetalSol.Controls.Add(this.label19);
            this.gboxMetalSol.Controls.Add(this.label20);
            this.gboxMetalSol.Controls.Add(this.tboxMetalTimer);
            this.gboxMetalSol.Controls.Add(this.tboxMetakFlow);
            this.gboxMetalSol.Controls.Add(this.btnMetalSolOff);
            this.gboxMetalSol.Controls.Add(this.btnMetalSolOn);
            this.gboxMetalSol.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxMetalSol.Location = new System.Drawing.Point(12, 413);
            this.gboxMetalSol.Name = "gboxMetalSol";
            this.gboxMetalSol.Size = new System.Drawing.Size(187, 167);
            this.gboxMetalSol.TabIndex = 13;
            this.gboxMetalSol.TabStop = false;
            this.gboxMetalSol.Text = "Metal Solution Pump Control";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(13, 145);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 16);
            this.label21.TabIndex = 13;
            this.label21.Text = "Stop";
            // 
            // labeltimerMetalSol
            // 
            this.labeltimerMetalSol.AutoSize = true;
            this.labeltimerMetalSol.Location = new System.Drawing.Point(131, 145);
            this.labeltimerMetalSol.Name = "labeltimerMetalSol";
            this.labeltimerMetalSol.Size = new System.Drawing.Size(16, 16);
            this.labeltimerMetalSol.TabIndex = 12;
            this.labeltimerMetalSol.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Timer (s) :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Flow Rate (ml/min) :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 16);
            this.label20.TabIndex = 7;
            // 
            // tboxMetalTimer
            // 
            this.tboxMetalTimer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxMetalTimer.Location = new System.Drawing.Point(115, 79);
            this.tboxMetalTimer.Name = "tboxMetalTimer";
            this.tboxMetalTimer.Size = new System.Drawing.Size(66, 21);
            this.tboxMetalTimer.TabIndex = 6;
            this.tboxMetalTimer.TextChanged += new System.EventHandler(this.tboxMetalTimer_TextChanged);
            this.tboxMetalTimer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxMetalTimer_KeyPress);
            // 
            // tboxMetakFlow
            // 
            this.tboxMetakFlow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxMetakFlow.Location = new System.Drawing.Point(115, 47);
            this.tboxMetakFlow.Name = "tboxMetakFlow";
            this.tboxMetakFlow.Size = new System.Drawing.Size(66, 21);
            this.tboxMetakFlow.TabIndex = 4;
            this.tboxMetakFlow.TextChanged += new System.EventHandler(this.tboxMetakFlow_TextChanged);
            this.tboxMetakFlow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxMetakFlow_KeyPress);
            // 
            // btnMetalSolOff
            // 
            this.btnMetalSolOff.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetalSolOff.Location = new System.Drawing.Point(98, 116);
            this.btnMetalSolOff.Name = "btnMetalSolOff";
            this.btnMetalSolOff.Size = new System.Drawing.Size(83, 26);
            this.btnMetalSolOff.TabIndex = 3;
            this.btnMetalSolOff.Text = "OFF";
            this.btnMetalSolOff.UseVisualStyleBackColor = true;
            this.btnMetalSolOff.Click += new System.EventHandler(this.btnMetalSolOff_Click);
            // 
            // btnMetalSolOn
            // 
            this.btnMetalSolOn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetalSolOn.Location = new System.Drawing.Point(11, 116);
            this.btnMetalSolOn.Name = "btnMetalSolOn";
            this.btnMetalSolOn.Size = new System.Drawing.Size(75, 26);
            this.btnMetalSolOn.TabIndex = 2;
            this.btnMetalSolOn.Text = "ON";
            this.btnMetalSolOn.UseVisualStyleBackColor = true;
            this.btnMetalSolOn.Click += new System.EventHandler(this.btnMetalSolOn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timMetalSol
            // 
            this.timMetalSol.Interval = 1;
            this.timMetalSol.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timBasePump
            // 
            this.timBasePump.Interval = 1;
            this.timBasePump.Tick += new System.EventHandler(this.timBasePump_Tick);
            // 
            // timAcidPump
            // 
            this.timAcidPump.Interval = 1;
            this.timAcidPump.Tick += new System.EventHandler(this.timAcidPump_Tick);
            // 
            // gboxPumpStatus
            // 
            this.gboxPumpStatus.Controls.Add(this.label28);
            this.gboxPumpStatus.Controls.Add(this.label27);
            this.gboxPumpStatus.Controls.Add(this.label26);
            this.gboxPumpStatus.Controls.Add(this.labelTotalAcid);
            this.gboxPumpStatus.Controls.Add(this.labelTotalBase);
            this.gboxPumpStatus.Controls.Add(this.labelTotalMetal);
            this.gboxPumpStatus.Controls.Add(this.label7);
            this.gboxPumpStatus.Controls.Add(this.label8);
            this.gboxPumpStatus.Controls.Add(this.label22);
            this.gboxPumpStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPumpStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gboxPumpStatus.Location = new System.Drawing.Point(17, 384);
            this.gboxPumpStatus.Name = "gboxPumpStatus";
            this.gboxPumpStatus.Size = new System.Drawing.Size(237, 82);
            this.gboxPumpStatus.TabIndex = 14;
            this.gboxPumpStatus.TabStop = false;
            this.gboxPumpStatus.Text = "Liquid Total";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(210, 58);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 18);
            this.label28.TabIndex = 21;
            this.label28.Text = "ml";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(210, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(26, 18);
            this.label27.TabIndex = 20;
            this.label27.Text = "ml";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(210, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(26, 18);
            this.label26.TabIndex = 19;
            this.label26.Text = "ml";
            // 
            // labelTotalAcid
            // 
            this.labelTotalAcid.AutoSize = true;
            this.labelTotalAcid.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAcid.ForeColor = System.Drawing.Color.Black;
            this.labelTotalAcid.Location = new System.Drawing.Point(127, 59);
            this.labelTotalAcid.Name = "labelTotalAcid";
            this.labelTotalAcid.Size = new System.Drawing.Size(18, 18);
            this.labelTotalAcid.TabIndex = 18;
            this.labelTotalAcid.Text = "0";
            // 
            // labelTotalBase
            // 
            this.labelTotalBase.AutoSize = true;
            this.labelTotalBase.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBase.ForeColor = System.Drawing.Color.Black;
            this.labelTotalBase.Location = new System.Drawing.Point(127, 41);
            this.labelTotalBase.Name = "labelTotalBase";
            this.labelTotalBase.Size = new System.Drawing.Size(18, 18);
            this.labelTotalBase.TabIndex = 17;
            this.labelTotalBase.Text = "0";
            // 
            // labelTotalMetal
            // 
            this.labelTotalMetal.AutoSize = true;
            this.labelTotalMetal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMetal.ForeColor = System.Drawing.Color.Black;
            this.labelTotalMetal.Location = new System.Drawing.Point(127, 23);
            this.labelTotalMetal.Name = "labelTotalMetal";
            this.labelTotalMetal.Size = new System.Drawing.Size(18, 18);
            this.labelTotalMetal.TabIndex = 16;
            this.labelTotalMetal.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Acid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(15, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Base";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(14, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "Metal Solution";
            // 
            // timAuto
            // 
            this.timAuto.Interval = 1000;
            this.timAuto.Tick += new System.EventHandler(this.timAuto_Tick);
            // 
            // zg1
            // 
            this.zg1.BackColor = System.Drawing.Color.White;
            this.zg1.Location = new System.Drawing.Point(16, 22);
            this.zg1.Margin = new System.Windows.Forms.Padding(2);
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.Size = new System.Drawing.Size(520, 355);
            this.zg1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-17, -7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1150, 124);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.zg1);
            this.groupBox1.Controls.Add(this.gboxPumpStatus);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(444, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 480);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Monitoring";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(348, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 84);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "pH";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(19, 12);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(155, 68);
            this.label29.TabIndex = 18;
            this.label29.Text = "0.00";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(-4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1018, 117);
            this.label14.TabIndex = 18;
            this.label14.Text = "pH Control and Monitoring System";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox2.Image = global::WindowsFormsApp7.Properties.Resources.Lambang_ITS;
            this.pictureBox2.Location = new System.Drawing.Point(166, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox1.Image = global::WindowsFormsApp7.Properties.Resources.MESIN;
            this.pictureBox1.Location = new System.Drawing.Point(781, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 611);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gboxMetalSol);
            this.Controls.Add(this.gboxPhControl);
            this.Controls.Add(this.gboxInitPump);
            this.Controls.Add(this.gboxDeviceSetup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pH Control and Monitoring System ver. 1.0 - 28/11/2020";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxDeviceSetup.ResumeLayout(false);
            this.gboxDeviceSetup.PerformLayout();
            this.gboxInitPump.ResumeLayout(false);
            this.gboxInitPump.PerformLayout();
            this.gboxPhControl.ResumeLayout(false);
            this.gboxPhControl.PerformLayout();
            this.gboxThreshold.ResumeLayout(false);
            this.gboxThreshold.PerformLayout();
            this.gboxAcidPump.ResumeLayout(false);
            this.gboxAcidPump.PerformLayout();
            this.gboxBasePump.ResumeLayout(false);
            this.gboxBasePump.PerformLayout();
            this.gboxMetalSol.ResumeLayout(false);
            this.gboxMetalSol.PerformLayout();
            this.gboxPumpStatus.ResumeLayout(false);
            this.gboxPumpStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDeviceSetup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.GroupBox gboxInitPump;
        private System.Windows.Forms.Button btnMetalFeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gboxPhControl;
        private System.Windows.Forms.GroupBox gboxAcidPump;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tboxAcidTimer;
        private System.Windows.Forms.TextBox tboxAcidFLow;
        private System.Windows.Forms.Button btnAcidOff;
        private System.Windows.Forms.Button btnAcidOn;
        private System.Windows.Forms.GroupBox gboxBasePump;
        private System.Windows.Forms.Button btnBaseOff;
        private System.Windows.Forms.Button btnBaseOn;
        private System.Windows.Forms.TextBox tboxBaseTimer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxBaseFlow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gboxThreshold;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnThresholdStop;
        private System.Windows.Forms.TextBox tboxLowerLimit;
        private System.Windows.Forms.TextBox tboxUperLimit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnThresholdStart;
        private System.Windows.Forms.ComboBox cboxMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAcidFeed;
        private System.Windows.Forms.Button btnBaseFeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gboxMetalSol;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tboxMetalTimer;
        private System.Windows.Forms.TextBox tboxMetakFlow;
        private System.Windows.Forms.Button btnMetalSolOff;
        private System.Windows.Forms.Button btnMetalSolOn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labeltimerMetalSol;
        private System.Windows.Forms.Timer timMetalSol;
        private System.Windows.Forms.Timer timBasePump;
        private System.Windows.Forms.Timer timAcidPump;
        private System.Windows.Forms.Label labeltimerAcidPump;
        private System.Windows.Forms.Label labeltimerBasePump;
        private System.Windows.Forms.GroupBox gboxPumpStatus;
        private System.Windows.Forms.Label labelTotalAcid;
        private System.Windows.Forms.Label labelTotalBase;
        private System.Windows.Forms.Label labelTotalMetal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Timer timAuto;
        private ZedGraph.ZedGraphControl zg1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

