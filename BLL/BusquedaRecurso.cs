///////////////////////////////////////////////////////////
//  BusquedaRecurso.cs
//  Implementation of the Class BusquedaRecurso
//  Generated by Enterprise Architect
//  Created on:      22-may.-2020 17:37:54
//  Original author: Haskell
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public class BusquedaRecurso {

	private Personal _creador;
	private string _observacion;
	private Oficina _oficina;
	private Necesidad _necesidad;

	public Personal Creador
	{
		get
		{
			return _creador;
		}
		set
		{
			_creador = value;
		}
	}

	public string Observacion
	{
		get
		{
			return _observacion;
		}
		set
		{
			_observacion = value;
		}
	}

	public Oficina Oficina
	{
		get
		{
			return _oficina;
		}
		set
		{
			_oficina = value;
		}
	}

	public Necesidad Necesidad
	{
		get
		{
			return _necesidad;
		}
		set
		{
			_necesidad = value;
		}
	}


}//end BusquedaRecurso