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
    public partial class VerNecesidad : Form
    {
        private ControlVista controlVista;
        internal ControlVista ControlVista { get => controlVista; set => controlVista = value; }

        private int ID;
        public VerNecesidad()
        {
            InitializeComponent();
            controlVista = new ControlVista();
            controlVista.VerNecesidad = this;
        }

        private void VerNecesidad_Load(object sender, EventArgs e)
        {
            dgrVerNecesidad.DataSource = new Necesidad().VerTodoNecesidad();
            if(ControlVista.Personal.Cargo.ID == 1)
            {
                btnCrearBusqueda.Hide();
            }
            if (ControlVista.Personal.Cargo.ID == 2)
            {
                btnVerPropuestos.Hide();
            }
        }

        private void VerNecesidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlVista.VerNecesidad.Hide();
            ControlVista.Menu.Show();
        }

        private void dgrVerNecesidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrVerNecesidad_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAsunto.Text = dgrVerNecesidad.Rows[e.RowIndex].Cells["Asunto"].Value.ToString();
            txtDescripcion.Text = dgrVerNecesidad.Rows[e.RowIndex].Cells["Necesidad"].Value.ToString();
            lblCreador.Text = dgrVerNecesidad.Rows[e.RowIndex].Cells["Creador"].Value.ToString();
            ID = Convert.ToInt32(dgrVerNecesidad.Rows[e.RowIndex].Cells["N°"].Value);
        }

        private void btnVerPropuestos_Click(object sender, EventArgs e)
        {
            ControlVista.VerPropuestos = new VerPropuestos();

            ControlVista.CrearBusqueda.ControlVista = ControlVista;
            ControlVista.VerPropuestos.necesidad = ID;

            this.Hide();
            ControlVista.VerPropuestos.Show();
        }

        private void btnCrearBusqueda_Click(object sender, EventArgs e)
        {
            ControlVista.CrearBusqueda = new CrearBusqueda();

            ControlVista.CrearBusqueda.ControlVista = ControlVista;
            ControlVista.CrearBusqueda.Necesidad = ID;
            ControlVista.CrearBusqueda.creador = ControlVista.Personal.ID;

            this.Hide();
            ControlVista.CrearBusqueda.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ControlVista.showMenu();
            this.Hide();
        }
    }
}
