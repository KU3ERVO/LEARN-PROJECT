package oop.modulodireccion;

public class Test {
	public static void main(String[]args) {
	
	ModuloDeDirecciones dir1 = new ModuloDeDirecciones("plz.","Maria Rojas",1,1,'D',57694,"Leganes","Madrid","España");
	ModuloDeDirecciones dir2 = new ModuloDeDirecciones("c.","Atocha",36,0,'C',45333,"Madrid","Madrid","España");
	ModuloDeDirecciones dir3 = new ModuloDeDirecciones("c.","Retiro",5,1,'A',95686,"Madrid","Madrid","España");
	ModuloDeDirecciones dir4 = new ModuloDeDirecciones("avd.","Soledad",13,2,'A',94014,"Ciudad Mujeres","Canarias","España");
	ModuloDeDirecciones dir5 = new ModuloDeDirecciones("plz.","12 octubre",2,5,'B',93222,"Guadalajara","Guadalajara","Mexico");
	
	dir1.prt();
	dir2.prt();
	dir3.prt();
	dir4.prt();
	dir5.prt();
	
	
	}
	

}
