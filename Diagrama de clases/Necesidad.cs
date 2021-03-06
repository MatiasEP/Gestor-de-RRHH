///////////////////////////////////////////////////////////
//  Necesidad.cs
//  Implementation of the Class Necesidad
//  Generated by Enterprise Architect
//  Created on:      22-may.-2020 17:37:55
//  Original author: Haskell
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public class Necesidad : ClaseGenerica {

	private Personal Creador;
	private Fecha FechaCierre;
	private Fecha FechaCreacion;
	private string Observacion;
	private Prioridad Prioridad;
	public RRHH m_RRHH;
	public Personal m_Personal;

	public Necesidad(){

	}

	~Necesidad(){

	}

	public Personal Creador{
		get{
			return Creador;
		}
		set{
			Creador = value;
		}
	}

	public Fecha FechaCierre{
		get{
			return FechaCierre;
		}
		set{
			FechaCierre = value;
		}
	}

	public Fecha FechaCreacion{
		get{
			return FechaCreacion;
		}
		set{
			FechaCreacion = value;
		}
	}

	public Prioridad Prioridad{
		get{
			return Prioridad;
		}
		set{
			Prioridad = value;
		}
	}

}//end Necesidad