package oop.fecha;

public class Fecha {
	
	private int dia,mes,anio;
	
	Fecha(){		
	}
	
	Fecha(int dia, int mes, int anio){
		this.dia=dia;
		this.mes=mes;
		this.anio=anio;
	}
	
	public void SetDia(int dia) {
		if((dia<31)&&(dia>0)) {
		this.dia=dia;}
	}
	public void SetMes(int mes) {
		if((mes>0)&&(mes<13)) {
		this.mes=mes;}
	}
	public void SetAnio(int anio) {
		this.anio=anio;
	}
	public int GetDia() {
		return dia;
	}
	public int GetMes() {
		return mes;
	}
	public int GetAnio() {
		return anio;
	}
	public String toString() {
		String fecha = dia + " | " + mes + " | " + anio;
		return fecha;
	}
	public boolean equals(int dia,int mes,int anio) {
		boolean igual = false;
		if ((this.dia == dia)&&(this.mes==mes)&&(this.anio==anio)) {
			igual = true;
		}
		return igual;
	}

}
