package ejercicios_programacion;
import java.util.Scanner;
public class Ecuacion_segundo_grado {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		//VARIABLES
		System.out.println("Introduce los datos a , b y c para hallar las x:");
		int a = sc.nextInt();
		int b = sc.nextInt();
		int c = sc.nextInt();
		//OPERACION
double x1 =(-b+(Math.sqrt(Math.pow(b, 2)-4*a*c)))/(2*a);
double x2 =(-b-(Math.sqrt(Math.pow(b, 2)-4*a*c)))/(2*a);


System.out.println("x = " + x1 + " y x2 =" + x2 );

sc.close();
	}
	
}
