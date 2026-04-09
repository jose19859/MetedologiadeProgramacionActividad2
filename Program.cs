/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 5/4/2026
 * Hora: 13:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Pila miPila =new Pila();
			llenaAlumnos(miPila);
			Console.WriteLine("ya llenamos con 20 numeros ");
			
			Informar(miPila);
			Console.WriteLine("ingrese un numero ");
			int leido =int.Parse(Console.ReadLine());
			
			Comparable buscado = new Numero(leido);
			if (miPila.Contiene(buscado))
			{
				Console.WriteLine("el numero esta en la coleccion ");
			}
			else
			{
				Console.WriteLine("el numero No se encuentra ");
				
			}
			// eje 7
			Cola miCola = new Cola();
			llenaAlumnos(miCola);
			Console.WriteLine("llenamos cola con 20 numero ");
			Informar(miCola);
			Console.WriteLine("Presione una tecla...");
			Console.ReadKey();
		}
		// eje 13
		public static void llenaAlumnos(Coleccionable c)
		{
			string [] nombres={ "Juan", "Maria", "Pedro", "Ana", "Jose", "Luis", "Elena", "Rosa", "Carlos", "Sofia", "Diego", "Lucia" };
			Random r=new Random();
			
			for (int i=0;i<20;i++)
			{
				string n= nombres[r.Next(nombres.Length)];
				int d=r.Next(600,900);
				int l=r.Next(100,200);
				
				double p =Math .Round (r.NextDouble()*10, 2);
				
				// ejercicio 2
				Alumnos nuevoAlumno =new Alumnos(n,d,l,p);
				nuevoAlumno.setEstrategia(new CompararporPromedio());
				
				c.Agregar(nuevoAlumno);
			}
			Console.WriteLine("se agregaron 20 alumnos a la colecciona");
		}

		public static void Informar(Coleccionable c)
		{
			Comparable max =c.Maximo();
			
			Comparable min =c.Minimo();
			if (max != null){
				Console.WriteLine("El maximo es:" + max.ToString());
				Console.WriteLine("El maximo es:" + min.ToString());
				
			}
		}
		public static void llenar(Coleccionable c)
		{
			
		}
		
		public static void informar(Iterable coleccion)
		{
			Iterador it =coleccion.crearIterador();
			it.primero();
			while (!it.fin())
			{
			
			Comparable c = it.actual();
			Console.WriteLine(c.ToString());
			it.siguiente();
			}
		Console.WriteLine("---------------------\n");
		}
	
	}
	
}

	
	// ME QUEDE POR ACTIVIDAD 3 Y 4.