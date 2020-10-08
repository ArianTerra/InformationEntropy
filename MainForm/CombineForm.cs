using EntropyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class CombineForm : Form
    {
        public CombineForm()
        {
            InitializeComponent();
        }

        private void CombineForm_Load(object sender, EventArgs e)
        {
            EntropyDataCombined EDC = new EntropyDataCombined();
            AlpA.ColumnCount = EDC.Alphabet.Count() + 1;
            AlpA.Rows.Clear();
            AlpA.Rows.Add();
            AlpA.ColumnHeadersVisible = false;
            AlpA.RowHeadersVisible = false;
            AlpA.Rows[0].Cells[0].Value = "Probabilities: ";
            for (int i = 0; i < EDC.Alphabet.Count(); i++)
            {
                AlpA.Rows[0].Cells[i + 1].Value = Math.Round(EDC.Alphabet[i], 4);
                AlpA.Columns[i + 1].Width = 60;
            }

            AlpB.ColumnCount = EDC.Blaphabet.Count() + 1;
            AlpB.Rows.Clear();
            AlpB.Rows.Add();
            AlpB.ColumnHeadersVisible = false;
            AlpB.RowHeadersVisible = false;
            AlpB.Rows[0].Cells[0].Value = "Probabilities: ";
            for (int i = 0; i < EDC.Blaphabet.Count(); i++)
            {
                AlpB.Rows[0].Cells[i + 1].Value = Math.Round(EDC.Blaphabet[i], 4);
                AlpB.Columns[i + 1].Width = 60;
            }

            AlpAAlpB.ColumnCount = EDC.AlpDepBlap.Count();
            AlpAAlpB.Rows.Clear();
            for (int i = 0; i < EDC.AlpDepBlap.Count(); i++)
            {
                AlpAAlpB.Rows.Add();
            }
            
            AlpAAlpB.ColumnHeadersVisible = false;
            AlpAAlpB.RowHeadersVisible = false;
            for (int i = 0; i < EDC.AlpDepBlap.Count(); i++)
            {
                AlpAAlpB.Columns[i].Width = 60;
                for (int j = 0; j < EDC.AlpDepBlap[0].Count(); j++)
                {
                    AlpAAlpB.Rows[i].Cells[j].Value = Math.Round(EDC.AlpDepBlap[i][j], 4);
                }
            }


            AlpBAlpA.ColumnCount = EDC.BlapDepAlp.Count();
            AlpBAlpA.Rows.Clear();
            for (int i = 0; i < EDC.BlapDepAlp.Count(); i++)
            {
                AlpBAlpA.Rows.Add();
            }

            AlpBAlpA.ColumnHeadersVisible = false;
            AlpBAlpA.RowHeadersVisible = false;
            for (int i = 0; i < EDC.BlapDepAlp.Count(); i++)
            {
                AlpBAlpA.Columns[i].Width = 60;
                for (int j = 0; j < EDC.BlapDepAlp[0].Count(); j++)
                {
                    AlpBAlpA.Rows[i].Cells[j].Value = Math.Round(EDC.BlapDepAlp[i][j], 4);
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
