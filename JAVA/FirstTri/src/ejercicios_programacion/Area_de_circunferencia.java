package ejercicios_programacion;
import java.util.Scanner;
public class Area_de_circunferencia {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Escribe el radio de tu circunferencia:");
		//establecer variables
		double radio = sc.nextDouble();
		//operacion
		double area= Math.PI * radio * radio;
		
		System.out.println("el area es: " + area);		
	
sc.close();
	}

}
