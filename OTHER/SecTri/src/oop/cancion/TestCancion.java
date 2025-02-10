package oop.cancion;

public class TestCancion {

	public static void main(String[] args) {
	
		Cancion c1 = new Cancion();
		Cancion c2 = new Cancion("Last Friday Night","Katy Perry");
		
		c1.setAutor("Mariah Carey");
		c1.setTitulo("ALL I WANT FOR CHRISTMAS");
		
		System.out.println(c1.getAutor()+"   "+c1.getTitulo());
		System.out.println(c2.getAutor()+"   "+c2.getTitulo());

	}

}
