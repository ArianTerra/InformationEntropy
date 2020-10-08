using System;
using System.IO;
using System.Linq;
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
            if (!string.IsNullOrEmpty(MainInput.Text))
            {
                OutputForm form = new OutputForm(new EntropyData(MainInput.Text,
                    Symbols.Checked, SpacesIgnore.Checked));
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("The text field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MainInput.Text = String.Empty;
        }

        private void TextFile_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
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

        private void URLbutton_Click(object sender, EventArgs e)
        {
            UrlForm form = new UrlForm(this);
            form.ShowDialog();
        }

        private void MainInput_TextChanged(object sender, EventArgs e)
        {
            charactersLabel.Text = MainInput.Text.Length.ToString();
            spacelessLabel.Text = string.Concat(MainInput.Text.Where(c => !char.IsWhiteSpace(c))).Length.ToString();

            string temp = String.Empty;
            foreach (char ch in MainInput.Text)
            {
                if (char.IsLetter(ch)) temp += ch.ToString();
            }

            lettersLabel.Text = temp.Length.ToString();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            MainInput.Text += "."; //a dumb way to call TextChanged event on startup
        }

        private void Combine_Click(object sender, EventArgs e)
        {
            CombineForm of = new CombineForm();
            of.ShowDialog();
        }
    }
}
