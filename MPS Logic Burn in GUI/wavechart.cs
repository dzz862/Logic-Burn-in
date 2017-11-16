using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MP6422_Test_Controller
{
    public partial class wavechart : UserControl
    {
        public bool Text_Bold
        {
            get
            {
                return label1.Font.Bold;
            }
            set
            {
                if(value)
                    label1.Font = new Font("Calibri", 12, FontStyle.Bold);
                else
                    label1.Font = new Font("Calibri", 12, FontStyle.Regular);
            }
        }

        public String Port_Name
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        public int middle_value
        {
            get;
            set;
        }

        public int margin
        {
            get;
            set;
        }

        public wavechart(Size size, int middle, int margin)
        {
            InitializeComponent();
            this.Size = size;
            this.middle_value = middle;
            this.margin = margin;
        }

        private void wave_dis_Load(object sender, EventArgs e)
        {
            chart1.Top = 0;
            chart1.Left = 40;
            chart1.Height = this.Height;
            chart1.Width = this.Width - chart1.Left;

            label1.Top = this.Height / 2 - 10;
            label1.Left = 0;
            //Graphics g = chart1.CreateGraphics();
            //g.DrawLine(new Pen(Color.Red, 1), new Point(20, 0), new Point(20, 50));
        }

        public void Draw_Chart(List<int> X_value)
        {
            int ini_value = 0;
            DataSet set = new DataSet();
            DataTable table = new DataTable();
            DataColumn column = new DataColumn();
            List<int> Y_value = new List<int>();
            
            DataPoint points = new DataPoint();
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            series.ShadowOffset = 2;

            ChartArea area = new ChartArea();
            area.Position.Width = 100;
            area.Position.Height = 100;
            area.InnerPlotPosition.Width = 100;
            area.InnerPlotPosition.Height = 100;

            if (X_value[0] != 0)
            {
                ini_value = 0;
                series.Points.AddXY(0, 0);
            }
            else
            {
                ini_value = 1;
                series.Points.AddXY(0, 1);
            }

            foreach(int x in X_value)
            {
                series.Points.AddXY(x - 1, ini_value);
                ini_value = (ini_value == 1) ? 0:1;
                series.Points.AddXY(x, ini_value);
            }

           chart1.ChartAreas.Add(area);
           chart1.Series.Add(series);

        }

        public void Zoom(int scale)
        {
       
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
