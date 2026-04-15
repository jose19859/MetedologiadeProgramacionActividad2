/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 5/4/2026
 * Hora: 14:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class CompararporNombre:Comparacion
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
		{	if (!(a is Alumnos) || !(b is Alumnos))
				return false;
			return ((Alumnos)a).getDni()==((Alumnos)b).getDni();
		}
		
		/*

		public int Comparar(Alumnos a1,Alumnos a2)
		{
			return string.Compare(a1.Nombre,a2.Nombre);
		}*/
	}
}
