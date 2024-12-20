package ejercicios;

public class Arrays {

	    // Binary Search (Sacado de chatGPT)
	    public static int binarySearch(int[] array, int key) {
	        int low = 0;
	        int high = array.length - 1;

	        while (low <= high) {
	            int mid = (low + high) / 2; // Calculate the middle index
	            if (array[mid] == key) {
	                return mid; // Key found
	            } else if (array[mid] < key) {
	                low = mid + 1; // Search in the right half
	            } else {
	                high = mid - 1; // Search in the left half
	            }
	        }
	        return -1; // Key not found
	    }

	    // Equals
	    public static boolean equals(int[] array1, int[] array2) {
	       //Comparador de cada index
	        for (int i = 0; i < array1.length; i++) {
	            if (array1[i] != array2[i]) {
	                return false;
	            }
	        }
	        return true;
	    }

	    // Fill
	    public static void fill(int[] array, int value) {
	    	//Rellenamos cada index con el valor que se aporta
	        for (int i = 0; i < array.length; i++) {
	            array[i] = value;
	        }
	    }

	    // Sort (de chatGPT)
	    public static void sort(int[] array) {
	    	for (int i = 0; i < array.length - 1; i++) {
	            int minIndex = i;
	            for (int j = i + 1; j < array.length; j++) {
	                if (array[j] < array[minIndex]) {
	                    minIndex = j;
	                }
	            }
	            // Swap the minimum value with the current value
	            int temp = array[i];
	            array[i] = array[minIndex];
	            array[minIndex] = temp;
	        }
	    }
	    

	    // To String
	    public static String toString(int[] array) {
	       
	        String palabra = "[";
	        // Añadimos cada valor al array + , o formato
	        for (int i = 0; i < array.length; i++) {
	            palabra += array[i];
	            if (i < array.length - 1) {
	                palabra += " | ";
	            }
	        }
	        palabra += "]";
	        return palabra;
	    }

	    // Bubble Sort (chatGPT)
	    public static void bubbleSort(int[] array) {
	        int n = array.length;
	        boolean swapped;
	        for (int i = 0; i < n - 1; i++) {
	            swapped = false;
	            for (int j = 0; j < n - i - 1; j++) {
	                if (array[j] > array[j + 1]) {
	                    // Swap elements
	                    int temp = array[j];
	                    array[j] = array[j + 1];
	                    array[j + 1] = temp;
	                    swapped = true;
	                }
	            }
	            if (!swapped) {
	                break; // No swaps mean the array is already sorted
	            }
	        }
	    }


}
