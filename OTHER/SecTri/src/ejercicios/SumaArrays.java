package ejercicios;

public class SumaArrays {

	public static void main(String[] args) {

		// SUMA DOS ARRAYS A Y B EN UN ARRAY SUMA DEL MISMO TAMAÑO
		//establecer el mas grande como ab y rellenar el otro con 0s
		int i = 0;
		int [] array_A = Array.scArr();
		int [] array_B = Array.scArr();
		int [] array_AB = new int [40];
		boolean A_MasPequeño=true,FinalMasPequeño=false;
		if(array_A.length>=array_B.length) {
			array_AB = new int [array_A.length];
			A_MasPequeño=false;}
		else {array_AB = new int [array_B.length];
		A_MasPequeño=true;}
		//ESTABLECEMOS LA LONGITUD DEL FOR COMO ARRAY AB Y LUEGO SUMAMOS 1 A J PARA ASI AUMENTAR EL DOBLE DE VECES J Y LLEGAR AL MAX DE AB
		for(i=0;i<array_AB.length;i++) {
			if((i==(array_A.length))||(i==(array_B.length))) {FinalMasPequeño=true;}
			//si el array mas chiquito ha llegado a su max entonces solo añadir el mayor a lo que queda de AB iterar sobre ab y no a
			if(FinalMasPequeño==false) {
				array_AB[i]=array_A[i]+array_B[i];}
			else {
				if(A_MasPequeño==true) {

					array_AB[i]=array_B[i];
				}
				else {
					array_AB[i]=array_A[i];}
			}

		}

		Array.sysoArr(array_AB);

	}

}
