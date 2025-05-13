/**
 * 
 */
package rpg;

/**
 * 
 */
public class NPC extends Character implements Talkable {

	/**
	 * 
	 */

	/**
	 * @param name
	 * @param hp
	 * @param attack
	 * @param defense
	 */
	public NPC(String name, int hp, int attack, int defense) {
		super(name, hp, attack, defense);
	}

	@Override
	public String talk() {
		
		String mensaje = "";
		
		return mensaje;
	}

}
