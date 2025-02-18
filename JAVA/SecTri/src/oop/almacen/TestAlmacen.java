package oop.almacen;
import oop.fecha.Fecha;

public class TestAlmacen {

	public static void main(String[] args) {
		
		Fecha f = new Fecha(10, 11, 2000);
	
		Ropa r1 = new Ropa(12,"pijama", 30, "algodón");
		Electronica e1 = new Electronica(4,"mp3",80);
		Alimento a1 = new Alimento(78,"pizza",3.5, f);
		
		Venta v1 = new Venta(1);
		
		v1.addProducto(a1);
		v1.addProducto(e1);
		v1.addProducto(r1);
		
		System.out.println(v1.suma());

	}

}
