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
    public partial class Division : Form
    {
        public Division()
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Calculadora ventana = new Calculadora();
            ventana.Show();
            this.Hide();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resul;

            num1 = Double.Parse(txt_num1.Text);
            num2 = Double.Parse(txt_num2.Text);

            resul = num1 / num2;

            txt_resul.Text = resul.ToString();
        }
    }
}
