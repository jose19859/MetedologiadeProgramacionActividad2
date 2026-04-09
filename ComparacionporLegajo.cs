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
		public int Comparar(Alumnos a1,Alumnos a2)
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
			}
		}
	}
}