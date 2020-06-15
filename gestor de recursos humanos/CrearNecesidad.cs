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
            ControlVista.CrearNecesidad.Hide();
            ControlVista.Menu.Show();
        }
    }
}
