/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 5/4/2026
 * Hora: 14:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{
	/// <summary>
	/// Description of CompararporDni.
	/// </summary>
	public class CompararporDni:Comparacion
	{
		public int Comparar(Alumnos a1,Alumnos a2)
		{
			if (a1.Dni>a2.Dni)
			{
				return 1;
			}
			else if (a1.Dni<a2.Dni)
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
