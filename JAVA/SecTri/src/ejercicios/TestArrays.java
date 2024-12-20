package ejercicios;

public class TestArrays {

	public static void main(String[] args) {

		int[] array1 = {34, 1, 31, 4, 222};
		int[] array2 = {4, 1, 11, 700, 7};

        // EQUALS
        System.out.println(Arrays.equals(array1, array2));

        // SORT
        Arrays.sort(array1);
        System.out.println(Arrays.toString(array1));
        
        // BUBBLE SORT
        Arrays.bubbleSort(array1);
        System.out.println(Arrays.toString(array2));
        
        // BINARY SEARCH
        int num = Arrays.binarySearch(array1, 4);
        System.out.println(num);

        // FILL
        Arrays.fill(array1, 700);
        System.out.println( Arrays.toString(array1));


	}

}
