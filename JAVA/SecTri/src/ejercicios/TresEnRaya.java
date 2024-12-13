package ejercicios;

public class TresEnRaya {

	public static void main(String[] args) {
		
		char [][] matrizJuego = {{'·','·','·'},{'·','·','·'},{'·','·','·'}};
		char [][] casillasJuego = {{'1','4','7'},{'2','5','8'},{'3','6','9'}};
		int i = 0;
		boolean Tres = false;
		char marca = 'x';
		System.out.println();
		Array.prtJuego(casillasJuego);
	    Array.prtJuego(matrizJuego);
		//PRINT CADA VEZ QUE SE INTENTA
		for(i=0;((i<=8)&&(Tres==false));i++) {
			//CAMBIO DE MARCA
			if(marca=='x') {marca='o';}else {marca='x';}
			//PEDIMOS LA CASILLA QUE SE QUIERE ACTUALIZAR Y SE ACTUALIZA
			System.out.println("next player: "+marca);
			matrizJuego = Array.getNum(matrizJuego,marca);
			Array.prtJuego(casillasJuego);
		    Array.prtJuego(matrizJuego);
		    //STATEMENT PARA SI SE HA HECHO TRES EN RALLA
		    Tres = Array.comprobador(matrizJuego,i);
		    }
		
		//EMPATE O GANADOR
		if(Tres==false) {
			
			System.out.println("EMPATE");
		}
		else {
			System.out.println("ENHORABUENA JUGADOR '"+ marca + "' GANASTE");
		}

	}

}