using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class personal
{
    public DataTable ComprobarUsuario(string legajo, string contrasena)
    {
        Conexion cPersonal = new Conexion();
        SqlParameter[] parametros = new SqlParameter[2];
        SqlParameter pLegajo = cPersonal.crearParametro("@Legajo", legajo);
        SqlParameter pContrasena = cPersonal.crearParametro("@Contrasena", contrasena);
        parametros[0] = pLegajo;
        parametros[1] = pContrasena;
        return cPersonal.LeerPorStoreProcedure("sp_ComprobarUsuario", parametros);
    }

    public DataTable TraerInformacionCompleta( string legajo)
    {
        Conexion cPersonal = new Conexion();
        SqlParameter[] parametros = new SqlParameter[1];
        SqlParameter pUsuario = cPersonal.crearParametro("@Legajo", legajo);
        parametros[0] = pUsuario;
        return cPersonal.LeerPorStoreProcedure("sp_InformacionCompleta", parametros);
    }
}