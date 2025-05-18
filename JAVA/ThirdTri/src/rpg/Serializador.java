/**
 * 
 */
package rpg;

/**
 * 
 **/

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

public class Serializador {

	private static String archivo = "datos.dat";
	
	

	public static void serializar(Player c) {

		try (ObjectOutputStream out = new ObjectOutputStream(new FileOutputStream(archivo))) {
			out.writeObject(c);
		} 
		catch (IOException e) {
			e.printStackTrace(); 
		}
	}


	public static Player deserializar() {
		
		File f = new File(archivo);
		
		if (!f.exists() || f.length() == 0) {
			System.out.println("El archivo no existe o está vacío.");
			return null; 
		}

		try (ObjectInputStream in = new ObjectInputStream(new FileInputStream(archivo))) {
			return (Player) in.readObject();
		}
		catch (IOException | ClassNotFoundException e) {
			e.printStackTrace();
			return null;
		}
		
	}
	
	public static void eliminarArchivo() {
        File f = new File(archivo);
        if (f.exists()) {
            f.delete();
        }
    }

}