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

        public int creador = 1; //modificar para que dependa del gerente logeado

        public CrearNecesidad()
        {
            InitializeComponent();
        }

        private void CrearNecesidad_Load(object sender, EventArgs e)
        {

        }

        private void CrearNecesidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlVista.CrearNecesidad.Hide();
            ControlVista.Menu.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(txtAsunto.Text=="" || txtNecesidad.Text=="")
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                string asunto = txtAsunto.Text;
                string necesidad = txtNecesidad.Text;
                new Necesidad().CrearNecesidad(asunto, necesidad, creador);
                MessageBox.Show("Creado con exito");
            }
        }
    }
}
