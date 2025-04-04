package AtletaComparable;

public class Atleta implements Comparable <Atleta>{
	
	private int seg;
	private String name;
	
	public Atleta(int seg, String name) {
		this.seg = seg;
		this.name = name;
	}

	public int getSeg() {
		return seg;
	}

	public void setSeg(int seg) {
		this.seg = seg;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int compareTo(Atleta a) {
		
		return seg-a.seg;
		
	}
	
	public String toString() {
		
		return"\n"+ name + "\nTiempo: "+seg+" segundos";
		
	}
	
	

}
