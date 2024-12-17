package oop.coche;

public class MainCoche {
	
	public static void main (String []args) {
	
	Coche car1 = new Coche("Lexus","CRX","negro", 400, 1, 4, 50000, 120);
	Coche car2 = new Coche("Toyota","Supra","rojo", 700, 1, 2, 27000, 100);
	
	car1.acelerar(30);
	car1.pintarCoche();
	
	car1.sysoDatos();
	
	}
}
