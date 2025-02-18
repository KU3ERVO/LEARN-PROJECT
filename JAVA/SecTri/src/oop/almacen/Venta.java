package oop.almacen;

public class Venta {
	
	private int ventaId,i=0;
	private Producto [] productos;
	
	public Venta(int ventaId) {
		this.ventaId = ventaId;
		this.productos = new Producto [20];
	}
	
	public void addProducto (Producto p) {
		if(i<productos.length) {
		productos [i] = p;
		i++;}
	}
	
	public double suma() {
		double suma = 0;
		for(Producto p : productos) {
			if(p instanceof Ropa) {
				suma+=((Ropa)p).getPrecio();
			}
			if(p instanceof Alimento) {
				suma+=((Alimento)p).getPrecio();
			}
			if(p instanceof Electronica) {
				suma+=((Electronica)p).getPrecio();
			}
		}
		
		return suma;
	}

}