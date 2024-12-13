package ejercicios_programacion;

import java.util.Scanner;

public class Notas_alumnos {

	public static void main(String[] args) {
		
	    try (Scanner sc = new Scanner(System.in)) {
			System.out.println("cuantos alumnos tiene la clase?");
			//ESTABLECER ARRAYS Y VARIABLES INPUT DE NUM DE ALUMNOS PARA ARRAY LENGTH
			int i=0,j=0,k=0, num_alumnos = sc.nextInt();
			float [] notas = new float [num_alumnos];
			float [] notas_altas = new float [num_alumnos] ;
			float [] notas_bajas = new float [num_alumnos];
			float nota_max=0,nota_min=10,suma_notas=0;
			
			System.out.println("introduce sus notas");
			//INTRODUCIR NOTAS HASTA QUE EL ARRAY SE LLENA
			for(i=0;i<num_alumnos;i++) {
			   //MAX MIN Y SUMA PARA LA MEDIA
				notas[i] = sc.nextFloat();
			    if(nota_max<notas[i]) {
			    	
			    	nota_max=notas[i];
			    }
			    if(nota_min>notas[i]) {
			    	
			    	nota_min=notas[i];
			    }
			    
			    suma_notas += notas[i];
			}
			

			

			//ESTABLECER NOTAS POR ENCIMA Y DEBAJO DE LA MEDIA
			for(i=0;i<num_alumnos;i++) {
				
				if(notas[i]>=(suma_notas/num_alumnos)) {
					
					
					notas_altas[j]= notas[i];
					j++;
					
				}
				
				else {
					
					notas_bajas[k]=notas[i];
					k++;
					
					
				}
			}
			

			sc.close();
			//OUTPUTS
			System.out.println("las notas son las siguientes: ");
			
			for (i=0;i<notas.length;i++) {
				
				System.out.print(notas[i]+", ");
				
			}
			
					System.out.println("\n -----------------------------------\n"
					+ "nota max = " +nota_max+ "\n"
					+ "nota min = "+ nota_min+ "\n"
					+ "media = "+ suma_notas/num_alumnos +"\n" );
					
					System.out.println("notas superiores a la media: \n");
					
					for (i=0;i<notas_altas.length;i++) {
						
						if(notas_altas[i]!=0) {
						System.out.print(notas_altas[i]+", ");}
						
					}
					
					System.out.println("\n");
					
					System.out.println("notas inferiores a la media: \n");
					
					for (i=0;i<notas_bajas.length;i++) {
						
						if(notas_bajas[i]!=0) {
						System.out.print(notas_bajas[i]+", ");}
						
					}
					
					
		}
		
	}

}
