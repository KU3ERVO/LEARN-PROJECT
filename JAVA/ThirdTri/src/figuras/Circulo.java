package figuras;

public class Circulo extends Figura implements Colorear {

	public Circulo(int x, int y) {
		super(x, y);
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

	public String colorear() {
		this.color="rojo";
		return "se cambió el color a rojo";
	}

}
