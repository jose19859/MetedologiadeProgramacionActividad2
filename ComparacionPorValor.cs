/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 12/4/2026
 * Hora: 17:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{
	/// <summary>
	/// Description of ComparacionPorValor.
	/// </summary>
	public class ComparacionPorValor : Comparacion
	{
		public bool sosIgual(Comparable a, Comparable b)
		{
				if (!(a is Alumnos) || !(b is Alumnos))
				return false;
			return((Numero)a).getValor() == ((Numero)b).getValor();
		}
		public bool sosMayor(Comparable a, Comparable b)
		{
				if (!(a is Alumnos) || !(b is Alumnos))
				return false;
			return((Numero)a).getValor() > ((Numero)b).getValor();
		}
		public bool sosMenor(Comparable a, Comparable b)
		{
				if (!(a is Alumnos) || !(b is Alumnos))
				return false;
			return((Numero)a).getValor() < ((Numero)b).getValor();
		}
	}
}
