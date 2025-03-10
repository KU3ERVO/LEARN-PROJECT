package Exam2ndEv;
/**
 * @author Angel Miguel Felipe
 * @version 1.0.0
 * 
 * CLASE HIJA Gato HEREDA Animal
 * **/
public class Gato extends Animal {
	
	private String color,pais;

	public Gato(String nombre, int edad, int anioNac, String vet, String color, String pais) {
		super(nombre, edad, anioNac, vet);
		this.pais=pais;
		this.color=color;
	}
	
	

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public String getPais() {
		return pais;
	}

	public void setPais(String pais) {
		this.pais = pais;
	}
	
	
	
	public String hacerSonido() {
		return"MIAU MIAUUUU";
	}
	
	public String comer() {
		return "pescado";
	}
	
	public String moverse() {
		return "saltitos";
	}
	
	public String toString() {
		return "GATO\n\nColor: "+color+"\nPais de origen: "+pais+"\n"+super.toString();
	}

}
