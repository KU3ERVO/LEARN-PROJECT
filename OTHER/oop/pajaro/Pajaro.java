package oop.pajaro;

public class Pajaro {
	
	private static int numPajaros;
	private String color;
	private int idPajaro=10000;
	//CONSTRUCTOR
	Pajaro(){
		nuevoPajaro();
	}
	
	public void nuevoPajaro() {
		
		numPajaros++;
		idPajaro+=numPajaros;
		
		double j=(Math.random()*(3-1+1))+1;
		int i = (int) j;
		switch (i) {
		
		case 1:
			color = "verde";
			break;
		case 2:
			color = "blanco";
			break;
		case 3:
			color = "negro";
			break;
		}
	}
	
	public String toString() {
		return "\n\ncolor " + color + "\nid " + idPajaro + "\nnum Pajaros " + numPajaros;
	}

}
