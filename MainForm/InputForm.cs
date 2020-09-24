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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void Process_Click(object sender, EventArgs e)
        {
            OutputForm form = new OutputForm(EntropyData.GetData(MainInput.Text, Symbols.Checked));
            form.ShowDialog();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
