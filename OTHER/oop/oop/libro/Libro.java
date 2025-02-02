package oop.libro;

import oop.fecha.Fecha;
import oop.persona.Persona;

public class Libro {

	private String titulo,iSBN,editorial,ciudad,pais,lugar;
	private Persona persona;
	private Fecha fecha;
	private int pags,edicion=1;
	public Libro(String titulo, String iSBN, int edicion, String editorial, String ciudad, String pais,
			Persona persona, Fecha fecha, int pags) {
		super();
		this.titulo = titulo;
		this.iSBN = iSBN;
		this.edicion = edicion;
		this.editorial = editorial;
		this.ciudad = ciudad;
		this.pais = pais;
		this.persona = persona;
		this.fecha = fecha;
		this.pags = pags;
		this.lugar=this.ciudad+" "+this.pais;
	}
	
	public Libro(String titulo, String iSBN, String editorial, Persona persona, Fecha fecha) {
		super();
		this.titulo = titulo;
		this.iSBN = iSBN;
		this.editorial = editorial;
		this.persona = persona;
		this.fecha = fecha;
	}

	public String getTitulo() {
		return titulo;
	}
	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}
	public String getISBN() {
		return this.iSBN;
	}
	public void setISBN(String iSBN) {
		this.iSBN = iSBN;
	}
	public int getEdicion() {
		return edicion;
	}
	public void setEdicion(int edicion) {
		this.edicion = edicion;
	}
	public String getEditorial() {
		return editorial;
	}
	public void setEditorial(String editorial) {
		this.editorial = editorial;
	}
	public String getCiudad() {
		return ciudad;
	}
	public void setCiudad(String ciudad) {
		this.ciudad = ciudad;
	}
	public String getPais() {
		return pais;
	}
	public void setPais(String pais) {
		this.pais = pais;
	}
	public Persona getPersona() {
		return persona;
	}
	public void setPersona(Persona persona) {
		this.persona = persona;
	}
	public Fecha getFecha() {
		return fecha;
	}
	public void setFecha(Fecha fecha) {
		this.fecha = fecha;
	}
	public int getPags() {
		return pags;
	}
	public void setPags(int pags) {
		this.pags = pags;
	}

	public String toString() {
		return "Titulo: "+this.titulo
				+"\n"+this.edicion+"a. edición"
				+ "\nAutor: "+this.persona.getNombre()+" "+this.persona.getApellidos()
				+ "\nISBN: "+this.iSBN
				+ "\n"+this.lugar+" "+this.fecha
				+"\n"+this.pags+" páginas"
				;
	}


}
