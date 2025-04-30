package myString;

import java.util.ArrayList;
public class MyString {

	private char[] cadena;
	private String mystring;

	public MyString()
	{
		for(char c : this.cadena)
		{
			this.mystring+=c;
		}
		
	}

	public MyString(char[] cadena)
	{        
		this.cadena=cadena;
		for(char c : this.cadena)
		{
			this.mystring+=c;
		}
	}

	public MyString(ArrayList<Character> cadena)
	{
		 this.cadena = new char[cadena.size()];
		    for (Character c : cadena) {
		        this.cadena[c] = cadena.get(c);
		    }
		    for(char c : this.cadena)
			{
				this.mystring+=c;
			}
	}
	
	
	
	
	

	public char[] getCadena()
	{
		
		return this.cadena;

	}

	public char myCharAt(int i) throws Exception
	{
		
		return this.mystring.charAt(i);
		
	}

	public int myCompareTo(MyString cadena2)
	{
		
		return this.mystring.compareTo(cadena2.mystring);
		
	}

	public int myCompareToIgnoreCase(MyString cadena2)
	{
		
		return this.mystring.compareToIgnoreCase(cadena2.mystring);
		
	}  

	public void myConcat(MyString cadena2)
	{   
		this.mystring.concat(cadena2.toString());
	}

	public int myIndexOf(int caracter)
	{
		
		return mystring.indexOf(caracter);
		
	}

	public int myLastIndexOf(int caracter)
	{
		
		return mystring.lastIndexOf(caracter);
		
	}

	public int myLength()
	{
		
		return mystring.length();

	}

	public MyString myReplace(char antiguo, char nuevo)
	{
		return new MyString(this.mystring.replace(antiguo, nuevo).toCharArray());
	}

	public MyString[] mySplit(char expresion)
	{
		String [] a = this.mystring.split(String.valueOf(expresion));
		MyString[] as = new MyString [a.length]; 
		//Añadir los datos al array vacio
		for (int i = 0; i < a.length; i++) {
            as[i] = new MyString(a[i].toCharArray());
        }
		
		return as;
		
	}



	public MyString mySubstring(int inicio, int fin) throws Exception
	{
		return new MyString(this.mystring.substring(inicio, fin).toCharArray());
	}

	public MyString myToLowerCase()
	{
		return new MyString(this.mystring.toLowerCase().toCharArray());
	}

	public MyString myToLowerCase(char[] cadena)
	{
		return new MyString(cadena.toString().toLowerCase().toCharArray());
	}

	public MyString myToUpperCase()
	{
		return new MyString(this.mystring.toUpperCase().toCharArray());
	}

	public MyString myTrim()
	{
		return new MyString(this.mystring.trim().toCharArray());
	}

	public void imprimir()
	{
		
		System.out.println(this.mystring);
		
	}

	public String myToString()
	{
		
		return this.mystring.toString();

	}

}
