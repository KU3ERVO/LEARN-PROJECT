package accesosecuencial;

/*Crea un programa que, a partir de un fichero de texto codificado en UTF-8,
genere un fichero de texto codificado en ISO-8859-1 y otro en UTF-16.
El fichero codificado en UTF-8 debe crearse con un editor de texto,
y debe incluir al menos vocales acentuadas. Puedes leer el fichero línea a línea con readLine().
Para generar el fichero de salida, puedes utilizar un BufferedWriter (para escribir línea a línea)
construido sobre un OutputStreamWriter (para recodificar el texto) construido sobre un FileOutputStream
(para escribir a un fichero). Busca una manera de verificar la codificación
de los ficheros de texto en el sistema operativo que estés utilizando mediante algún comando
del sistema operativo o algún programa de utilidad.
Puedes utilizar los programas de ejemplo para volcado binario para verificar qué
caracteres se codifican de manera distinta. Puedes crear otro programa que haga la conversión inversa,
para comprobar que se vuelve a obtener un fichero igual al inicial,
utilizando las clases InputStreamReader y FileInputStream.
Muestra el resultado de la ejecución del programa.*/


import java.io.*;

public class Ej4 {
    public static void main(String[] args) {


        File f1 = new File("fichero_usado.txt");

        File f2 = new File("fichero_Iso.txt");
        File f3 = new File("fichero_16.txt");

        try {
            if (!f1.exists()) {
                f1.createNewFile();
            }
            if (!f2.exists()) {
                f2.createNewFile();
            }
            if (!f3.exists()) {
                f3.createNewFile();
            }
        } catch (IOException e) {
            throw new RuntimeException(e);
        }

        try (
                // Leer el fichero original con codificación UTF-8

                BufferedReader reader = new BufferedReader(
                        new InputStreamReader(new FileInputStream(f1), "UTF-8"));

                // Escribir los ficheros con codificaciones distintas
                BufferedWriter bfw2 = new BufferedWriter(
                        new OutputStreamWriter(new FileOutputStream(f2), "ISO-8859-1"));
                BufferedReader r2 = new BufferedReader(
                        new InputStreamReader(new FileInputStream(f2), "ISO-8859-1"));

                BufferedWriter bfw3 = new BufferedWriter(
                        new OutputStreamWriter(new FileOutputStream(f3), "UTF-16"));
                BufferedReader r3 = new BufferedReader(
                        new InputStreamReader(new FileInputStream(f3), "UTF-16"));
        ) {

            String l1;
            int i = 0;


            while ((l1 = reader.readLine()) != null) {
                // Mostrar la línea por consola (UTF-8 original)
                System.out.format("[%3d] %s%n", ++i, l1);

                // Escribir la misma línea en los dos ficheros
                bfw2.write(l1);
                bfw2.newLine();

                bfw3.write(l1);
                bfw3.newLine();

            }

            bfw2.close();
            bfw3.close();
i =0;
            while ((l1 = r2.readLine()) != null) {
                // Mostrar la línea por consola (UTF-8 original)
                System.out.format("[%3d] %s%n", ++i, l1);}
i=0;
            while ((l1 = r3.readLine()) != null) {
                // Mostrar la línea por consola (UTF-8 original)
                System.out.format("[%3d] %s%n", ++i, l1);}

        } catch (IOException e) {
            e.printStackTrace();
        }

    }
}
