/**
 * 
 */
package rpg;

import java.util.Comparator;

/**
 * 
 */
public class ComparadorAtaque implements Comparator<Character> {

	@Override
	public int compare(Character o1, Character o2) {
		
		return o1.getAttack()-o2.getAttack();
	}

}
