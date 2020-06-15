using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_de_recursos_humanos
{
    public partial class ActualizarPassword : Form
    {
        public ActualizarPassword()
        {
            InitializeComponent();
        }

        private ControlVista controlVista;

        internal ControlVista ControlVista { get => controlVista; set => controlVista = value; }

        private void cambiarPassword_Click(object sender, EventArgs e)
        {
            if (this.passDos.Text.Equals(this.passUno.Text))
            {
                if (!this.passUno.Text.Equals(ControlVista.Personal.Documento.ToString())) 
                {
                    controlVista.Personal.Contrasena = ControlVista.GetHashString(this.passUno.Text);
                    controlVista.Personal.modificarPassword();
                    controlVista.ActualizarPassword.Hide();
                    controlVista.ActualizarPassword.passUno.Text = "";
                    controlVista.ActualizarPassword.passDos.Text = "";
                    MessageBox.Show("Password actualizado con exito");
                    controlVista.Login.Show();
                }
                else {
                    MessageBox.Show("Se debe usar un password diferente al documento");
                }
            }
            else {
                MessageBox.Show("los passwords ingresados no coinciden");
            }
             
        }
    }
}
