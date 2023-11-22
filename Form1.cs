namespace ProjectZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Form2 foró = new Form2();
            foró.Show();
          this.Hide();
        }
    }
}