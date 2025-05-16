package rpg;

import java.util.Scanner;

public class GameManager {

	/**
	 * 
	 */
	private Player p1 = new Player("", 2000, 100, 50);
	Wave w = new Wave(p1);
	boolean exit = false;
	Scanner s = new Scanner(System.in);

	public GameManager() {

		startGame();

	}


	public void startGame() {

		System.out.println("                                   BIENVENIDO A TEXTPG VIAJERO"
				+ "\n Cual es tu nombre?");

		p1.setName(s.next());

		System.out.println("Bienvenido "+ p1.getName() + " te encuentras en una cueva" );

		inicio();
	}


	public void inicio() {

		exit = false;

		while (exit != true)
		{
			System.out.println("WELCOME TO TEXTPG\n\n[1] Start Game\n[2] Load Game\n[3] Settings\n[4] Exit");
			String input = s.next();
			switch (input)
			{

			case "1":
				System.out.println("THE GAME IS ON");
				gameLoop();
				break;

			case "2":
				System.out.println("YOU LOADED GAME X");
				break;
			case "3":
				System.out.println("OPTIONS");
				break;
			case "4":
				System.out.println("BYE");
				exit = true;
				break;
			default:
				System.out.println("thats not a valid input");
				break;
			}
		}
	}
	public void gameLoop() {

		exit = false;


		while (exit != true)
		{
			if(w.getOrda().getLast().isMuerto()==true) {
				w = new Wave(p1);}

			for(Enemy e : w.getOrda()) {

				while(e.isMuerto()!=true&&exit!=true) {

					System.out.println("                                                                        \n\n\n\n\n\n" +
							" ________________________¬                                        _________________________¬\n" +
							"| Player "+String.format("%-16.16s", p1.getName())+"|                                       | ENEMY "+String.format("%-16.16s", e.getName())+"  |\n" +
							"|                        |                                       |                         |\n" +
							"| HP: "+String.format("%-10.10s", p1.getHp())+"         |                                       | HP: "+String.format("%-16.16s", e.getHp())+"    |\n" +
							"| Level: "+String.format("%-16.16s", p1.getLvl())+"|                                       |                         |\n" +
							"|________________________|                                       |_________________________|\n" +
							"                                                                                            \n" +
							" ________________________¬                                                                  \n" +
							"|                        |                                                                  \n" +
							"| [1] Attack             |                                                                  \n" +
							"| [2] Heal               |                                                                  \n" +
							"| [3] Talk               |                                                                  \n" +
							"| [4] Exit & Save        |                                                                  \n" +
							"|________________________|                                      \n\n\n\n");

					String input = s.next();
					switch (input)
					{
					case "1":
						e.daniado(p1.getAttack());
						p1.daniado(e.getAttack());
						break;
					case "2":
						break;
					case "3":

						break;
					case "4":
						exit = true;
						inicio();
						break;
					default:
						System.out.println("not a valid input");
						break;
					}
				}
			}
		}
	}
	public void combat() {}
	public void talk() {}

}
