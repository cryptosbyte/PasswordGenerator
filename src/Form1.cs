using System;
using System.Text;
using System.Windows.Forms;

namespace passgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            intInput.Items.Add("8");
            intInput.Items.Add("12");
            intInput.Items.Add("16");
            intInput.Items.Add("32");
        }

        private void startFunc_Click(object sender, EventArgs e)
        {
            string output = this.intInput.SelectedItem.ToString();

            if (output != null)
            {
                this.progressBar1.Increment(100);

                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!?#@_";
                StringBuilder returning = new StringBuilder();
                Random rn = new Random();
                int parsed = int.Parse(output);
                while (0 < parsed--)
                {
                    returning.Append(valid[rn.Next(valid.Length)]);
                }

                MessageBox.Show(output + " character string is " + returning + " | It has been copied to your clipboard.");
                Clipboard.SetText(returning.ToString());
            }

        }

    }
}
