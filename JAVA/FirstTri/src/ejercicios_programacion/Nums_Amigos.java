package ejercicios_programacion;

import java.util.Scanner;

public class Nums_Amigos {

	public static void main(String[] args) {
		
Scanner sc = new Scanner(System.in);
		//INPUT 2 NUMS
		int num1 = sc.nextInt();
		int num2 = sc.nextInt();
		
		int i= 0;
		
		int sum1=0;
		int sum2=0;
		//SACAR DIVISORES NUM1
		while(i<num1) {
			
			i++;
			
			while((num1%i)!=0) {
				
				i++;
			}
			
			if(i!= num1) {
				
				System.out.println(i);
				
                sum1+=i;
			}
			
		}
		
	i=0;
	
	//SACAR DIVISORES NUM2
	while(i<num2) {
		
		i++;
		
		while((num2%i)!=0) {
			
			i++;
		}
		
		if(i!= num2) {
			
			System.out.println(i);
			
            sum2+=i;
		}
		
	}
	//COMPROBACION DE AMISTAD
	if((sum1==num2)&&(sum2==num1)){
		
		System.out.println(" son amigos! " + num1 + " y "+num2);
		
	}
		
		else {
			
			System.out.println( " no amigos ;( " + num1 +" y " + num2 );
		}
	
	sc.close();

	}

}
