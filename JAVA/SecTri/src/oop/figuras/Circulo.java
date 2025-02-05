package oop.figuras;

public class Circulo extends Figura{
	
	private double radio;

	public Circulo(double radio,String color) {
		super(color);
		this.radio = radio;
	}

	public double getRadio() {
		return radio;
	}

	public void setRadio(double radio) {
		this.radio = radio;
	}
	
	public double Area() {
		return Math.PI*(radio*radio);
	}
	
	public double Perimetro() {
		return 2*Math.PI*radio;
	}
	
	
	
	
	
	



}
