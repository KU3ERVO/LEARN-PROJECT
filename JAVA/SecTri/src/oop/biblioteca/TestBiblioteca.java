package oop.biblioteca;

import oop.fecha.Fecha;
import oop.libro.Libro;
import oop.persona.Persona;

public class TestBiblioteca {

	public static void main(String[] args) {
		
		Persona p1 = new Persona(null,"Gabriel","Garcia Marquez");
		Persona p2 = new Persona(null, "Julio","Cortazar");
		Persona p3 = new Persona(null,"Mario","Vargas Llosa");
		
		Fecha f1 = new Fecha(1, 2,1967);
		Fecha f2 = new Fecha(30, 7,1963);
		Fecha f3 = new Fecha(20, 11,1977);
		
		
		Libro l1 = new Libro("Cien años de soledad","978-84-376-0494-7","Sudamericana", p1, f1);
		Libro l2 = new Libro("Rayuela","978-84-376-0499-2","S.XX1", p1, f2);
		Libro l3 = new Libro("La tia Julia y el escribidor","978-84-376-0871-6","Seix Barral", p1, f3);
		
		Biblioteca b1 = new Biblioteca("PEPITA");
		
		b1.addLibro(l1);
		b1.addLibro(l2);
		b1.addLibro(l3);
		
		System.out.println(b1.listLibros());
		
		b1.deleteLibro(l2);
		
		System.out.println(b1.listLibros());

	}

}
