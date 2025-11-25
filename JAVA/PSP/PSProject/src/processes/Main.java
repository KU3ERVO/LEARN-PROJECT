package processes;

import java.io.IOException;

public class Main {

    public static void main(String[] args) {

        Process p;

        try {
            p = new ProcessBuilder("notepad","D:\\LEARN-PROJECT\\OTHER\\GameDevPresentationScript.txt").redirectErrorStream(true).start();
            Thread.sleep(2000);
            p.waitFor();
            System.out.println(
                    "Process has been stopped"
            );
            p = new ProcessBuilder("D:\\APPS\\Unity Hub\\Unity Hub.exe").redirectErrorStream(true).start();

        } catch (IOException e) {
            throw new RuntimeException(e);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }

    }

}
