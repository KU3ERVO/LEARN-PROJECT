package ejercicios_programacion;
import java.util.Scanner;
public class Cambio_cajero_automatico {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.println("escribe los dos números a sumar");


		// INTRODUCIR DOUBLES A SUMAR
		double num1 = sc.nextDouble();
		double num2 = sc.nextDouble();
		//SUMA
		double suma = (num1+num2);

		System.out.println("la suma de los números es: "+ suma);
		//VALOR MAX DEL DINERO
		double valor_bill = 500;

		int i = 1;

		int num_bill=0;
		//CAMBIO DE VALOR DINERO 1
		while (i<=7) {

			switch (i) {

			case 1:

				valor_bill=500;

				break;

			case 2:

				valor_bill=200;

				break;

			case 3:

				valor_bill=100;

				break;

			case 4:

				valor_bill=50;

				break;

			case 5:

				valor_bill=20;

				break;

			case 6:

				valor_bill=10;

				break;

			case 7:

				valor_bill=5;

				break;


			}
			//OPERACION COMPROBACION BILL UTILIZADOS Y RESTA
			while (suma>=valor_bill){

				suma-=valor_bill;

				num_bill++;
			}
			//PRINT 
			if(num_bill!=0) {

				System.out.println(num_bill + " billetes de " + valor_bill);
			}

			num_bill=0;

			i++;
		}
		//CAMBIO DE VALOR DINERO 2
		while (i<=9) {

			switch (i) {

			case 8:

				valor_bill=2;

				break;

			case 9:

				valor_bill=1;

				break;


			}
			//OPERACION COMPROBACION DE NUM DE MONEDAS UTILIZADAS Y RESTA
			while (suma>=valor_bill) {

				suma-=valor_bill;

				num_bill++;
			}
			//PRINT
			if(num_bill!=0) {

				System.out.println(num_bill + " monedas de " + valor_bill+ " euros");
			}

			num_bill=0;

			i++;
		}

		//CAMBIO DE VALOR DINERO 3
		while (i<=15) {

			switch (i) {

			case 10:

				valor_bill=0.50;

				break;

			case 11:

				valor_bill=0.20;

				break;

			case 12:

				valor_bill=0.10;

				break;

			case 13:

				valor_bill=0.05;

				break;

			case 14:

				valor_bill=0.02;

				break;

			case 15:

				valor_bill=0.01;

				break;

			}
			//OPERACION COMPROBACION DE NUM DE MONEDAS UTILIZADAS Y RESTA
			while (suma>=valor_bill) {

				suma-=valor_bill;

				num_bill++;
			}
			//PRINT
			if(num_bill!=0) {

				System.out.println(num_bill + " monedas de " + valor_bill+ " céntimos");
			}

			num_bill=0;

			i++;
		}


		sc.close();
	}

}
