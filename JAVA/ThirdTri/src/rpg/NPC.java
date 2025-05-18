/**
 * 
 */
package rpg;

import java.util.ArrayList;
import java.util.Collections;

/**
 * 
 */
public class NPC extends Character implements Talkable {

	/**
	 * 
	 */
	
	private ArrayList<Character> datos; 

	/**
	 * @param name
	 * @param hp
	 * @param attack
	 * @param defense
	 */
	public NPC(String name, int hp, int attack, int defense) {
		super(name, hp, attack, defense);
		datos = new ArrayList<Character>();
		datos.add(new Boss(name, defense, defense, defense, defense));
		datos.add(new Goblin(name, hp, attack, defense, defense));
		datos.add(new Orco(name, hp, attack, defense, defense));
	}

	@Override
	public String talk(Player p) {
		
		datos.add(p);
		Collections.sort(datos, new ComparadorAtaque());
		
		String mensaje = "";
		
		for(Character c : datos) {
			
			mensaje += "\n\n"+c.toString();
			
		}
		
		return mensaje;
	}

}
