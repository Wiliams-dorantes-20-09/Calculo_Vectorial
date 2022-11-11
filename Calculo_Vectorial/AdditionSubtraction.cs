using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Vectorial
{
    public partial class AdditionSubtraction : Form
    {
        public AdditionSubtraction()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string string1, string2;
            string1 = textBox1.Text;
            string2 = textBox2.Text;

            float[] vector1 = Array.ConvertAll(string1.Split(','), float.Parse);
            float[] vector2 = Array.ConvertAll(string2.Split(','), float.Parse);

            Vectors vec = new Vectors();
            float[] vector3 = vec.addition(vector1, vector2);
            label3.Text = "Resultado:  " + string.Join(",  ", vector3); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string string1, string2;
            string1 = textBox1.Text;
            string2 = textBox2.Text;

            float[] vector1 = Array.ConvertAll(string1.Split(','), float.Parse);
            float[] vector2 = Array.ConvertAll(string2.Split(','), float.Parse);

            Vectors vec = new Vectors();
            float[] vector3 = vec.subtraction(vector1, vector2);
            label3.Text = "Resultado:  " + string.Join(",  ", vector3);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addVector ad = new addVector();
            ad.Visible = true;
            this.Visible = false;
        }
    }
}
