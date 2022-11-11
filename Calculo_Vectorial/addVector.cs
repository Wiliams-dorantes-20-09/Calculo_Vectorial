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
    public partial class addVector : Form
    {
        public addVector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string string1, string2, string3;
            string1 = textBox1.Text;
            string2 = textBox2.Text;
            string3 = textBox3.Text;

            float[] vector1 = Array.ConvertAll(string1.Split(','), float.Parse);
            float[] vector2 = Array.ConvertAll(string2.Split(','), float.Parse);
            float[] vector3 = Array.ConvertAll(string3.Split(','), float.Parse);

            Vectors vec = new Vectors();
            float[] vector4 = vec.additionV(vector1, vector2, vector3);
            label3.Text = "Resultado:  " + string.Join(",  ", vector4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdditionSubtraction a = new AdditionSubtraction();
            a.Visible = true;
            this.Visible = false;

        }
    }
}
