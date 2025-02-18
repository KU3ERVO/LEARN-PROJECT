package oop.almacen;
/*PRODUCTOS DE ALIMENTACION:
 * ELECTRONICA PLUS GARANTIA
 * ALIMENTACION FECHA CADUCIDAD
 * ROPA MATERIAL
 * ARRAYLIST VENTA
 * Utilizar producto[i] instanceof Ropa          ((Ropa)producto[i].getMaterial())
 * */
public class Producto { 
	protected static int totalId = 1000;
	protected int id;
	protected String nombre;
	protected double precio;
	public Producto(int id, String nombre, double precio) {
		super();
		this.id = id+totalId;
		this.nombre = nombre;
		this.precio = precio;
	}
	
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getNombre() {
		return nombre;
	}
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	public double calcPrecio() {
		return 0;
	}
	public void setPrecio(double precio) {
		this.precio = precio;
	}

}
