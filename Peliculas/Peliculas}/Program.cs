using System;
			
public class Pelicula{

	public string titulo;
	public int año;
	public string pais;
	public string director;
	
}


public class Program
{
	
	public static void Main()
	{
		Pelicula p1 = new Pelicula();
		p1.titulo = "Parasitos";
		p1.año = 2019;
		
		Pelicula p2 = new Pelicula();
		p2.titulo = "La La Land";
		p2.año = 2016;
		
		Console.WriteLine(p1.titulo + "\t" + p1.año + "\n" + p2.titulo + "\t" + p2.año);
		
	}
}