package accesosecuencial;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
/*Crea un programa que busque un texto dado en un fichero de texto, y que muestre para cada
aparición la línea y la columna. Se recomienda leer el fichero línea a línea y, dentro de cada línea,
buscar las apariciones del texto utilizando un método apropiado de la clase String. Se puede
consultar la documentación de dicha clase en la API de Java
(http://docs.oracle.com/javase/8/docs/api/).
Muestra el resultado de la ejecución del programa.

*/
public class Ej3 {

    public static void main(String[] args) {

        if (args.length < 1) {
            System.out.println("Ingrese la ruta del fichero");
        }
        String nomFich = args[0];

        try (BufferedReader br = new BufferedReader(new FileReader(nomFich))) {

            int i = 0;
            String linea = br.readLine();

            while (linea != null) {
                if (linea.contains("GAME")) {
                    System.out.format("[%5d] %s", ++i, linea);
                    System.out.println();
                    linea = br.readLine();
                } else {
                    ++i;
                    linea = br.readLine();
                }
            }

        } catch (FileNotFoundException e) {
            System.out.println("No existe fichero " + nomFich);
        } catch (IOException e){
            System.out.println("Error al acceder el fichero" + e.getMessage());
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}

