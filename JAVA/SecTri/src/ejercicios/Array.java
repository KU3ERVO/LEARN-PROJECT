package ejercicios;

import java.util.Scanner;

public class Array {
	//PRINT OUT DE UN ARRAY ARRAYS TO STRING PA Q QUEDE BONITO
	public static void sysoArr ( int [] array) {
		
		int i = 0;
		
		System.out.print("[ ");
            for(i=0;i<array.length;i++) {
			   if (i!=array.length -1) {
			      System.out.print(array[i]+" | ");
			      }
			   else {
				   System.out.print(array[i]);
			   }
               }
            
            System.out.print(" ]");
            
            return;
		
	}
	
	//CON UN ITERADOR CONTAR LA CANTIDAD DE NUMS QUE SE METEN EN EL ARRAY E IR GUARDANDO EN UN ARRAY GRANDE
	//ESTABLECER ARRAY CON EL LENGTH DEBIDO
	//AÑADIR NUMS
	public static int [] scArr () {
		
		    Scanner sc = new Scanner(System.in);
			System.out.println("Escribe -1000 para terminar");
			
			int i=0;
			int [] array = new int [40];
			array[i] = sc.nextInt();
			i++;
			while(array[i-1]!= -1000) {
				
				if(array[i-1]!=-1000) {
				array[i] = sc.nextInt();
				i++;}
				
			}
			
			int [] arrayFinal = new int [i-1];
			
			for(i=0;i<arrayFinal.length;i++) {
				
				arrayFinal[i]=array[i];
				
			}
			
			return arrayFinal;
		
		
	}
	
	
	
	
	
	
	
	
	//PASO POR VALOR NO MODIFICA EL DATO SI NO HAY RETURN
	public static int metodoA (int a) {
		a++;
		return a;
	}
	//PASO POR REFERENCIA CAMBIA DIRECTAMENTE EL DATO EN LA DIRECCION DE MEMORIA
	public static void metodoB (int x []) {
		
		x[3]=22;
		
}
	
	
	
	
	
	
	
	
	
	//PRINT DEL JUEGO
public static void prtJuego (char [] [] coords) {
		
		int i = 0,j = 0;
		for(j=0;j<=2;j++) {
			
			for(i=0;i<=2;i++) {
				
				System.out.print(" "+coords [i] [j]);
				
			}
			System.out.println();
		}
		
		System.out.println();
		
		return;
	}
	
	public static char [][] getNum(char[][]coords,char marca){
		
		Scanner sc = new Scanner(System.in);
		int casilla = 0,i=0,j=0;
		do  {
			System.out.println("elige una casilla que no se haya usado antes");
		casilla = sc.nextInt();
		//TODO NO DEJAR PASAR SI YA SE HA COLOCADO MARCA AHI
        //SI COORDS DE ESE LAO NO ES UN · ENTONCES ESTA OCUPADO
		switch (casilla){
		
		case 1:
			coords[j=0][i=0]=coords[0][0];
			break;
		case 2:
			coords[j=1][i=0]=coords[1][0];
			break;
		case 3:
			coords[j=2][i=0]=coords[2][0];
			break;
		case 4:
			coords[j=0][i=1]=coords[0][1];
			break;
		case 5:
			coords[j=1][i=1]=coords[1][1];
			break;
		case 6:
			coords[j=2][i=1]=coords[2][1];
			break;
		case 7:
			coords[j=0][i=2]=coords[0][2];
			break;
		case 8:
			coords[j=1][i=2]=coords[1][2];
			break;
		case 9:
			coords[j=2][i=2]=coords[2][2];
			break;
		}
		}while((coords[j][i]=='x')||(coords[j][i]=='o'));
		
		coords[j][i]=marca;
		
		return coords;
	}
	//TODO FIX BUG Q SI LA COMPROBACION DA VERDADERO SOLO PUEDAS GANAR SI NO SON PUNTOS ···········
	public static boolean comprobador(char[][]coords,int turnos) {
		
		int i=9,j=0;
		boolean ganar = false;
		
		
			
			for(i=0;(i<3)&&(ganar==false);i++) {
			//VERTICAL
			;
			if((coords[i][0]!='·')&&(coords[i][0]==coords[i][1])&&(coords[i][0]==coords[i][2])){
				System.out.println("VERTICAL");
				ganar= true;}
			else{
				
			if((coords[0][i]!='·')&&(coords[0][i]==coords[1][i])&&(coords[0][i]==coords[2][i])){
				System.out.println("HORIZONTAL");
				ganar= true;}
			else{
				
			//diagonal abajo
			if((coords[0][0]!='·')&&(coords[0][0]==coords[1][1])&&(coords[0][0]==coords[2][2])){
				System.out.println("DIAGONAL");
				ganar= true;
				}
			else{
				
			
			if((coords[2][0]!='·')&&(coords[2][0]==coords[1][1])&&(coords[2][0]==coords[0][2])){
				System.out.println("DIAGONAL");
				ganar= true;}
			else{
				ganar=false;}}}}
		
		}
		
		return ganar;
		
		
		
	}
	
	

}
