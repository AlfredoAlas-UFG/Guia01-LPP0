using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;

namespace G1_Ejemplo03
{
    public partial class Form1 : Form
    {
        string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            string usuario = txtbuser.Text;
            string contra = txtbpass.Text;
            string url = "C:\\ProyectosPersonales\\LPP0\\" + usuario + ".txt"; //usted elige ubicación de carpeta, la que hizo en el paso 3, pero esta debe existir
            if (File.Exists(url)) //verifica que el archive exista 
            {
                MessageBox.Show("ERROR. ¡Usuario ya existe!"); //usuario registrado 
                txtbuser.Clear(); //limpiamos todos los textbox
                txtbpass.Clear();
            }
            else
            {
                File.WriteAllText(url, contra); /*Crea un Nuevo archivo con ese nombre y guarda dentro del archivo el valor del segundo parámetro*/
                MessageBox.Show("Usuario Registrado con éxito"); txtbuser.Clear(); txtbpass.Clear();
            }
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            string usuario = txtbuser.Text; //capturamos los valores de usuario y contraseña
            string contra = txtbpass.Text;
            string url = "C:\\ProyectosPersonales\\LPP0\\" + usuario + ".txt";
            if (File.Exists(url)) //verifica si existe 
            {
                password = File.ReadAllText(url); //lee el texto almacenado dentro del archivo 
                if (contra.Equals(password)) //verifica si contraseña es igual al archivo 
                {
                    MessageBox.Show("¡Ingreso exitoso, bienvenido!"); //login exitoso 
                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta! ");//login fallido 
                }
            }
            else
            {
                MessageBox.Show("¡Usuario incorrecto! "); //usuario incorrecto
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
