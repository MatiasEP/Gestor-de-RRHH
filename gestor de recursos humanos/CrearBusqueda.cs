﻿using System;
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
    public partial class CrearBusqueda : Form
    {
        private ControlVista controlVista;
        internal ControlVista ControlVista { get => controlVista; set => controlVista = value; }

        public int creador;//se debe agregar el ID del RRHH que esta logeado
        public int Necesidad;//aca se debe cargar el ID de la necesidad de donde procede

        public CrearBusqueda()
        {
            InitializeComponent();
        }

        private void CrearBusqueda_Load(object sender, EventArgs e)
        {
            creador = ControlVista.Personal.ID;
            Necesidad =  ControlVista.VerNecesidad.IdNecesidad;
            cbxOficina.DataSource = new Oficina().VerOficinas();
            cbxOficina.DisplayMember = "Descripcion";
            cbxOficina.ValueMember = "ID";

            DataTable necesidadAux = new Necesidad().VerNecesidadPorID(Necesidad);
            txtAsunto.Text = necesidadAux.Rows[0]["Asunto"].ToString();
            txtBusqueda.Text = necesidadAux.Rows[0]["Necesidad"].ToString();
        }

        private void CrearBusqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlVista.CrearBusqueda.Hide();
            ControlVista.VerNecesidad.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtAsunto.Text == "" || txtBusqueda.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {

                try
                {

                    string asunto = txtAsunto.Text;
                    string busqueda = txtBusqueda.Text;
                    int oficina = Convert.ToInt32(cbxOficina.SelectedValue);
                    new BusquedaRecurso().CrearBusqueda(Necesidad, asunto, busqueda, creador, oficina);
                    MessageBox.Show("Creado con exito");
                    ControlVista.VerNecesidad.Show();
                    ControlVista.CrearBusqueda.Hide();
                }
                catch (Exception ex)
                {
                MessageBox.Show("La necesidad ya posee una busqueda asociada");
                }
                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            ControlVista.VerNecesidad.Show();
            ControlVista.CrearBusqueda.Hide();
        }
    }
}
