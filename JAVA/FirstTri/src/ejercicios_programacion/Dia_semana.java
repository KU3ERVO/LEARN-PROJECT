package ejercicios_programacion;

import java.util.Scanner;

public class Dia_semana {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.println("escribe el número del día");
		//LEER
		int dia = sc.nextInt();
		//SEGUN EL NUM = DIA X
		switch(dia) {
		
		   case 1:
			
			  System.out.println("Lunes");
			
			  break;
			
           case 2:
			
			  System.out.println("Martes");
			
			  break;
			
           case 3:
			
			  System.out.println("Miercoles");
			
			  break;
			
           case 4:
	
	          System.out.println("Jueves");
	
	          break;
	
           case 5:
	
	          System.out.println("Viernes");
	
	          break;
	
	
           case 6:
	
	          System.out.println("Sábado");
	          
              break;
	
           case 7:
	
	          System.out.println("Domingo");
	
	          break;
	          
	          
	       default:
	    	   
	    	   System.out.println("ERROR");

	}
		
		sc.close();

}
}
