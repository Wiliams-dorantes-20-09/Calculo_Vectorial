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
    public partial class ProductPoint : Form
    {
        public ProductPoint()
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
            float response = 0;
            response = vec.ProductP(vector1, vector2);

            if (vec.mistake)
            {
                MessageBox.Show("La multiplicacion no se pudo realizar","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                label3.Text = "Resultado de la multiplicación:  " + response.ToString("f2");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
