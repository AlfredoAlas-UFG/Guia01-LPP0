using System.Windows.Forms;

namespace Ejemplo_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresarbtn_Click(object sender, System.EventArgs e)
        {
            listNumbers.Items.Add(valorTxb.Text);
            valorTxb.Clear();
            valorTxb.Focus();
        }

        private void mostrar1_Click(object sender, System.EventArgs e)
        {
            int mayorneg = -1000;
            for (int i = 0; i < listNumbers.Items.Count; i++)
            {
                string valor = listNumbers.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero < 0 && numero % 2 == 0)
                {
                    if (numero > mayorneg)
                    {
                        mayorneg = numero;
                        mayorNegativotxb.Text = mayorneg.ToString();
                    }
                }
                else
                {
                    mayorNegativotxb.Text = "No hay números negativos pares";
                }
            }
        }

        private void mostrar2_Click(object sender, System.EventArgs e)
        {
            double cantidadnumeros = listNumbers.Items.Count;
            double cantidadceros = 0;
            double porcentaje = 0;
            for (int i = 0; i < listNumbers.Items.Count; i++)
            {
                string valor = listNumbers.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 0)
                {
                    cantidadceros = cantidadceros + 1;
                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100;
            porcentajeCerostxb.Text = porcentaje.ToString() + "%";
        }

        private void mostrar3_Click(object sender, System.EventArgs e)
        {
            double prom;
            double cantidadimpares = 0;
            double suma = 0;
            for (int i = 0; i < listNumbers.Items.Count; i++)
            {
                string valor = listNumbers.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 != 0)
                {
                    suma = suma + numero;
                    cantidadimpares = cantidadimpares + 1;
                }
            }
            prom = suma / cantidadimpares;
            promedioImparestxb.Text = prom.ToString();
        }

        private void mostrar4_Click(object sender, System.EventArgs e)
        {
            int mayor = 0;
            for (int i = 0; i < listNumbers.Items.Count; i++)
            {
                string valor = listNumbers.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 == 0)
                {
                    if (numero > mayor)
                        mayor = numero;
                }
            }
            mayorPositivotxb.Text = mayor.ToString();
        }
    }
}
