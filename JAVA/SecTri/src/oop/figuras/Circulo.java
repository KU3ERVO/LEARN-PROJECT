package oop.figuras;

public class Circulo extends Figura{
	
	private double area;
	private double radio;

	public Circulo(double radio,String color) {
		super(color, area);
		this.radio = radio;
		area = Math.PI*Math.pow(radio, 2);
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
	
	
	
	
	
	



}
