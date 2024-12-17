package ejercicios;

public class FusionarArrays {

	public static void main(String[] args) {
		// DOBLE DE LENGTH CON TODOS LOS ELEMENTOS ORDENADOS
		int i = 0,j = 0,k = 0;
		boolean comparador = true;
		System.out.println("introduce los numeros en orden de menor a mayor: ");
		System.out.println("array A");
		int [] array_A = Array.scArr();
		System.out.println("array B");
		int [] array_B = Array.scArr();
		int [] array_AB = new int [array_A.length + array_B.length]; 
		//ESTABLECEMOS LA LONGITUD DEL FOR COMO ARRAY A Y LUEGO SUMAMOS 1 A J PARA ASI AUMENTAR EL DOBLE DE VECES J Y LLEGAR AL MAX DE AB
		while(k<array_AB.length) {

			if((array_A[i]<array_B[j])&&(comparador!=false)) { //NECESITO QUE NO COMPARE LOS DOS O QUE NO SUME EL ULTIMO ++

				array_AB[k]=array_A[i];
				if(i==(array_A.length-1)){comparador=false;}
				if(i<(array_A.length-1)) {
					i++;}


			}
			else {
				array_AB[k]=array_B[j];
				if(j<(array_B.length-1)){
					j++;}
			}


			k++;

		}

		Array.sysoArr(array_AB);

	}
}


