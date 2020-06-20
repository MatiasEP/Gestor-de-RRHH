using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestor_de_recursos_humanos
{
    public partial class Login : Form
    {
        ControlVista controlVista;
        public Login()
        {
            InitializeComponent();
            controlVista = new ControlVista();
            controlVista.Login = this;
        }

        internal void limpiarDatos()
        {
            txtLegajo.Text = "";
            txtContrasena.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            DataTable resultado = new DataTable();
            try
            {
                string hashPassword = ControlVista.GetHashString(txtContrasena.Text);

                resultado = personal.ComprobarUsuario(txtLegajo.Text, hashPassword);
                

                string hashDocument = ControlVista.GetHashString(personal.Documento.ToString());

                if (!hashDocument.Equals(personal.Contrasena))
                {
                    DataRow row = resultado.Rows[0];
                    MessageBox.Show("Nombre: " + row["Nombre"].ToString() + "\nApellido: " + row["Apellido"].ToString());
                    controlVista.Personal = personal;
                    controlVista.Login.limpiarDatos();
                    controlVista.Login.Hide();
                    controlVista.showMenu();
                }
                else 
                {
                    DataRow row = resultado.Rows[0];
                    MessageBox.Show("Nombre: " + row["Nombre"].ToString() + "\nApellido: " + row["Apellido"].ToString());
                    controlVista.Personal = personal;
                    controlVista.Login.limpiarDatos();
                    controlVista.Login.Hide();
                    controlVista.showActualizarPassword();
                }

            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Ingrese Informacion valida");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form test = new VerPostulantes();
            test.Show();
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
