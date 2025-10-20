package json;
/*El objetivo de esta práctica es aprender a serializar (convertir objetos Java a JSON) y deserializar (convertir JSON a objetos Java) utilizando la librería Jackson. Se trabajará con una estructura de objetos anidados para simular un caso de uso real, como la gestión de un inventario de productos.
Enunciado
Se requiere desarrollar una aplicación de consola en Java que gestione un pequeño inventario de una tienda. El inventario completo, que incluye el nombre de la tienda y una lista de productos, debe ser guardado en un archivo inventario.json y posteriormente recuperado desde el mismo.
Requisitos
1.
Definir los Modelos (POJOs):
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
}
