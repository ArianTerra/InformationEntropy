using System;
using System.Windows.Forms;
using TextParser;

namespace MainForm
{
    public partial class UrlForm : Form
    {
        private InputForm inputForm;
        public UrlForm()
        {
            InitializeComponent();
        }

        public UrlForm(InputForm inputForm) : this()
        {
            this.inputForm = inputForm;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            inputForm.MainInput.Text = Parser.GetText(textBox1.Text);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    buttonOK.PerformClick();
                    break;
                case Keys.Escape:
                    buttonCancel.PerformClick();
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
