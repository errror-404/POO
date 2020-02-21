using System;
using System.Collections.Generic;	


public class Pelicula{
	private string titulo;
	private int año;
	private string pais;
	private string director;
	
	public Pelicula(string t, int a){
		titulo = t;
		año = a;
	}
	public void imprime(){
		Console.WriteLine(titulo + "\t" + año);	
	}
}

public class Program
{
	public static void Main()
	{
	
		List<Pelicula> P1 = new List<Pelicula>();
		P1.Add(new Pelicula ("Toy Story 3", 2019));
		P1.Add(new Pelicula ("La La Land",2016));
		P1.Add(new Pelicula ("Parasitos",2019));
		P1.Add(new Pelicula ("Joker",2019));
		P1.Add(new Pelicula ("Krauss",2019));
		
		foreach (Pelicula p in P1){
			p.imprime();
		}
	}
}