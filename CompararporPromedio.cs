/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 5/4/2026
 * Hora: 14:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{
	/// <summary>
	/// Description of CompararporPromedio.
	/// </summary>
	public class CompararporPromedio:Comparacion
		
		
	{
		public bool sosMayor(Comparable a,Comparable b)
		{
				if (!(a is Alumnos) || !(b is Alumnos))
				return false;
			return ((Alumnos)a).getDni()>((Alumnos)b).getDni();
		}
		
		public bool sosMenor(Comparable a,Comparable b)
		{
				if (!(a is Alumnos) || !(b is Alumnos))
				return false;
			return ((Alumnos)a).getDni()<((Alumnos)b).getDni();
		}
		

		public bool sosIgual(Comparable a,Comparable b)
		{
				if (!(a is Alumnos) || !(b is Alumnos))
				return false;return ((Alumnos)a).getDni()==((Alumnos)b).getDni();
		}
		
		/*
		public int Comparar(Alumnos a1,Alumnos a2)
			
		{
			double prom1 =a1.Promedio;
			double prom2 =a2.Promedio;
			
			if (prom1>prom2)
			{
				return 1;
				
			}
		
			else if (prom1<prom2)
			{
				return -1;
				
			}
			else
			{
				return 0;
			}
		 */
	}
}

