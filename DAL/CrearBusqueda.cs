using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class CrearBusqueda
{
    public void sp_CrearBusqueda(int ID, string Asunto, string Busqueda, int Creador, int Oficina)
    {
        Conexion cBusqueda = new Conexion();
        SqlParameter[] parametros = new SqlParameter[5];
        SqlParameter pID = cBusqueda.crearParametro("@ID", ID);
        SqlParameter pAsunto = cBusqueda.crearParametro("@Asunto", Asunto);
        SqlParameter pBusqueda = cBusqueda.crearParametro("@Busqueda", Busqueda);
        SqlParameter pCreador = cBusqueda.crearParametro("@Creador", Creador);
        SqlParameter pOficina = cBusqueda.crearParametro("@Oficina", Oficina);
        parametros[0] = pID;
        parametros[1] = pAsunto;
        parametros[2] = pBusqueda;
        parametros[3] = pCreador;
        parametros[4] = pOficina;
        cBusqueda.LeerPorStoreProcedure("sp_CrearNecesidad", parametros);
    }
}
