package ej_modulares;
import java.util.Scanner;
public class Calculadora {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		//declarar métodos
		new Operaciones();


		System.out.println("escribe el tipo de operacion que quieres hacer entre: + - * / % ! ^");

		String operador = sc.next();

		System.out.println("a continuación escribe los números a utilizar:");

		int num1 = 0;
		int num2 = 0;
		//se elige el operador y en base a el llama al método necesario
		switch (operador) {

		case "+":		

			num1 = sc.nextInt();
			num2 = sc.nextInt();

			System.out.println(Operaciones.suma(num1, num2));

			break;

		case "-":

			num1 = sc.nextInt();
			num2 = sc.nextInt();

			System.out.println(Operaciones.resta(num1,num2));

			break;

		case "*":

			num1 = sc.nextInt();
			num2 = sc.nextInt();

			System.out.println(Operaciones.multi(num1,num2));

			break;

		case "/":

			num1 = sc.nextInt();
			num2 = sc.nextInt();

			System.out.println(Operaciones.div(num1,num2));

			break;

		case "%":

			num1 = sc.nextInt();
			num2 = sc.nextInt();

			System.out.println(Operaciones.mod(num1,num2));

			break;

		case "!":

			num1 = sc.nextInt();

			System.out.println(Operaciones.fac(num1));

			break;

		case "^":

			num1 = sc.nextInt();
			num2 = sc.nextInt();

			System.out.println(Operaciones.pow(num1,num2));

			break;

		default:

			System.out.println("ERROR");


		}
		sc.close();
	}

}
