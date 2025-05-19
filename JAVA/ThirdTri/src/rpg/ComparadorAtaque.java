/**
 * 
 */
package rpg;

import java.util.Comparator;

/**
 * @author Angel Miguel Felipe
 * @version 1.0.0
 * 
 * CLASE ComparadorAtaque
 * 
 * Clase que implementa Comparator para ordenar listas de personajes en base a su ataque.
 * 
 */
public class ComparadorAtaque implements Comparator<Character> {

	
	/**
	 *@override Compare
	 *@return int comparacion ataque de 2 personajes
	 */
	public int compare(Character o1, Character o2) {
		
		return o1.getAttack()-o2.getAttack();
	}

}
