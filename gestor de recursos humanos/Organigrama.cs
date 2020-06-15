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
    public partial class Organigrama : Form
    {
        private ControlVista controlVista;
        internal ControlVista ControlVista { get => controlVista; set => controlVista = value; }

        public Organigrama()
        {
            InitializeComponent();
        }

        private void Organigrama_Load(object sender, EventArgs e)
        {

        }

        private void Organigrama_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlVista.Organigrama.Hide();
            ControlVista.Menu.Show();
        }
    }
}
