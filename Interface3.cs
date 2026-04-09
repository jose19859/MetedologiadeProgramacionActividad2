/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 5/4/2026
 * Hora: 17:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{

	public interface Coleccionable
	{
		int Cuantos ();
		Comparable Maximo ();
		Comparable Minimo ();
		void Agregar (Comparable c);
		bool Contiene (Comparable c);
	}
		
}
