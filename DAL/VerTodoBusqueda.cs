using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class VerTodoBusqueda
{
    public DataTable sp_VerTodoBusqueda()
    {
        return new Conexion().LeerPorStoreProcedure("sp_VerTodoBusqueda");
    }
}
