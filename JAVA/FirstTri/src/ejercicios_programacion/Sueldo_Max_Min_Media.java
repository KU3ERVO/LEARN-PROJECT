package ejercicios_programacion;
import java.util.Scanner;
public class Sueldo_Max_Min_Media {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		//ESTABLECER VARIABLES DE COMPROBACION
		System.out.println("escribe la cantidad de sueldos que necesites, usa -1 para finalizar");
		int sueldoMax = 0;
		int sueldoSum = 0;
		int sueldoMin = 999999999;
		int sueldo = 0;

		int i = -1;
		//MIENTRAS NO SE PULSE -1 SE SIGUEN METIENDO SUELDOS
		while(sueldo!=-1) {
			sueldo = sc.nextInt();
			i++;
			//EXCEPCION PARA QUE NO CUENTE EL -1 COMO DATO
			if(sueldo!=-1) {
				sueldoSum+=sueldo;
				//COMPROBACIONES MAX MIN
				if(sueldo<sueldoMin){

					sueldoMin=sueldo;
				}

				else {

					if(sueldo>sueldoMax) {

						sueldoMax=sueldo;
					}
				}
			}
		}

		//OUTPUT
		System.out.println("la media de los sueldos es " + sueldoSum/i + " sueldo Max: "+ sueldoMax + " sueldo Min: " + sueldoMin);
		sc.close();
	}

}
