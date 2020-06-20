using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class VerPostulantes
{
    public DataTable sp_VerPostulantesEnBusqueda(int FK_Busqueda)
    {
        Conexion cPostulantes = new Conexion();
        SqlParameter[] parametros = new SqlParameter[1];
        SqlParameter cBusqueda = cPostulantes.crearParametro("@FK_Busqueda", FK_Busqueda);
        parametros[0] = cBusqueda;
        return cPostulantes.LeerPorStoreProcedure("sp_VerPostulantesEnBusqueda", parametros);
    }
}
