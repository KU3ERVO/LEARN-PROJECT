package figuraAbstracta;

public class Circulo extends Figura {

	public Circulo(int x, int y) {
		super(x, y);
		c=Color.AZUL;
	}

	public double Area() {
		return 3;
	}

	public double Perimetro() {
		return 2;
	}

	public String mostrarPosicion() {
		return x+","+y;
	}

}
