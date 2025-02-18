package oop.almacen;

public class Ropa extends Producto {
	
	private String material;

	public Ropa(int id, String nombre, double precio,String material) {
		super(id, nombre, precio);
		this.material=material;
	}

	public String getMaterial() {
		return material;
	}

	public void setMaterial(String material) {
		this.material = material;
	}
	public double calcPrecio() {
		return precio;
	}
	
	

}
