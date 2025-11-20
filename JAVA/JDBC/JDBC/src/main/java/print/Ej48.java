package print;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.sql.*;

/**
 * Ej48 - Navegador interactivo de ResultSet
 *
 * Uso desde Main:
 *   Ej48 ej48 = new Ej48();
 *   ej48.navegarTabla(connection, "CLIENTES");
 *
 * Comandos:
 *   .   -> salir (libera recursos)
 *   k   -> siguiente fila
 *   d   -> fila anterior
 *   N   -> si N es un entero, ir a la fila N (1-based)
 *
 * Nota: la clase solicita un ResultSet scrollable (TYPE_SCROLL_INSENSITIVE).
 */
public class Ej48 {

    /**
     * Inicia la navegación interactiva sobre la tabla pasada.
     *
     * @param conn      conexión activa (NO se cierra aquí; solo se usan/cierran Statements/ResultSets)
     * @param tableName nombre de la tabla a navegar (ej: "CLIENTES")
     */
    public void navegarTabla(Connection conn, String tableName) {
        String sql = "SELECT * FROM " + tableName;

        // BufferedReader para leer comandos del teclado
        try (BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
             Statement stmt = conn.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_READ_ONLY);
             ResultSet rs = stmt.executeQuery(sql)) {

            // Comprobamos si hay filas
            if (!rs.last()) {
                System.out.println("La consulta no devolvió filas. Saliendo.");
                return;
            }

            // Obtenemos número total de filas
            int totalFilas = rs.getRow();

            // Nos posicionamos en la primera fila para mostrar "fila 1" inicialmente
            rs.first();
            mostrarFila(rs, totalFilas);

            // Bucle de lectura de comandos
            String comando;
            System.out.println("Introduce comando (k = siguiente, d = anterior, N = ir a fila N, . = salir):");
            while ((comando = br.readLine()) != null) {
                comando = comando.trim();

                if (comando.equals(".")) {
                    System.out.println("Comando de salida recibido. Liberando recursos y terminando.");
                    break; // try-with-resources cerrará rs/stmt/br
                } else if (comando.equalsIgnoreCase("k")) {
                    // siguiente fila si no estamos en la última
                    if (rs.isLast()) {
                        System.out.println("Ya estás en la última fila (" + totalFilas + "). No se puede avanzar.");
                    } else {
                        if (rs.next()) {
                            mostrarFila(rs, totalFilas);
                        } else {
                            // Fallo inesperado: no pudo avanzar
                            System.out.println("No se pudo avanzar a la siguiente fila.");
                        }
                    }
                } else if (comando.equalsIgnoreCase("d")) {
                    // fila anterior si no estamos en la primera
                    if (rs.isFirst()) {
                        System.out.println("Ya estás en la primera fila (1). No se puede retroceder.");
                    } else {
                        if (rs.previous()) {
                            mostrarFila(rs, totalFilas);
                        } else {
                            System.out.println("No se pudo retroceder a la fila anterior.");
                        }
                    }
                } else {
                    // Intentamos interpretar el comando como número de fila
                    try {
                        int filaDestino = Integer.parseInt(comando);

                        if (filaDestino < 1 || filaDestino > totalFilas) {
                            System.out.println("Fila inválida. Debe estar entre 1 y " + totalFilas + ".");
                        } else {
                            // Movemos el cursor a la fila indicada (absolute usa 1-based)
                            if (rs.absolute(filaDestino)) {
                                mostrarFila(rs, totalFilas);
                            } else {
                                System.out.println("No se pudo mover a la fila " + filaDestino + ".");
                            }
                        }
                    } catch (NumberFormatException nfe) {
                        System.out.println("Comando no reconocido: '" + comando + "'. Usa k, d, ., o un número entero.");
                    }
                }

                System.out.println("Introduce comando (k = siguiente, d = anterior, N = ir a fila N, . = salir):");
            }

        } catch (SQLException e) {
            System.err.println("Error de SQL durante la navegación: " + e.getMessage());
            e.printStackTrace(System.err);
        } catch (Exception e) {
            System.err.println("Error inesperado: " + e.getMessage());
            e.printStackTrace(System.err);
        }
    }

    /**
     * Muestra por consola la fila actual del ResultSet en formato:
     *   fila N
     *   nombreColumna : valor
     *   ...
     *
     * @param rs        ResultSet posicionado en la fila a mostrar
     * @param totalRows número total de filas (para contexto)
     * @throws SQLException en caso de error de acceso al ResultSet
     */
    private void mostrarFila(ResultSet rs, int totalRows) throws SQLException {
        ResultSetMetaData md = rs.getMetaData();
        int cols = md.getColumnCount();
        int filaActual = rs.getRow(); // 1-based

        System.out.println("----- fila " + filaActual + " de " + totalRows + " -----");

        for (int i = 1; i <= cols; i++) {
            String nombre = md.getColumnLabel(i); // alias o nombre de columna
            Object valor = rs.getObject(i);
            if (valor == null) {
                System.out.println(nombre + " : NULL");
            } else {
                System.out.println(nombre + " : " + valor.toString());
            }
        }
        System.out.println("------------------------------");
    }
}
