using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ZedGraph;
using System.IO.Ports;
using System.Reflection;
using System.Text.RegularExpressions;

using System.Drawing.Drawing2D;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {

        
        SerialPort port = new SerialPort();
        string comPort, RxString;
        string[] ports = SerialPort.GetPortNames();
        string str;

        #region variabel_grafik
        double tickstart;
        PointPairList list;
        RollingPointPairList list1;
        RollingPointPairList list2;
        RollingPointPairList list3;
        Scale xScale1, yScale1;
        double x;
        GraphPane myPane;
        
        #endregion variabel_grafik


        #region variabel_thread
        delegate void invok(String m);
            invok invoker;
        #endregion variabel_thread

      

        public Form1()
        {

            #region init_grafik
            InitializeComponent();


            zg1.GraphPane.CurveList.Clear();
           zg1.GraphPane.GraphObjList.Clear();

            myPane = zg1.GraphPane;
            myPane.Title.Text = " ";
            myPane.XAxis.Title.Text = "Time (s)";
            myPane.YAxis.Title.Text = "pH";
            myPane.YAxis.MajorGrid.Color = Color.DimGray;
            myPane.YAxis.MajorTic.Color = Color.White;
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 50;
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 15;

            list1 = new RollingPointPairList(1000); // Grafik geser dengan 1000 maksimal data history
            list2 = new RollingPointPairList(1000);
            list3 = new RollingPointPairList(1000);
            list = new PointPairList(); // Grafik Fix tanpa geser 
            LineItem myCurve = myPane.AddCurve("pH", list1, Color.Black, SymbolType.None);
            LineItem myCurve2 = myPane.AddCurve("Upper Limit", list2, Color.Blue, SymbolType.None);
            LineItem myCurve3 = myPane.AddCurve("Lower Limit", list3, Color.Red, SymbolType.None);
            myPane.Fill = new Fill(Color.FromArgb(255,255,255), Color.FromArgb(255, 255, 255));     //warna  

            myCurve.Line.Width = 2;
            myCurve2.Line.Width = 1;
            myCurve3.Line.Width = 1;
            myPane.Title.FontSpec.FontColor = Color.Black;
            zg1.GraphPane.Fill.Color = SystemColors.ControlText;
            //zg1.GraphPane.Chart.Fill = new Fill(Color.FromArgb(0, 0, 0));

            myPane.Chart.Fill = new Fill(Color.White,Color.FromArgb(240, 240, 255), -90F);

            zg1.GraphPane.Chart.Border.Color = Color.Black;
            zg1.GraphPane.XAxis.Color = Color.Black;
            zg1.GraphPane.Border.Color = Color.Black;

            myPane.YAxis.Scale.FontSpec.FontColor = Color.Black;
            myPane.YAxis.Title.FontSpec.FontColor = Color.Black;
            myPane.XAxis.Scale.FontSpec.FontColor = Color.Black;
            myPane.XAxis.Title.FontSpec.FontColor = Color.Black;

            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.DashOn = 1;
            myPane.YAxis.MajorGrid.DashOff = 2;

            myPane.XAxis.MajorGrid.DashOn = 1;
            myPane.XAxis.MajorGrid.DashOff = 2;

            myPane.YAxis.MajorGrid.Color = Color.Black;
            myPane.YAxis.MajorTic.Color = Color.Black;

            myPane.XAxis.MajorGrid.Color = Color.DimGray;
            myPane.XAxis.MajorTic.Color = Color.Black;

            zg1.AxisChange();
            zg1.Refresh();
            #endregion init_grafik



            invoker = new invok(dataku);
            
            foreach (string s in ports) portNameComboBox.Items.Add(s);
            port.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            btnStart.Enabled = false;
            //btnStop.Enabled = false;
            gboxBasePump.Enabled = false;
            gboxAcidPump.Enabled = false;
            gboxThreshold.Enabled = false;
            gboxInitPump.Enabled = false;
            gboxMetalSol.Enabled = false;
            gboxPhControl.Enabled = false;
            btnMetalSolOn.Enabled = false;
            btnMetalSolOff.Enabled = false;
            btnThresholdStart.Enabled = false;
            btnThresholdStop.Enabled = false;
            btnBaseOn.Enabled = false;
            btnBaseOff.Enabled = false;
            btnAcidOn.Enabled = false;
            btnAcidOff.Enabled = false;
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboxMode.SelectedItem == "AUTO")
            {

                gboxBasePump.Enabled = false;
                gboxAcidPump.Enabled = false;
                gboxThreshold.Enabled = true;
            }
            else {
                gboxThreshold.Enabled = false;
                gboxBasePump.Enabled = true;
                gboxAcidPump.Enabled = true;
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {

            //pictureBox1.Enabled = true;
            try { port.Write("runmetalsol&"); }
            catch { }
   
            //port.Write("!");
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            try { port.Write("stop&"); }
            catch { }
            
            //port.Write("!");
            //pictureBox1.Enabled = false;

        }

       

       

        private void portNameComboBox_Click(object sender, EventArgs e)
        {
            try
            {
                portNameComboBox.DataSource = null;
                portNameComboBox.Items.Clear();

            }
            catch { }
            ports = SerialPort.GetPortNames();
            foreach (string s in ports) portNameComboBox.Items.Add(s);
        }



        int penampil = 0;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
        
            if (port.IsOpen == true) {

                try
                {
                    
                    this.BeginInvoke(invoker, port.ReadLine());
                }
                catch
                {

                }
            }


        }

        private void portNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            //btnStop.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }


        void panggil(object a, object b, object c, object d, EventArgs e) {

            Button bt1 = a as Button;
            Button bt2 = b as Button;
            TextBox tb1 = c as TextBox;
            TextBox tb2 = d as TextBox;
            

            if (tb1.Text != "" && tb1.TextLength > -1 &&  tb2.Text != "" && tb2.TextLength > -1)
            {
                bt2.Enabled = false;
                bt1.Enabled = true;
            }
            else
            {
                bt2.Enabled = false;
                bt1.Enabled = false;
            }

        }

        void disable_feed(object a, object b, object c, object d, object gb, EventArgs e)
        {

            Button bt1 = a as Button;
            Button bt2 = b as Button;
            TextBox tb1 = c as TextBox;
            TextBox tb2 = d as TextBox;
            GroupBox gb1 = gb as GroupBox;

            if (bt1.Enabled == true)
            {
                bt1.Enabled = false;
                bt2.Enabled = true;                
                gb1.Enabled = false;                           
                tb1.Enabled = false;
                tb2.Enabled = false;
            }

            else {
                bt1.Enabled = true;
                bt2.Enabled = false;
                if (btnMetalSolOff.Enabled == false && btnThresholdStop.Enabled == false && btnAcidOff.Enabled == false && btnBaseOff.Enabled == false) {
                    gb1.Enabled = true;
                }

                if (btnMetalSolOff.Enabled == false) {
                    try { port.Write("a@"); } catch { }
                    
                }

                if (btnAcidOff.Enabled == false)
                {
                    try { port.Write("b@"); } catch { }
                    
                }

                if (btnBaseOff.Enabled == false)
                {
                    try { port.Write("c@"); } catch { }
                    
                }


                tb1.Enabled = true;
                tb2.Enabled = true;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            comPort = Convert.ToString(portNameComboBox.SelectedItem);
            try
            {
                port.PortName = comPort;
                port.BaudRate = 115200;
                port.Open();
                tickstart = Environment.TickCount;
                MessageBox.Show("Connected!");
                btnStart.Enabled = false;
                //btnStop.Enabled = true;
                gboxInitPump.Enabled = true;
                gboxMetalSol.Enabled = true;
                gboxPhControl.Enabled = true;
                


            }
            catch
            {

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

           

            try {

                btnMetalSolOff_Click(sender, e);
                btnBaseOff_Click(sender, e);
                btnAcidOff_Click(sender, e);
                btnThresholdStop_Click(sender, e);

                metalVol = 0;
                baseVol = 0;
                acidVol = 0;
                labelTotalMetal.Text = metalVol.ToString();
                labelTotalBase.Text = baseVol.ToString();
                labelTotalAcid.Text = acidVol.ToString();
                port.Close();
                btnStart.Enabled = true;
                //btnStop.Enabled = false;
                MessageBox.Show("Disconnect");
                gboxInitPump.Enabled = false;
                gboxMetalSol.Enabled = false;
                gboxPhControl.Enabled = false;
                
            } catch {
            
            }

        }

        private void gboxThreshold_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnMetalSolOn_Click(object sender, EventArgs e)
        {
            try
            {
               if (Convert.ToInt32(tboxMetakFlow.Text) > 20)
                {
                    tboxMetakFlow.Text = "20";
                }
            }
            catch
            {
                MessageBox.Show("Wrong Parameter!");
            }

            tes = Environment.TickCount;
            disable_feed(btnMetalSolOn, btnMetalSolOff, tboxMetakFlow, tboxMetalTimer, gboxInitPump, e);
            timMetalSol.Enabled = true;
            label21.Text = "Running...";
            label21.ForeColor = Color.Green;
            if (Convert.ToInt32(tboxMetakFlow.Text) < 30)
            {
               
            }
            else {
                try { port.Write("meta" + tboxMetakFlow.Text + "@"); } catch { }
            }
            timerMetalSol = 0;
            labeltimerMetalSol.Text = "0";
            
        }

        private void btnMetalSolOff_Click(object sender, EventArgs e)
        {
            disable_feed(btnMetalSolOn, btnMetalSolOff, tboxMetakFlow, tboxMetalTimer, gboxInitPump, e);

            label21.Text = "Stop";
            label21.ForeColor = Color.Red;
            timMetalSol.Enabled = false;
        }

        private void tboxMetakFlow_TextChanged(object sender, EventArgs e)
        {
            panggil(btnMetalSolOn, btnMetalSolOff, tboxMetakFlow, tboxMetalTimer,e);         
        }

        private void tboxMetalTimer_TextChanged(object sender, EventArgs e)
        {
            panggil(btnMetalSolOn, btnMetalSolOff, tboxMetakFlow, tboxMetalTimer, e);
            try
            {
                 if (Convert.ToInt32(tboxMetakFlow.Text) > 20)
                {
                    tboxMetakFlow.Text = "20";
                }
            }
            catch {
                MessageBox.Show("Wrong Parameter!");
            }

           
        }

        private void tboxUperLimit_TextChanged(object sender, EventArgs e)
        {
            panggil(btnThresholdStart, btnThresholdStop, tboxUperLimit, tboxLowerLimit, e);
        }

        private void tboxLowerLimit_TextChanged(object sender, EventArgs e)
        {
            panggil(btnThresholdStart, btnThresholdStop, tboxUperLimit, tboxLowerLimit, e);
        }

        private void btnThresholdStart_Click(object sender, EventArgs e)
        {


            //if ((tboxUperLimit.Text.IndexOf('0') == 0) || ((tboxUperLimit.Text.IndexOf('1') == 0) && (tboxUperLimit.Text.IndexOf('.') == 1)) || (tboxUperLimit.Text.IndexOf('.') == 0))
            //{
                //tboxUperLimit.Text = "";
            //    MessageBox.Show("The value must be greater than 2.00");
            //    return;
            //}

            //if ((tboxLowerLimit.Text.IndexOf('0') == 0) || ((tboxLowerLimit.Text.IndexOf('1') == 0) && (tboxLowerLimit.Text.IndexOf('.') == 1)) || (tboxLowerLimit.Text.IndexOf('.') == 0))
            //{
            //    //tboxLowerLimit.Text = "";
            //    MessageBox.Show("The value must be greater than 2.00");
            //    return;
            //}





            if (Convert.ToDouble(tboxUperLimit.Text) < Convert.ToDouble(tboxLowerLimit.Text)) {
                MessageBox.Show("Uper Limit must be greater than Lower Limit");
                return;
            }
            if (Convert.ToDouble(tboxUperLimit.Text) > 12.00 || Convert.ToDouble(tboxLowerLimit.Text) > 12.00)
            {
                MessageBox.Show("The value must be lower than 12.00");
                tboxUperLimit.Text = "";
                tboxLowerLimit.Text = "";
                return;
            }

                if (Convert.ToDouble(tboxUperLimit.Text) < 2.00 || Convert.ToDouble(tboxLowerLimit.Text) < 2.00)
                {
                    MessageBox.Show("The value must be greater than 2.00");
                    tboxUperLimit.Text = "";
                    tboxLowerLimit.Text = "";
                    return;
                }

                if (tboxUperLimit.TextLength == 1) {
                
                tboxUperLimit.Text = tboxUperLimit.Text + ".00";
            }

            if (tboxUperLimit.TextLength == 2 && tboxUperLimit.Text.IndexOf('.') == -1)
            {
                
                tboxUperLimit.Text = tboxUperLimit.Text + ".00";
            }



            if (tboxLowerLimit.TextLength == 1)
            {
                
                tboxLowerLimit.Text = tboxLowerLimit.Text + ".00";
            }

            if (tboxLowerLimit.TextLength == 2 && tboxLowerLimit.Text.IndexOf('.') == -1)
            {
               
                tboxLowerLimit.Text = tboxLowerLimit.Text + ".00";
            }


            if (tboxLowerLimit.TextLength == 2 && tboxLowerLimit.Text.IndexOf('.') == 1)
            {
                
                tboxLowerLimit.Text = tboxLowerLimit.Text + "00";
            }

            if (tboxLowerLimit.TextLength == 3 && tboxLowerLimit.Text.IndexOf('.') == 2)
            {
               
                tboxLowerLimit.Text = tboxLowerLimit.Text + "00";
            }



            if (tboxUperLimit.TextLength == 2 && tboxUperLimit.Text.IndexOf('.') == 1)
            {
                
                tboxUperLimit.Text = tboxUperLimit.Text + "00";
            }

            if (tboxUperLimit.TextLength == 3 && tboxUperLimit.Text.IndexOf('.') == 2)
            {
               
                tboxUperLimit.Text = tboxUperLimit.Text + "00";
            }




            if (tboxLowerLimit.TextLength == 4 && tboxLowerLimit.Text.IndexOf('.') == 2)
            {

                tboxLowerLimit.Text = tboxLowerLimit.Text + "0";
            }

            if (tboxLowerLimit.TextLength == 3 && tboxLowerLimit.Text.IndexOf('.') == 1)
            {

                tboxLowerLimit.Text = tboxLowerLimit.Text + "0";
            }


            if (tboxUperLimit.TextLength == 4 && tboxUperLimit.Text.IndexOf('.') == 2)
            {

                tboxUperLimit.Text = tboxUperLimit.Text + "0";
            }

            if (tboxUperLimit.TextLength == 3 && tboxUperLimit.Text.IndexOf('.') == 1)
            {

                tboxUperLimit.Text = tboxUperLimit.Text + "0";
            }





            if (tboxUperLimit.TextLength == 4 && tboxLowerLimit.TextLength == 4)
            {
                try { port.Write("0" + tboxUperLimit.Text + "0" + tboxLowerLimit.Text + "*"); } catch { }
                
            }

            if (tboxUperLimit.TextLength == 5 && tboxLowerLimit.TextLength == 5)
            {
                try { port.Write(tboxUperLimit.Text + tboxLowerLimit.Text + "*"); } catch { }
                
            }

            if (tboxUperLimit.TextLength == 5 && tboxLowerLimit.TextLength == 4)
            {
                try { port.Write(tboxUperLimit.Text + "0" + tboxLowerLimit.Text + "*"); } catch { }
                
                }

                if (tboxUperLimit.TextLength == 4 && tboxLowerLimit.TextLength == 5)
            {
                try { port.Write("0" + tboxUperLimit.Text + tboxLowerLimit.Text + "*"); } catch { }
               
            }


            disable_feed(btnThresholdStart,btnThresholdStop,tboxUperLimit,tboxLowerLimit,gboxInitPump,e);
            zg1.GraphPane.CurveList.Clear();
            zg1.GraphPane.GraphObjList.Clear();
            tickstart = Environment.TickCount;

            
            myPane = zg1.GraphPane;
            myPane.Title.Text = " ";
            myPane.XAxis.Title.Text = "Time (s)";
            myPane.YAxis.Title.Text = "pH";
            myPane.YAxis.MajorGrid.Color = Color.DimGray;
            myPane.YAxis.MajorTic.Color = Color.White;
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 50;
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 15;

            list1 = new RollingPointPairList(1000); // Grafik geser dengan 1000 maksimal data history
            list2 = new RollingPointPairList(1000);
            list3 = new RollingPointPairList(1000);
            list = new PointPairList(); // Grafik Fix tanpa geser 
            LineItem myCurve = myPane.AddCurve("pH", list1, Color.Black, SymbolType.None);
            LineItem myCurve2 = myPane.AddCurve("Upper Limit", list2, Color.Blue, SymbolType.None);
            LineItem myCurve3 = myPane.AddCurve("Lower Limit", list3, Color.Red, SymbolType.None);
            myPane.Fill = new Fill(Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255));     //warna  

            myCurve.Line.Width = 2;
            myCurve2.Line.Width = 1;
            myCurve3.Line.Width = 1;
            myPane.Title.FontSpec.FontColor = Color.Black;
            zg1.GraphPane.Fill.Color = SystemColors.ControlText;
            //zg1.GraphPane.Chart.Fill = new Fill(Color.FromArgb(0, 0, 0));

            myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(240, 240, 255), -90F);

            zg1.GraphPane.Chart.Border.Color = Color.Black;
            zg1.GraphPane.XAxis.Color = Color.Black;
            zg1.GraphPane.Border.Color = Color.Black;

            myPane.YAxis.Scale.FontSpec.FontColor = Color.Black;
            myPane.YAxis.Title.FontSpec.FontColor = Color.Black;
            myPane.XAxis.Scale.FontSpec.FontColor = Color.Black;
            myPane.XAxis.Title.FontSpec.FontColor = Color.Black;

            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.DashOn = 1;
            myPane.YAxis.MajorGrid.DashOff = 2;

            myPane.XAxis.MajorGrid.DashOn = 1;
            myPane.XAxis.MajorGrid.DashOff = 2;

            myPane.YAxis.MajorGrid.Color = Color.Black;
            myPane.YAxis.MajorTic.Color = Color.Black;

            myPane.XAxis.MajorGrid.Color = Color.DimGray;
            myPane.XAxis.MajorTic.Color = Color.Black;

            zg1.AxisChange();
            zg1.Refresh();
            timAuto.Enabled = true;
            cboxMode.Enabled = false;

            


        }

        private void btnThresholdStop_Click(object sender, EventArgs e)
        {
            disable_feed(btnThresholdStart, btnThresholdStop, tboxUperLimit, tboxLowerLimit, gboxInitPump, e);
            cboxMode.Enabled = true;
            try { port.Write("0*"); }
            catch { }
    
            timAuto.Enabled = false;
        }

        private void tboxBaseFlow_TextChanged(object sender, EventArgs e)
        {
            panggil(btnBaseOn, btnBaseOff, tboxBaseFlow, tboxBaseTimer, e);
        }

        private void tboxBaseTimer_TextChanged(object sender, EventArgs e)
        {
            panggil(btnBaseOn, btnBaseOff, tboxBaseFlow, tboxBaseTimer, e);
            try
            {
              
                if (Convert.ToInt32(tboxBaseFlow.Text) > 20)
                {
                    tboxBaseFlow.Text = "20";
                }
            }
            catch
            {
                MessageBox.Show("Wrong Parameter!");
            }
        }

        private void btnBaseOn_Click(object sender, EventArgs e)
        {

            try
            {
               if (Convert.ToInt32(tboxBaseFlow.Text) > 20)
                {
                    tboxBaseFlow.Text = "20";
                }
            }
            catch
            {
                MessageBox.Show("Wrong Parameter!");
            }

            tes2 = Environment.TickCount;
            disable_feed(btnBaseOn, btnBaseOff, tboxBaseFlow, tboxBaseTimer, gboxInitPump, e);
            label23.Text = "Running...";
            label23.ForeColor = Color.Green;
            cboxMode.Enabled = false;
            timBasePump.Enabled = true;
            try { port.Write("basa" + tboxBaseFlow.Text + "@"); }
            catch { }
            
            timerBasePump = 0;
            labeltimerBasePump.Text = "0";
        }

        private void btnBaseOff_Click(object sender, EventArgs e)
        {
            disable_feed(btnBaseOn, btnBaseOff, tboxBaseFlow, tboxBaseTimer, gboxInitPump, e);
            label23.Text = "Stop";
            label23.ForeColor = Color.Red;
            if (btnBaseOff.Enabled == false && btnAcidOff.Enabled == false) {
                cboxMode.Enabled = true;
            }
            timBasePump.Enabled = false;
        }

        private void tboxAcidFLow_TextChanged(object sender, EventArgs e)
        {
            panggil(btnAcidOn, btnAcidOff, tboxAcidFLow, tboxAcidTimer, e);
        }

        private void tboxAcidTimer_TextChanged(object sender, EventArgs e)
        {
            panggil(btnAcidOn, btnAcidOff, tboxAcidFLow, tboxAcidTimer, e);
            try
            {
               
                if (Convert.ToInt32(tboxAcidFLow.Text) > 20)
                {
                    tboxAcidFLow.Text = "20";
                }
            }
            catch
            {
                MessageBox.Show("Wrong Parameter!");
            }


        }

        private void btnAcidOn_Click(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToInt32(tboxAcidFLow.Text) > 20)
                {
                    tboxAcidFLow.Text = "20";
                }
            }
            catch
            {
                MessageBox.Show("Wrong Parameter!");
            }

            tes9 = Environment.TickCount;
            disable_feed(btnAcidOn, btnAcidOff, tboxAcidFLow, tboxAcidTimer, gboxInitPump, e);
            label13.Text = "Running...";
            label13.ForeColor = Color.Green;
            cboxMode.Enabled = false;
            timAcidPump.Enabled = true;
            try { port.Write("asam" + tboxAcidFLow.Text + "@"); }
            catch { }
            
            timerAcidPump = 0;
            labeltimerAcidPump.Text = "0";
        }

        private void btnAcidOff_Click(object sender, EventArgs e)
        {
            disable_feed(btnAcidOn, btnAcidOff, tboxAcidFLow, tboxAcidTimer, gboxInitPump, e);
            label13.Text = "Stop";
            label13.ForeColor = Color.Red;
            if (btnBaseOff.Enabled == false && btnAcidOff.Enabled == false)
            {
                cboxMode.Enabled = true;
            }
            timAcidPump.Enabled = false;
        }

        #region TIMER
        int timerMetalSol = 0;
        double metalVol = 0;
        int tes = 0;


        bool onmeta = true;
        bool onterusmetal = true;
        int metal_ad = 0;
        int[] p = new int[2];
        int q;


        private void timer1_Tick(object sender, EventArgs e)
        {
           
            //this.Text = Math.Round(60.00 / (Convert.ToDouble(tboxMetakFlow.Text)), MidpointRounding.AwayFromZero).ToString();

            if (timerMetalSol %  Math.Round(20.00 / (Convert.ToDouble(tboxMetakFlow.Text)), MidpointRounding.AwayFromZero) == 0)
            {
                
                try { port.Write("meta" + "20" + "@"); }
                catch { }


                p[q] = timerMetalSol;
                 q++;
                if (q == 2)
                {
                    q = 0;
                }





                if (Convert.ToDouble(tboxMetakFlow.Text) == 20 && p[0]!=p[1])
                {
                    labelTotalMetal.Text = (metalVol += Math.Round(20 / 60.00, 2)).ToString("0.00");
                    metal_ad++;
                    if (metal_ad % 3 == 0)
                    {
                        labelTotalMetal.Text = (metalVol += 0.01).ToString("0.00");
                        metal_ad = 0;
                    }
                }

                else {
                    if (onmeta == true)
                    {
                        labelTotalMetal.Text = (metalVol += Math.Round(20 / 60.00, 2)).ToString("0.00");
                        metal_ad++;
                        if (metal_ad % 3 == 0)
                        {
                            labelTotalMetal.Text = (metalVol += 0.01).ToString("0.00");
                            metal_ad = 0;
                        }
                        onmeta = false;
                    }

                }

            }
            else {
                onmeta = true;
                try { port.Write("a@"); }
                catch { }
            }

            timerMetalSol = (Environment.TickCount - tes) / 1000;
            labeltimerMetalSol.Text = timerMetalSol.ToString();


            //if ((Convert.ToInt32(tboxMetakFlow.Text) < 30))
            //{


            //    if (timerMetalSol % (30 / Convert.ToInt32(tboxMetakFlow.Text)) == 0)
            //    {
            //        try { port.Write("meta" + "30" + "@"); }
            //        catch { }
            //        labelTotalMetal.Text = (metalVol += Math.Round(30.00 / 60.00, 2)).ToString("0.00");
            //    }
            //    else
            //    {
            //        try { port.Write("a@"); }
            //        catch { }
            //    }

            //}
            //else {
            //    labelTotalMetal.Text = (metalVol += Math.Round(Convert.ToDouble(tboxMetakFlow.Text) / 60.00, 2)).ToString("0.00");
            //}

                

                if (tboxMetalTimer.Text == timerMetalSol.ToString()) {
                    timMetalSol.Enabled = false;
                label21.Text = "Stop";
                label21.ForeColor = Color.Red;
                timerMetalSol = 0;
                    disable_feed(btnMetalSolOn, btnMetalSolOff, tboxMetakFlow, tboxMetalTimer, gboxInitPump, e);

                }
            
        }

        int timerBasePump = 0;
        double baseVol = 0;

        int tes2 = 0;
        bool onbase = true;
        bool onterusbase = true;
        int base_ad = 0;
        int[] p1 = new int[2];
        int q1;


        private void timBasePump_Tick(object sender, EventArgs e)
        {


            if (timerBasePump % Math.Round(20.00 / (Convert.ToDouble(tboxBaseFlow.Text)), MidpointRounding.AwayFromZero) == 0)
            {
                try { port.Write("basa" + "20" + "@"); }
                catch { }

                p1[q1] = timerBasePump;
                q1++;
                if (q1 == 2)
                {
                    q1 = 0;
                }

                if (Convert.ToDouble(tboxBaseFlow.Text) == 20 && p1[0] != p1[1])
                {
                    labelTotalBase.Text = (baseVol+= Math.Round(20 / 60.00, 2)).ToString("0.00");
                    base_ad++;
                    if (base_ad% 3 == 0)
                    {
                        labelTotalBase.Text = (baseVol += 0.01).ToString("0.00");
                        base_ad = 0;
                    }
                }

                else
                {
                    if (onbase == true)
                    {
                        labelTotalBase.Text = (baseVol += Math.Round(20 / 60.00, 2)).ToString("0.00");
                        base_ad++;
                        if (base_ad % 3 == 0)
                        {
                            labelTotalBase.Text = (baseVol += 0.01).ToString("0.00");
                            base_ad = 0;
                        }
                        onbase = false;
                    }

                }

            }

            else
            {
                onbase = true;
                try { port.Write("c@"); }
                catch { }
            }

            timerBasePump = (Environment.TickCount - tes2) / 1000;
            labeltimerBasePump.Text = timerBasePump.ToString();



            if (tboxBaseTimer.Text == timerBasePump.ToString())
            {
                timBasePump.Enabled = false;
                label23.Text = "Stop";
                label23.ForeColor = Color.Red;
                timerBasePump = 0;
                disable_feed(btnBaseOn, btnBaseOff, tboxBaseFlow, tboxBaseTimer, gboxInitPump, e);

            }
            
            //labelTotalBase.Text = (baseVol += Math.Round(Convert.ToDouble(tboxBaseFlow.Text) / 60.00, 2)).ToString("0.00");
        }

        int timerAcidPump = 0;
        double acidVol = 0;

        int tes9 = 0;
        bool onacid = true;
        bool onterusacid = true;
        int acid_ad = 0;
        int[] p9 = new int[2];
        int q9;
        private void timAcidPump_Tick(object sender, EventArgs e)
        {

            if (timerAcidPump % Math.Round(20.00 / (Convert.ToDouble(tboxAcidFLow.Text)), MidpointRounding.AwayFromZero) == 0)
            {
                try { port.Write("asam" + "20" + "@"); } catch { }

                p9[q9] = timerAcidPump;
                q9++;
                if (q9 == 2)
                {
                    q9 = 0;
                }

                if (Convert.ToDouble(tboxAcidFLow.Text) == 20 && p9[0] != p9[1])
                {
                    labelTotalAcid.Text = (acidVol+= Math.Round(20 / 60.00, 2)).ToString("0.00");
                    acid_ad++;
                    if (acid_ad% 3 == 0)
                    {
                        labelTotalAcid.Text = (acidVol+= 0.01).ToString("0.00");
                        acid_ad = 0;
                    }
                }

                else
                {
                    if (onacid == true)
                    {
                        labelTotalAcid.Text = (acidVol += Math.Round(20 / 60.00, 2)).ToString("0.00");
                        acid_ad++;
                        if (acid_ad% 3 == 0)
                        {
                            labelTotalAcid.Text = (acidVol += 0.01).ToString("0.00");
                            acid_ad = 0;
                        }
                        onacid = false;
                    }

                }


            }

            else
            {
                onacid = true;
                try { port.Write("b@"); }
                catch { }
            }



            timerAcidPump = (Environment.TickCount - tes9) / 1000;
            labeltimerAcidPump.Text = timerAcidPump.ToString();

            if (tboxAcidTimer.Text == timerAcidPump.ToString())
            {
                timAcidPump.Enabled = false;
                label13.Text = "Stop";
                label13.ForeColor = Color.Red;
                timerAcidPump = 0;
                disable_feed(btnAcidOn, btnAcidOff, tboxAcidFLow, tboxAcidTimer, gboxInitPump, e);

            }
            
           
        }

        private void btnBaseFeed_MouseDown(object sender, MouseEventArgs e)
        {
            try { port.Write("runbase&"); } catch { }
           
        }

        private void btnBaseFeed_MouseUp(object sender, MouseEventArgs e)
        {
            try { port.Write("stop&"); } catch { }
           
        }

        private void btnAcidFeed_MouseDown(object sender, MouseEventArgs e)
        {
            try { port.Write("runacid&"); } catch { }
            
        }

        private void btnAcidFeed_MouseUp(object sender, MouseEventArgs e)
        {
            try { port.Write("stop&"); } catch { }
            
        }

        private void tboxMetakFlow_KeyPress(object sender, KeyPressEventArgs e)
        {
            only_number(tboxMetakFlow,e);
        }
        #endregion TIMER

        #region AKUISISI DATA
       
        public void dataku(String data)
        {
           
            



            if ((tboxMetakFlow.Text.IndexOf('0') == 0))
            {
                tboxMetakFlow.Text = "";
            }
            if ((tboxMetalTimer.Text.IndexOf('0') == 0))
            {
                tboxMetalTimer.Text = "";
            }

            if ((tboxBaseFlow.Text.IndexOf('0') == 0))
            {
                tboxBaseFlow.Text = "";
            }
            if ((tboxBaseTimer.Text.IndexOf('0') == 0))
            {
                tboxBaseTimer.Text = "";
            }


            if ((tboxAcidFLow.Text.IndexOf('0') == 0))
            {
                tboxAcidFLow.Text = "";
            }
            if ((tboxAcidTimer.Text.IndexOf('0') == 0))
            {
                tboxAcidTimer.Text = "";
            }

           


            penampil++;
            if (penampil == 100)
            {
                label29.Text = data;
                penampil = 0;

                #region draw_grafik    

                double time = (Environment.TickCount - tickstart) / 1000;
                //double.TryParse(arduinodata[5], out x);
                x = time;
                double.TryParse((data).ToString(), out double y);
                if (y > 14)
                {
                    y = 14;
                }

                else if (y <= 0) {
                    y = 0;
                }
                list1.Add(x, y);

                if (timAuto.Enabled == true) {
                    list2.Add(x, Convert.ToDouble(tboxUperLimit.Text));
                    list3.Add(x, Convert.ToDouble(tboxLowerLimit.Text));

                }
                
                
                try
                {
                    xScale1 = zg1.GraphPane.XAxis.Scale;
                    yScale1 = zg1.GraphPane.YAxis.Scale;
                }
                catch
                {
                }

                //////////////////AUTO GESER////////////////////
                if (x > xScale1.Max - xScale1.MajorStep)
                {
                    xScale1.Max = x + xScale1.MajorStep;
                    xScale1.Min = xScale1.Max - 50;
                }

                if (y > yScale1.Max - yScale1.MajorStep)
                {
                    yScale1.Max = y + yScale1.MajorStep;
                    yScale1.Min = yScale1.Max - 15;
                }
                ///////////////////AUTO GESER////////////////

                zg1.AxisChange();
                zg1.Refresh();



                #endregion draw_grafik
            }













        }
        #endregion AKUISISI DATA

        private void tboxMetalTimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            only_number(tboxMetalTimer, e);
        }

        private void tboxUperLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((sender as TextBox).Text.IndexOf('.') == 1)
            {
                tboxUperLimit.MaxLength = 4;
            }
            else {
                tboxUperLimit.MaxLength = 5;
            }
            
        }

        private void tboxBaseFlow_KeyPress(object sender, KeyPressEventArgs e)
        {
            only_number(tboxBaseFlow, e);
        }

        private void tboxAcidFLow_KeyPress(object sender, KeyPressEventArgs e)
        {
            only_number(tboxAcidFLow, e);
        }

        private void tboxLowerLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            tboxLowerLimit.MaxLength = 5;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    try {
            //        port.Write("stop&");
            //        port.Close();
            //        Application.Exit();

            //    } catch { }



            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    e.Cancel = true;
            //    return;
            //}
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                port.Write("stop&");
                port.Close();
               
            }
            catch { }
        }

        private void tboxBaseTimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            only_number(sender,e);
        }

        private void tboxAcidTimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            only_number(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void timAuto_Tick(object sender, EventArgs e)
        {
        try{
                if (Convert.ToDouble(label29.Text) > Convert.ToDouble(tboxUperLimit.Text))
                {

                    //labelTotalAcid.Text = (acidVol += Math.Round(24.00 / 60.00, 2)).ToString("0.00");
                }
                if (Convert.ToDouble(label29.Text) < Convert.ToDouble(tboxLowerLimit.Text))
                {
                    //labelTotalBase.Text = (baseVol += Math.Round(23.00 / 60.00, 2)).ToString("0.00");
                }
            }
            catch{
                MessageBox.Show("Error pH!");
                timAuto.Enabled = false;
            }
          
           
        }

        void only_number(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            (sender as TextBox).MaxLength = 6;


        }
    }
}
