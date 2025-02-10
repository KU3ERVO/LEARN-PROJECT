package oop.cestanavidad;
public class TestCesta {
	
	public static void main (String[] args) {
	
	Producto p1 = new Producto(40, false,"Jamón",TipoProducto.SALADO);
	Producto p2 = new Producto(8,true,"Mazapán",TipoProducto.DULCE);
	Producto p3 = new Producto(5, true,"Turrón",TipoProducto.DULCE);
	Producto p4 = new Producto(10,true,"Foie",TipoProducto.SALADO);
	Producto p5 = new Producto(8, false,"Sidra",TipoProducto.BEBIDA);
	Producto p6 = new Producto(15,false,"Cava",TipoProducto.BEBIDA);
	
	Cliente lola = new Cliente("Lola","Floreh","5555555R",TipoOrg.EMPRESA);
	Cliente paco = new Cliente("Francisco","Maria Gomero","01010101X",TipoOrg.PARTICULAR);
	
	Cesta c1 = new Cesta(lola);
	Cesta c2 = new Cesta(paco);
	
	c1.addProduct(p1);
	c1.addProduct(p6);
	c1.addProduct(p3);
	c1.addProduct(p3);
	c1.addProduct(p3);
	c1.addProduct(p1);
	
	c2.addProduct(p1);
	c2.addProduct(p1);
	
	System.out.println(c1.toString()+"\n"+c1.aptaCeliacos()+"\n\n");
	System.out.println(c2.toString()+"\n"+c2.aptaCeliacos());
	}
}
