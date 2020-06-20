///////////////////////////////////////////////////////////
//  Postulante.cs
//  Implementation of the Class Postulante
//  Generated by Enterprise Architect
//  Created on:      22-may.-2020 17:37:55
//  Original author: Haskell
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;

public class Postulante : Persona 
{

	private string _URL_CV;

	public string URL_CV
	{
		get
		{
			return _URL_CV;
		}
		set
		{
			_URL_CV = value;
		}

	}

	public DataTable VerPostulantes(int Busqueda)
	{
		return new VerPostulantes().sp_VerPostulantesEnBusqueda(Busqueda);
	}


	public void ModificarEstadoPostulante(int FK_Postulante, int FK_Busqueda, int FK_Estado)
	{
		new ModificarEstadoPostulante().sp_ModificarEstadoPostulante(FK_Postulante, FK_Busqueda, FK_Estado);
	}

	public int VerIDPostulante(string Nombre, string Apellido)
	{
		return new VerIDPostulante().sp_VerIDPostulante(Nombre, Apellido);
	}

}//end Postulante