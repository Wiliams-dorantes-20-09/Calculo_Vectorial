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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdditionSubtraction adSb= new AdditionSubtraction();
            adSb.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductPoint pp = new ProductPoint();
            pp.Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrossProduct cp = new CrossProduct();
            cp.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MixedProduct mp = new MixedProduct();
            mp.Visible = true;
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Visible = true;
            this.Visible = false;
        }
    }
}
