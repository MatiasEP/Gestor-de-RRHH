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
    public partial class VerPersonal : Form
    {
        public DataTable PersonalSeleccionado = new DataTable();
        string seleccionado;
        public VerPersonal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgrVerPersonal.DataSource = new Personal().VerTodoPersonal();
        }


        private void dgrVerPersonal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = dgrVerPersonal.Rows[e.RowIndex].Cells[0].Value.ToString();
            PersonalSeleccionado = new Personal().VerInformacionCompleta(seleccionado);
            DataRow fila = PersonalSeleccionado.Rows[0];
            lblAltura.Text = fila["Altura"].ToString();
            lblApellido.Text = fila["Apellido"].ToString();
            lblNombre.Text = fila["Nombre"].ToString();
            lblLegajo.Text = fila["Legajo"].ToString();
            lblGenero.Text = fila["Genero"].ToString();
            lblFnac.Text = fila["FechaNacimiento"].ToString();
            lblEmail.Text = fila["Email"].ToString();
            lblCargo.Text = fila["Cargo"].ToString();
            lblFing.Text = fila["FechaIngreso"].ToString();
            lblLegSup.Text = fila["LegajoSupervisor"].ToString();
            lblLocalidad.Text = fila["Localidad"].ToString();
            lblNtel.Text = fila["NumeroTel"].ToString();
            lblOficina.Text = fila["Oficina"].ToString();
            lblProvincia.Text = fila["Provincia"].ToString();
            lblTdir.Text = fila["TipoDireccion"].ToString();
            lblTtel.Text = fila["TipoTelefono"].ToString();
            lblBarrio.Text = fila["Barrio"].ToString();
            lblCalle.Text = fila["Calle"].ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ModificarPersonal modificar = new ModificarPersonal();
                modificar.legajo = Convert.ToInt32(seleccionado);
                modificar.DatosPersonal = PersonalSeleccionado;
                modificar.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Seleccione un empleado a modificar");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Personal borrar = new Personal();
            try
            {
                borrar.DesvincularPersonal(Convert.ToInt32(seleccionado));
                MessageBox.Show("Borrado con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un Empleado a desvincular");
            }
            dgrVerPersonal.DataSource = new Personal().VerTodoPersonal();
        }
    }
}
