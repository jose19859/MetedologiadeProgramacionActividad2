/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 28/3/2026
 * Hora: 18:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace ejercicio2
{

	public class Cola : Coleccionable, Iterable//clase cola que inmplementa interface coleccionble
	{
		private List<Comparable> elementos;
		
		public Cola()
		{
			elementos=new List <Comparable>();
		}
		public void Agregar(Comparable c)
		{
			elementos.Add(c);
		}
		public int Cuantos()
		{
			return elementos.Count;
		}
		public Comparable Maximo()
		{
			Comparable m =elementos [0];
			foreach (Comparable actual in elementos)
			{
				if (actual.sosMayor(m))
				{
					m=actual;
				}
			}
			return m;
		}
		public Comparable Minimo()
		{
			Comparable m =elementos [0];
			foreach (Comparable actual in elementos)
			{
				if (actual.sosMenor(m))
				{
					m=actual;
				}
			}
			return m;
		}
		public bool Contiene(Comparable c)
		{
			foreach (Comparable actual in elementos)
			{
				if (actual.sosIgual(c))
				{
					return true;
				}
			}
			return false;
		}
		public Comparable desencolar()
		{
			Comparable aux = elementos[0];
			elementos.RemoveAt(0);
			return aux;
		}
		
		public List<Comparable> getElementos(){
			return this.elementos;
		}
		public Iterador crearIterador(){
			return new IteradorParaCola(this);
		}
		
	}
	
}

