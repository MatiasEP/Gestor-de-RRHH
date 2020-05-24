using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class personal
{
    public DataTable ComprobarUsuario(string legajo, string contraseña)
    {
        Conexion cPersonal = new Conexion();
        SqlParameter[] parametros = new SqlParameter[2];
        SqlParameter pUsuario = cPersonal.crearParametro("@Legajo", legajo);
        SqlParameter pContraseña = cPersonal.crearParametro("@Contraseña", contraseña);
        parametros[0] = pUsuario;
        parametros[1] = pContraseña;
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