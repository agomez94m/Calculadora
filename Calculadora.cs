using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            SUMA ventana = new SUMA();    
            ventana.Show();
            this.Hide();
            
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            RESTA ventana = new RESTA();
            ventana.Show();
            this.Hide();
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            Multipli ventana = new Multipli();
            ventana.Show();
            this.Hide();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            Division ventana = new Division();
            ventana.Show();
            this.Hide();
        }
    }
}
