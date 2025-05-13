/**
 * 
 */
package rpg;

/**
 * 
 */
public abstract class Enemy extends Character implements Daniable,Comparable<Enemy> {

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

	@Override
	public void daniado(int dmg) {

		this.setHp(this.getHp()-(dmg-this.getDefense()));

		if(this.getHp()<=0) {
			
			muerto = true;

		}
	}
	
	public int getRareza() {
		return rareza;
	}

	public void setRareza(int rareza) {
		this.rareza = rareza;
	}

	public boolean isMuerto() {
		return muerto;
	}

	public void setMuerto(boolean muerto) {
		this.muerto = muerto;
	}

	public abstract String accion();
	
	public int compareTo(Enemy e) {
		
		return this.rareza - e.getRareza();
		
	}
	
}
