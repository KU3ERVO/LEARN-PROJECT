package oop.modulodireccion;



public class ModuloDeDirecciones {
	
	
	private String tipoVia;
	private String nombreVia;
	private int portal;
	private int escalera;
	private char puerta;
	
	private int codPostal;
	
	private String localidad;
	private String provincia;
	private String pais;
	
	ModuloDeDirecciones(String tipoVia,String nombreVia, int portal, int escalera, char puerta, int codPostal,String localidad, String provincia, String pais){
	
	
	this.tipoVia = tipoVia;
	this.nombreVia = nombreVia;
	this.portal = portal;
	this.escalera = escalera;
	this.puerta = puerta;
	this.codPostal = codPostal;
	this.localidad = localidad;
	this.provincia = provincia;
	this.pais = pais;
	
	}
	
	 public void prt() {
		
		 System.out.println(tipoVia + " " + nombreVia + " " + portal + " " + escalera + "º" + puerta + "\nCP: " + codPostal + "\n" + localidad + " " + provincia + " " + pais);
	}
	 
}
	
/*Ejercicio 1.

Se desea modelar una entidad que almacene los datos de residencia que llamaremos Dirección.

Según el enunciado, tenemos los siguientes requisitos:

- Una dirección se compone de:

Un tipo de vía que puede ser: Calle, Avenida, Callejón, Pasaje, Pasadizo, etc. Suele ser un valor alfanumérico.
El nombre de la vía. Lo que entendemos como Calle.
Un número de portal.
Número de escalera.
Identificador de la puerta. Puede ser un número o una letra.
Código postal.
Localidad
Provincia 
País
- Entendemos que una entidad Dirección tiene "vida" cuando tiene como mínimo: Tipo de vía, Nombre y número. Pero también puede ocurrir que tengamos todos los datos para crear un objeto Dirección.

- Todos los datos pueden ser modificados.



Se pide:

- Diseña la clase correspondiente con todos sus métodos, etc.

- Crea un programa principal que tenga cinco objetos de tipo Dirección e imprime en pantalla todos sus datos.*/




