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
    public partial class Organigrama : Form
    {
        private ControlVista controlVista;
        internal ControlVista ControlVista { get => controlVista; set => controlVista = value; }

        public int ID ;
        public Organigrama()
        {
            InitializeComponent();
        }

        private void Organigrama_Load(object sender, EventArgs e)
        {
            dgrSupervisor.DataSource = new OrganigramaPersonal().VerSupervisor(ID);            
            if(dgrSupervisor.Rows.Count == 0)
            {
                dgrSupervisor.Hide();
                lblSupervisor.Show();
            }
            dgrSupervisados.DataSource = new OrganigramaPersonal().VerSupervisados(ID);
            if (dgrSupervisados.Rows.Count == 0)
            {
                dgrSupervisados.Hide();
                lblSupervisados.Show();
            }
        }

        private void Organigrama_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlVista.Organigrama.Hide();
            ControlVista.Menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlVista.Organigrama.Hide();
            ControlVista.Menu.Show();
            ControlVista.Menu.Location = ControlVista.Organigrama.Location;
        }
    }
}
