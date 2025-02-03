package oop.cestanavidad;

public class Cesta {
	
	private Producto [] productos;
	private Cliente cliente;
	private int numProducto=0,sumPrecio=0;
	
	public Cesta(Cliente cliente) {
	
		productos = new Producto [20];
		this.cliente = cliente;
	}
	
	public void addProduct(Producto producto) {
		
		if((sumPrecio+producto.getPrecio())<=100) {
		productos[numProducto]=producto;
		numProducto++;
		sumPrecio+=producto.getPrecio();}
		else {
			System.out.println("has sobrepasado el maximo de precio de 100");
		}
	}
	
	public void delProducto(Producto producto) {
		
		boolean llave = false;
		int i = 0;

		for(i=0;i<productos.length&&productos[i]!=null;i++) {
			if(productos[i]!=null) {
				
				llave=productos[i].getCodProducto()==(producto.getCodProducto());
				if(llave==true) {
					
					this.productos[i]=null;
					llave=false;
					}
				}
		}
		
		while(i+1<productos.length&&productos[i+1]!=null){
			
			productos[i+1]=productos[i];
			i++;
			
		}
		
		numProducto--;
	}
	
	public String toStringPrecio(){
		return "Precio total: "+sumPrecio;
	}
	
	public String toString() {
		
		String datos = "CESTA DE "+ cliente.getOrg()+" "+cliente.getNombre()+" "+cliente.getApellidos()
		+"\nDNI: "+cliente.getDni()+"\n\nPrecio: "+sumPrecio+"\n\n";
		
		for(int i = 0;i<productos.length&&productos[i]!=null;i++) {
			datos += productos[i].toString()+"\n\n";
		}
		
		return datos;
	}
	
	public String aptaCeliacos() {
		
		boolean apto=true;
		for(int i = 0;i<productos.length&&productos[i]!=null;i++) {
			
			apto = productos[i].getGluten();
			
		}
		
		if(apto!=true) {
			return"apto";
		}
		else {
			return"no apto para celiacos";
		}
	}
	

}
