using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class CrearNecesidad
{
    public void sp_CrearNecesidad(string Asunto, string Necesidad, int Creador)
    {
        Conexion cNecesidad = new Conexion();
        SqlParameter[] parametros = new SqlParameter[3];
        SqlParameter pAsunto = cNecesidad.crearParametro("@Asunto", Asunto);
        SqlParameter pNecesidad = cNecesidad.crearParametro("@Necesidad", Necesidad);
        SqlParameter pCreador = cNecesidad.crearParametro("@Creador", Creador);
        parametros[0] = pAsunto;
        parametros[1] = pNecesidad;
        parametros[2] = pCreador;
        cNecesidad.LeerPorStoreProcedure("sp_CrearNecesidad", parametros);
    }
}
