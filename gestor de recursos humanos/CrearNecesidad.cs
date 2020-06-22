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
    public partial class CrearNecesidad : Form
    {
        private ControlVista controlVista;
        internal ControlVista ControlVista { get => controlVista; set => controlVista = value; }

        public CrearNecesidad()
        {
            InitializeComponent();
        }

        private void CrearNecesidad_Load(object sender, EventArgs e)
        {

        }

        private void CrearNecesidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlVista.Menu.Show();
            ControlVista.CrearNecesidad.Hide();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(txtAsunto.Text=="" || txtNecesidad.Text=="")
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                try
                {

                    string asunto = txtAsunto.Text;
                    string necesidad = txtNecesidad.Text;
                    new Necesidad().CrearNecesidad(asunto, necesidad, ControlVista.Personal.ID);
                    MessageBox.Show("Creado con exito");
                    ControlVista.Menu.Show();
                    ControlVista.CrearNecesidad.Hide();
                }
                catch (Exception ex) {
                    MessageBox.Show("Ocurrio un error - consulte en RH");
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ControlVista.Menu.Show();
            ControlVista.CrearNecesidad.Hide();
        }
    }
}
