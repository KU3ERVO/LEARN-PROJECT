package placaElectronica;

public class CircuitoSerie extends Circuito {

	public CircuitoSerie(double voltaje) {
		super(voltaje);
	}
	
	public double Intensidad() {
	
		double resist = 0;
		
		for(Resistencia r : this.resistencias) {
			resist += r.ohm;
		}
		
		return this.voltaje/resist;
	}

}
