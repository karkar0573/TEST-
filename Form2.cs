using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using ProjectZ;
using static ProjectZ.Ball;

namespace ProjectZ
{
    public partial class Form2 : Form
    {
       

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

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
                MessageBox.Show("Ответ верный");
              
            }

            if (radioButton4.Checked)
            {
                MessageBox.Show("Ответ неверный");
            }

            Form3 forу = new Form3();
            forу.Show();
            this.Hide();
        }


    }
}
