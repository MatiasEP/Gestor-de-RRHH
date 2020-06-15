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
    public void sp_AltaPersonal(string nombre, string apellido, int documento, string email, int genero, string fNac, string fIng, string calle, int altura, int tipoDireccion, int barrio, int cargo, int oficina, int tipoTel, int numeroTel, string empresaTel, int supervisor, string contrasena)
    {
        Conexion aPersonal = new Conexion();
        SqlParameter[] parametros = new SqlParameter[18];
        SqlParameter pNombre = aPersonal.crearParametro("@Nombre", nombre);
        SqlParameter pApellido = aPersonal.crearParametro("@Apellido", apellido);
        SqlParameter pDocumento = aPersonal.crearParametro("@Documento", documento);
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
        SqlParameter pContrasena = aPersonal.crearParametro("@Contrasena", contrasena);
        parametros[0] = pNombre;
        parametros[1] = pApellido;
        parametros[2] = pDocumento;
        parametros[3] = pEmail;
        parametros[4] = pGenero;
        parametros[5] = pfNac;
        parametros[6] = pfIng;
        parametros[7] = pCalle;
        parametros[8] = pAltura;
        parametros[9] = ptDireccion;
        parametros[10] = pBarrio;
        parametros[11] = pCargo;
        parametros[12] = pOficina;
        parametros[13] = ptTel;
        parametros[14] = pnTel;
        parametros[15] = peTel;
        parametros[16] = pSupervisor;
        parametros[17] = pContrasena;
        aPersonal.LeerPorStoreProcedure("sp_AltaPersonal", parametros);
    }
}
