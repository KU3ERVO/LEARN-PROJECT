package oop.figuras;

public class TestFiguras {

	public static void main(String[] args) {
		
		Figura [] fa = new Figura [4];
		
		Circulo c1 = new Circulo(5.4,"rojo");
		Triangulo t1 = new Triangulo("azul", 3, 5);
		Cuadrado c2 = new Cuadrado("verde",4);
		
		fa[0]=c1;
		fa[1]=t1;
		fa[2]=t1;
		fa[3]=c2;
		
		
		for (int i = 0;i<fa.length;i++) {
		System.out.println(fa[i].toString());}
	}

}
