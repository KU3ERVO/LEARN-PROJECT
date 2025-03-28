package excepcion;

public class TestExcepcion{

public static void main(String[]args){
	
	

	try {

		Excepcion e1 = new Excepcion();
		e1.SuperadoEnNumeros(1);

	}
	catch(SuperiorA1000 e){
		System.out.println(e.getMessage());
	}
	finally {
		System.out.println("la batalla ha terminado");
	}

}
}

