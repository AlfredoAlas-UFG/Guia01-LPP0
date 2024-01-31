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
    public partial class frmVentana : Form
    {
        public frmVentana()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string texto = txtnombre.Text;
            //MessageBox.Show("Bienvenido a LPP0 " + texto + " este es tu primer formulario.");
            string mensaje = string.Format("Bienvenido al segundo formulario " + texto);
            Form2 frmrecibe = new Form2(mensaje); /* creo un objeto del segundo formulario, adonde mando información*/ frmrecibe.Visible = true; // muestra el nuevo formulario 
            this.Visible = false; // esconde el formulario actual
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
