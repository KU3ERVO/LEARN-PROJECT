package oop.cuenta_banco;
/**La clase Cuenta tiene dos clases hijas: Cuenta corriente

Posee un atributo de sobregiro, el cual se inicializa en cero. Se
redefinen los siguientes métodos:

Retirar: se retira dinero de la cuenta actualizando su saldo. Se
puede retirar dinero superior al saldo. El dinero que se debe queda como sobregiro.

Consignar: invoca al método heredado. Si hay sobregiro, la cantidad consignada reduce
el sobregiro.

Extracto mensual: invoca al método heredado.
Un nuevo método imprimir que muestra en pantalla el saldo de la cuenta, la comisión
mensual, el número de transacciones realizadas (suma de cantidad de consignaciones y retiros) y
el valor de sobregiro.

Realizar un método main que implemente un objeto Cuenta de ahorros y llame a los
métodos correspondientes.**/


public class CuentaCorriente extends Cuenta {
	
	private float sobregiro=0;

	public CuentaCorriente(float saldo, float tasaAnual) {
		super(saldo, tasaAnual);
	}
	
	public void Retirar(float eur) {
		
		if(eur>saldo) {
			
			sobregiro+= -(saldo-eur);
			saldo=0;
			retiros++;
		}
		else {
			super.Retirar(eur);
		}
	}
	
	public void Consignar(float eur) {
		
		if (sobregiro>0) {
			consignaciones++;
			if(eur<=sobregiro) {
				sobregiro-=eur;
			}
			else {
				saldo+=(eur-sobregiro);
				sobregiro = 0;
			}
		}
		else {
			super.Consignar(eur);
		}
	}
	
	public void ExtractoMensual() {
		super.ExtractoMensual();
	}

	public String toString() {
		return "\n\nCUENTA CORRIENTE\n\n"+ super.toString()+"\nTransacciones llevadas a cabo: "+(consignaciones+retiros)
				+"\nSobregiro: "+sobregiro;
	}
}
