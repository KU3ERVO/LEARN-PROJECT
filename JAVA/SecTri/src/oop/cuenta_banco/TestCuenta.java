package oop.cuenta_banco;

public class TestCuenta {

	public static void main(String[] args) {
		
		CuentaCorriente cc1 = new CuentaCorriente(2000, 60);
		CuentaAhorro ca1 = new CuentaAhorro(700,5);
		
		cc1.ExtractoMensual();
		cc1.Retirar(2200);
		cc1.Retirar(2000);
		cc1.Consignar(3000);
		
		ca1.Retirar(300);
		ca1.Consignar(300);
		
		
		System.out.println(cc1.toString()); 
		System.out.println(ca1.toString());
		
		ca1.Consignar(29000);
		ca1.Retirar(2000);
		
		System.out.println(ca1.toString());

	}

}
