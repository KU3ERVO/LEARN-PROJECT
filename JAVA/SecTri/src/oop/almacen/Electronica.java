package oop.almacen;

public class Electronica extends Producto {
	
	private double plus = 0.20;

	public Electronica(int id, String nombre, double precio) {
		super(id, nombre, precio);
		precio += precio*plus;
	}

	public double getPlus() {
		return plus;
	}

	public void setPlus(double plus) {
		if(plus>=0&&plus<=1) {
		this.plus = plus;}
	}

}