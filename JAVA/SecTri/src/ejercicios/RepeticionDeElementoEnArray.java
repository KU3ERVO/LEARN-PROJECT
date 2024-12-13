package ejercicios;
import java.util.Scanner;
public class RepeticionDeElementoEnArray {
	
	public static void main (String [] args) {
		
		try (Scanner sc = new Scanner(System.in)) {
			int i = 0, j = 0,num;
			System.out.println("escribe tus numeros: ");
			
			int [] nums = Array.scArr();
			System.out.println("Escribe el numero que quieres buscar: ");
			
			num = sc.nextInt();
			
			System.out.println("Las posiciones de los "+num+" son las siguientes: \n");
			
			for (i = 0;i< nums.length;i++) {
				
				if(nums[i]==num) {
				System.out.print(i+" ");
				j++;}
				
			}
			
			System.out.println("\n \nHay un total de "+ j);
			
			sc.close();
		}
	
	}

}
