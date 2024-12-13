package ejercicios;

import java.util.Random;
import java.util.Arrays;

public class PruebaMetodos {

	public static void main(String[] args) {
		
		int num = 25;
		Array.metodoA(num);
		System.out.println(num);
		//EJ DE COMPROBACION DE CONEXIONES DE METODOS
		int [] nums = {1,2,3,4};
		Array.metodoB(nums);
		for(int i = 0;i<nums.length;i++) {
		System.out.println(nums[i]);}
		
		int i=0;
		
		int [] nums2 = new int [40];
		
		Arrays.fill(nums2,100);
		System.out.println(Arrays.toString(nums2));
		
		for( int j : nums2) {
			
			num*=2;
			System.out.println(j);
			nums2[j]=num;
		}
		System.out.println(Arrays.toString(nums2));
		
		



	}

}
