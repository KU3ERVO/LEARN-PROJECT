package oop.cestanavidad;

public class Producto {
	private static int id = 25600;
	private int codProducto;
	private int precio;
	private boolean gluten;
	private enum tipoProductos{DULCE,SALADO,BEBIDA}
	private String nombre;
	
	public Producto(int codProducto, int precio, boolean gluten, String nombre) {
		this.codProducto = codProducto;
		this.precio = precio;
		this.gluten = gluten;
		this.nombre = nombre;
	}
	
	
	
	
}
