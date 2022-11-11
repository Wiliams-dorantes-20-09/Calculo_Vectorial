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
    public partial class CrossProduct : Form
    {
        public CrossProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ui = int.Parse(textBox1.Text);
            int uj = int.Parse(textBox2.Text);
            int uk = int.Parse(textBox3.Text);

            int vi = int.Parse(textBox4.Text);
            int vj = int.Parse(textBox5.Text);
            int vk = int.Parse(textBox6.Text);

            int iVal = (uj * vk - uk * vj);
            int jVal = -(ui * vk - uk * vi);
            int kVal = (ui * vj - uj * vi);

            label3.Text = $"Resultado:  {iVal} i,  {jVal} j,  {kVal} k";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
