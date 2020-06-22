using System;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Text;

namespace gestor_de_recursos_humanos
{
    internal class ControlVista
    {
        public readonly int CARGO_GERENTE = 1;
        public readonly int CARGO_RH = 2;
        public readonly int CARGO_EMPLEADO = 3;
        private readonly string SESSIONINICIADA = "Sesión iniciada - ";
        private readonly string VISUALIZARPERSONAL = "Visualizar personal - ";
        private readonly string REGISTRARPERSONAL = "Registrar personal - ";
        private readonly string MODIFICARPERSONAL = "Modificar personal - ";
        private readonly string CREARNECESIDAD = "Crear Necesidad - ";
        private readonly string CREAREMPLEADO = "Crear Empleado - ";
        private readonly string VISUALIZARNECESIDAD = "Visualizar Necesidad - ";



        private readonly string CREARBUSQUEDA = "Crear busqueda - ";
        private readonly string VISUALIZARBUSQUEDA = "Visualizar busqueda - ";


        private readonly string VISUALIZARPOSTULANTE = "Visualizar postulante - ";
        private readonly string CREARPOSTULANTE = "Crear postulante - ";

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
        private VerPostulantes verPostulantes;
        private VerPropuestos verPropuestos;
        internal BusquedaRecurso BusquedaRecurso;


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
        public VerPostulantes VerPostulantes { get => verPostulantes; set => verPostulantes = value; }
        public VerPropuestos VerPropuestos { get => verPropuestos; set => verPropuestos = value; }

        internal void showMenu()
        {
            menu = new MenuGestor();
            menu.ControlVista = this;
            menu.Text = SESSIONINICIADA+ cargoText();
            menu.Show();
            menu.Location = login.Location;
        }
        internal void ShowOrganigrama()
        {
            Organigrama = new Organigrama();
            Organigrama.ControlVista = this;
            Organigrama.ID = Personal.ID;
            Organigrama.Show();
            Organigrama.Hide();
            Organigrama.Location = login.Location;
        }

        internal void showCrearNecesidad()
        {
            CrearNecesidad = new CrearNecesidad();
            CrearNecesidad.ControlVista = this;
            CrearNecesidad.Text = CREARNECESIDAD + cargoText();
            CrearNecesidad.Show();
            Menu.Hide();
            crearNecesidad.Location = login.Location;
        }
        internal void showVerBusquedas()
        {
            VerBusquedas = new VerBusquedas();
            VerBusquedas.ControlVista = this;
            VerBusquedas.Text = VISUALIZARBUSQUEDA + cargoText();
            VerBusquedas.Show();
            Menu.Hide();
            VerBusquedas.Location = login.Location;
        }
        internal void showVerNecesidad()
        {
            VerNecesidad = new VerNecesidad();
            VerNecesidad.ControlVista = this;
            VerNecesidad.Show();
            Menu.Hide();
            VerNecesidad.Text = VISUALIZARNECESIDAD + cargoText();
            VerNecesidad.checkBtn();
            VerNecesidad.Location = login.Location;
        }

        private string cargoText()
        {
            if (isRh()) { return "RRHH"; }
            if (isGerente()) { return "Gerente"; }
            if (isEmpleado()) { return "Empleado"; }

            return "";
        }

        internal void showActualizarPassword()
        {
            actualizarPassword = new ActualizarPassword();
            actualizarPassword.ControlVista = this;
            actualizarPassword.Show();
            actualizarPassword.Location = login.Location;
        }

        public void showLogin()
        {
            login.Show();
            menu.Hide();

        }

        internal void showAlta()
        {
            alta = new AltaPersonal();
            alta.ControlVista = this;
            alta.Text = CREAREMPLEADO + cargoText();
            alta.Show();
            menu.Hide();
            alta.Location = login.Location;
        }

        internal void showVerEmpleado()
        {
            verPersonal = new VerPersonal();
            verPersonal.Text = VISUALIZARPERSONAL + cargoText();
            verPersonal.ControlVista = this;
            verPersonal.Show();
            menu.Hide();
            VerPersonal.Location = login.Location;
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

        public bool isEmpleado()
        {
            return Personal.Cargo.ID.Equals(CARGO_EMPLEADO);
        }

        public bool isRh()
        {
            return Personal.Cargo.ID.Equals(CARGO_RH);
        }

        public bool isGerente()
        {
            return Personal.Cargo.ID.Equals(CARGO_GERENTE);
        }
    }
}