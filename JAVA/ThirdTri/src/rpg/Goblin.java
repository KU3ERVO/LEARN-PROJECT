/**
 * 
 */
package rpg;

/**
 * 
 */
public class Goblin extends Enemy {

	/**
	 * @param name
	 * @param hp
	 * @param attack
	 * @param defense
	 */
	
	public Goblin(String name, int hp, int attack, int defense, int rareza) {
		super( name = "GOBLIN", hp = 100, attack = 50, defense = 0, rareza = 1);
		setRareza(1);
	}

	@Override
	public String accion() {
		
		return "El goblin te ha robado!";
	}
	
	
	
}
