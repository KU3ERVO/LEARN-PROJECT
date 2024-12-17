package ejercicios_programacion;
import java.util.Scanner;
public class Perimetro {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.println("escribe el radio");
		//INPUT
		int radio = sc.nextInt();
		//OPERACION
		System.out.println(2*Math.PI*radio);

		sc.close();
	}

}
