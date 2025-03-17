package figuraAbstracta;

public class Cuadrado extends Figura {

	public Cuadrado(int x, int y) {
		super(x, y);
		c=Color.ROJO;
	}

	public double Area() {
		return 85;
	}

	public double Perimetro() {
		return 30;
	}

	public String mostrarPosicion() {
		return x+","+y;
	}

}
