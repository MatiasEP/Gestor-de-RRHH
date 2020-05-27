///////////////////////////////////////////////////////////
//  Provincia.cs
//  Implementation of the Class Provincia
//  Generated by Enterprise Architect
//  Created on:      22-may.-2020 17:37:55
//  Original author: Haskell
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;



public class Provincia : ClaseGenerica {

	private List<Localidad> _localidades;

	public List<Localidad> Localidades
	{
		get
		{
			return _localidades;
		}
		set
		{
			_localidades = value;
		}
	}

	public DataTable VerProvincias()
	{
		DALProvincia provincias = new DALProvincia();
		return provincias.sp_VerTodoProvincia();
	}

}//end Provincia