package ejercicios_programacion;
import java.util.Random;
public class Dado {

	public static void main(String[] args) {


		Random rn = new Random();

		int [] dado = new int [7];
		int i,num;
		float percent;

		//1000 TIRADAS
		for(i=1;i<=1000;i++){
			//RANDOM ENTRE 1 Y 7
			num = rn.nextInt(1,7);
			//AÑADIR NUMERO DE VECES QUE HA SALIDO EL NUM SEGUN EL NUM 
			switch(num){

			case 1:

				dado[1]++;

				break;

			case 2:

				dado[2]++;

				break;

			case 3:

				dado[3]++;

				break;

			case 4:

				dado[4]++;

				break;

			case 5:

				dado[5]++;

				break;

			case 6:

				dado[6]++;

				break;
			}


		}
		//ESTABLECER VALOR DE SUMA DE VECEES QUE ALGO HA SALIDO COMO FLOAT Y PRINT DE DATOS
		for(i=1;i<7;i++) {

			percent = dado[i];
			System.out.print("num "+i+ " salió " + dado[i] + " veces un " +  percent/10 + "% \n");
		}

	}



}


