package ej_modulares;

public class Operaciones {

	//raliza una clase matemática con métodos y pruebala en otra clase con un método main

	public static int suma(int num1,int num2) {
		return num1+num2;
	}

	public static int resta(int num1,int num2) {
		return num1-num2;
	}

	public static int multi(int num1,int num2) {
		return num1*num2;
	}

	public static int div(int num1,int num2) {
		return num1/num2;
	}

	public static int mod(int num1,int num2) {
		return num1%num2;
	}

	//FACTORIAL
	public static int fac(int num1) {
		int mul_num1 = 0;
		int i = 1;
		while(i<=num1) {

			mul_num1 *= i;
			i++;
		}

		return mul_num1;}

	//POTENCIA
	public static int pow(int num1, int num2) {
		int ele_num1 = num1;
		int i = 1;
		while(i<num2) {

			ele_num1 *= num1;
			i++;
		}

		return ele_num1;}
}













