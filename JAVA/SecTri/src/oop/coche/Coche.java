package oop.coche;
import java.util.Scanner;

public class Coche {
	
	 private String marca, modelo, color;
	 private int potencia, maletero, puertas, precio, velocidad;
	 
	 Coche(String marca, String modelo, String color, int potencia, int maletero, int puertas, int precio, int velocidad){
	 
		 this.marca = marca;
		 this.modelo = modelo;
		 this.color = color;
		 this.potencia = potencia;
		 this.maletero = maletero;
		 this.puertas = puertas;
		 this.precio = precio;
		 this.velocidad = velocidad;
	 }
	 
	 
	 
	 public void setMarca(String marca) {
		 this.marca = marca;
		 }
		 public String getMarca() {
		 return marca;
		 }
		 public void setModelo(String modelo) {
		 this.modelo = modelo;
		 }
		 public String getModelo() {
		 return modelo;
		 }
		 public void setColor(String color) {
		 this.color = color;
		 }
		 public String getColor() {
		 return color;
		 }
		 public void setPotencia(int potencia) {
		 this.potencia = potencia;
		 }
		 public int getPotencia() {
		 return potencia;
		 }
		 public void setMaletero(int maletero) {
		 this.maletero = maletero;
		 }
		 public int getMaletero() {
		 return maletero;
		}
		 public void setPuertas(int puertas) {
		 this.puertas = puertas;
		 }
		 public int getPuertas() {
		 return puertas;
		 }
		 public void setPrecio(int precio) {
		 this.precio = precio;
		 }
		 public int getPrecio() {
		 return precio;
		 }
		 public void setVelocidad(int velocidad) {
		 this.velocidad = velocidad;
		 }
		 public int getVelocidad() {
		 return velocidad;
		 }
	 
	 
		 public void acelerar(int mas) {
			 velocidad += mas;
			 }
			 public void desacelerar(int menos) {
			 velocidad -= menos;
			 }
			 public void frenar() {
			 velocidad = 0;
			 }
			 public void pintarCoche() {
			 System.out.print("¿De qué color desea pintar el coche? ");
			 setColor(teclado.nextLine());
			 }
			 public void mostrarDatos() {
			 System.out.println("****CARACTERÍSTICAS DEL COCHE****");
			 System.out.println("MARCA: " + marca);
			 System.out.println("MODELO: " + modelo);
			 System.out.println("COLOR: " + color);
			 System.out.println("POTENCIA: " + potencia + " CV.");
			 System.out.println("MALETERO: " + maletero + " L.");
			 System.out.println("NÚMERO DE PUERTAS: " + puertas);
			 System.out.println("PRECIO: " + precio + " €");
			}
			}
			