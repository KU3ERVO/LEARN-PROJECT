package excepcion;

public class Metodo {
	
	public void SuperadoEnNumeros (int n) throws SuperiorA1000 {
		
		if (n<1000) {
			
			throw new SuperiorA1000("OH NO");
		}
	}

}
