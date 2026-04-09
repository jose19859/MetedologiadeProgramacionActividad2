/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 5/4/2026
 * Hora: 14:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{
	
	public class Alumnos : Comparable// clase alumnos hereda de la clase persona
	{
		public int Legajo {get;set;}
		public double Promedio {get;set;}
		public int Dni;
		public string Nombre{get;set;}
		public Comparacion estrategia;
		
		
		
		public Alumnos(string n,int d,int l,double p)
		{
			this.Legajo =l;
			this.Promedio = p;
			this.Dni =d;
			this.Nombre=n;
			this.estrategia =new CompararporDni();
		}
		
		
		public void setEstrategia(Comparacion elegida)
		{
			this.estrategia = elegida;
		}
		public  bool sosMayor(Comparable c)
		{
			if (c is Alumnos)
			{
				return this.estrategia.Comparar(this,(Alumnos)c) == 1;
			}
			return false;
		}
		public  bool sosMenor(Comparable c)
		{
			if (c is Alumnos)
			{
				
				return this.estrategia.Comparar(this,(Alumnos)c) ==-1;
			}
			return false;
			
		}
		public  bool sosIgual(Comparable c)
		{
			if (c is Alumnos)
			{
				
				return this.estrategia.Comparar(this,(Alumnos)c)==0;
			}
			return false;
		}
		
		public override string ToString()
        {
            return "Nombre: " + this.Nombre + " | DNI: " + this.Dni + " | Promedio: " + this.Promedio;
        }
		
	}

}
