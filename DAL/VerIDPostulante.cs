using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class VerIDPostulante
{
    public int sp_VerIDPostulante(string Nombre, string Apellido)
    {
        int ID;
        DataTable aux = new DataTable();
        Conexion cPostulante = new Conexion();
        SqlParameter[] parametros = new SqlParameter[2];
        SqlParameter cNombre = cPostulante.crearParametro("@Nombre", Nombre);
        SqlParameter cApellido = cPostulante.crearParametro("@Apellido", Apellido);
        parametros[0] = cNombre;
        parametros[1] = cApellido;
        aux = cPostulante.LeerPorStoreProcedure("sp_VerIDPostulante", parametros);
        ID = Convert.ToInt32(aux.Rows[0]["ID"]);
        return ID;
    }
}