/**
 * 
 */
package rpg;

import java.util.ArrayList;
import java.util.Collections;

/**
 * 
 */
public class Wave {
	


	private ArrayList <Enemy> orda;

	
	
	public Wave(Player p) {
		
		this.orda = new ArrayList<Enemy>();
		crearOrda(p);
		Collections.sort(this.orda);
		
	}
	
	
	
	
	public ArrayList<Enemy> getOrda() {
		return orda;
	}

	public void setOrda(ArrayList<Enemy> orda) {
		this.orda = orda;
	}
	
	
	
	
	
	public void crearOrda(Player p) {
		
		double prob;
		
		for(int i = p.getLvl();i>=0;i--) {
			
			prob = Math.random();
			
			if(prob <= 0.6) {
				this.orda.add(new Goblin(null, i, i, i, i));		
			}
			else if (prob > 0.6 && prob < 0.9) {
				this.orda.add(new Orco(null, i, i, i, i));
			}
			else {this.orda.add(new Boss(null, i, i, i, i));}
			
		}
		
		
		
	}

}
