package oop.calculadora;

public class Calculadora {
//ATRIBUTOS
	private int acumulador, memory;
//CONSTRUCTOR
	Calculadora(int acumulador,int memory){

		this.memory= memory;
		this.acumulador=memory;

	}
	
	//METODOS
	public String toString() {		
		String result= "-> " + acumulador + "\nMemoria: "+ memory;
		return result;
	}

	public void reinicio() {
		acumulador=0;
	}

	public void guardar() {
		memory = acumulador;
	}

	public void cargar() {
		acumulador = memory;

	}

	public void sumar (int sumando) {
		acumulador+=sumando;
	}

	public void restar (int restando) {

		acumulador -= restando;
	}

	public void multiplicar (int multiplicador) {

		acumulador *= multiplicador;
	}

	public void dividir (int divisor) {

		acumulador /= divisor;
	}

}
