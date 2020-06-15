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
    public partial class MenuGestor : Form
    {
        private ControlVista controlVista;

        internal ControlVista ControlVista { get => controlVista; set => controlVista = value; }

        public MenuGestor()
        {
            InitializeComponent();
        }

        private void btn_show_org_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_nesec_Click(object sender, EventArgs e)
        {

        }

        private void btn_show_nesec_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_find_resource_Click(object sender, EventArgs e)
        {

        }

        private void btn_show_find_resouce_Click(object sender, EventArgs e)
        {
            controlVista.showVerEmpleado();
        }

        internal void verDatos()
        {
            legajoActual.Text = controlVista.Personal.Legajo.ToString();
            cargoActual.Text = controlVista.Personal.Cargo.Descripcion;
        }

        private void btn_regist_empl_Click(object sender, EventArgs e)
        {
            controlVista.showAlta();
        }

        private void btn_show_empl_Click(object sender, EventArgs e)
        {
            controlVista.showVerEmpleado();
        }

        private void btn_sign_out_Click(object sender, EventArgs e)
        {
            controlVista.showLogin();
        }

        private void MenuGestor_Load(object sender, EventArgs e)
        {

        }

        private void MenuGestor_FormClosed(object sender, FormClosedEventArgs e)
        {
            controlVista.showLogin();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
