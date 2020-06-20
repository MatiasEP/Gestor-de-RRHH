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

        public int busqueda;
        public VerBusquedas()
        {
            InitializeComponent();
        }

        private void VerBusquedas_Load(object sender, EventArgs e)
        {
            dgrVerBusqueda.DataSource = new BusquedaRecurso().VerTodoBusqueda();
        }

        private void VerBusquedas_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlVista.VerBusquedas.Hide();
            ControlVista.Menu.Show();
        }

        private void dgrVerBusqueda_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAsunto.Text = dgrVerBusqueda.Rows[e.RowIndex].Cells["Asunto"].Value.ToString();
            txtDescripcion.Text = dgrVerBusqueda.Rows[e.RowIndex].Cells["Busqueda"].Value.ToString();
            lblOficina.Text = dgrVerBusqueda.Rows[e.RowIndex].Cells["Oficina"].Value.ToString();
            lblCreador.Text = dgrVerBusqueda.Rows[e.RowIndex].Cells["Creador"].Value.ToString();
            busqueda = Convert.ToInt32(dgrVerBusqueda.Rows[e.RowIndex].Cells["Numero"].Value);
        }

        private void btnVerPostulantes_Click(object sender, EventArgs e)
        {
            ControlVista.VerPostulantes = new VerPostulantes();

            ControlVista.VerPostulantes.ControlVista = ControlVista;
            ControlVista.VerPostulantes.numeroBusqueda = busqueda;

            this.Hide();
            ControlVista.VerPostulantes.Show();
        }
    }
}
