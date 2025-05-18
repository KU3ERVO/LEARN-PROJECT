/**
 * 
 */
package rpg;

/**
 * 
 */
public class Boss extends Enemy {

	/**
	 * @param name
	 * @param hp
	 * @param attack
	 * @param defense
	 * @param rareza
	 */
	public Boss(String name, int hp, int attack, int defense, int rareza) {
		super(name = "MALIGNA ESCOBAR", hp = 1000, attack = 200, defense = 85, rareza = 5);
		setRareza(5);
	}

	@Override
	public String accion() {
		
		return "Maligna te mira con decepcion, o al menos eso piensas, porque no tiene ojos";
	}

}
