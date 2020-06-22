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
    public partial class AltaPersonal : Form
    {
        private ControlVista controlVista;
        internal ControlVista ControlVista { get => controlVista; set => controlVista = value; }

        public AltaPersonal()
        {
            InitializeComponent();
        }

        private void AltaPersonal_Load(object sender, EventArgs e)
        {
            cbxGenero.DataSource = new Genero().verGeneros();
            cbxGenero.DisplayMember = "Descripcion";
            cbxGenero.ValueMember = "ID";

            cbxProvincia.DataSource = new Provincia().VerProvincias();
            cbxProvincia.DisplayMember = "Descripcion";
            cbxProvincia.ValueMember = "ID";

            int provincia = (Convert.ToInt32(cbxProvincia.SelectedValue));
            cbxLocalidad.DataSource = new Localidad().VerLocalidadesEnProvincia(provincia);
            cbxLocalidad.DisplayMember = "Descripcion";
            cbxLocalidad.ValueMember = "ID";

            int localidad = (Convert.ToInt32(cbxLocalidad.SelectedValue));
            cbxBarrio.DataSource = new Barrio().VerBarriosEnLocalidad(localidad);
            cbxBarrio.DisplayMember = "Descripcion";
            cbxBarrio.ValueMember = "ID";

            cbxCargo.DataSource = new CargoEmpleado().vercargos();
            cbxCargo.DisplayMember = "Descripcion";
            cbxCargo.ValueMember = "ID";

            cbxTDireccion.DataSource = new TipoDireccion().VerTiposDeDireccion();
            cbxTDireccion.DisplayMember = "Descripcion";
            cbxTDireccion.ValueMember = "ID";

            cbxTTelefono.DataSource = new TipoTelefono().VerTiposDeTelefono();
            cbxTTelefono.DisplayMember = "Descripcion";
            cbxTTelefono.ValueMember = "ID";

            cbxOficina.DataSource = new Oficina().VerOficinas();
            cbxOficina.DisplayMember = "Descripcion";
            cbxOficina.ValueMember = "ID";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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
                telefono.Empresa = txtEmpresa.Text.ToString();
                telefono.TipoTelefono = tipoTelefono;
                Fecha fNac = new Fecha();
                fNac.Dia = Convert.ToInt32(txtNacDia.Text);
                fNac.Mes = Convert.ToInt32(txtNacMes.Text);
                fNac.Año = Convert.ToInt32(txtNacAño.Text);
                Fecha fIng = new Fecha();
                fIng.Dia = Convert.ToInt32(txtIngDia.Text);
                fIng.Mes = Convert.ToInt32(txtIngMes.Text);
                fIng.Año = Convert.ToInt32(txtIngAño.Text);
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
                nuevo.FechaNacimiento = fNac;
                nuevo.FechaIngreso = fIng;
                nuevo.Superior = Convert.ToInt32(txtLegajoSupervisor.Text);
                nuevo.Documento = int.Parse(txtDocumento.Text.ToString());
                nuevo.Contrasena = ControlVista.GetHashString(txtDocumento.Text.ToString());
                nuevo.altaPersonal();
                MessageBox.Show("Agregado Con Exito - La constraseña es Su Documento ");

                controlVista.Alta.Hide();
                controlVista.showMenu();
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

        private void AltaPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
            controlVista.Alta.Hide();
            ControlVista.Menu.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtLegajoSupervisor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Documento_Click(object sender, EventArgs e)
        {

        }

        private void cbxTDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            controlVista.Alta.Hide();
            ControlVista.Menu.Show();
        }
    }
}
