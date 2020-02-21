using System;
using System.Collections.Generic;	


public class Pelicula{
	private string titulo;
	private int año;
	private string pais;
	private string director;
	
	public Pelicula(string t, int a, string p, string d ){
		titulo = t;
		año = a;
        pais = p;
        director = d;
	}

	public void imprime(){
		Console.WriteLine(titulo + "\t" + año+ "\t" + pais+ "\t" + director);	
	}
}

public class Program
{
	public static void Main()
	{
	
		List<Pelicula> P1 = new List<Pelicula>();
		P1.Add(new Pelicula ("Toy Story 3", 2019,"USA","PIXART"));
		P1.Add(new Pelicula ("La La Land",2016,"USA","Damien Chazelle"));
		P1.Add(new Pelicula ("Parasitos",2019,"KOREA","Bong Joon-ho"));
		P1.Add(new Pelicula ("Joker",2019,"USA","Todd Phillips"));
		P1.Add(new Pelicula ("Klaus",2019,"ESPAÑA","Sergio Pablos"));
		
		foreach (Pelicula p in P1){
			p.imprime();
		}
	}
}