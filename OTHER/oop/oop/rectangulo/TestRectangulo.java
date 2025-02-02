package oop.rectangulo;

public class TestRectangulo {

	public static void main(String[] args) {
		
		Rectangulo r1 = new Rectangulo();
		Rectangulo r2 = new Rectangulo();
		
		r1.SetAltura(2);
		r1.SetBase(1);
		//comprobado que no mantiene valores iguales para que no sea cuadrado
		r2.SetAltura(40);
		r2.SetBase(40);
		
		System.out.println("R1 Area: " + r1.Area() + "\nperimetro: " + r1.Perimetro());
		System.out.println("R2 Area: " + r2.Area() + "\nperimetro: " + r2.Perimetro());
		
	}

}
