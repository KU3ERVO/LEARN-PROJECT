package oop.figuras;

public class Cuadrado extends Figura {
	
	private double lado;

	public Cuadrado(String color,double lado) {
		super(color);
		this.lado=lado;
	}
	
	public double Area() {
		return lado*lado;
		
	}
	
	public double Perimetro() {
		return lado*4;
	}

}
