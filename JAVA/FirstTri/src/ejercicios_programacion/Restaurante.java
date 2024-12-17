package ejercicios_programacion;
import java.util.Scanner;
public class Restaurante {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);



		String platos = ""; //para seleccionar platos
		int opc1=0,opc2=0;//2 OPCIONES PARA QUE NO SE SALGA DE LA PARTE 3 A LA UNO DIRECTAMENTE YA QUE EL VALOR SALIDA ES EL MISMO




		//MIENTRAS LA OPCION NO SEA 4 SIGUES EN EL MENU 1
		while(opc1!=4) {
			//ELEGIR 1era OPCION
			System.out.println("MENU PACA \n ----------------------- \n pulse 1 para ver entrantes \n pulse 2 para ver seegundos platos \n pulse 3 par ver postres \n pulse 4 para salir");
			opc1 = sc.nextInt();
			//ENTRAR A MENU 2
			switch(opc1) {
			//MENU 2.1
			case 1:

				while(opc2!=3) {
					//ELEGIR OPCION DE 3era VENTANA
					System.out.println("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n PRIMEROS PLATOS \n ----------------------- \n pulse 1 para ver tortilla de patata \n pulse 2 para ver jamoncito \n pulse 3 para salir ");
					opc2 = sc.nextInt();
					//ENTRAR MENU 3.1
					switch(opc2) {
					//MENU3.1.1
					case 1:
						//MIENTRAS NO PULSES 3 SIGUES EN MENU 3
						while(opc1!=3) {
							//PRINT DESCRIPCION E INPUT ELECCION O SALIDA
							System.out.println("\n----------------------- \n tortilla doradita: \n con patatas, huevo y SIN cebolla \n\n pulse 1 para añadir \n pulse 3 para salir");
							opc1 = sc.nextInt();
							//AÑADIR PLATO
							if (opc1==1) {platos+=" tortilla |"; System.out.println("AÑADIDO");}
						}
						break;
						//MENU3.1.2
					case 2:

						while(opc1!=3) {

							System.out.println("\n----------------------- \n Jamoncito: \n el mejor jamón serrano de la sierra de gredos \n\n pulse 1 para añadir \n pulse 3 para salir");
							opc1 = sc.nextInt();

							if (opc1==1) {platos+=" jamón |"; System.out.println("AÑADIDO");}
						}
						break;
						//MENU3.1.3
					case 3:

						System.out.println("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

						break;

					default:

						System.out.println("ERROR");
						opc1 = sc.nextInt();

					}
					//RESETEO VARIABLES 
					opc1 =0;
				}
				//RESETEO DE VARIABLES
				opc2=0;
				opc1=0;

				break;
				//MENU 2.2	
			case 2:
				//MIENTRAS NO PULSES 3 SIGUES EN MENU 3
				while(opc2!=3) {

					System.out.println("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n SEGUNDOS PLATOS \n ----------------------- \n pulse 1 para ver lentejitas de la abuela \n pulse 2 para ver cocido madrileño \n pulse 3 para salir ");
					opc2 = sc.nextInt();
					//ENTRAR MENU 3.2
					switch(opc2) {
					//MENU3.2.1
					case 1:

						while(opc1!=3) {

							System.out.println("\n----------------------- \n Puchero de lentejas: \n hechas con tiempo y mucho mimo por las abuelas más profesionales de zaragoza \n\n pulse 1 para añadir \n pulse 3 para salir");
							opc1 = sc.nextInt();

							if (opc1==1) {platos+=" lentejas |"; System.out.println("AÑADIDO");}
						}
						break;
						//MENU3.2.2
					case 2:

						while(opc1!=3) {

							System.out.println("\n----------------------- \n Cocido madrileño: \n Se sirve en tres partes, para ponerse las botas \n\n pulse 1 para añadir \n pulse 3 para salir");
							opc1 = sc.nextInt();

							if (opc1==1) {platos+=" cocido |"; System.out.println("AÑADIDO");}
						}
						break;
						//MENU3.2.3
					case 3:

						System.out.println("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

						break;

					default:

						System.out.println("ERROR");
						opc1 = sc.nextInt();

					}

					opc1 =0;
				}

				opc2=0;
				opc1=0;

				break;
				//MENU 2.3
			case 3:
				//MIENTRAS NO PULSES 3 SIGUES EN MENU 3
				while(opc2!=3) {

					opc1=0;
					System.out.println("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n POSTRES \n ----------------------- \n pulse 1 para ver arroz con leche \n pulse 2 para ver postre del día \n pulse 3 para salir ");
					opc2 = sc.nextInt();
					//ENTRAR MENU 3.3
					switch(opc2) {
					//MENU3.3.1
					case 1:

						while(opc1!=3) {

							System.out.println("\n----------------------- \n Arroz con leche: \n suave arroz con leche, miel y canela \n\n pulse 1 para añadir \n pulse 3 para salir");
							opc1 = sc.nextInt();

							if (opc1==1) {platos+=" arroz con leche |"; System.out.println("AÑADIDO");}
						}
						break;
						//MENU3.3.2
					case 2:

						while(opc1!=3) {

							System.out.println("\n----------------------- \n El postre del día es: \n Tarta de calabaza, perfecta para el clima otoñal \n\n pulse 1 para añadir \n pulse 3 para salir");
							opc1 = sc.nextInt();

							if (opc1==1) {platos+=" tarta de calabaza |"; System.out.println("AÑADIDO");}
						}
						break;
						//MENU3.3.3
					case 3:

						System.out.println("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

						break;

					default:

						System.out.println("ERROR");
						opc1 = sc.nextInt();

					}

					opc1 =0;
				}

				opc2=0;
				opc1=0;

				break;
				//SALIR
			case 4:

				System.out.println("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
				break;
				//CUALQUIER OTRO INPUT DA ERROR
			default:

				System.out.println("ERROR");
				opc1 = sc.nextInt();

			}	
		}
		//OUTPUT DE SELECCIONES
		sc.close();
		System.out.println("\n\n\n\n\n\n\n\n\n\n\n\n\n Sus platos seleccionados son: "+platos);


	}

}
