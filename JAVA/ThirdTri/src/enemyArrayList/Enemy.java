package enemyArrayList;

public class Enemy {
	
	protected double speed,hp;
	protected int attack;
	String name;

	public Enemy(double speed, double hp, int attack,String name) {
		this.speed = speed;
		this.hp = hp;
		this.attack = attack;
		this.name=name;
	}

	public double getSpeed() {
		return speed;
	}

	public void setSpeed(double speed) {
		this.speed = speed;
	}

	public double getHp() {
		return hp;
	}

	public void setHp(double hp) {
		this.hp = hp;
	}

	public int getAttack() {
		return attack;
	}

	public void setAttack(int attack) {
		this.attack = attack;
	}
	
	public String toString() {
		return "\n\n"+name+"\n\nAtaque: "+attack+"\nVelocidad: "+speed+"\nVida: "+hp;
	}

}
