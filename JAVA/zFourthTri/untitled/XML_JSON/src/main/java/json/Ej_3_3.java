package json;

import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.SerializationFeature;

import java.io.File;
import java.util.List;

/*El objetivo de esta práctica es aprender a serializar (convertir objetos Java a JSON) y deserializar (convertir JSON a objetos Java) utilizando la librería Jackson. Se trabajará con una estructura de objetos anidados para simular un caso de uso real, como la gestión de un inventario de productos.
Enunciado
Se requiere desarrollar una aplicación de consola en Java que gestione un pequeño inventario de una tienda. El inventario completo, que incluye el nombre de la tienda y una lista de productos, debe ser guardado en un archivo inventario.json y posteriormente recuperado desde el mismo.
Requisitos
1.
Definir los Modelos (POJOs):

PLAIN OLD JAVA OBJECTS son objetos de java que:

No extiende ni implementa clases o interfaces especiales del framework.

No contiene anotaciones o dependencias innecesarias.

Tiene atributos privados.

Tiene métodos getters y setters públicos.

Puede incluir un constructor vacío y otro con parámetros.
o
Crea una clase Producto con las siguientes propiedades: id (String), nombre (String), precio (double) y cantidad (int).
o
Crea una clase Inventario con las siguientes propiedades: nombreTienda (String) y productos (una List<Producto>).
2.
Lógica Principal:
o
En la clase principal (Main), crea una instancia de Inventario.
o
Añade 3 productos de ejemplo a la lista de productos del inventario.
o
Serialización: Convierte el objeto Inventario a una cadena JSON con formato legible (pretty print) y guárdala en un archivo llamado inventario.json.
o
Deserialización: Lee el contenido del archivo inventario.json y conviértelo de nuevo en un objeto Inventario.
o
Verificación: Imprime en la consola el nombre de la tienda y los detalles de cada producto del objeto recién deserializado para verificar que el proceso tuvo éxito.*/
public class Ej_3_3 {
    public static void main(String[] args) {

        try {

            Inventario inventario = new Inventario("PiliMili");

            Producto falda = new Producto("Falda", "01", 10, 200);
            Producto camiseta = new Producto("Camiseta", "02", 15, 100);
            Producto tacones = new Producto("Tacones", "03", 70, 80);

            inventario.setProductos(List.of(falda, camiseta, tacones));

            ObjectMapper mapper = new ObjectMapper();
            mapper.enable(SerializationFeature.INDENT_OUTPUT);

            File f = new File("inventario.json");
            mapper.writeValue(f, inventario);

            //GUARDAMOS LOS DATOS DEL JSON A UN NUEVO OBJETO INVENTARIO
            Inventario saveinventario = mapper.readValue(f, Inventario.class);

            System.out.println(saveinventario.getNombreTienda() + " SHOPPING");
            for (int i = 0; i < saveinventario.getProductos().size(); i++) {
                System.out.println("\nProducto: " + saveinventario.getProductos().get(i).nombre +
                        "\nCantidad: " + saveinventario.getProductos().get(i).cantidad +
                        "\nPrecio: " + saveinventario.getProductos().get(i).precio +
                        "\nID: " + saveinventario.getProductos().get(i).id);
            }

        } catch (Exception e) {
            e.printStackTrace();
        } finally {

        }

    }

    public static class Inventario {

        private String nombreTienda;
        private List<Producto> productos;

        public Inventario() {
        }

        public Inventario(String nombreTienda) {
            this.nombreTienda = nombreTienda;
        }


        public String getNombreTienda() {
            return nombreTienda;
        }

        public void setNombreTienda(String nombreTienda) {
            this.nombreTienda = nombreTienda;
        }

        public List<Producto> getProductos() {
            return productos;
        }

        public void setProductos(List<Producto> productos) {
            this.productos = productos;
        }
    }


    public static class Producto {

        private String nombre;
        private String id;
        private double precio;
        private int cantidad;

        Producto() {
        }

        public Producto(String nombre, String id, double precio, int cantidad) {
            this.nombre = nombre;
            this.id = id;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public String getNombre() {
            return nombre;
        }

        public void setNombre(String nombre) {
            this.nombre = nombre;
        }

        public String getId() {
            return id;
        }

        public void setId(String id) {
            this.id = id;
        }

        public double getPrecio() {
            return precio;
        }

        public void setPrecio(double precio) {
            this.precio = precio;
        }

        public int getCantidad() {
            return cantidad;
        }

        public void setCantidad(int cantidad) {
            this.cantidad = cantidad;
        }
    }

}
