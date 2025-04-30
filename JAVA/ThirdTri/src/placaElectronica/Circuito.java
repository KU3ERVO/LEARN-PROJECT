package placaElectronica;

import java.util.ArrayList;

public abstract class Circuito {
	
	protected double voltaje;
	protected ArrayList <Resistencia> resistencias;
	
    public Circuito(double voltaje) {
    	this.voltaje=voltaje;
    	this.resistencias = new ArrayList<>();
    }

    
    
	public double getVoltaje() {
		return voltaje;
	}

	public void setVoltaje(double voltaje) {
		this.voltaje = voltaje;
	}

	public ArrayList<Resistencia> getResistencias() {
		return resistencias;
	}

	public void setResistencias(ArrayList<Resistencia> resistencias) {
		this.resistencias = resistencias;
	}
    
    
	
	public abstract double Intensidad();

}
