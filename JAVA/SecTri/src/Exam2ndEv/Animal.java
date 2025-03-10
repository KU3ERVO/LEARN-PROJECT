package Exam2ndEv;
/**
 * @author Angel Miguel Felipe
 * @version 1.0.0
 * 
 * CLASE PADRE Animal
 * **/
public class Animal {
	
	/**
	 * @Atributo Nombre: el nombre del animal
	 * @Atributo totalAnimales: la suma de los animales que se hayan creado
	 * @Atributo Cartilla: contiene los datos de la cartilla médica del animal
	 * @Atributo edad: la edad del animal**/
	
	private String nombre;
	private static int totalAnimales = 0;
	private Cartilla cartilla;
	private int edad;
	
	/**
	 * CONSTRUCTOR
	 * 
	 * @param nombre: nombre del animal
	 * @param edad: edad del animal (no puede ser negativa)
	 * @param anioNac: el año de nacimiento del animal, es un atributo de la cartilla
	 * @param vet: nombre del veterinario encargado del animal, atributo de cartilla
	 * @param Cartilla: creamos una cartilla nueva cada vez que creamos un nuevo animal (agregacion fuerte) con vacunas y enfermedades a 0**/
	
	
	public Animal(String nombre, int edad,int anioNac,String vet) {
		totalAnimales++;
		this.nombre = nombre;
		this.cartilla = new Cartilla(anioNac,0,0, vet);
		if (edad>=0) {
		this.edad = edad;}
	}
	
	/**
	 * GETS Y SETS
	 * **/
	
	public String getNombre() {
		return nombre;
	}
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	public static int getTotalAnimales() {
		return totalAnimales;
	}
	public Cartilla getCartilla() {
		return cartilla;
	}
	public void setCartilla(Cartilla cartilla) {
		this.cartilla = cartilla;
	}
	public int getEdad() {
		return edad;
	}
	
	/**
	 * @METHOD setEdad : pide un número entero para establecer la edad del animal (si la edad es negativa no se reestablecera)
	 **/
	
	public void setEdad(int edad) {
		if (edad>=0) {
			this.edad = edad;}
	}
	
	/**
	 * METODOS
	 * **/
	/**
	 * @METHOD hacerSonido : devuelve un String con el sonido que hace el animal
	 **/
	
	public String hacerSonido() {
		return"";
	}
	
	/**
	 * @METHOD comer : devuelve un String con lo que come el animal
	 **/
	
	public String comer() {
		return"";
	}
	
	/**
	 * @METHOD moverse : devuelve un String con la manera en la que se mueve el animal
	 **/
	
	public String moverse() {
		return"";
	}
	
	/**
	 * @METHOD enfermar : pide un veterinario para que diagnostique una enfermedad al animal y suma 1 a la cuenta de enfermedades del animal
	 * @param vet : el veterinario que diagnosticará la enfermedad
	 **/
	
	
	public void enfermar(String vet) {
		
		cartilla.setVeterinario(vet);
		cartilla.setEnfermedades(cartilla.getEnfermedades()+1);
		
	}
	
	/**
	 * @METHOD vacunar : pide un veterinario para que ponga la vacuna al animal y suma 1 a la cuenta de vacunas del animal
	 * @param vet : el veterinario que pondrá la vacuna
	 **/
	
	public void vacunar(String vet) {
		
		cartilla.setVeterinario(vet);
		cartilla.setVacunas(cartilla.getVacunas()+1);
		
	}
	
	/**
	 * @METHOD toString : devuelve un String con toda la informacion del animal
	 **/
	
	public String toString() {
		return"Nombre: " + nombre 
				+"\nEdad: "+edad+" años"
				+"\nNacido en "+ cartilla.getAnioNac()
				+"\nNombre del veterinario: "+cartilla.getVeterinario()
				+"\nNumero de enfermedades: "+cartilla.getEnfermedades()
				+"\nNumero de vacunaciones: "+cartilla.getVacunas()
				+"\nEste animal hace "+hacerSonido()
				+"\nEste animal come "+comer()
				+"\nEste animal "+moverse();
	}
	

}
