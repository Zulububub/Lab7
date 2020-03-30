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
    public partial class TableForm : Form
    {
        public class Names
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string PhoneNumber { get; set; }
        }
        public static List<Names> names = new List<Names>();
        public TableForm()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("Names.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ' });
                    names.Add(new Names() { Name = words[0], Surname = words[1], PhoneNumber = words[2] });
                }
            }
            dataGridView1.DataSource = names;
        }

        private void TableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            names.Clear();
        }
    }
}
