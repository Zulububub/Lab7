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

namespace Lab7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                using (StreamWriter sw = new StreamWriter("Names.txt", true))
                {
                    sw.WriteLine(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
                    textBox1.Text = textBox2.Text = textBox3.Text = "";
                }
            }
            else MessageBox.Show("Please, fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableForm form = new TableForm();
            form.ShowDialog();
        }
    }
}
