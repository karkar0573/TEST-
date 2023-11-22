using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectZ
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                MessageBox.Show("Ответ верный");
            }

            if (radioButton2.Checked)
            {
                MessageBox.Show("Ответ неверный");
            }

            if (radioButton3.Checked)
            {
                MessageBox.Show("Ответ неверный");
            }

            if (radioButton4.Checked)
            {
                MessageBox.Show("Ответ неверный");
            }
            Form5 forу = new Form5();
            forу.Show();
            this.Hide();
        }
    }
}
