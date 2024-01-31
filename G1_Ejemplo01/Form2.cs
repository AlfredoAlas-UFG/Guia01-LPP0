using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G1_Ejemplo01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string textx)
        {
            InitializeComponent(); lbrecibido.Text = textx; // Asignamos lo recibido al label
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            frmVentana form1 = new frmVentana(); //instanciamos al primer formulario 
            this.Close(); //cerramos el formulario actual 
            form1.Visible = true; //hacemos visible al form1 de nuevo
        }
    }
}
