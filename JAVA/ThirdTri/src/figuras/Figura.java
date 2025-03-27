package figuras;

public abstract class Figura {
	
	protected int x,y;
	protected String color;

	public Figura(int x,int y) {
		this.x=x;
		this.y=y;
	}

	public String toString() {
		return "\n\n";
	}
	
	public abstract double Area();
	
	public abstract double Perimetro();
	
	public abstract String mostrarPosicion();

	public int getX() {
		return x;
	}

	public void setX(int x) {
		this.x = x;
	}

	public int getY() {
		return y;
	}

	public void setY(int y) {
		this.y = y;
	}

}
