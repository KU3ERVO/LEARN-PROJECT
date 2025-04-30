package palindromo;

public class Palindromo {
	
	public Palindromo() {
	}

	public boolean Comprobar(String s) 
	{
		boolean pal = true;
		char[] c = new char [s.length()];
		c = s.toLowerCase().toCharArray();
		//REVISAR
		for(int i = 0; i<s.length()&&pal==true;i++) {
			
			System.out.println(c[i]+ "==" +c[s.length()-i-1]);
			if(c[i]!=c[s.length()-i-1]) 
			{
				pal = false;
			}
			
		}
		System.out.println();
		return pal;
	}

}
