package oop.tiempo;

public class TestTiempo {

	public static void main(String[] args) {
		Tiempo t1 = new Tiempo(24, 65, 02);
		Tiempo t2 = new Tiempo(23);
		
		System.out.println(t1.toString());
		
		t1.setMin(23);
		t1.setSeg(40);
		
		System.out.println(t1.toString());
		
		t2.setMin(58);
		t2.setSeg(50);
	
		t2.RelojOn();


	}

}
