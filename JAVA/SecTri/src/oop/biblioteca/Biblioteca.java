package oop.biblioteca;

import java.util.Arrays;

import oop.libro.Libro;

public class Biblioteca {

	private static Libro [] libros;
	private String nombre;
	private static int i=0,j=0;

	public Biblioteca(String nombre) {
		this.nombre = nombre;
		this.libros = new Libro [4];
	}

	public void addLibro(Libro libro) {

		this.libros[i]=libro;
		i++;
		//Arrays.sort(libros);
	}

	public void deleteLibro(Libro libro) {
		
		j=Arrays.binarySearch(libros, libro);
		this.libros[j]=null;
		//Arrays.sort(libros,0,i);
		i--;
	}

	public String listLibros() {

		String biblio = "";

		while(libros[j]!=null){
			biblio += libros[j].toString()+"\n\n";
			j++;
		}
		j=0;
		return "BIBLIOTECA "+this.nombre+"\n\n"+biblio;
	}


}
