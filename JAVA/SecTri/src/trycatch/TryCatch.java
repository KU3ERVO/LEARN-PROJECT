package trycatch;

public class TryCatch {

	public static void main(String[] args) {
		// PRUEBA DE EXCEPCIONES
		//AQUI HAY EXCEPCION Y TRY NO SE EJECUTA
		try {
			int i = 4/0;
			System.out.println("esto NO sale a consola");
		} catch (ArithmeticException e) {
			System.out.println("NO SE PUEDE DIVIDIR POR 0");
		}
		finally {
			System.out.println("---->");
		}
		
		System.out.println("esto ahora SI va a salir a consola");
		
		
		System.out.println("\n\n");
		
		
		//AQUI SI SE EJECUTA EL TRY PERO NO EL CATCH YA QUE NO ES UN ERROR ARITMETICO
		
		try {
			int i = 4/1;
			System.out.println("esto NO sale a consola");
		} catch (ArithmeticException e) {
			System.out.println("NO SE PUEDE DIVIDIR POR 0");
		}
		finally {
			System.out.println("---->");
		}
		
		System.out.println("esto ahora SI va a salir a consola");

	}

}
