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
		MyString a = this.mystring.replace(antiguo, nuevo);
		return a;
	}

	public MyString[] mySplit(char expresion)
	{
		MyString [] a = this.mystring.split(expresion);
		return a;
		
	}



	public MyString mySubstring(int inicio, int fin) throws Exception
	{
		return this.mystring.substring(inicio, fin);
	}

	public MyString myToLowerCase()
	{
		this.mystring.toLowerCase();
	}

	public MyString myToLowerCase(char[] cadena)
	{
		
	}

	public MyString myToUpperCase()
	{
	}

	public MyString myTrim()
	{
	}

	public void imprimir()
	{
	}

	public String myToString()
	{

	}

}
