using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text == "Бегун") && (textBox1.Text == "123"))
            {
                begun bmenu = new begun();
                bmenu.Show();
                this.Hide();
            }
            else
               if ((comboBox1.Text == "Координатор") && (textBox1.Text == "1234"))
            {
                Form3 rco = new Form3();
                rco.Show();
                this.Hide();
            }
            else
               if ((comboBox1.Text == "Главный") && (textBox1.Text == "12345"))
            {
                admin radm = new admin();
                radm.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inf main = new inf();
            main.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
