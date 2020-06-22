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
    public partial class VerPostulantes : Form
    {
        private ControlVista controlVista;

        internal ControlVista ControlVista { get => controlVista; set => controlVista = value; }

        public int numeroBusqueda;//agregar el ID de busqueda
        private int postulanteID;

        public VerPostulantes()
        {
            InitializeComponent();
        }

        private void VerPostulantes_Load(object sender, EventArgs e)
        {

            btnProponerPostulante.Visible = controlVista.isRh();
            dgrVerPostulantes.DataSource = new Postulante().VerPostulantes(numeroBusqueda);
            dgrVerPostulantes.Columns["PostulanteID"].Visible = false;
        }

        private void dgrVerPostulantes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            postulanteID = int.Parse( dgrVerPostulantes.Rows[e.RowIndex].Cells["PostulanteID"].Value.ToString());
            lblNombre.Text = dgrVerPostulantes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            lblApellido.Text = dgrVerPostulantes.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            txtCurriculum.Text = dgrVerPostulantes.Rows[e.RowIndex].Cells["Curriculum"].Value.ToString();
            lblEstado.Text = dgrVerPostulantes.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
        }

        private void btnProponerPostulante_Click(object sender, EventArgs e)
        {
            Postulante aux = new Postulante();
            aux.ModificarEstadoPostulante(postulanteID, numeroBusqueda,2);

            dgrVerPostulantes.DataSource = new Postulante().VerPostulantes(numeroBusqueda);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            controlVista.VerBusquedas.Show();
            controlVista.VerPostulantes.Hide();
        }

        private void VerPostulantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlVista.VerBusquedas.Show();
            ControlVista.VerPostulantes.Hide();
        }
    }
   }
