package myString;

public class MyString {

	private char[] cadena;
	private String mystring;

	public MyString(String cadena)
	{

	}

	public MyString(char[] cadena)
	{        

		String mystring = "";

		for(char c : cadena) {

			mystring += c;

		}

	}

	public MyString(ArrayList<Character> cadena)
	{
	}

	public char[] getCadena()
	{

	}

	public char myCharAt(int i) throws Exception
	{
	}

	public int myCompareTo(MyString cadena2)
	{
	}

	public int myCompareToIgnoreCase(MyString cadena2)
	{
	}  

	public void myConcat(MyString cadena2)
	{   
	}

	public int myIndexOf(int caracter)
	{
	}

	public int myLastIndexOf(int caracter)
	{
	}

	public int myLength()
	{

	}

	public MyString myReplace(char antiguo, char nuevo)
	{
	}

	/*
	 * public MyString[] mySplit(char expresion)
	    {
	    }
	 */

	public MyString[] mySplit(char expresion)
	{
	}



	public MyString mySubstring(int inicio, int fin) throws Exception
	{
	}

	public MyString myToLowerCase()
	{
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
