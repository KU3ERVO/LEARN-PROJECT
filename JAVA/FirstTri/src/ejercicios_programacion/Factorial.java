package ejercicios_programacion;
import java.util.Scanner;
public class Factorial {

	public static void main(String[] args) {
		
Scanner sc = new Scanner(System.in);

System.out.println("introduce tu número a continuación");
int mul_num1=0;
int num = sc.nextInt();
//OPERACION POR CADA FACTOR MULTIPLICAR
  for(int i=1; i<=num; i++) {
	
    mul_num1 *= i;}
  
System.out.println(mul_num1);

sc.close();
	}

}
