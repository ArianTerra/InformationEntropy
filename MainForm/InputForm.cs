using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void TextFile_Click(object sender, EventArgs e)
        {
            string text = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        text = reader.ReadToEnd();
                    }
                }
            }

            MainInput.Text = text;
        }
    }
}
