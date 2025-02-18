package oop.almacen;

import oop.fecha.Fecha;

public class Alimento extends Producto {
	
	private Fecha caducidad;

	public Alimento(int id, String nombre, double precio,Fecha caducidad) {
		super(id, nombre, precio);
		if(caducidad.Validez(caducidad.GetDia(),caducidad.GetMes(),caducidad.GetAnio())==true) {
			this.caducidad=caducidad;
		}
	}
	public double calcPrecio() {
		return precio;
	}

}