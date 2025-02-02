package oop.libro;

import oop.fecha.Fecha;
import oop.persona.Persona;

public class TestLibro {

	public static void main(String[] args) {
		
		Persona p1 = new Persona("11891196B","Emily","Bronte");
		Fecha f1 = new Fecha(28, 11, 1847);
		Libro l1 = new Libro("Cumbres Borrascosas","980-3-16-148410-0",3,"Alianza","Londres","Reino Unido", p1, f1,472);
		
		System.out.println(l1.toString());

	}

}
