package AtletaComparable;

import java.util.Comparator;

public class ComparadorEdad implements Comparator<Atleta> {

	@Override
	public int compare(Atleta o1, Atleta o2) {
		
		return o1.getName().compareTo(o2.getName());
	}
	
	

}
