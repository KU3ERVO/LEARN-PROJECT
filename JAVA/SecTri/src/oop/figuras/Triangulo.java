package oop.figuras;

public class Triangulo extends Figura {
	
	private double base,altura;

	public Triangulo(String color,double base, double altura) {
		super(color);
		this.altura = altura;
		this.base = base;

	}

	public double getBase() {
		return base;
	}

	public void setBase(double base) {
		this.base = base;
	}

	public double getAltura() {
		return altura;
	}

	public void setAltura(double altura) {
		this.altura = altura;
	}
	
	public double Area() {
	return (base*altura)/2;
	}
	
	public double Perimetro() {
		return base*3;
	}
	
	public String toString() {
		return super.toString()+"\nBase: "+base+" Altura: "+altura+"\nArea: "+Area()+"\nPerimetro: "+Perimetro();	
		}
	public String T() {
		return "TRIANGULO";
	}

}
