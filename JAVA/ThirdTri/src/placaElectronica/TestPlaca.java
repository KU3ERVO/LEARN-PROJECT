package placaElectronica;

public class TestPlaca {

	public static void main(String[] args) {
		
		CircuitoSerie c1 = new CircuitoSerie(34);
		CircuitoSerie c2 = new CircuitoSerie(45);
		
		CircuitoParalelo c3 = new CircuitoParalelo(100);
		
		Resistencia r1 = new Resistencia(200);
		Resistencia r2 = new Resistencia(400);
		Resistencia r3 = new Resistencia(500);
		Resistencia r4 = new Resistencia(50);
		Resistencia r5 = new Resistencia(700);
		Resistencia r6 = new Resistencia(100);
		
		c1.getResistencias().add(r1);
		c1.getResistencias().add(r2);
		c1.getResistencias().add(r3);
		
		c2.getResistencias().add(r4);
		c2.getResistencias().add(r5);
		
		c3.getResistencias().add(r6);
		
		System.out.println(c1.Intensidad());
		System.out.println(c2.Intensidad());
		
		System.out.println(c3.Intensidad());
		
		Placa p1 = new Placa();
		
		p1.getCircuitos().add(c1);
		p1.getCircuitos().add(c2);
		p1.getCircuitos().add(c3);
		
		System.out.println(p1.IntensidadTotal());
	}

}
