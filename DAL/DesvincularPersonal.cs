using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class DesvincularPersonal
{
    public void BajaPersonal(int legajo)
    {
        Conexion cPersonal = new Conexion();
        SqlParameter[] parametros = new SqlParameter[1];
        SqlParameter cLegajo = cPersonal.crearParametro("@Legajo", legajo);
        parametros[0] = cLegajo;
        cPersonal.LeerPorStoreProcedure("sp_BajaPersonal", parametros);
    }
}