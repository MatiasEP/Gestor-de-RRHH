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
        private int idNecesidad;
        public int IdNecesidad { get => idNecesidad; set => idNecesidad = value; }


        public VerNecesidad()
        {
            InitializeComponent();
        }

        private void VerNecesidad_Load(object sender, EventArgs e)
        {
            dgrVerNecesidad.DataSource = new Necesidad().VerTodoNecesidad();
            dgrVerNecesidad.Columns["ID"].Visible = false;




        }

        private void VerNecesidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlVista.Menu.Show();
            ControlVista.VerNecesidad.Hide();
        }

        private void dgrVerNecesidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrVerNecesidad_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            IdNecesidad = int.Parse(dgrVerNecesidad.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            txtAsunto.Text = dgrVerNecesidad.Rows[e.RowIndex].Cells["Asunto"].Value.ToString();
            txtDescripcion.Text = dgrVerNecesidad.Rows[e.RowIndex].Cells["Necesidad"].Value.ToString();
            lblCreador.Text = dgrVerNecesidad.Rows[e.RowIndex].Cells["Creador"].Value.ToString();

        }

        internal void checkBtn()
        {
                this.btnCrearBusqueda.Visible = ControlVista.isRh();
        }
        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ControlVista.Menu.Show();
            ControlVista.VerNecesidad.Hide();
        }

        private void btnCrearBusqueda_Click(object sender, EventArgs e)
        {
            ControlVista.BusquedaRecurso = new BusquedaRecurso();

            ControlVista.CrearBusqueda = new CrearBusqueda();
            ControlVista.CrearBusqueda.ControlVista = ControlVista;
            ControlVista.CrearBusqueda.Show();
            ControlVista.VerNecesidad.Hide();

        }

        private void btnVerPropuestos_Click(object sender, EventArgs e)
        {
            ControlVista.VerPropuestos = new VerPropuestos();
            ControlVista.VerPropuestos.ControlVista = controlVista;
            ControlVista.VerPropuestos.Show();
            ControlVista.VerNecesidad.Hide();

        }
    }
}
