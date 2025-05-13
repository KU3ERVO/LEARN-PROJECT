package rpg;

import java.util.Scanner;

public class GameManager {

	/**
	 * 
	 */
	private Player p1 = new Player("", 20, 50, 2000);
	
	public GameManager() {
		
		startGame();
		
	}
	
	public void startGame() {
		
		Scanner s = new Scanner(System.in);
		
		System.out.println("                                   BIENVENIDO A TEXTPG VIAJERO"
				+ "\n Cual es tu nombre?");
		
		p1.setName(s.next());
		
		System.out.println("Bienvenido "+ p1.getName() + " te encuentras en una cueva" );
	}
	
	public void inicio() {}
	public void gameLoop() {}
	public void combat() {}
	public void talk() {}

}
