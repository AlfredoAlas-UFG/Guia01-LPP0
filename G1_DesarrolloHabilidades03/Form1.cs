using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calcula la igualdad de Celcius a Farenheit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Temperatura_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbCelcius.Text, out decimal celsius))
            {
                decimal fahrenheit = (celsius * 9 / 5) + 32;
                txbFarenheit.Text = fahrenheit.ToString();
            }
            else if (string.IsNullOrEmpty(txbCelcius.Text)) return;
            else
            {
                MessageBox.Show("Por favor, ingrese un valor decimal para temperatura.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCelcius.Clear();
                txbFarenheit.Clear();
            }
        }

        /// <summary>
        /// Calcula la igualdad de Metros a Pies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Longitud_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbMetros.Text, out decimal metros))
            {
                decimal pies = metros * 3.28084m;
                txbPies.Text = pies.ToString();
            }
            else if (string.IsNullOrEmpty(txbMetros.Text)) return;
            else
            {
                MessageBox.Show("Por favor, ingrese un valor decimal para longitud.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMetros.Clear();
                txbPies.Clear();
            }
        }

        /// <summary>
        /// Calcula la igualdad de Kilogramos a Libras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Peso_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbKilogramos.Text, out decimal kilogramos))
            {
                decimal libras = kilogramos * 2.20462m;
                txbLibras.Text = libras.ToString();
            }
            else if (string.IsNullOrEmpty(txbKilogramos.Text)) return;
            else
            {
                MessageBox.Show("Por favor, ingrese un valor decimal para peso.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbKilogramos.Clear();
                txbLibras.Clear();
            }
        }
    }
}
