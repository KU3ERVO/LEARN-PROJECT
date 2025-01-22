package oop.fecha;
public class TestFecha {

	public static void main(String[] args) {

		Fecha f1 = new Fecha(20, 1, 2025);
		Fecha f2 = new Fecha();
		f2.FechaActual();
		
		System.out.println(f1.toString());
		System.out.println(f2.toString());
		System.out.println(f1.equals(f2));

	}

}
