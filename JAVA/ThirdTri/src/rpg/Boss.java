/**
 * 
 */
package rpg;

/**
 * @author Angel Miguel Felipe
 * @version 1.0.0
 * 
 * CLASE BOSS
 * 
 * Es la clase hija de Enemigo que representará a nuestro enemigo mas fuerte, al igual que el resto puede pedir parámetros
 * por hacer más simple el ejercicio he establecido los valores al crearse
 * 
 */
public class Boss extends Enemy {

	private static final long serialVersionUID = 1L;

	/**
	 * @param nombre
	 * @param vida
	 * @param ataque
	 * @param defensa
	 * @param rareza
	 */
	public Boss(String name, int hp, int attack, int defense, int rareza) {
		super(name = "MALIGNA ESCOBAR", hp = 1000, attack = 200, defense = 85, rareza = 5);
		setRareza(5);
	}

	/**@Override
	 * Accion específica del BOSS
	 * */
	public String accion() {
		return "Maligna te mira con decepcion, o al menos eso piensas, porque no tiene ojos";
	}

}
