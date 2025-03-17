package figuraAbstracta;

public class Triangulo extends Figura {

	

	public Triangulo(int x, int y) {
		super(x, y);
		c=Color.AMARILLO;
	}

	public double Area() {
		return 20;
	}

	public double Perimetro() {
		return 10;
	}

	public String mostrarPosicion() {
		return x+","+y;
	}

}
