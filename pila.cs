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

	public class Pila : Coleccionable,Iterable // se implementa la interfece coleccionable
	{
		private List<Comparable> elementos; // se crea una lista de elementos
		
		public Pila()
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
	public Comparable desapilar()
        {
		int ultimoIndice = elementos.Count -1;
		Comparable aux=elementos[ultimoIndice];
		elementos.RemoveAt(ultimoIndice);
            return aux;
		}
	
		public List<Comparable> getElementos(){
			return this.elementos;
		}
		public Iterador crearIterador(){
			return new IteradorParaPila(this);
		}
	}
}


