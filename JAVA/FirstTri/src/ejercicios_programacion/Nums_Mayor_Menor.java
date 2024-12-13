package ejercicios_programacion;

import java.util.Scanner;
public class Nums_Mayor_Menor {

	public static void main(String[] args) {
		//INPUTS
		Scanner sc = new Scanner(System.in);
		System.out.println("introduce 3 nums");
		int num1= sc.nextInt();
		int num2= sc.nextInt();
		int num3= sc.nextInt();
		int aux=0;
	//COMPROBADOR MAYOR MENOR
while ((num1>num2)||(num1>num3)){

	aux=num1;
	num1=num2;
	num2=num3;
	num3=aux;
}

if(num2<num3) {
	
	System.out.println(num1 + ", "+num2 + ", "+num3 + ", ");
	
	
}

else {
	
	aux=num2;
	num2=num3;
	num3=aux;
	
	System.out.println(num1 + ", "+num2 + ", "+num3 + ", ");
}
sc.close();
	}

}
