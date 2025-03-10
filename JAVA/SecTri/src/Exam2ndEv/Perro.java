package Exam2ndEv;
/**
 * @author Angel Miguel Felipe
 * @version 1.0.0
 * 
 * CLASE HIJA Perro HEREDA Animal
 * **/
public class Perro extends Animal {
	
	private String raza, pedigri;

	public Perro(String nombre, int edad, int anioNac, String vet, String raza, String pedigri) {
		super(nombre, edad, anioNac, vet);
		this.pedigri=pedigri;
		this.raza=raza;
	}

	public String getRaza() {
		return raza;
	}

	public void setRaza(String raza) {
		this.raza = raza;
	}

	public String getPedigri() {
		return pedigri;
	}

	public void setPedigri(String pedigri) {
		this.pedigri = pedigri;
	}
	
	
	public String hacerSonido() {
		return"GUAU GUAUUU";
	}
	
	public String comer() {
		return "croquetas";
	}
	
	public String moverse() {
		return "corre";
	}
	
	public String toString() {
		return "PERRO\n\nRaza: "+raza+"\nPedigrí: "+pedigri+"\n"+super.toString();
	}



}
