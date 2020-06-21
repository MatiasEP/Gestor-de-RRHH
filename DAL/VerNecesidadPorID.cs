using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class VerNecesidadPorID
{
    public DataTable sp_VerNecesidadPorID(int ID)
    {
        Conexion cNecesidad = new Conexion();
        SqlParameter[] parametros = new SqlParameter[1];
        SqlParameter pID =  cNecesidad.crearParametro("@ID", ID);
        parametros[0] = pID;
        return cNecesidad.LeerPorStoreProcedure("sp_VerNecesidadPorID", parametros);
    }
}
