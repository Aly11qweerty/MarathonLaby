using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class bmr : Form
    {
        float gen;
        float vs;
        float ro;
        float age;
        public bmr()
        {
            InitializeComponent();
        }

        private void bmr_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float ves = float.Parse(s.Text);
            float rost = float.Parse(r.Text);
            float ag = float.Parse(d.Text);
            float f = gen + (vs * ves) + (ro * rost) - (age * ag);
            label8.Text = f.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            gen = 66;
            vs = 13.7f;
            ro = 5;
            age = 6.8f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gen = 65;
            vs = 9.6f;
            ro = 1.8f;
            age = 4.7f;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gen = 0;
            r.Clear();
            s.Clear();
            d.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            inf main = new inf();
            main.Show();
            this.Hide();
        }
    }
}
