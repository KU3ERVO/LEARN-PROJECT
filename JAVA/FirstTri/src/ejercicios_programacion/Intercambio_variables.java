package ejercicios_programacion;

public class Intercambio_variables {

	public static void main(String[] args) {
		
		int a=1,b=2,c=3,aux;
		
		System.out.println("a="+a+" b="+b+" c="+c);
		//CICLO DE INTERCAMBIO Y PRINT POR EL NUM DE VECES
		for(int i=1;i<4;i++) {
		aux=a;
		a=b;
		b=c;
		c=aux;
		
		System.out.println("a="+a+" b="+b+" c="+c);	}

	}

}
