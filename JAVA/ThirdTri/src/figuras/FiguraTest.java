package figuras;

import java.util.ArrayList;
import java.util.Collections;

public class FiguraTest {

	public static void main(String[] args) {

		Cuadrado c1 = new Cuadrado(0, 0);
		Cuadrado c2 = new Cuadrado(0, 0);
		Cuadrado c3 = new Cuadrado(0, 0);

		Circulo l1 = new Circulo(0, 0);
		Circulo l2 = new Circulo(0, 0);
		Circulo l3 = new Circulo(0, 0);

		ArrayList<Figura> figuras = new ArrayList<Figura>();

		figuras.add(l1);
		figuras.add(l2);
		figuras.add(l3);
		figuras.add(c1);
		figuras.add(c2);
		figuras.add(c3);

		for(Figura f : figuras) {
			System.out.println(f.color);
			if(f instanceof Cuadrado) {
				((Cuadrado)f).colorear();
			}
		}
		
		System.out.println("\n");

		for(Figura f : figuras) {
			System.out.println(f.color);
			if(f instanceof Circulo) {
				((Circulo)f).colorear();
			}
		}
		
		System.out.println("\n");
		
		for(Figura f : figuras) {
			System.out.println(f.color);
		}
	}
}


