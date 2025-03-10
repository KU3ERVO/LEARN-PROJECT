package Exam2ndEv;

public class Granja {

	private Animal [] animales;
	private int contadorAnimales = 0;

	public Granja() {

		animales = new Animal [3];
	}

	public void addAnimal(Animal a) {

		this.animales[this.contadorAnimales]=a;
		this.contadorAnimales++;

	}

	public String toString() {

		String datos ="";

		for(Animal a : animales) {
			datos+=a.toString()+"\n\n\n";
		}

		return datos;
	}

	public String toStringMover() {

		String datos ="";

		for(Animal a : animales) {
			datos+=a.moverse()+"\n\n\n";
		}

		return datos;
	}

	public String toStringComer() {

		String datos ="";

		for(Animal a : animales) {
			datos+=a.comer()+"\n\n\n";
		}

		return datos;
	}

	public String toStringSonar() {

		String datos ="";

		for(Animal a : animales) {
			datos+=a.hacerSonido()+"\n\n\n";
		}

		return datos;
	}

	public void vacunarGeneral() {

		for(Animal a : animales) {
			a.vacunar(a.getCartilla().getVeterinario());
		}

	}

}
