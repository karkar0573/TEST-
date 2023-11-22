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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Ответ неверный");
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
                MessageBox.Show("Ответ верный");
            }
            Form6 forу = new Form6();
            forу.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
