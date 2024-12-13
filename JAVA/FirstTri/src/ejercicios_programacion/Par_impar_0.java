package ejercicios_programacion;
import java.util.Scanner;
public class Par_impar_0 {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		//INPUT
		System.out.println("introduce num a evaluar");
		int num = sc.nextInt();
		//COMPROBACIÓN Y OUTPUTS
		if(num==0) {
			
		System.out.println("esto es un 0");	}
			
		else {
			
			if((num%2)==0) {System.out.println("PAR");}
			
			else {System.out.println("IMPAR");}
		}
		
		sc.close();
}
}
