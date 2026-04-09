/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 5/4/2026
 * Hora: 18:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace ejercicio2
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Conjunto:Coleccionable , Iterable
	{
		
		private List<Comparable> elemento = new List<Comparable>();
		
		
		public bool pertenece (Comparable c)
		{
			foreach (Comparable e in elemento)
			{
				if (e.sosIgual (c))
				{
					return true;
				}
			}
			return false;
		}
		public void Agregar (Comparable c){
			if (!this.pertenece(c))
			{
				elemento.Add(c);
			}
		}
		public int Cuantos()
		{
			return elemento.Count;
		}
		public Comparable Minimo()
		{
			if (elemento.Count==0)
			{
				return null;
			}
			Comparable masChico=elemento[0];
			
			foreach (Comparable e in elemento)
			{
				if (e.sosMenor(masChico))
				{
					masChico=e;
				}
			}
			return masChico;
		}
		public Comparable Maximo()
		{
			if (elemento.Count==0) return null;
			
			Comparable masGrande =elemento [0];
			foreach (Comparable e in elemento) {
				if (e.sosMayor(masGrande))
				{
					masGrande=e;
				}
			}
			return masGrande;
		}
		
		public bool Contiene(Comparable c)
		{
			return this.pertenece(c);
		}
		public List<Comparable> getElementos(){
			return this.elemento;
		}
		public Iterador crearIterador(){
			return new IteradorParaConjunto(this);
		}
	}
}





