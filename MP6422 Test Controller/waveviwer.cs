using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP6422_Test_Controller
{
    public partial class waveviwer : UserControl
    {
        public waveviwer()
        {
            InitializeComponent();
            SelectIndexChanged += Waveviwer_selectIndexChanged;
        }

        private void Waveviwer_selectIndexChanged()
        {
            wavechart wchart;
            for (int c = 0; c < panel2.Controls.Count; c++)
            {
                wchart = panel2.Controls[c] as wavechart;
                wchart.Text_Bold = (c == selectedIndex) ? true : false;
            }
        }

        public delegate void SelectWaveHandler();
        public event SelectWaveHandler SelectIndexChanged;

        public new int Height
        {
            get
            {
                return (panel2.Height-2);
            }
            set
            {
                panel2.Height = value;
            }
        }

        public int waveCount
        {
            get
            {
                return panel2.Controls.Count;
            }
        }

        private int selectedIndex;
        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                selectedIndex = value;
                SelectIndexChanged();
            }
        }

        public void Add_wave(wavechart wchar)
        {
            panel2.Controls.Add(wchar);
            wchar.Top = (panel2.Controls.Count - 1) * wchar.Height;
            wchar.Port_Name = 'P' + (panel2.Controls.Count - 1).ToString("D2");
        }

        public void Remove_wave(int index)
        {
            panel2.Controls.RemoveAt(index);
        }

        public void Draw_wave(List<List<int>> wave)
        {
            int max_value = 0;
            foreach(List<int> w in wave)
            {
                if (w.Count > 0)
                {
                    int temp = w[w.Count - 1];
                    if (max_value > temp)
                    {
                        w.Add(max_value);
                    }
                    else
                    {
                        max_value = temp;
                    }
                }
            }

            wavechart wchart = panel2.Controls[selectedIndex] as wavechart;

            foreach(List<int> w in wave)
            {
                if(w.Count > 0)
                {
                    wchart.Draw_Chart(w);
                }
            }     
        }
    }
}
