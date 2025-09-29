package excepciones;

public class ExcepcionDivPorCeroGest {
    public int divide(int a, int b) {
        return a / b;
    }
    public static void main(String[] args) {
        int a, b;
        a = 5; b = 2;
        try {
            //si compactamos los try y queremos que se
            //produzcan las 3 divisiones debemos poner primero
            //las que no van a dar error, o si no el programa
            //se cortará antes de calcular el resto
            System.out.println(a + "/" + b + " = " + a/b );
            b = 3;
            System.out.println(a + "/" + b + " = " + a/b );
            b = 0;
            System.out.println(a + "/" + b + " = " + a/b );
        } catch (ArithmeticException e) {
            System.err.println("error al dividir: " + a + " / " + b) ;
        }
    }
}
