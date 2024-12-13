package ejercicios_programacion;
import java.util.Scanner;
public class Nums_primos {

	public static void main(String[] args) {
	
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("introduce el número a evaluar");
		//INPUT NUM
		int num = sc.nextInt();
		int divisores = 2;
		//COMPROBADOR
		while((num%divisores)!=0) {	
			
			divisores++;
		}
		
		if(num==divisores) {
			
			System.out.println("primo!");
		}
		else {
			
			System.out.println("no primo );");
		}
		sc.close();
	}

}
