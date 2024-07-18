using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kendiformuygilk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ad = textBoxad.Text;
            string soyad = textBoxsoyad.Text;

            listBox1.Items.Add("T.C:" + maskedTextBox1.Text + " " + "Ad:" + ad + " " + "Soyad:" + soyad + " " + "Alınan Kitap:" + comboBox1.Text + " " + "Alınma Tarihi:" + dateTimePicker1.Text);

        }
    }
}
