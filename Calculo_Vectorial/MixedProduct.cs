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
    public partial class MixedProduct : Form
    {
        public MixedProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //b
            int ui = int.Parse(textBox1.Text);
            int uj = int.Parse(textBox2.Text);
            int uk = int.Parse(textBox3.Text);

            //c
            int vi = int.Parse(textBox4.Text);
            int vj = int.Parse(textBox5.Text);
            int vk = int.Parse(textBox6.Text);

            //a

            int wi = int.Parse(textBox7.Text);
            int wj = int.Parse(textBox8.Text);
            int wk = int.Parse(textBox9.Text);

            //producto cruz de BXC
            int iVal = (uj * vk - uk * vj);
            int jVal = -(ui * vk - uk * vi);
            int kVal = (ui * vj - uj * vi);

            //Producto punto de A*(BXC)
            int vTol = ((wi * iVal)+(wj * jVal)+(wk * kVal));

            //resultado del producto cruz
            label3.Text = $"Resultado de producto cruz:  {iVal} i, {jVal} j, {kVal} k";

            //resultado final
            label5.Text = $"Resultado final:  {vTol} A * (B x C)";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();    
            textBox8.Clear();
            textBox9.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Visible = true;
            this.Visible = false;
        }
    }
}
