package oop.rectangulo;

public class Rectangulo {

	private int base = 2,altura = 1;

	Rectangulo(){
	}

	public void SetAltura(int altura) {

		if(altura!=this.base) {
			this.altura=altura;
		}
	}
	public void SetBase(int base) {

		if(base!=this.altura) {
			this.base=base;
		}
	}
	public int Area() {
		return base*altura;
	}
	public int Perimetro() {
		return 2*(base+altura);
	}

}

