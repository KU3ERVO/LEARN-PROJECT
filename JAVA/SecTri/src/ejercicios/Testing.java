package ejercicios;

import java.util.Arrays;

public class Testing {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int [] nums2 = new int [40];
		int num=25;
		int i=1;
		Arrays.fill(nums2,7);
		System.out.println(Arrays.toString(nums2));

		for( i=0;i<nums2.length;i++) {

			num=(int) (Math.random()*100);
			nums2[i]*=num;


		}
		System.out.println(Arrays.toString(nums2));

		Arrays.sort(nums2);
		System.out.println(Arrays.toString(nums2));

		System.out.println(Arrays.equals(nums2, nums2));

		System.out.println(Arrays.binarySearch(nums2, 0));


	}

}
