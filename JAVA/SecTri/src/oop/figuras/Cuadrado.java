package oop.figuras;

public class Cuadrado extends Figura {
	
	private double lado;

	public Cuadrado(String color,double lado) {
		super(color);
		this.lado=lado;
	}
	
	
	
	public double getLado() {
		return lado;
	}



	public void setLado(double lado) {
		this.lado = lado;
	}



	public double Area() {
		return lado*lado;
		
	}
	
	public double Perimetro() {
		return lado*4;
	}
	
	public String toString() {
	return super.toString()+"\nLado: "+lado+"\nArea: "+Area()+"\nPerimetro: "+Perimetro();	
	}
	
	public String I() {
		return "CUADRADO";
	}

}
