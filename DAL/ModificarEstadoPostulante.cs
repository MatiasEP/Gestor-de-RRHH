using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class ModificarEstadoPostulante
{
    public void sp_ModificarEstadoPostulante(int FK_Postulante, int FK_Busqueda, int FK_Estado)
    {
        Conexion cEstado = new Conexion();
        SqlParameter[] parametros = new SqlParameter[3];
        SqlParameter Postulante = cEstado.crearParametro("@FK_Postulante", FK_Postulante);
        SqlParameter Busqueda = cEstado.crearParametro("@FK_Busqueda", FK_Busqueda);
        SqlParameter Estado = cEstado.crearParametro("@FK_Estado", FK_Estado);
        parametros[0] = Postulante;
        parametros[1] = Busqueda;
        parametros[2] = Estado;
        cEstado.LeerPorStoreProcedure("sp_CambiarEstadoPostulante", parametros);
    }
}
