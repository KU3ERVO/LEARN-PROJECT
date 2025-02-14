package oop.cuenta_banco;

/*
 * 	Desarrollar un programa que modele una cuenta bancaria que tiene los siguientes atributos, que
   	deben ser de acceso protegido:
		Saldo, de tipo float.
		Número de consignaciones con valor inicial cero, de tipo int.
		Número de retiros con valor inicial cero, de tipo int.
		Tasa anual (porcentaje), de tipo float.
		Comisión mensual con valor inicial cero, de tipo float.

	La clase Cuenta tiene un constructor que inicializa los atributos saldo y tasa anual con
	valores pasados como parámetros. La clase Cuenta tiene los siguientes métodos:

		Consignar una cantidad de dinero en la cuenta actualizando su saldo.
		Retirar una cantidad de dinero en la cuenta actualizando su saldo. El valor a retirar no debe
		superar el saldo.
		Calcular el interés mensual de la cuenta y actualiza el saldo correspondiente.
		Extracto mensual: actualiza el saldo restándole la comisión mensual y calculando el interés
		mensual correspondiente (invoca el método anterior).	
		Imprimir: muestra en pantalla los valores de los atributos.

		
 * 
 */


public class Cuenta {

	protected float saldo,tasaAnual,comisionMensual;
	protected int consignaciones = 0, retiros = 0;

	public Cuenta(float saldo, float tasaAnual) {
		super();
		this.saldo = saldo;
		if(tasaAnual<=100&&tasaAnual>=0) {
		this.tasaAnual = tasaAnual;}
	}

	public void Consignar(float eur) {
		saldo+=eur;
		consignaciones++;
	}

	public void Retirar(float eur) {
		saldo-=eur;
		retiros++;
	}

	public void Calcular() {
		float interesMes=tasaAnual/12;
		saldo+=(saldo/100)*interesMes;
	}

	public void ExtractoMensual() {
		saldo-=comisionMensual;
		Calcular();
	}

	public String toString() {
		return"SALDO: "+saldo+"€"
				+"\n\nTasa anual: "+ tasaAnual+"%"
				+"\nTasa mensual: "+ tasaAnual/12+"%"
				+"\nComision mensual: "+comisionMensual+"€"
				+"\nRetiros: "+retiros
				+"\nConsignaciones: "+consignaciones;
	}

	public float getSaldo() {
		return saldo;
	}

	public void setSaldo(float saldo) {
		this.saldo = saldo;
	}

	public float getTasaAnual() {
		return tasaAnual;
	}

	public void setTasaAnual(float tasaAnual) {
		if(tasaAnual<=100&&tasaAnual>=0) {
		this.tasaAnual = tasaAnual;}
	}

	public float getComisionMensual() {
		return comisionMensual;
	}

	public void setComisionMensual(float comisionMensual) {
		this.comisionMensual = comisionMensual;
	}

	public int getConsignaciones() {
		return consignaciones;
	}

	public void setConsignaciones(int consignaciones) {
		this.consignaciones = consignaciones;
	}

	public int getRetiros() {
		return retiros;
	}

	public void setRetiros(int retiros) {
		this.retiros = retiros;
	}
	
	


}
