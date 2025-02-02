package oop.director_pelicula;

public class Director {
	
	private String nombre,pais;
	private int anioNacim;
	
	Director(String nombre,String pais,int anioNacim){
		
		this.nombre=nombre;
		this.pais=pais;
		this.anioNacim=anioNacim;
		
	}
	
	public String imprimir() {
		
		return "Director: "+this.nombre+"\nNacido en: "+this.pais+" en "+this.anioNacim;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getPais() {
		return pais;
	}

	public void setPais(String pais) {
		this.pais = pais;
	}

	public int getAnioNacim() {
		return anioNacim;
	}

	public void setAnioNacim(int anioNacim) {
		this.anioNacim = anioNacim;
	}
	
	

}
