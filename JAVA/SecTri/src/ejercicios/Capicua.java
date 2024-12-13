package ejercicios;

public class Capicua {

	public static void main(String[] args) {
		System.out.println("Escribe los numeros uno a uno");
		int [] num = Array.scArr();
		boolean capi = true;
		int i = 0, j = num.length -1;
		
		for(i=0;i<num.length/2;i++,j--) {
			
			if(num [i]!=num[j]) {
				
				capi = false;
					
			}
			
		}
		
		if(capi==false) {
			
			System.out.println("no es capicua");
		}
		else {System.out.println("CAPICUA");}

	}

}
