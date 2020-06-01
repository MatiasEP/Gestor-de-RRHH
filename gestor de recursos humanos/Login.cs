using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestor_de_recursos_humanos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            DataTable resultado = new DataTable();
            try
            {
                resultado = personal.ComprobarUsuario(txtLegajo.Text, txtContraseña.Text);
                DataRow row = resultado.Rows[0];
                MessageBox.Show("Nombre: "+ row["Nombre"].ToString()+"\nApellido: "+row["Apellido"].ToString());
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Ingrese Informacion valida");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerPersonal test = new VerPersonal();
            test.Show();
            AltaPersonal test2 = new AltaPersonal();
            test2.Show();
        }
    }
}
