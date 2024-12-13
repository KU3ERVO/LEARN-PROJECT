package ejercicios_programacion;

public class Tablas_de_multiplicar {

	public static void main(String[] args) {
		
		int num,multip;
		//SELECTOR DE TABLA HASTA LA TABLA DEL 10
		for (num=1;num<=10;num++){ 
			
			System.out.println("La tabla del " + num +" es:");
			//MULTIPLICADOR HASTA EL 10
			for (multip=1;multip<=10;multip++) {
				
				System.out.println(num+"x"+multip+"="+num*multip);
			}
			
		}
		

	}

}
