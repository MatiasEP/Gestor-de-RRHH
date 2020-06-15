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
    public partial class VerBusquedas : Form
    {
        private ControlVista controlVista;
        internal ControlVista ControlVista { get => controlVista; set => controlVista = value; }

        public VerBusquedas()
        {
            InitializeComponent();
        }

        private void VerBusquedas_Load(object sender, EventArgs e)
        {

        }

        private void VerBusquedas_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlVista.VerBusquedas.Hide();
            ControlVista.Menu.Show();
        }
    }
}
