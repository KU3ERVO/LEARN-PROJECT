package oop.cestanavidad;

public class Producto {
	private static int id =   0;
	private int codProducto;
	private int precio;
	private boolean gluten;
	private String nombre;
	private TipoProducto tp;
	
	public Producto( int precio, boolean gluten, String nombre, TipoProducto tp) {
		this.codProducto = id +1;
		this.precio = precio;
		this.gluten = gluten;
		this.nombre = nombre;
		id++;
		this.tp=tp;
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

	public boolean getGluten() {
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
	
	public String toString() {
		
		return "CODE: "+ codProducto
				+"\nTipo: "+ nombre
				+" "+precio+"€"
				+"\nTipo "+tp;
	}
	
	
	
	
	
}
