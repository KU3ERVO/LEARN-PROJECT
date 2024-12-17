package ejercicios_programacion;
import java.util.Scanner;
public class Fecha_jubilacion {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		//RESULTADOS R ES SI TE HAS JUBILADO R 2 LOS DIAS QUE TE QUEDAN
		boolean r;
		int r2;
		//INPUTS DE DATOS
		System.out.println("escribe el año actual");
		int CurrentYear = sc.nextInt();
		System.out.println("escribe el mes actual");
		int CurrentMonth = sc.nextInt();
		System.out.println("escribe el dia actual");
		int CurrentDay = sc.nextInt();
		System.out.println("escribe el año de nacimiento");
		int BirthYear = sc.nextInt();
		System.out.println("escribe el mes de nacimiento");
		int BirthMonth = sc.nextInt();
		System.out.println("escribe el dia de nacimiento");
		int BirthDay = sc.nextInt();

		//OPERACION LOGICA
		r2=(((CurrentDay-BirthDay)+((CurrentMonth-BirthMonth)*30))+(CurrentYear-BirthYear)*365)-65*365;

		r= (((CurrentYear-BirthYear)>65)||((CurrentYear-BirthYear)==65)&&(CurrentMonth<=BirthMonth)&&(CurrentDay<=BirthDay));

		System.out.println(r + " " + r2 + " dias para jubilarte");
		sc.close();
	}

}
