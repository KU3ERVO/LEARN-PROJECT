package ejercicios_programacion;
import java.util.Scanner;
public class Suma_nums_hasta_0 {
	
	public static void main(String[]args) {
		
		Scanner sc = new Scanner(System.in);
		
		
		int input=-1,suma = 0;
		System.out.println("introduce tus números usa 0 para finalizar");
		//SUMA NUMS HASTA QUE SE PULSA 0
		while (input!=0) {
			
			input = sc.nextInt();
			suma+=input;
			
			System.out.println(suma);
		}
		
		System.out.println("FIN");
		sc.close();
	}

}
