package oop.fecha;

public class Fecha {

	private int dia,mes,anio;

	Fecha(){		
	}

	Fecha(int dia, int mes, int anio){
		if (Validez(dia, mes, anio)==true) {
			this.dia=dia;
			this.mes=mes;
			this.anio=anio;
		}
	}

	public boolean Validez(int dia, int mes , int anno) {

		boolean validez=true;
		
		switch (mes) {
		//MESES DE 31 DIAS
		case 1 , 3 , 5 , 7 , 8 , 10 , 12:

			if(dia>31) {

				validez = false;	
			}
			else {
				
				validez =true;
			}
		break;
		//FEBRERO EXCEEPCION
		case 2:

			if((anno%4)==0) {

				if(dia>29) {

					validez = false;
				}

				else {

					validez=true;
				}
			}

			else {

				if(dia>28) {

					validez=false;
				}

				else {

					validez=true;
				}
			}
			break;

			//MESES 30 DIAS
		case 4 , 6 , 9 , 11:

			if(dia>30) {

				validez=false;
			}
			else {

				validez=true;
			}
		
		break;

		default:
			validez=false;
			break;



		}
		return validez;
	}
	
	public void SetDia(int dia) {
		if(Validez(dia, mes, anio)==true) {
			this.dia=dia;
		}
	}
	public void SetMes(int mes) {
		if ((mes>0)&&(mes<13)) {
			this.mes=mes;
		}
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
