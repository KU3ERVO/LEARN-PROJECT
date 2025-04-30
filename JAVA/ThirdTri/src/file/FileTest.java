package file;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class FileTest {

	public static void main(String[] args) throws IOException {
		
		String path = "D:\\mañana no tocar/LEARN-PROJECT/JAVA/ThirdTri/src/file/text.txt";
		
			FileReader fr = new FileReader(path);						
		BufferedReader br = new BufferedReader(fr);
		
		java.io.File f = new java.io.File("D:\\mañana no tocar/LEARN-PROJECT/JAVA/ThirdTri/src/file/text2.txt");
		
		f.createNewFile();
		
		String a;
		while((a=br.readLine()) != null) {
			System.out.println(a);
		}
		
		fr.close();
		br.close();
		
		FileWriter fw = new FileWriter(path,true);
		BufferedWriter bw = new BufferedWriter(fw);
		
		bw.write("\nMALIGNA ESCOBAR");
		bw.newLine();
		bw.write("TU MATASTE A MI PADRE!!!");
		
		bw.close();
		fw.close();

		fr = new FileReader(path);
        br = new BufferedReader(fr);
        
		while((a=br.readLine()) != null) {
			System.out.println(a);
		}
		
		br.close();
		fr.close();
	}

}
