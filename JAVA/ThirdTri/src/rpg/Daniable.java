/**
 * 
 */
package rpg;

/**
 * @author Angel Miguel
 * @version 1.0.0
 * 
 * INTERFAZ DAÑABLE
 * 
 * Determina si un personaje u objeto puede ser dañado e implementa el método para restar vida
 * 
 */ 

public interface Daniable {
	
	/**
	 * @param daño a recibir
	 */
	public abstract void daniado(int dmg);

}