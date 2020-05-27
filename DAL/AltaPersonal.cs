using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class AltaPersonal
{
    public bool sp_ComprobarSiExistePersonal(string Nombre, string Apellido, string Email)
    {
        Conexion aPersonal = new Conexion();
        SqlParameter[] parametros = new SqlParameter[3];
        SqlParameter pNombre = aPersonal.crearParametro("@Nombre",Nombre);
        SqlParameter pApellido = aPersonal.crearParametro("@Apellido",Apellido);
        SqlParameter pEmail = aPersonal.crearParametro("@Email",Email);
        parametros[0] = pNombre;
        parametros[1] = pApellido;
        parametros[2] = pEmail; 
        DataTable tabla  = aPersonal.LeerPorStoreProcedure("sp_ComprobarSiExisteElPersonal", parametros);
        if (tabla.Rows.Count == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void sp_AltaPersonal(string nombre, string apellido, string email, int genero, string fNac, string fIng, string calle, int altura, int tipoDireccion, int barrio, int cargo, int oficina, int tipoTel, int numeroTel, string empresaTel, int supervisor, string contraseña)
    {
        Conexion aPersonal = new Conexion();
        SqlParameter[] parametros = new SqlParameter[17];
        SqlParameter pNombre = aPersonal.crearParametro("@Nombre", nombre);
        SqlParameter pApellido = aPersonal.crearParametro("@Apellido", apellido);
        SqlParameter pEmail = aPersonal.crearParametro("@Email", email);
        SqlParameter pGenero = aPersonal.crearParametro("@Genero", genero);
        SqlParameter pfNac = aPersonal.crearParametro("@FechaNacimiento", fNac);
        SqlParameter pfIng = aPersonal.crearParametro("@FechaIngreso", fIng);
        SqlParameter pCalle = aPersonal.crearParametro("@Calle", calle);
        SqlParameter pAltura = aPersonal.crearParametro("@Altura", altura);
        SqlParameter ptDireccion = aPersonal.crearParametro("@FK_TipoDireccion", tipoDireccion);
        SqlParameter pBarrio = aPersonal.crearParametro("@FK_Barrio", barrio);
        SqlParameter pCargo = aPersonal.crearParametro("@FK_Cargo", cargo);
        SqlParameter pOficina = aPersonal.crearParametro("@FK_Oficina", oficina);
        SqlParameter ptTel = aPersonal.crearParametro("@FK_TipoTelefono", tipoTel);
        SqlParameter pnTel = aPersonal.crearParametro("@NumeroTelefono", numeroTel);
        SqlParameter peTel = aPersonal.crearParametro("@EmpresaTelefono", empresaTel);
        SqlParameter pSupervisor = aPersonal.crearParametro("@FK_Supervisor", supervisor);
        SqlParameter pContraseña = aPersonal.crearParametro("@Contraseña", contraseña);
        parametros[0] = pNombre;
        parametros[1] = pApellido;
        parametros[2] = pEmail;
        parametros[3] = pGenero;
        parametros[4] = pfNac;
        parametros[5] = pfIng;
        parametros[6] = pCalle;
        parametros[7] = pAltura;
        parametros[8] = ptDireccion;
        parametros[9] = pBarrio;
        parametros[10] = pCargo;
        parametros[11] = pOficina;
        parametros[12] = ptTel;
        parametros[13] = pnTel;
        parametros[14] = peTel;
        parametros[15] = pSupervisor;
        parametros[16] = pContraseña;
        aPersonal.LeerPorStoreProcedure("sp_AltaPersonal", parametros);
    }
}
