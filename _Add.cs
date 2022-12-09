using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class _Add : Form
    {
        public _Add()
        {
            InitializeComponent();
        }
        public Clients Addclass { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals(""))
            {
                MessageBox.Show("Введiть данi");
            }
            try
            {
                Addclass = new Clients(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Некоректнi данi");
            }
        }
    }
}
