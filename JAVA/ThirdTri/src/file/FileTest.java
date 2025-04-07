package file;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class FileTest {

	public static void main(String[] args) throws IOException {
		
		String path = "D:\\mañana no tocar/LEARN-PROJECT/JAVA/ThirdTri/src/file/text.txt";
		
			FileReader fr = new FileReader(path);						
		BufferedReader br = new BufferedReader(fr);
		
		
		String a;
		while((a=br.readLine()) != null) {
			System.out.println(a);
		}
		
		FileWriter fw = new FileWriter(path,true);
		BufferedWriter bw = new BufferedWriter(fw);
		
		bw.write("MALIGNA ESCOBAR");
		bw.newLine();
		bw.write("TU MATASTE A MI PADRE!!!");
		

		while((a=br.readLine()) != null) {
			System.out.println(a);
		}
	}

}
