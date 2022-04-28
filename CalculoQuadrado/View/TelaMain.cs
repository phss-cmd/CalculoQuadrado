using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoQuadrado.View
{
    public partial class TelaMain : Form
    {
        public TelaMain()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = 0;
            int quadrado = 0;

            numero = Convert.ToInt32(tbxNumero.Text);

            quadrado = numero * numero;

            lblResultado.Text = "O quadrado de " + numero + " é " + quadrado;

            tbxNumero.Focus();

            tbxNumero.SelectAll();
        }

        private void btnCalcular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                btnCalcular.PerformClick();
            }
        }
    }
}
