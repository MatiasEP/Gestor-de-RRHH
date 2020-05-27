using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


public class DALBarrio
{
    public DataTable sp_VerBarriosEnLocalidad(int Localidad)
    {
        Conexion cBarrio = new Conexion();
        SqlParameter[] parametros = new SqlParameter[1];
        SqlParameter pLocalidad = cBarrio.crearParametro("@FK_Localidad",Localidad);
        parametros[0] = pLocalidad;
        return cBarrio.LeerPorStoreProcedure("sp_VerBarriosEnLocalidad", parametros);
    }
}

public class DALLocalidad
{
    public DataTable sp_VerLocalidadesEnProvincia(int Provincia)
    {
        Conexion cLocalidad = new Conexion();
        SqlParameter[] parametros = new SqlParameter[1];
        SqlParameter pLocalidad = cLocalidad.crearParametro("@FK_Provincia", Provincia);
        parametros[0] = pLocalidad;
        return cLocalidad.LeerPorStoreProcedure("sp_VerLocalidadesEnProvincia", parametros);
    }
}

public class DALProvincia
{
    public DataTable sp_VerTodoProvincia()
    {
        Conexion cProvincia = new Conexion();
        return cProvincia.LeerPorStoreProcedure("sp_VerTodoProvincia");
    }
}

public class DALGenero
{
    public DataTable sp_VerGenero()
    {
        Conexion cGenero = new Conexion();
        return cGenero.LeerPorStoreProcedure("sp_VerGenero");
    }
}

public class DALCargo
{
    public DataTable sp_VerTodoCargo()
    {
        Conexion cCargo = new Conexion();
        return cCargo.LeerPorStoreProcedure("sp_VerTodoCargo");
    }
}

public class DALOficina
{
    public DataTable sp_VerTodoOficina()
    {
        Conexion cOficina = new Conexion();
        return cOficina.LeerPorStoreProcedure("sp_VerTodoOficina");
    }
}

public class DALTipoDireccion
{
    public DataTable sp_VerTodoTipoDireccion()
    {
        Conexion cTipoDireccion = new Conexion();
        return cTipoDireccion.LeerPorStoreProcedure("sp_VerTodoTipoDireccion");
    }
}

public class DALTipoTelefono
{
    public DataTable sp_VerTodoTipoTelefono()
    {
        Conexion cTipoTelefono = new Conexion();
        return cTipoTelefono.LeerPorStoreProcedure("sp_VerTodoTipoTelefono");
    }
}
