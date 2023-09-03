using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private List<int> caja = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_INGRESAR_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty(TX_1.Text) )
            {
                MessageBox.Show("No Hay datos o Numero Invalido");
                return;
            }   
            if ( !EsNumero(TX_1.Text))
            {
                MessageBox.Show("Ingrese numeros validos");
                return;
            }

            caja.Add(Int32.Parse(TX_1.Text));

            TX_1.Text = null;
            TX_1.Focus();
        }

        private bool EsNumero(string cadena)
        {
            return int.TryParse(cadena , out int num);
        }

        private void BTN_MOSTRAR_Click(object sender, EventArgs e)
        {
            TX_RESULTADO.Text = string.Join(" ", caja);
            LB_RESULTADO.Text = "Resultado = " + (caja.Count).ToString();
        }
    }
}
