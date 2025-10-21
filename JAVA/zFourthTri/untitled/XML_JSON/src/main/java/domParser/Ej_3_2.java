package domParser;
/*Crea un programa en Java que, a partir de los contenidos del fichero XML como el del ejemplo,
con los datos de varios clientes, muestre un nuevo documento de XML que sea el resultado de añadir los datos de un nuevo cliente al principio,
antes de todos los clientes que puedan existir. Debe utilizarse un parser DOM y las interfaces de DOM para añadir los datos del nuevo cliente,
incluyendo DNI, apellidos y CP. La salida debe ser a salida estándar (System.out) y en formato XML, y debe generarse utilizando la clase Transformer.
El fichero se debe especificar mediante un argumento de línea de comandos. Si el fichero no es un fichero XML correcto,
o si lo es pero no tiene un único elemento con nombres de clientes en el nivel más alto,
se debe terminar la ejecución inmediatamente, y mostrar mensajes de error apropiados.*/

import org.w3c.dom.*;

import javax.xml.parsers.*;
import javax.xml.transform.*;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import java.io.File;

public class Ej_3_2 {

    public static void main(String[] args) {
        // SE HA PASADO ARGUMENTO?
        if (args.length < 1) {
            System.err.println("Uso: java domParser.Ej_3_2 <nombre_fichero.xml>");
            System.exit(1);
        }

        //CREAMOS EL FICHERO
        String nombreFichero = args[0];
        File f = new File(nombreFichero);

        try {
            // CREAMOS EL PARSER
            DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = factory.newDocumentBuilder();

            // PARSEAMOS EL FICHERO XML
            Document doc = builder.parse(f);

            // CREAMOS LA VARIABLE QUE UTILIZAREMOS COMO REFERENCIA A LA RAIZ DEL DOC
            Element root = doc.getDocumentElement();

            // CREAMOS LOS ELEMENTOS QUE AÑADIREMOS Y LES AÑADIMOS SUS VALORES
            Element newCliente = doc.createElement("PACO");

            Element dni = doc.createElement("dni");
            dni.setTextContent("66666666I");

            Element apellidos = doc.createElement("apellidos");
            apellidos.setTextContent("Flores de Molina");

            Element cp = doc.createElement("cp");
            cp.setTextContent("28916");

            // ESTABLECEMOS LA JERARQUIA DE LOS ELEMENTOS
            newCliente.appendChild(dni);
            newCliente.appendChild(apellidos);
            newCliente.appendChild(cp);

            // TOMAMOS EL PRIMER ELEMENTO DESDE LA RAIZ Y LO ASIGNAMOS A UNA VARIABLE
            Node firstCliente = root.getFirstChild();
            // COMPROBAMOS QUE NO SEA NULL ESTE PRIMER CLIENTE NO ESTÉ VACIO Y COGEMOS EL QUE NO ESTÉ VACIO
            while (firstCliente != null && firstCliente.getNodeType() != Node.ELEMENT_NODE) {
                firstCliente = firstCliente.getNextSibling();
            }
            //SI EL CLIENTE QUE HEMOS COGIDO NO ES NULL ENTONCES INSERTAMOS NUESTRO CLIENTE CREADO ANTES QUE EL
            //SI ES NULL SIGNIFICA QUE NO HABÍA CLIENTES ENTONCES LO AÑADIMOS COLGANDO DE ROOT
            if (firstCliente != null)
                root.insertBefore(newCliente, firstCliente);
            else
                root.appendChild(newCliente);

            // CREAMOS EL TRANSFORMER
            TransformerFactory transF = TransformerFactory.newInstance();
            Transformer trans = transF.newTransformer();
            //LE DAMOS LAS PROPIEDADES QUE NECESITAMOS PARA QUE SE VEA BONITO
            trans.setOutputProperty(OutputKeys.INDENT, "yes");
            trans.setOutputProperty(OutputKeys.ENCODING, "UTF-8");
            //DE DONDE A DONDE LLEVAMOS LA INFO GUARDADA
            DOMSource src = new DOMSource(doc);
            StreamResult sr = new StreamResult(System.out);

            // EJECUTAMOS LA TRANSFORMACION DE DOM A PRINT XML POR CONSOLA
            trans.transform(src, sr);

        } catch (ParserConfigurationException e) {
            System.err.println(" Error al configurar el parser DOM: " + e.getMessage());
        } catch (org.xml.sax.SAXException e) {
            System.err.println(" El archivo no es un XML válido: " + e.getMessage());
        } catch (java.io.IOException e) {
            System.err.println(" Error al leer el archivo: " + e.getMessage());
        } catch (TransformerException e) {
            System.err.println(" Error al transformar el DOM a XML: " + e.getMessage());
        }
    }
}


