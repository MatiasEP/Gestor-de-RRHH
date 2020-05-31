using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class VerTodoPersonal
{
    public DataTable sp_VerTodoPersonal()
    {
        return new Conexion().LeerPorStoreProcedure("sp_VerTodoPersonal");
    }
}
