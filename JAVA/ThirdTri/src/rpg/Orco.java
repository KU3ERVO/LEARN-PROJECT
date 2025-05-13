/**
 * 
 */
package rpg;

/**
 * 
 */
public class Orco extends Enemy {

	/**
	 * @param name
	 * @param hp
	 * @param attack
	 * @param defense
	 */
	public Orco(String name, int hp, int attack, int defense, int rareza) {
		super(name = "ORCO", hp = 300, attack = 100, defense = 50, rareza = 2);
		setRareza(2);
	}

	@Override
	public String accion() {
		// TODO Auto-generated method stub
		return "Este Orco cree que es muy guapo, te das cuenta de que ahora se parece a Brad Pitt";
	}

}
