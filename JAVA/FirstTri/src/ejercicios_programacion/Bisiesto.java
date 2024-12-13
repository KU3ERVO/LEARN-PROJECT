package ejercicios_programacion;
import java.util.Scanner;
public class Bisiesto {

	public static void main(String[] args) {
		
		
		Scanner sc= new Scanner(System.in);
		
		int anno = sc.nextInt();
		//COMPROBADOR
		if((anno%100)==0){
			
			if (((anno%400)==0)&&((anno%4)==0)) {
				
				System.out.println("bisiesto!");
			}
		}
		
		else {
			
			if((anno%4)==0) {
				
				System.out.println("bisiesto!");
			}
			
			else {System.out.println("no bisiesto");}
		}
		
	sc.close();

	}

}
