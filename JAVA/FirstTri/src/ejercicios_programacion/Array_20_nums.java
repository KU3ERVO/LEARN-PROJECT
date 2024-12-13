package ejercicios_programacion;
import java.util.Scanner;
public class Array_20_nums {
	
	public static void main(String[]args) {
		
		try (Scanner sc = new Scanner(System.in)) {
			
			//ESTABLECER VARIABLES Y LENGTH ARRAYS
			int [] array = new int [20];
			int [] posit = new int [20];
			int [] negat = new int [20];
			int [] zero = new int [20];
			int i,j=0,k=0,g=0;
			//COMPROBADOR DEL NUM
			for(i=0;i<array.length;i++) {
				
				array [i] = sc.nextInt();
				
				if(array[i]<0) {
				
				     negat[j]+=array[i];
					j++;
				}
				
				else if(array[i]>0){
					
					posit[k]+=array[i];
					k++;
				}
				
				else {
					
					zero[g]+=0;
					g++;
				}
				
				
			}//OUTPUTS
			System.out.println("\n TODOS LOS NUMS: \n");
			for (i=0;i<array.length;i++) {
				
				System.out.print(array[i]+",");
				
			}
			System.out.println("\n\n NEGATIVOS: \n");
			for (i=0;i<j;i++) {
				
				System.out.print(negat[i]+",");
				
			}
			System.out.println("\n\n POSITIVOS: \n");
			for (i=0;i<k;i++) {
				
				System.out.print(posit[i]+",");
				
			}
			System.out.println("\n\n CEROS: \n");
			for (i=0;i<g;i++) {
				
				System.out.print(zero[i]+",");
				
			}
			
			sc.close();
		}
	
	}
}
