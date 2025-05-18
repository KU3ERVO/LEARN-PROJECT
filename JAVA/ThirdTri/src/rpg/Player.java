/**
 * 
 */
package rpg;

import java.io.Serializable;

/**
 * 
 */
public class Player extends Character implements Daniable,Serializable {

	private int lvl;
	private int exp;
	private int maxHp;

	/**
	 * @param name
	 * @param hp
	 * @param attack
	 * @param defense
	 */
	public Player(String name, int hp, int attack, int defense) {
		super(name, hp, attack, defense);
		this.setLvl(1);
		this.setExp(0);
		this.setMaxHp(hp);
	}





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
	/**
	 * @return the maxHp
	 */
	public int getMaxHp() {
		return maxHp;
	}
	/**
	 * @param maxHp the maxHp to set
	 */
	public void setMaxHp(int maxHp) {
		this.maxHp = maxHp;
	}





	@Override
	public void daniado(int dmg) {

		if(dmg-this.getDefense()<=0){
		}
		else {

			this.setHp(this.getHp()-(dmg-this.getDefense()));

			if(this.getHp()<=0) {

				this.setHp(0);
			}
		}

	}

	public void lvlUp(int exp) 
	{
		this.exp += exp;
		while(this.exp>=(this.lvl*100)) {

			this.exp -= this.lvl*100;
			this.lvl++;
			this.setAttack(this.getAttack()+50);
			this.setDefense(this.getDefense()+10);
			this.setMaxHp(this.getMaxHp()+250);
			this.setHp(this.getMaxHp());

		}

	}

}
