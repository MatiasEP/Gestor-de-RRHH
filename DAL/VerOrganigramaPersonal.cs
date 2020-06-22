using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class VerOrganigramaPersonal
{
    public DataTable sp_VerSupervisor(int ID)
    {
        Conexion cSupervisor = new Conexion();
        SqlParameter[] parametros = new SqlParameter[1];
        SqlParameter pSupervisado = cSupervisor.crearParametro("@ID", ID);
        parametros[0] = pSupervisado;
        return cSupervisor.LeerPorStoreProcedure("sp_VerSupervisor", parametros);
    }

    public DataTable sp_VerSupervisados(int ID)
    {
        Conexion cSupervisados = new Conexion();
        SqlParameter[] parametros = new SqlParameter[1];
        SqlParameter pSupervisor = cSupervisados.crearParametro("@ID", ID);
        parametros[0] = pSupervisor;
        return cSupervisados.LeerPorStoreProcedure("sp_VerSupervisados", parametros);
    }
}
