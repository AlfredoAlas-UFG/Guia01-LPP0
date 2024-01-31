using System.Windows.Forms;

namespace Analisis_Desarrollo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento click que evalua los descuentos a realizar
        /// </summary>
        /// <param name="sender">Objeto que disparo el evento</param>
        /// <param name="e">argumentos del evento</param>
        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            string nombre = $"{tbNombre.Text} {tbApellido.Text}";
            decimal salarioBruto;

            //Se evalua que el dato de entrada 'salario' sea decimal
            if (!decimal.TryParse(tbSalarioBruto.Text, out salarioBruto))
            {
                MessageBox.Show("Ingrese un salario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal porcentajeDescuento = 0;

            // Se evalua el tipo de descuento a realizar
            if (cbGerente.Checked)
                porcentajeDescuento = 20;
            else if (cbSubgerente.Checked)
                porcentajeDescuento = 15;
            else if (cbSecretaria.Checked)
                porcentajeDescuento = 5;
            else
            {
                MessageBox.Show("Por favor seleccione el puesto que desempeña.");
                return;
            }

            // Se realizan los calculos
            decimal montoDescuento = salarioBruto * (porcentajeDescuento / 100);
            decimal salarioNeto = salarioBruto - montoDescuento;

            string mensaje = $"Nombre: {nombre}\n";
            mensaje += $"Tipo de empleado: {(cbGerente.Checked ? "Gerente" : (cbSubgerente.Checked ? "Subgerente" : "Secretaria"))}\n";
            mensaje += $"Salario bruto: {salarioBruto:C}\n";
            mensaje += $"Descuento ({porcentajeDescuento}%): {montoDescuento:C}\n";
            mensaje += $"Salario neto: {salarioNeto:C}";

            tbMontoDescuento.Text = montoDescuento.ToString("C");
            tbSalarioNeto.Text = salarioNeto.ToString("C");

            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
