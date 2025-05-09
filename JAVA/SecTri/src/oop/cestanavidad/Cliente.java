package oop.cestanavidad;

import oop.persona.Persona;

public class Cliente {
	
	private String nombre,apellidos,dni;
	private TipoOrg org;

	public Cliente(String nombre, String apellidos, String dni, TipoOrg org) {

		this.nombre = nombre;
		this.apellidos = apellidos;
		this.dni = dni;
		this.org = org;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getApellidos() {
		return apellidos;
	}

	public void setApellidos(String apellidos) {
		this.apellidos = apellidos;
	}

	public String getDni() {
		return dni;
	}

	public void setDni(String dni) {
		this.dni = dni;
	}

	public TipoOrg getOrg() {
		return org;
	}

	public void setOrg(TipoOrg org) {
		this.org = org;
	}
	
	

}
