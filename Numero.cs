/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 27/3/2026
 * Hora: 23:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{

	public class Numero:Comparable // se implementa interface Comparable 
		
	{
		private int Valor;
		public Numero (int V) { this.Valor =V;}
		
		public bool sosIgual(Comparable c)
		{
			if  (this.Valor==((Numero)c).getValor())
				return true;
					else { return false;}
		}
		public bool sosMayor(Comparable c)
		{
			if  (this.Valor>((Numero)c).getValor())
				return true;
					else { return false;}
		}
		public bool sosMenor(Comparable c)
		{
			if  (this.Valor<((Numero)c).getValor())
				return true;
					else { return false;}
		}
		public int getValor()
		{
			return this.Valor;
		}
	}
	

}
