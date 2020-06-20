using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class VerTodoNecesidad
{
    public DataTable sp_VerTodoNecesidad()
    {
        return new Conexion().LeerPorStoreProcedure("sp_VerTodoNecesidad");
    }
}
