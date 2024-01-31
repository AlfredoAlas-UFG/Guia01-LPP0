using System;
using System.Windows.Forms;

namespace Analisis2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento click que evalua la ecuación
        /// </summary>
        /// <param name="sender">Objeto que disparo el evento</param>
        /// <param name="e">argumentos del evento</param>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, c;

            // Se valida que los datos de entrada son números punto flotante
            if (!TryParseTextBoxValue(txbA.Text, out a, "a") ||
                !TryParseTextBoxValue(txbB.Text, out b, "b") ||
                !TryParseTextBoxValue(txbC.Text, out c, "c"))
            {
                return;
            }

            // Se evalua el resultado con la formula general
            // para encontrar las raíces de una ecuación cuadrática
            double formulaGeneral = b * b - 4 * a * c;

            if (formulaGeneral < 0)
            {
                MessageBox.Show("La ecuación cuadrática no tiene soluciones reales.", "Error de cálculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double x1 = (-b + Math.Sqrt(formulaGeneral)) / (2 * a);
            double x2 = (-b - Math.Sqrt(formulaGeneral)) / (2 * a);

            // Se muestran los resultados
            txbX1.Text = x1.ToString();
            txbX2.Text = x2.ToString();
        }

        /// <summary>
        /// Obtiene el valor double de una string
        /// este metodo fue realizado para no repetir codigo
        /// </summary>
        /// <param name="input">Valor del textbox a parsear</param>
        /// <param name="result">resultado del parseo</param>
        /// <param name="variableName">auxiliar para mostrar el textbox que dio error</param>
        /// <returns></returns>
        private bool TryParseTextBoxValue(string input, out double result, string variableName)
        {
            if (!double.TryParse(input, out result))
            {
                MessageBox.Show($"Por favor, ingrese un valor numérico para '{variableName}'.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
