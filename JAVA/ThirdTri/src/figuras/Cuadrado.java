package figuras;

public class Cuadrado extends Figura implements Colorear{

	public Cuadrado(int x, int y) {
		super(x, y);
		// TODO Auto-generated constructor stub
	}

	@Override
	public double Area() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public double Perimetro() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public String mostrarPosicion() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public String colorear() {
		
		this.color="Esmeralda";
		return "Se cambió el color a esmeralda";
	}

}
