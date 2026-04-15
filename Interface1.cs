/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 5/4/2026
 * Hora: 14:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{
	/// <summary>
	/// Description of Interface2.
	/// </summary>
	public interface Comparacion
	{
		//int Comparar(Alumnos a1, Alumnos a2);
		bool sosIgual(Comparable a, Comparable b);
		bool sosMayor(Comparable a, Comparable b);
		bool sosMenor(Comparable a, Comparable b);
		
	}
	
}