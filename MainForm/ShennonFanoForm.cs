using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using EntropyLib;

namespace MainForm
{
    public partial class ShennonFanoForm : Form
    {
        private InputForm inputForm;
        private EntropyData entropyData;
        public ShennonFanoForm()
        {
            InitializeComponent();
        }

        public ShennonFanoForm(EntropyData ed, InputForm inputForm) : this()
        {
            entropyData = ed;
            Symbol.FigureEncoding(ed);
            this.inputForm = inputForm;
        }

        private void ShennonFanoForm_Load(object sender, EventArgs e)
        {
            Grid.Rows.Clear();
            Grid.RowHeadersVisible = false;

            Grid.ColumnCount = 3;
            Grid.Columns[0].HeaderText = "Symbol";
            Grid.Columns[1].HeaderText = "Probability";
            Grid.Columns[2].HeaderText = "Code";

            for (int i = 0; i < Symbol.symbols.Count; i++)
            {
                Grid.Rows.Add();
                Grid[0, i].Value = Symbol.symbols[i].Name;
                Grid[2, i].Value = Symbol.symbols[i].Code;
                Grid[1, i].Value = Math.Round(Symbol.symbols[i].Probability, 4);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = "data";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName+".txt", FileMode.Create))
                    {
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.Write(Symbol.ApplyEncoding(entropyData.Temptext));
                        }
                    }
                    using (FileStream fs = new FileStream(saveFileDialog.FileName+".dat", FileMode.Create))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(fs, Symbol.symbols);
                    }
                }
            }
            
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            string coded = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        coded = reader.ReadToEnd();
                    }

                    using (FileStream fs = new FileStream(Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".dat", FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        Symbol.symbols = (List<Symbol>)formatter.Deserialize(fs);
                    }
                }
            }

            inputForm.MainInput.Text = Symbol.ApplyDecoding(coded);
            inputForm.Focus();
        }
    }
}
