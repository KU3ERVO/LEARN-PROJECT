package thread;

public class Main {
    public static void main(String[] args) {

        Thread hilo1 = new ThreadChild();
        hilo1.start();

        Thread hilo2 = new Thread(() ->{
                System.out.println("HIIIIII");
        });

        hilo2.start();

        Thread hilo3 = new Thread() {
            public void run(){
                 System.out.println("HIIIIII 3");
             }
        };
        hilo3.start();

        Generico <String,Double> g = (s,d) -> System.out.println();
    }
}
