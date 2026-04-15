/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 5/4/2026
 * Hora: 15:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{
	/// <summary>
	/// Description of ComparacionporLegajo.
	/// </summary>
	public class ComparacionporLegajo:Comparacion
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
				return false;
			return ((Alumnos)a).getDni()==((Alumnos)b).getDni();
		}
		
		/*public int Comparar(Alumnos a1,Alumnos a2)
		{
			if (a1.Legajo>a2.Legajo)
			{
				return 1;
			}
			else if (a1.Legajo<a2.Legajo)
			{
				return-1;
			}
			else
			{
				return 0;
			}*/
		}
	}
