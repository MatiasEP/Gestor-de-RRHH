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
    public partial class ModificarPersonal : Form
    {
        private ControlVista controlVista;

        internal ControlVista ControlVista { get => controlVista; set => controlVista = value; }

        public DataTable DatosPersonal = new DataTable();
        public int legajo;
        public ModificarPersonal()
        {
            InitializeComponent();
        }

        private void ModificarPersonal_Load(object sender, EventArgs e)
        {
            DataRow fila = DatosPersonal.Rows[0];
            txtAltura.Text = fila["Altura"].ToString();
            txtApellido.Text = fila["Apellido"].ToString();
            txtNombre.Text = fila["Nombre"].ToString();
            txtEmail.Text = fila["Email"].ToString();
            txtLegajoSupervisor.Text = fila["LegajoSupervisor"].ToString();
            txtNumero.Text = fila["NumeroTel"].ToString();
            txtCalle.Text = fila["Calle"].ToString();

            cbxGenero.DataSource = new Genero().verGeneros();
            cbxGenero.DisplayMember = "Descripcion";
            cbxGenero.ValueMember = "ID";
            cbxGenero.Text = fila["Genero"].ToString();

            cbxProvincia.DataSource = new Provincia().VerProvincias();
            cbxProvincia.DisplayMember = "Descripcion";
            cbxProvincia.ValueMember = "ID";
            cbxProvincia.Text = fila["Provincia"].ToString();

            int provincia = (Convert.ToInt32(cbxProvincia.SelectedValue));
            cbxLocalidad.DataSource = new Localidad().VerLocalidadesEnProvincia(provincia);
            cbxLocalidad.DisplayMember = "Descripcion";
            cbxLocalidad.ValueMember = "ID";
            cbxLocalidad.Text = fila["Localidad"].ToString();

            int localidad = (Convert.ToInt32(cbxLocalidad.SelectedValue));
            cbxBarrio.DataSource = new Barrio().VerBarriosEnLocalidad(localidad);
            cbxBarrio.DisplayMember = "Descripcion";
            cbxBarrio.ValueMember = "ID";
            cbxBarrio.Text = fila["Barrio"].ToString();

            cbxCargo.DataSource = new CargoEmpleado().vercargos();
            cbxCargo.DisplayMember = "Descripcion";
            cbxCargo.ValueMember = "ID";
            cbxCargo.Text = fila["Cargo"].ToString();

            cbxTDireccion.DataSource = new TipoDireccion().VerTiposDeDireccion();
            cbxTDireccion.DisplayMember = "Descripcion";
            cbxTDireccion.ValueMember = "ID";
            cbxTDireccion.Text = fila["TipoDireccion"].ToString();

            cbxTTelefono.DataSource = new TipoTelefono().VerTiposDeTelefono();
            cbxTTelefono.DisplayMember = "Descripcion";
            cbxTTelefono.ValueMember = "ID";
            cbxTTelefono.Text = fila["TipoTelefono"].ToString();

            cbxOficina.DataSource = new Oficina().VerOficinas();
            cbxOficina.DisplayMember = "Descripcion";
            cbxOficina.ValueMember = "ID";
            cbxOficina.Text = fila["Oficina"].ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Barrio barrio = new Barrio();
                barrio.ID = Convert.ToInt32(cbxBarrio.SelectedValue);
                barrio.Descripcion = cbxBarrio.Text.ToString();
                Localidad localidad = new Localidad();
                localidad.ID = Convert.ToInt32(cbxLocalidad.SelectedValue);
                localidad.Descripcion = cbxLocalidad.Text.ToString();
                Provincia provincia = new Provincia();
                provincia.ID = Convert.ToInt32(cbxProvincia.SelectedValue);
                provincia.Descripcion = cbxProvincia.Text.ToString();
                TipoDireccion tipoDireccion = new TipoDireccion();
                tipoDireccion.ID = Convert.ToInt32(cbxTDireccion.SelectedValue);
                tipoDireccion.Descripcion = cbxTDireccion.Text.ToString();
                Direccion direccion = new Direccion();
                direccion.Calle = txtCalle.Text;
                direccion.Numero = Convert.ToInt32(txtAltura.Text);
                direccion.Barrio = barrio;
                direccion.Localidad = localidad;
                direccion.Provincia = provincia;
                direccion.TipoDireccion = tipoDireccion;
                CargoEmpleado cargo = new CargoEmpleado();
                cargo.ID = Convert.ToInt32(cbxCargo.SelectedValue);
                cargo.Descripcion = cbxCargo.Text.ToString();
                TipoTelefono tipoTelefono = new TipoTelefono();
                tipoTelefono.ID = Convert.ToInt32(cbxTTelefono.SelectedValue);
                tipoTelefono.Descripcion = cbxTTelefono.Text.ToString();
                Telefono telefono = new Telefono();
                telefono.Numero = Convert.ToInt32(txtNumero.Text);
                telefono.TipoTelefono = tipoTelefono;
                Genero genero = new Genero();
                genero.ID = Convert.ToInt32(cbxGenero.SelectedValue);
                genero.Descripcion = cbxGenero.Text.ToString();
                Oficina oficina = new Oficina();
                oficina.ID = Convert.ToInt32(cbxOficina.SelectedValue);
                oficina.Descripcion = cbxOficina.Text.ToString();
                Personal nuevo = new Personal();
                nuevo.Nombre = txtNombre.Text;
                nuevo.Apellido = txtApellido.Text;
                nuevo.Email = txtEmail.Text;
                nuevo.Genero = genero;
                nuevo.Oficina = oficina;
                nuevo.Cargo = cargo;
                nuevo.Direccion = direccion;
                nuevo.Telefono = telefono;
                nuevo.Superior = Convert.ToInt32(txtLegajoSupervisor.Text);
                nuevo.Legajo = legajo;
                nuevo.modificarPersonal();
                MessageBox.Show("Modificado Con Exito");
                
                controlVista.VerPersonal.Show();
                controlVista.Modificar.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Complete todos los campos con datos validos");
            }
        }

        private void cbxProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int provincia = (Convert.ToInt32(cbxProvincia.SelectedValue.ToString()));
            cbxLocalidad.DataSource = new Localidad().VerLocalidadesEnProvincia(provincia);
            cbxLocalidad.DisplayMember = "Descripcion";
            cbxLocalidad.ValueMember = "ID";
        }

        private void cbxLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int localidad = (Convert.ToInt32(cbxLocalidad.SelectedValue.ToString()));
            cbxBarrio.DataSource = new Barrio().VerBarriosEnLocalidad(localidad);
            cbxBarrio.DisplayMember = "Descripcion";
            cbxBarrio.ValueMember = "ID";
        }

        private void ModificarPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlVista.Modificar.Hide();
            ControlVista.VerPersonal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlVista.VerPersonal.Show();
            controlVista.Modificar.Hide();
        }
    }
}
