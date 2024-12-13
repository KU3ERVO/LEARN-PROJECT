package ejercicios_programacion;
import java.util.Random;
import java.util.Scanner;
public class juego_escribir_q {
// ES UN JUEGO DE ESCRIBIR q LO MAS RAPIDO POSIBLE SI SE METE CUALQUIER OTRO CARACTER ES UN FALLO
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		Random rand = new Random();
		
		int i,fallo,fallo_max,meta;
		char input = ' ';
		
		i=1;
		fallo=0;
		//INPUT DE INTENTOS
		System.out.println("escribe tu máximo de intentos a continuación:");
		
		fallo_max = sc.nextInt();
		//NUM Q A ESCRIBIR PARA GANAR RANDOM
		meta = rand.nextInt(10,100);
		
		System.out.println("escribe q lo más rápido que puedas, cualquier otro carácter será un fallo, la meta es: " + meta);
		//JUEGO MIENTRAS LOS FALLOS NO SEAN SUFICIENTES Y NO HAYAS LLEGADO A LA META NO SALE DEL BUCLE
		while((i<meta)&&(fallo<=fallo_max)) {
			
			input = sc.next().charAt(0); //FALLA EL INPUT DE Q
			System.out.println(input);
			//CONTADOR DE FALLOS
			while((input!='q')&&(fallo<=fallo_max)) {
				
				System.out.println("FALLO");
				fallo++;
				input=sc.next().charAt(0);
				}
			
			input=' ';
			i++;
			
			
		}
		//COMPROBADOR DE GANAR O PERDER
		if(fallo<=fallo_max) {
			
			while(input!='f') {
				
				System.out.println("lo lograste, has hecho un total de "+ meta+ " q letras con "+ fallo+ " fallos pulsa f para salir");
				input=sc.next().charAt(0);
			
			}
				
		}
		else {
			
             while(input!='f') {
				
				System.out.println("perdiste, has hecho un total de "+ i+ " q letras con "+ fallo+ " fallos pulsa f para salir");
				input=sc.next().charAt(0);
			
		}
	}

		sc.close();
	}
	
}