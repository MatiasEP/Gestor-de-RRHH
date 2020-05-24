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
    public partial class Form2 : Form
    {
        public DataTable DatosLogeado = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataRow fila = DatosLogeado.Rows[0];
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
    }
}
