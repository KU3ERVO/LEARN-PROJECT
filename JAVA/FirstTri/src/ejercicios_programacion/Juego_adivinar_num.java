package ejercicios_programacion;
import java.util.Scanner;
public class Juego_adivinar_num {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		//ESTABLECER NUM RANDOM
		double num = Math.random()*100;
		num = (int)num;
		int i = 1;
		//INPUTS
		System.out.println("Introduce el número de oportunidades que quieres tener");
		int oportunidades = sc.nextInt();
		System.out.println("introduce tus predicciones tienes "+ oportunidades + " intentos");
		int adivinanza = sc.nextInt();

		//COMPROBADOR HASTA QUE SE ACABAN OPORTUNIDADES
		while((num!=adivinanza)&&(i<oportunidades)) {
			//SI EL NUM ES MENOR QUE EL RANDOM PRINT ES MENOS SINO ES MAS
			if(num<adivinanza) {

				System.out.println("el número que buscas es menor");
			}
			else {

				System.out.println("el número que buscas es mayor");
			}
			//INPUT DE TU INTENTO
			i++;
			adivinanza = sc.nextInt();

		}
		//OUTPUT
		if(i<oportunidades) {

			System.out.println("FELICIDADES GANASTE!!! "+ i +" intentos");
		}	

		else {

			System.out.println("Has perdido ); el numero era "+ num);
		}


		sc.close();


	}

}
