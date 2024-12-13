package ejercicios_programacion;

public class Array_circular {

	public static void main(String[] args) {
		
		//ESTABLECER ARRAY
		int [] array = {1,5,70,3,8};
		int i,j,aux = array [0];
		//NUMERO DE VECEES QUE SE VA A HACER EL INTERCAMBIO
		for(j=1;j<8;j++) {
			
			aux = array [0];
			//INTERCAMBIO
		for(i = 0;i<(array.length-1);i++) {
			
			array[i]=array[i+1];			
		}
		
		array[i]=aux;
		
		for (i=0;i<array.length;i++) {
			
			System.out.print(array[i]+ ", ");
		}
		System.out.println(" ");
		}
		
	}

}
