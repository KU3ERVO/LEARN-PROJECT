package oop.biblioteca;

import java.util.Arrays;

import oop.libro.Libro;

public class Biblioteca {

	private Libro [] libros;
	private String nombre;
	private int contadorLibros=0,j=0;

	public Biblioteca(String nombre) {
		this.nombre = nombre;
		this.libros = new Libro [4];
	}

	public void addLibro(Libro libro) {

		this.libros[contadorLibros]=libro;
		contadorLibros++;

	}

	public void deleteLibro(Libro libro) {

		boolean llave = false;
		int i = 0;

		for(i=0;i<libros.length&&libros[i]!=null;i++) {
			if(libros[i]!=null) {
				
				llave=libros[i].getISBN().equalsIgnoreCase(libro.getISBN());
				if(llave==true) {
					System.out.println(i);
					this.libros[i]=null;
					llave=false;
					}
				}
		}
		System.out.println(i);
		while(i+1<libros.length&&libros[i+1]!=null){
			
			libros[i+1]=libros[i];
			i++;
			
		}
		
		contadorLibros--;
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
