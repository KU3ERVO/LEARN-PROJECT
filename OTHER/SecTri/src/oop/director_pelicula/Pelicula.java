package oop.director_pelicula;

public class Pelicula {
	
	private String title;
	private int anio;
	private Director director;
	
	Pelicula(String title){	
		this.title=title;
	}
	Pelicula(){
	}
	Pelicula(Director director){
		this.director=director;
	}
	public String getTitle() {
		return title;
	}
	public void setTitle(String title) {
		this.title = title;
	}
	public int getAnio() {
		return anio;
	}
	public void setAnio(int anio) {
		this.anio = anio;
	}
	public Director getDirector() {
		return director;
	}
	public void setDirector(Director director) {
		this.director = director;
	}
	
	public String toString() {

		return this.director.imprimir()+"\nPelicula: "+this.title+" "+this.anio;
	}

}
