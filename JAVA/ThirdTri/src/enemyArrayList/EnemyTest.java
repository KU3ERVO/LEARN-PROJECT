package enemyArrayList;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.HashSet;
import java.util.LinkedHashSet;
import java.util.Set;
import java.util.TreeSet;

public class EnemyTest {

	public static void main(String[] args) {

		ArrayList <Enemy> wave = new ArrayList <Enemy> ();

		Enemy orc = new Enemy(1, 300,300,"ORCO");
		Enemy goblin = new Enemy(2, 50,120,"GOBLIN");
		Enemy troll = new Enemy(1.5, 200,150,"TROLL");
		Enemy demonio = new Enemy(3, 200, 250,"DEMONIO");

		wave.add(orc);
		wave.add(troll);
		wave.add(0, goblin);

		for(Enemy e : wave) {
			System.out.println(e.toString());
		}

		wave.addAll(wave);
		wave.addAll(1, wave);

		System.out.println("\n\n\n\n\n2\n");
		for(Enemy e : wave) {
			System.out.println(e.toString());
		}

		wave.addFirst(demonio);
		wave.addLast(demonio);

		System.out.println("\n\n\n\n\n3\n");
		for(Enemy e : wave) {
			System.out.println(e.toString());
		}

		wave.clear();
		wave.add(demonio);
		wave.add(demonio);
		wave.add(goblin);
		System.out.println("\n\n"+wave.contains(troll));
		System.out.println("\n\n"+wave.containsAll(wave)+wave.get(0)+" "+wave.getLast()+" "+wave.getFirst());
		wave.ensureCapacity(4);



		System.out.println("\n\n\n4\n\n\n");
		for(Enemy e : wave) {
			System.out.println(e.toString());
		}




		//Creacion de un treeset y un hashset

		Set<Enemy> ts = new TreeSet<>();
		Set<Enemy> hs = new HashSet<>();
		Set<Enemy> lhs = new LinkedHashSet<>();
		
		//Añadir objetos
		ts.add(demonio);
		hs.add(goblin);
		//Añade todos los elementos de una coleccion u array
		ts.addAll(wave);
		//limpia el set de todos los elementos
		hs.clear();
		//false o true dependiendo si contiene el elemento que le damos
		hs.contains(demonio);
		//true o false si contiene o no todos los elementos de la coleccion pasada
		ts.containsAll(wave);
		//Metodo equals
		hs.equals(hs);
		
		
		//Añade objetos a una collection a la vez
		Collections.addAll(hs,orc,goblin);
		//Busca con un comparador en la lista
		Collections.binarySearch(null,wave);
		//Cambia los objetos primeros por ultimo
		Collections.asLifoQueue(null);
		// Copia todos los elementos de la segunda lista a la primera
		Collections.copy(wave,wave);
	}

}
