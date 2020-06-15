using System;
using System.Security.Cryptography;
using System.Text;

namespace gestor_de_recursos_humanos
{
    internal class ControlVista
    {
        private Personal personal;
        private Login login;
        private MenuGestor menu;
        private AltaPersonal alta;
        private VerPersonal verPersonal;
        private ModificarPersonal modificar;
        private ActualizarPassword actualizarPassword;
        private Organigrama organigrama;
        private VerNecesidad verNecesidad;
        private VerBusquedas verBusquedas;
        private CrearNecesidad crearNecesidad;
        private CrearBusqueda crearBusqueda;


        public ControlVista()
        {
        }

        public Login Login { get => login; set => login = value; }
        public Personal Personal { get => personal; set => personal = value; }
        public VerPersonal VerPersonal { get => verPersonal; set => verPersonal = value; }
        public ModificarPersonal Modificar { get => modificar; set => modificar = value; }
        public MenuGestor Menu { get => menu; set => menu = value; }
        public AltaPersonal Alta { get => alta; set => alta = value; }
        public ActualizarPassword ActualizarPassword { get => actualizarPassword; set => actualizarPassword = value; }
        public Organigrama Organigrama { get => organigrama; set => organigrama = value; }
        public VerNecesidad VerNecesidad { get => verNecesidad; set => verNecesidad = value; }
        public VerBusquedas VerBusquedas { get => verBusquedas; set => verBusquedas = value; }
        public CrearNecesidad CrearNecesidad { get => crearNecesidad; set => crearNecesidad = value; }
        public CrearBusqueda CrearBusqueda { get => crearBusqueda; set => crearBusqueda = value; }

        internal void showMenu()
        {
            menu = new MenuGestor();
            menu.ControlVista = this;
            menu.verDatos();
            menu.Show();
        }
        internal void showActualizarPassword()
        {
            actualizarPassword = new ActualizarPassword();
            actualizarPassword.ControlVista = this;
            actualizarPassword.Show();
        }

        public void showLogin()
        {
            menu.Hide();
            login.Show();
        }

        internal void showAlta()
        {
            menu.Hide();
            alta = new AltaPersonal();
            alta.ControlVista = this;
            alta.Show();
        }

        internal void showVerEmpleado()
        {
            menu.Hide();
            verPersonal = new VerPersonal();
            verPersonal.ControlVista = this;
            verPersonal.Show();
        }

      

            public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
}
}