using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
public class ModificarPersonal
{
    public void sp_ModificarPersonal(int legajo, string nombre, string apellido, string email, int genero, string calle, int altura, int tipoDireccion, int barrio, int cargo, int oficina, int tipoTel, int numeroTel, int supervisor)
    {
        Conexion aPersonal = new Conexion();
        SqlParameter[] parametros = new SqlParameter[14];
        SqlParameter pLegajo = aPersonal.crearParametro("@Legajo", legajo);
        SqlParameter pNombre = aPersonal.crearParametro("@Nombre", nombre);
        SqlParameter pApellido = aPersonal.crearParametro("@Apellido", apellido);
        SqlParameter pEmail = aPersonal.crearParametro("@Email", email);
        SqlParameter pGenero = aPersonal.crearParametro("@Genero", genero);
        SqlParameter pCalle = aPersonal.crearParametro("@Calle", calle);
        SqlParameter pAltura = aPersonal.crearParametro("@Altura", altura);
        SqlParameter ptDireccion = aPersonal.crearParametro("@FK_TipoDireccion", tipoDireccion);
        SqlParameter pBarrio = aPersonal.crearParametro("@FK_Barrio", barrio);
        SqlParameter pCargo = aPersonal.crearParametro("@FK_Cargo", cargo);
        SqlParameter pOficina = aPersonal.crearParametro("@FK_Oficina", oficina);
        SqlParameter ptTel = aPersonal.crearParametro("@FK_TipoTelefono", tipoTel);
        SqlParameter pnTel = aPersonal.crearParametro("@NumeroTelefono", numeroTel);
        SqlParameter pSupervisor = aPersonal.crearParametro("@FK_Supervisor", supervisor);
        parametros[0] = pLegajo;
        parametros[1] = pNombre;
        parametros[2] = pApellido;
        parametros[3] = pEmail;
        parametros[4] = pGenero;
        parametros[5] = pCalle;
        parametros[6] = pAltura;
        parametros[7] = ptDireccion;
        parametros[8] = pBarrio;
        parametros[9] = pCargo;
        parametros[10] = pOficina;
        parametros[11] = ptTel;
        parametros[12] = pnTel;
        parametros[13] = pSupervisor;
        aPersonal.LeerPorStoreProcedure("sp_ModificarPersonal", parametros);
    }
}