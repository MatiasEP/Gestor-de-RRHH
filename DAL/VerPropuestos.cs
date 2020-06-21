using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class VerPropuestos
{
    public DataTable sp_VerPropuestosDeNecesidad(int Necesidad)
    {
        Conexion cPostulantes = new Conexion();
        SqlParameter[] parametros = new SqlParameter[1];
        SqlParameter pNecesidad = cPostulantes.crearParametro("@ID", Necesidad);
        parametros[0] = pNecesidad;
        return cPostulantes.LeerPorStoreProcedure("sp_VerPropuestosDeNecesidad", parametros);
    }
}
