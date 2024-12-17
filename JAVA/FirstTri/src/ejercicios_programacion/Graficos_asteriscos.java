package ejercicios_programacion;
import java.util.Scanner;
public class Graficos_asteriscos {

	public static void main(String[]args) {

		Scanner sc =new Scanner(System.in);
		//VARIABLES
		int Num_hor,Num_ver,i,j,k;
		//DEFINIR ANCHO
		System.out.println("Escribe el ancho de las figuras");

		Num_hor = sc.nextInt();
		//DEFINIR ALTO
		System.out.println("Escribe el alto de las figuras");

		Num_ver = sc.nextInt();

		System.out.println("\n -----------------------------------------------------");

		sc.close();
		//LINEA
		for(i=1;i<=Num_hor;i++) {

			System.out.print(" * ");

		}

		System.out.println("\n -----------------------------------------------------");

		//CUADRADO
		for(j=1;j<=Num_ver;j++) {

			for(i=1;i<=Num_hor;i++) {

				System.out.print(" * ");

			}

			System.out.println("");

		}

		System.out.println("\n -----------------------------------------------------");


		k=Num_hor;
		//ESCALERA INVERTIDA
		for(j=1;j<=Num_ver;j++) {

			for(i=1;i<=k;i++) {

				System.out.print(" * ");
			}

			System.out.println("\n");
			k--;

		}

		System.out.println("\n -----------------------------------------------------");


		k=0;

		//ESCALERA
		for(j=1;j<=Num_hor;j++) {

			for(i=0;i<=k;i++) {

				System.out.print(" * ");
			}

			System.out.println("\n");
			k++;

		}





	}

}
