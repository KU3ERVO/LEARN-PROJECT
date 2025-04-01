package AtletaComparable;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;

public class TestAtleta {

	public static void main(String[] args) {

		Atleta a1 = new Atleta(10, "Ana");
		Atleta a2 = new Atleta(11, "Sofia");
		Atleta a3 = new Atleta(12, "Carlos");
		Atleta a4 = new Atleta(15, "Luis");

		Atleta [] atletas = new Atleta[]{a3,a2,a1,a4};
		
		System.out.println("\n\n\n ARRAY DESORDENADO");
		
		for(Atleta a : atletas) {

			System.out.println(a.toString());

		}

		Arrays.sort(atletas);
		
		System.out.println("\n\n\n ARRAY ORDENADO");

		for(Atleta a : atletas) {

			System.out.println(a.toString());

		}
		
		ArrayList<Atleta> atletas2 = new ArrayList<Atleta>();
		
		atletas2.add(a4);
		atletas2.add(a1);
		atletas2.add(a3);
		atletas2.add(a2);
		
		System.out.println("\n\n\n ARRAYLIST DESORDENADO");
		
		for(Atleta a : atletas2) {

			System.out.println(a.toString());

		}
		
		Collections.sort(atletas2);
		
		System.out.println("\n\n\n ARRAYLIST ORDENADO");
		
		for(Atleta a : atletas2) {

			System.out.println(a.toString());

		}

	}
}
