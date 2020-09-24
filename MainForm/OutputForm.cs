using System;
using System.Linq;
using System.Windows.Forms;
using EntropyLib;

namespace MainForm
{
    public partial class OutputForm : Form
    {
        readonly EntropyData infoDat;
        public OutputForm()
        {
            InitializeComponent();
        }

        public OutputForm(EntropyData dat): this()
        {
            infoDat = dat;
            infoLabel.Text = "Hartly: " + Math.Round(dat.Hartly, 4) + " Shennon: " + Math.Round(dat.Shennon, 4);
        }
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
