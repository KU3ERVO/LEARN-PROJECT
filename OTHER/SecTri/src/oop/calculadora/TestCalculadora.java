package oop.calculadora;
import java.util.Scanner;
public class TestCalculadora {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		char operando = ' ';
		Calculadora calc1 = new Calculadora(0, 0);
		
		while(operando!='.') {
		System.out.println(calc1.toString());
		
		System.out.println("introduce el operando  + - : x  utiliza < para guardar y > para cargar, 0 para reiniciar, utiliza . para cerrar");
		operando = sc.next().charAt(0);

		
		
		switch(operando) {
		
		case '+':
			System.out.println("introduce el num");
			calc1.sumar(sc.nextInt());
			break;
			
		case '-':
			System.out.println("introduce el num");
			calc1.restar(sc.nextInt());
			break;
			
		case ':':
			System.out.println("introduce el num");
			calc1.dividir(sc.nextInt());
			break;
			
		case 'x':
			System.out.println("introduce el num");
			calc1.multiplicar(sc.nextInt());
			break;
			
		case '>':
			System.out.println("introduce el num");
			calc1.cargar();
			break;
			
		case '<':
			System.out.println("introduce el num");
			calc1.guardar();
			break;
			
		case '0':
			System.out.println("introduce el num");
			calc1.reinicio();
			break;
			
		}
		

	}

}
}