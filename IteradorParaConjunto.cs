/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 9/4/2026
 * Hora: 02:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 9/4/2026
 * Hora: 02:39
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
	public class IteradorParaConjunto : Iterador
	{
	
			private List<Comparable> elementos;
			private int posicionActual;
			
			public IteradorParaConjunto(Conjunto c)
			{
				this.elementos = c.getElementos();
				this.primero();
				
			}
			public void primero(){
				posicionActual = 0;
			}
			public void siguiente(){
				posicionActual++;
			}
			public bool fin(){
				return posicionActual >= elementos.Count;
			}
			public Comparable actual(){
				return elementos[posicionActual];
			}
	}
}
