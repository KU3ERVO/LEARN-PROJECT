package Exam2ndEv;
/**
 * @author Angel Miguel Felipe
 * @version 1.0.0
 * 
 * CLASE main GranjaTest
 * **/
public class GranjaTest {

	public static void main(String[] args) {
		
		Perro p1 = new Perro("Fresita",5,2020,"Manuel","Bulldog","nose");
		Perro p2 = new Perro("Princess",10,2015,"Maria","Chihuahua","nose");
		
		Gato g1 = new Gato("Gato",3,2022,"Maria","gris","España");
		
		Granja gr1 = new Granja();
		
		gr1.addAnimal(g1);
		gr1.addAnimal(p1);
		gr1.addAnimal(p2);
		
		System.out.println(gr1.toString());
		
		gr1.vacunarGeneral();
		
		p2.enfermar("Pepe");
		
		System.out.println(gr1.toStringComer());
		System.out.println(gr1.toStringMover());
		System.out.println(gr1.toStringSonar());
		
		System.out.println("TOTAL ANIMALES "+ g1.getTotalAnimales());
		
		System.out.println(gr1.toString());

	}

}
