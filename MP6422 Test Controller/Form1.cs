using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CCWin;
using System.IO;
using Logic;

namespace MP6422_Test_Controller
{
    public partial class Form1 : CCSkinMain
    {

        List<List<int>> data = new List<List<int>>();
        List<List<int>> wave = new List<List<int>>();

        public Form1()
        {
            InitializeComponent();
            Sys_Initial();
        }

       
        private void Sys_Initial()
        {
            //serialPort1.BaudRate = 9600;
            //serialPort1.PortName = System.IO.Ports.SerialPort.GetPortNames()[0];
            //serialPort1.Open();
            //serialPort1.WriteLine("Welcome to use MPS Test Helper!");
            //serialPort1.WriteLine("Author: Gene Gan");
            //serialPort1.WriteLine("Version: alpha");
            //serialPort1.WriteLine("");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void Label9_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //if (e.Delta > 0)
            //{
            //    if(comboBox3.SelectedIndex < (comboBox3.Items.Count - 1))
            //        comboBox3.SelectedIndex++;
            //}
            //else
            //{
            //    if(comboBox3.SelectedIndex > 0)
            //        comboBox3.SelectedIndex--;
            //}
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox portnum = sender as ComboBox;

            int cnt = (comboBox1.SelectedIndex) - waveviwer1.waveCount;

            if (cnt > 0)
            {
                while (cnt > 0)
                {
                    wavechart wchar = new wavechart(new Size(waveviwer1.Width - 4, waveviwer1.Height / 8), 2000, 2000);
                    waveviwer1.Add_wave(wchar);
                    comboBox2.Items.Add("P" + (waveviwer1.waveCount - 1).ToString("D2"));
                    data.Add(new List<int>());
                    wave.Add(new List<int>());
                    cnt--;
                }
            }
            else
            {
                while (cnt < 0)
                {
                    waveviwer1.Remove_wave(waveviwer1.waveCount - 1);
                    comboBox2.Items.RemoveAt(waveviwer1.waveCount);
                    data.RemoveAt((data.Count - 1));
                    wave.RemoveAt((data.Count - 1));
                    cnt++;
                }
            }

            //panel2.Controls.Clear();
            //comboBox3.SelectedIndex = 4;

            //for (int i = 0; i <= portnum.SelectedIndex; i++)
            //{
            //    wavechart item = new wavechart();
            //    List<int> wave = new List<int>();
            //    data.Insert(i,wave);
            //    //data[i].Add(0);
            //    //data[i].Add(0);
            //    //data[i].Add(0);
            //    item.Width = panel2.Width - 2;
            //    item.Height = panel2.Height / 8;
            //    item.Top = i * item.Height;
            //    item.Name = "wave_" + i;
            //    item.Port_Name = "P" + (i / 8).ToString() + (i % 8).ToString();
            //    panel2.Controls.Add(item);

            //    
            //}
        }

        //private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    ComboBox timescale = sender as ComboBox;
        //    label9.Text = timescale.SelectedItem.ToString() + " /div";

        //    foreach (Control c in panel2.Controls)
        //    {
        //        if (c.Name.Contains("wave_"))
        //        {
        //            wavechart wd = c as wavechart;
        //            wd.Zoom(timescale.SelectedIndex);
        //        }
        //    }
        //}

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int SDateTemp = this.serialPort1.ReadByte();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox currentport = sender as ComboBox;
            waveviwer1.SelectedIndex = comboBox2.SelectedIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int start = 0;
            int time = 0;
            //List<int> w = data[comboBox2.SelectedIndex];       

            if (comboBox2.SelectedIndex != -1)
            {
                try
                {
                    start = Int32.Parse(textBox2.Text);
                    time = Int32.Parse(textBox1.Text);
                    if (start < 0 || time < 0)
                    {
                        throw new Exception("Invalid Input");
                    }

                    else
                    {
                        data[waveviwer1.SelectedIndex].Add(start);
                        wave[waveviwer1.SelectedIndex].Add(start);
                        data[waveviwer1.SelectedIndex].Add(time);
                        wave[waveviwer1.SelectedIndex].Add(start + time);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    //MessageBox.Show("Please enter a num between 0 to 2147483647");
                }


                waveviwer1.Draw_wave(wave);
            }
            else
            {
                MessageBox.Show("Please Select Operation Point");
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveWaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String filename = "wave_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + "_" + System.DateTime.Now.Minute;

            FileStream wave = File.Create(filename + ".wave");
            StreamWriter sw = new StreamWriter(wave);

            foreach(List<int> w in data)
            {
                sw.Write(data.IndexOf(w).ToString() + "(");
                foreach(int d in w)
                {
                    sw.Write(d.ToString() + ", ");
                }
                sw.Write(")\n");
            }
            sw.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<List<C_Data>> whole_data = new List<List<C_Data>>();

            bool value = false;
            List<C_Data> ch0_data = new List<C_Data>();
            Double[] ch0_time = new Double[4] { 15000, 10000, 15000, 30000 };
            //Double[] ch0_time = new Double[2] { 10, 20 };
            for (int i = 0; i < ch0_time.Length; i++)
            {
                C_ODData data = new C_ODData(0);
                data.time = ch0_time[i];
                data.value = value;
                ch0_data.Add(data);
                value = value ? false : true;
            }
            whole_data.Add(ch0_data);

            value = true;
            List<C_Data> ch1_data = new List<C_Data>();
            Double[] ch1_time = new Double[6] { 2000, 15000, 5000, 15000, 32999, 1 };
            //Double[] ch1_time = new Double[4] { 20, 40, 60, 80 };
            for (int i = 0; i < ch1_time.Length; i++)
            {
                C_ODData data = new C_ODData(1);
                data.time = ch1_time[i];
                data.value = value;
                ch1_data.Add(data);
                value = value ? false : true;
            }
            whole_data.Add(ch1_data);

            value = false;
            List<C_Data> ch2_data = new List<C_Data>();
            Double[] ch2_time = new Double[12] { 45000, 10, 10, 10, 10, 10, 10, 10, 10, 10, 24909, 1 };
            //Double[] ch2_time = new Double[2] { 160, 320 };
            for (int i = 0; i < ch2_time.Length; i++)
            {
                C_ODData data = new C_ODData(2);
                data.time = ch2_time[i];
                data.value = value;
                ch2_data.Add(data);
                value = value ? false : true;
            }
            whole_data.Add(ch2_data);

            value = false;
            List<C_Data> ch3_data = new List<C_Data>();
            Double[] ch3_time = new Double[2] { 65000, 5000 };
            //Double[] ch3_time = new Double[2] { 640, 1280};
            for (int i = 0; i < ch3_time.Length; i++)
            {
                C_ODData data = new C_ODData(3);
                data.time = ch3_time[i];
                data.value = value;
                ch3_data.Add(data);
                value = value ? false : true;
            }
            whole_data.Add(ch3_data);

            value = false;
            List<C_Data> ch4_data = new List<C_Data>();
            Double[] ch4_time = new Double[12] { 11000, 13000, 360, 440, 34000, 36000, 360, 440, 59000, 61000, 1000, 10000 };
            //Double[] ch4_time = new Double[8] { 13000, 16000, 34000, 36000, 59000, 61000, 64000, 66000 };
            //Double[] ch4_time = new Double[2] { 1280, 2560 };
            for (int i = 0; i < ch4_time.Length; i++)
            {
                C_IDData data = new C_IDData(1);
                data.time_min = ch4_time[i++];
                data.time_max = ch4_time[i];
                data.value = value;
                ch4_data.Add(data);
                value = value ? false : true;
            }
            whole_data.Add(ch4_data);

            C_Transform trans = new C_Transform();
            List<byte> result = new List<byte>();
            try
            {
                result = trans.GetResult(whole_data, 70000);

            }
            catch (IndexOutOfRangeException e1)
            {
                MessageBox.Show(e1.ToString());
            }
            catch (InvalidOperationException e2)
            {
                MessageBox.Show(e2.ToString());
            }
            String r = null;
            foreach (byte b in result)
            {
                r += "0x" + b.ToString("X2") + ", ";
            }
            r += result.Count;
            MessageBox.Show(r);
        }
    }
}
