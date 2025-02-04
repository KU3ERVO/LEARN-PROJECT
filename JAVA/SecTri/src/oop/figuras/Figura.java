package oop.figuras;

public class Figura {

	private String color;

	public Figura(String color) {
		this.color = color;
		
	}

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
		
	}
	
	
	public String toString() {
		return "Color "+color;
	}
	
	public double Area() {
		return 0;
	}
	
	public double Perimetro() {
		return 0;
	}

}
