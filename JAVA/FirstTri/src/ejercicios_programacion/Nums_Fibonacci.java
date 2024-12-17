package ejercicios_programacion;
import java.util.Scanner;
public class Nums_Fibonacci {

	public static void main(String[] args) {

		Scanner sc= new Scanner(System.in);

		System.out.println("introduce el número de cifras que quieres ver");
		//DECIDIR CANTIDAD CIFRAS A MOSTRAR
		int a=0;
		int b=1;
		int Num_cifs = sc.nextInt();
		//OPERACION
		for (int i=1; i<=Num_cifs; i++){
			System.out.println(a);
			int num_fib= a+b;
			a=b;
			b=num_fib;

		}
		sc.close();

	}

}
