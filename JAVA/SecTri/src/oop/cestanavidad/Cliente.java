package oop.cestanavidad;

import oop.persona.Persona;

public class Cliente {
	
	private String nombre="nombre",apellidos="1apellido 2apellido",dni="00000000X",tipoOrg="organizacion";

	public Cliente(String nombre, String apellidos, String dni, String tipoOrg) {

		this.nombre = nombre;
		this.apellidos = apellidos;
		this.dni = dni;
		if(tipoOrg=="empresa"||tipoOrg=="particular") {
			this.tipoOrg = tipoOrg;}
	}
	
	

}
