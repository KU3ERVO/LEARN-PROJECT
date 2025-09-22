package listadoDirectorio;

import java.io.File;

public class ListadoDirectorio {

    public static void main(String[] args) {
        /*
        * Inicializamos con un . para la var ruta (dir actual)
        * */
        String ruta = ".";
        if (args.length >= 1) ruta = args[0];
        //Creamos una instancia de file
        File fich = new File(ruta);
        //Verificamos si existe el fichero
        if (!fich.exists()) {
            System.out.println(ruta + " no existe el fichero o directorio");
        } else  {
            System.out.println(ruta + " es un directorio. Contenidos: ");
            //Array de files
            File[] ficheros = fich.listFiles(); //Ojo ficheros o dirs
            //Recorremos el array y añadimos un prefijo para comprobar si es un fich o dir
            for (File f : ficheros) {
                String textDescr = f.isDirectory() ? "d" : f.isFile() ? "f" : "?";
                System.out.println("("+ textDescr +")" + f.getName());
            }
        }

    }

}
