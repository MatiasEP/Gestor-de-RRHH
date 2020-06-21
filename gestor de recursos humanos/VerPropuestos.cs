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
    public partial class VerPropuestos : Form
    {
        public int necesidad;
        public VerPropuestos()
        {
            InitializeComponent();
        }

        private void VerPropuestos_Load(object sender, EventArgs e)
        {
            dgrVerPropuestos.DataSource = new Necesidad().VerPropuestosDeNecesidad(necesidad);
        }

        private void dgrVerPropuestos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblNombre.Text = dgrVerPropuestos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            lblApellido.Text = dgrVerPropuestos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            txtCurriculum.Text = dgrVerPropuestos.Rows[e.RowIndex].Cells["Curriculum"].Value.ToString();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            int ID;
            Postulante aux = new Postulante();
            ID = aux.VerIDPostulante(lblNombre.Text, lblApellido.Text);
            aux.ModificarEstadoPostulante(ID, necesidad, 4);

            lblNombre.Text = "__________";
            lblApellido.Text = "__________";
            txtCurriculum.Text = "";
            dgrVerPropuestos.DataSource = new Necesidad().VerPropuestosDeNecesidad(necesidad);
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            int ID;
            Postulante aux = new Postulante();
            ID = aux.VerIDPostulante(lblNombre.Text, lblApellido.Text);
            aux.ModificarEstadoPostulante(ID, necesidad, 3);

            lblNombre.Text = "__________";
            lblApellido.Text = "__________";
            txtCurriculum.Text = "";
            dgrVerPropuestos.DataSource = new Necesidad().VerPropuestosDeNecesidad(necesidad);
        }
    }
}
