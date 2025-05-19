/**
 * 
 */
package rpg;

/**
 * @author Angel Miguel Felipe
 * @version 1.0.0
 * 
 * CLASE ENEMY
 * 
 * Es la clase hija de Character y padre de los enemigos que representará a nuestro enemigo plantilla.
 * incorpora isMuerto boolean que determina si este enemigo está muerto o no
 * incorpora rareza que utilizaremos para determinar la importancia y los porcentajes en los que nos encontramos con el enemigo.
 * 
 */
public abstract class Enemy extends Character implements Daniable,Comparable<Enemy> {

	private static final long serialVersionUID = 1L;
	/**
	 * @param name
	 * @param hp
	 * @param attack
	 * @param defense
	 */
	
	private int rareza;
	private boolean muerto = false;
	
	public Enemy(String name, int hp, int attack, int defense,int rareza) {
		super(name, hp, attack, defense);
	}

	/**
	 *@Override daniado
	 *@param int daño enemigo
	 *
	 *Se restará el daño de x fuente a la vida de este enemigo y si la vida llega a 0 morirá
	 */
	
	public void daniado(int dmg) {

		this.setHp(this.getHp()-(dmg-this.getDefense()));

		if(this.getHp()<=0) {
			
			muerto = true;

		}
	}
	
	/**
	 * @return rareza
	 */
	public int getRareza() {
		return rareza;
	}

	/**
	 * @param rareza
	 */
	public void setRareza(int rareza) {
		this.rareza = rareza;
	}

	/**
	 * @return está muerto
	 */
	public boolean isMuerto() {
		return muerto;
	}

	/**
	 * @param está muerto
	 */
	public void setMuerto(boolean muerto) {
		this.muerto = muerto;
	}

	/**
	 * @return String accion específica del Enemigo.
	 */
	public abstract String accion();
	
	/**
	 *@override CompareTo
	 *@return int comparacion de la rareza de los enemigos.
	 */
	public int compareTo(Enemy e) {
		
		return this.rareza - e.getRareza();
		
	}
	
}
