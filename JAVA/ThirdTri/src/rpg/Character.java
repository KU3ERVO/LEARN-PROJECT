/**
 * 
 */
package rpg;

import java.io.Serializable;

/**
 * @author Angel Miguel Felipe
 * @version 1.0.0
 * 
 * CLASE CHARACTER
 * 
 * Es la clase padre de la que heredarán todos nuestros personajes, ya sean jugables o no jugables
 * 
 */

public abstract class Character implements Serializable{
	
	private String name;
	private int hp;
	private int attack;
	private int defense;
	/**
	 * @param name
	 * @param hp
	 * @param attack
	 * @param defense
	 */
	public Character(String name, int hp, int attack, int defense) {
		
		this.name = name;
		this.hp = hp;
		this.attack = attack;
		this.defense = defense;
	}
	
	/**
	 * @return the name
	 */
	public String getName() {
		return name;
	}
	/**
	 * @param name the name to set
	 */
	public void setName(String name) {
		this.name = name;
	}
	/**
	 * @return the hp
	 */
	public int getHp() {
		return hp;
	}
	/**
	 * @param hp the hp to set
	 */
	public void setHp(int hp) {
		this.hp = hp;
	}
	/**
	 * @return the attack
	 */
	public int getAttack() {
		return attack;
	}
	/**
	 * @param attack the attack to set
	 */
	public void setAttack(int attack) {
		this.attack = attack;
	}
	/**
	 * @return the defense
	 */
	public int getDefense() {
		return defense;
	}
	/**
	 * @param defense the defense to set
	 */
	public void setDefense(int defense) {
		this.defense = defense;
	}

	@Override
	public String toString() {
		
		return "Nombre: " + this.name + "\n\nVida: " + this.hp + "\nAtaque: " + this.attack;
	}
	
	
	

}
