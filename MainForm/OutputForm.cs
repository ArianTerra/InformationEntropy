using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntropyLib;

namespace MainForm
{
    public partial class OutputForm : Form
    {
        public OutputForm()
        {
            InitializeComponent();
        }

        public OutputForm(EntropyData dat): this()
        {
            infoDat = dat;
        }

        readonly EntropyData infoDat;

        private void OutputForm_Load(object sender, EventArgs e)
        {
            double[] yValues = infoDat.Frequency.Select(x => x.Value).ToArray();
            string[] xValues = infoDat.Frequency.Select(x => Convert.ToString(x.Key)).ToArray();

            Chart.ChartAreas[0].AxisX.Title = "Символы алфавита";
            Chart.ChartAreas[0].AxisY.Title = "Частота появления";
            
            Chart.Series[0].Points.DataBindXY(xValues, yValues);
            Chart.ChartAreas[0].AxisX.Interval = 1;
            Chart.Legends.Clear();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
