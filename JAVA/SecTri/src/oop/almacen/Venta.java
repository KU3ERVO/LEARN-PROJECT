package oop.almacen;

public class Venta {
	
	private int ventaId,contProducto=0;
	private Producto [] productos;
	
	public Venta(int ventaId) {
		this.ventaId = ventaId;
		this.productos = new Producto [20];
	}
	
	public void addProducto (Producto p) {
		if(contProducto<productos.length) {
		productos [contProducto] = p;
		contProducto++;}
	}
	
	public double suma() {
		double suma = 0;
		for(int i = 0;i<this.contProducto;i++) {
			suma+=productos[i].calcPrecio();
		}
		
		return suma;
	}

}