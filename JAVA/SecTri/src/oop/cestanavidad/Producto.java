package oop.cestanavidad;

public class Producto {
	private static int id =   0;
	private int codProducto;
	private int precio;
	private boolean gluten;
	private String nombre;
	
	public Producto(int codProducto, int precio, boolean gluten, String nombre) {
		this.codProducto = codProducto;
		this.precio = precio;
		this.gluten = gluten;
		this.nombre = nombre;
	}

	public static int getId() {
		return id;
	}

	public static void setId(int id) {
		Producto.id = id;
	}

	public int getCodProducto() {
		return codProducto;
	}

	public void setCodProducto(int codProducto) {
		this.codProducto = codProducto;
	}

	public int getPrecio() {
		return precio;
	}

	public void setPrecio(int precio) {
		this.precio = precio;
	}

	public boolean isGluten() {
		return gluten;
	}

	public void setGluten(boolean gluten) {
		this.gluten = gluten;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	
	
	
	
	
}
