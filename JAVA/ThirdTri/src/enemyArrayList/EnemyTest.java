package enemyArrayList;

import java.util.ArrayList;

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
		

	}

}
