package oop.tiempo;
import java.util.concurrent.TimeUnit;
public class Tiempo {

	//+ TIMER QUE VAYA SUMANDO 1 CADA SEGUNDO
	private int hora=00,min=00,seg= 00;
	private boolean stop=true;

	Tiempo(int hora, int min, int seg) {
		if(hora<24&&hora>-1) {
			this.hora = hora;}
		if(min<60&&min>-1) {
			this.min = min;}
		if(seg<60&&seg>-1) {
			this.seg = seg;}
	}

	Tiempo(int hora, int min) {
		if(hora<24&&hora>-1) {
			this.hora = hora;}
		if(min<60&&min>-1) {
			this.min = min;}
	}

	Tiempo(int hora) {
		if(hora<24&&hora>-1) {
			this.hora = hora;}
	}

	public int getHora() {
		return hora;
	}

	public void setHora(int hora) {
		if(hora<24&&hora>-1) {
			this.hora = hora;}
	}

	public int getMin() {
		return min;
	}

	public void setMin(int min) {
		if(min<60&&min>-1) {
			this.min = min;}
	}

	public int getSeg() {
		return seg;
	}

	public void setSeg(int seg) {
		if(seg<60&&seg>-1) {
			this.seg = seg;}
	}
	
	public String toString() {
		return this.hora+":"+this.min+":"+this.seg;
	}
	public void RelojOn() {
		this.stop=false;
		
		while(this.stop==false) {
			while(this.hora<24) {
				while(this.min<60) {	
					while(this.seg<60) {
						try {
			                Thread.sleep(1000);
			            } catch (InterruptedException e) {
			                e.printStackTrace();}
						this.seg++;
						System.out.println(toString());
					}
					this.min++;
					this.seg=0;
				}
				this.hora++;
				this.min=0;
			}
			this.hora=0;
		}
		
	}
	
	public void RelojOff() {
		this.stop=true;
	}






}
