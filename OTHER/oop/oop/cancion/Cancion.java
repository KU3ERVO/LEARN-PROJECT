package oop.cancion;

public class Cancion {
	
	private String autor,titulo;

	Cancion(String titulo, String autor) {
		
		this.autor = autor;
		this.titulo = titulo;
	}

	Cancion() {}

	public String getAutor() {
		return autor;
	}

	public void setAutor(String autor) {
		this.autor = autor;
	}

	public String getTitulo() {
		return titulo;
	}

	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}
	
	
	
	
	
	

}
