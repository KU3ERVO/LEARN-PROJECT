package Exam2ndEv;
/**
 * @author Angel Miguel Felipe
 * @version 1.0.0
 * 
 * CLASE Cartilla
 * **/
public class Cartilla {
	
	private int anioNac,vacunas,enfermedades;
	private String veterinario;
	
	public Cartilla(int anioNac, int vacunas, int enfermedades, String veterinario) {
		super();
		this.anioNac = anioNac;
		if(vacunas>=0) {
			this.vacunas = vacunas;}
		if (enfermedades>=0) {
			this.enfermedades = enfermedades;}
		this.veterinario = veterinario;
	}

	public int getAnioNac() {
		return anioNac;
	}

	public void setAnioNac(int anioNac) {
		this.anioNac = anioNac;
	}

	public int getVacunas() {
		return vacunas;
	}

	public void setVacunas(int vacunas) {
		if(vacunas>=0) {
		this.vacunas = vacunas;}
	}

	public int getEnfermedades() {
		return enfermedades;
	}

	public void setEnfermedades(int enfermedades) {
		if (enfermedades>=0) {
		this.enfermedades = enfermedades;}
	}

	public String getVeterinario() {
		return veterinario;
	}

	public void setVeterinario(String veterinario) {
		this.veterinario = veterinario;
	}
	
	
	

}
