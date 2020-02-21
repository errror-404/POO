using System;
			
public class Pelicula{

	private string titulo;
	private int año;
	private string pais;
	private string director;
	
	public Pelicula(String p, int a ){
		titulo = p;
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
		Pelicula p1 = new Pelicula("Parasitos",2019);
		p1.imprime();
		
	}
}