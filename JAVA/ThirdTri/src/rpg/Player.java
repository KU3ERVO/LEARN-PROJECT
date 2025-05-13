/**
 * 
 */
package rpg;

import java.io.Serializable;

/**
 * 
 */
public class Player extends Character implements Daniable,Serializable {

	/**
	 * @param name
	 * @param hp
	 * @param attack
	 * @param defense
	 */
	
	private int lvl = 1;
	private int exp = 0; 
	
	public int getLvl() {
		return lvl;
	}

	public void setLvl(int lvl) {
		this.lvl = lvl;
	}

	public int getExp() {
		return exp;
	}

	public void setExp(int exp) {
		this.exp = exp;
	}

	public Player(String name, int hp, int attack, int defense) {
		super(name, hp, attack, defense);
		
	}

	@Override
	public void daniado(int dmg) {
		
		this.setHp(this.getHp()-(dmg-this.getDefense()));
		
		if(this.getHp()<=0) {
			
			
			
		}
		
	}

}
