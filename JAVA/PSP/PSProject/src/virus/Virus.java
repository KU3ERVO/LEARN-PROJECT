package virus;

import java.io.IOException;

public class Virus {

    private Process process;

    public void execute() {

        //int rand = (int) (Math.random() * 3);

        ProcessBuilder pb = new ProcessBuilder("C:\\Program Files\\Mozilla Firefox\\firefox.exe");
        ProcessBuilder pb2 = new ProcessBuilder("notepad");

        /*try {
            switch (rand) {
                case 0:
                    process = Runtime.getRuntime().exec("C:\\Windows\\explorer.exe ");
                    break;
                case 1:
                    process = pb.start();
                    break;
                case 2:
                    process = pb2.start();
                    break;
            }


        } catch (IOException e) {
            throw new RuntimeException(e);
        }
*/
        try {
            process = Runtime.getRuntime().exec("C:\\Windows\\explorer.exe");
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

    public void Kill() {
        try {
            this.process.destroy();
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }

    public void Contagio() {
        int i = 1;
        while(i<=40){


            try {
                Thread.sleep(1000);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }

            execute();
            if(process!=null){
            Kill();}

            i++;

        }
    }

}
