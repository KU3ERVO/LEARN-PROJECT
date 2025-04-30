package placaElectronica;
import java.util.ArrayList;

public class Placa {
	
	private ArrayList <Circuito> circuitos;
	
	public Placa() {
	
		this.circuitos = new ArrayList<>();
		
	}

	public ArrayList<Circuito> getCircuitos() {
		return circuitos;
	}

	public void setCircuitos(ArrayList<Circuito> circuitos) {
		this.circuitos = circuitos;
	}
	
	
	public double IntensidadTotal() 
	{
		double intensidad = 0;
		
		for(Circuito c : circuitos) 
		{
			intensidad += c.Intensidad();
		}
		
		return intensidad;
	}
	

}
