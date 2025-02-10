package oop.director_pelicula;

public class TestDirectorPelicula {

	public static void main(String[] args) {
		//EXPERIMENTO 1
		Director WA = new Director("Woody Allen","Francia",1935);
		Pelicula p1 = new Pelicula();
		
		p1.setAnio(1979);
		p1.setTitle("Manhattan");
		p1.setDirector(WA);
		
		System.out.println(p1.toString());
		//EXPERIMENTO 2
		Director PJ = new Director("Peter Jackson","Nueva Zelanda",1961);
		Pelicula p2 = new Pelicula("El Señor de los Anillos");
		
		p2.setAnio(2001);
		p2.setDirector(PJ);
		
		System.out.println("\n"+p2.toString());
		//EXPERIMENTO 3
		Pelicula p3 = new Pelicula(WA);
		
		p3.setAnio(1987);
		p3.setTitle("Dias de Radio");
		
		System.out.println("\n"+p3.toString());
		//EXPERIMENTO 4
		p3.getDirector().setPais("Estados Unidos");
		
		System.out.println("\n"+p3.toString()+"\n\n"+p2.toString()+"\n\n"+p1.toString());

	}

}
