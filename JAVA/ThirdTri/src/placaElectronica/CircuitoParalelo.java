package placaElectronica;

public class CircuitoParalelo extends Circuito {

	public CircuitoParalelo(double voltaje) {
		super(voltaje);
		// TODO Auto-generated constructor stub
	}

	@Override
	public double Intensidad() {
		
		double intensidad = 0;
		
		for(Resistencia r : this.resistencias) {
			intensidad += this.voltaje/r.ohm;
		}
		
		return intensidad;
	}

}
