package oop.fecha;
import java.util.Date;
public class TestFecha {

	public static void main(String[] args) {
		
		Date ld = new Date();

		Fecha f1 = new Fecha(31, 12, 2000);
		
		System.out.println(f1.toString());
		System.out.println(ld);

	}

}
