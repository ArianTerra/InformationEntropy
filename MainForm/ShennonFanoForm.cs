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
    public partial class ShennonFanoForm : Form
    {
        List<Symbol> symbols;

        public ShennonFanoForm()
        {
            InitializeComponent();
        }

        public ShennonFanoForm(EntropyData ed) : this()
        {
            symbols = Symbol.ApplyEncoding(ed);
        }

        private void ShennonFanoForm_Load(object sender, EventArgs e)
        {
            Grid.Rows.Clear();
            Grid.RowHeadersVisible = false;

            Grid.ColumnCount = 3;
            Grid.Columns[0].HeaderText = "Symbol";
            Grid.Columns[1].HeaderText = "Probability";
            Grid.Columns[2].HeaderText = "Code";

            for (int i = 0; i < symbols.Count; i++)
            {
                Grid.Rows.Add();
                Grid[0, i].Value = symbols[i].Name;
                Grid[2, i].Value = symbols[i].Code;
                Grid[1, i].Value = Math.Round(symbols[i].Probability, 4);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
