package ejercicios;

public class IntersecciónArrays {

	public static void main(String[] args) {
		// TERCER ARRAYS SOLO CON ELEMENTOS QUE SE REPITEN
		int i = 0,j = 0,k = 0,l=0;
		boolean comparador = false;
		int [] array_A = Array.scArr();
		int [] array_B = Array.scArr();
		int [] array_AB = new int [array_A.length + array_B.length];
		//ESTABLECEMOS LA LONGITUD DEL FOR COMO ARRAY A Y LUEGO SUMAMOS 1 A J PARA ASI AUMENTAR EL DOBLE DE VECES J Y LLEGAR AL MAX DE AB
		for(i=0;i<array_A.length;i++) {
			for(j=0;j<array_B.length;j++) {//FALTA QUE NO SE PUEDA REPETIR NUMS
				if(array_A [i] == array_B[j]) {
					for(k=0;k<array_AB.length;k++){
						if(array_AB[k]==array_A[i]) {
							comparador=true;}}
					if(comparador==false) {
						array_AB[l] = array_A[i];
						l++;}
				}
			}
			comparador=false;
		}
		//OUTPUT DEL ARRAY SIN LOS VACIOS
		System.out.println("los numeros que se repiten son: \n");
		for(i=0;i<array_AB.length;i++) {
			if(array_AB[i]!=0) {
				System.out.print(array_AB[i]+" ");}

		}
	}

}
