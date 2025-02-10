package ejercicios;

public class DuplicarArray {

	public static void main(String[] args) {

		int i = 0;
		int [] nums;

		nums = Array.scArr();

		System.out.println("Array duplicado: \n");
		//SE MULTIPLICA EL ARRAY X 2
		for (i = 0;i< nums.length;i++) {

			nums [i] *= 2;

		}

		Array.sysoArr(nums);





	}

}
