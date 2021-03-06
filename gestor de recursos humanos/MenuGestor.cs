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
    public partial class MenuGestor : Form
    {
        private readonly int CARGO_GERENTE = 1;
        private readonly int CARGO_RH = 2;
        private readonly int CARGO_EMPLEADO = 3;

        private ControlVista controlVista;
        internal ControlVista ControlVista { get => controlVista; set => controlVista = value; }

        public MenuGestor()
        {
            InitializeComponent();
        }

        private void btn_show_org_Click(object sender, EventArgs e)
        {
            ControlVista.ShowOrganigrama();

        }

        private void btn_new_nesec_Click(object sender, EventArgs e)
        {
            ControlVista.showCrearNecesidad();
        }

        private void btn_show_nesec_Click(object sender, EventArgs e)
        {
            
            ControlVista.showVerNecesidad();
        }

        private void btn_new_find_resource_Click(object sender, EventArgs e)
        {

            ControlVista.CrearBusqueda = new CrearBusqueda();
            ControlVista.CrearBusqueda.ControlVista = ControlVista;
            ControlVista.Menu.Hide();
            ControlVista.CrearBusqueda.Show();
        }

        private void btn_show_find_resouce_Click(object sender, EventArgs e)
        {
            ControlVista.showVerBusquedas();
        }


        private void btn_regist_empl_Click(object sender, EventArgs e)
        {
            controlVista.showAlta();
        }

        private void btn_show_empl_Click(object sender, EventArgs e)
        {
            controlVista.showVerEmpleado();
        }

        private void btn_sign_out_Click(object sender, EventArgs e)
        {
            controlVista.showLogin();
        }

        private void MenuGestor_Load(object sender, EventArgs e)
        {
            
            /**
             * btn_show_org ver         organizagra
             * btn_new_nesec            crear necesidad
             * btn_show_nesec           visualizar necesidad
             * btn_new_find_resource    crear busqueda de recurso
             * btn_show_find_resouce    ver busqueda de recurso
             * btn_regist_empl          ver registro de empleado
             * btn_show_empl            ver empleado
             * 
             * 
             * */

            hideBtn();
            if (controlVista.isGerente() | controlVista.isRh() | controlVista.isEmpleado() ) btn_show_org.Enabled = true;
            if (controlVista.isGerente()                                                   ) btn_new_nesec.Enabled = true;
            if (controlVista.isGerente() | controlVista.isRh()                             ) btn_show_nesec.Enabled = true;
            //   if (               controlVista.isRh()                                    ) btn_new_find_resource.Enabled = true;
            if (                           controlVista.isRh()                             ) btn_show_find_resouce.Enabled = true;
            if (                           controlVista.isRh()                             ) btn_regist_empl.Enabled = true;
            if (                           controlVista.isRh()                             ) btn_show_empl.Enabled = true;



        }



        private void hideBtn()
        {
            btn_show_org.Enabled = false;
            btn_new_nesec.Enabled = false;
            btn_show_nesec.Enabled = false;
            btn_regist_empl.Enabled = false;
            btn_show_empl.Enabled = false;
            btn_show_find_resouce.Enabled = false;

        }

        private void MenuGestor_FormClosed(object sender, FormClosedEventArgs e)
        {
            controlVista.showLogin();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
