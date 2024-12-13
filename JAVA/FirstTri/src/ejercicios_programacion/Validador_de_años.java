package ejercicios_programacion;
import java.util.Scanner;
public class Validador_de_años {

	public static void main(String[] args) {

		boolean validez = true;
		//INPUTS
		Scanner sc = new Scanner(System.in);
		System.out.println("Introduce el día: ");
		int dia= sc.nextInt();
		System.out.println("Introduce el mes: ");
		int mes= sc.nextInt();
		System.out.println("Introduce el año: ");
		int anno= sc.nextInt();
        sc.close();
		//VALIDEZ DEL FORMATO DEL AÑO 
		if((mes<1)||(dia<1)||(anno>2024)) {
			//VALIDEZ DE NUMS IMPOSIBLES DE METER EN EL FORMATO
		
		       validez = false;
		}
		else {
			
			
			switch (mes) {
			//MESES DE 31 DIAS
			case 1 + 3 + 5 + 7 + 8 + 10 + 12:
				
				if(dia>31) {
					
					validez = false;	
				}
				else {
					
					validez =true;
				}
			//FEBRERO EXCEEPCION
			case 2:
				
				if((anno%4)==0) {
					
					if(dia>29) {
						
						validez = false;
					}
					
					else {
						
						validez=true;
					}
				}
				
				else {
					
					if(dia>28) {
						
						validez=false;
					}
					
					else {
						
						validez=true;
					}
				}
				
				//MESES 30 DIAS
			case 4 + 6 + 9 + 11:
				
				if(dia>30) {
					
					validez=false;
				}
				else {
					
					validez=true;
				}
			
			default:
				
				
				
			}
			
		}
	//COMPROBADOR BISIESTO
	if((anno%100)==0){
		
		if (((anno%400)==0)&&((anno%4)==0)) {
			
			System.out.println("bisiesto!");
		}
	}
	
	else {
		
		if((anno%4)==0) {
			
			System.out.println("bisiesto!");
		}
	}
	// COMPROBADOR ANTES DE CRISTO
	if(anno<0) {
		
		System.out.println("AC");
	}
	
	System.out.println(validez);
	
	}

}
