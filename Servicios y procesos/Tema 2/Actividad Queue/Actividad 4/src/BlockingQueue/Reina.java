package BlockingQueue;

import java.util.concurrent.BlockingQueue;
import java.util.concurrent.LinkedBlockingDeque;

public class Reina implements Runnable {
	
	//primero creamos una boocking queue para cada tipo de larva
	private BlockingQueue<Integer> obrera;
	private BlockingQueue<Integer> cuidadora;
	private BlockingQueue<Integer> guerrera;
	
	Reina() { 
		obrera = new LinkedBlockingDeque<Integer>();
		cuidadora = new LinkedBlockingDeque<Integer>();
		guerrera = new LinkedBlockingDeque<Integer>();
	}

	@Override
	public void run() {		
		while (true) {
			try {
				
				int tipo_huevo= (int) (Math.random()*3 + 1);   // generamos el tipo de huevo
				
				ponerHuevo(tipo_huevo);
				
				incubarHuevo(); //incubamos el huevo
			} catch (InterruptedException e) {				
				e.printStackTrace();
			}
		}				
	}
	
	
	
	
	//aqui vamos a poner los huevos dependiendo del tipo que sea
	private void ponerHuevo(int tipoHuevo) throws InterruptedException {
		int huevo =1;
		
		if(tipoHuevo==1) {//quiere decir que es larva de obrera
			
			this.obrera.put(huevo);//ponemos el huevo en su queue correspondiente
		}
		else if (tipoHuevo == 2) {//quiere decir que es cuidadora
			
			this.cuidadora.put(huevo);//ponemos el huevo en su queue correspondiente
		}
		else if (tipoHuevo == 3) {//quiere decir que es guerrera
			this.guerrera.put(huevo);//ponemos el huevo en su queue correspondiente
		}
	}
	
	
	private void incubarHuevo() throws InterruptedException {//creamos la clase que incubará un huevo
		Thread.sleep((long)Math.random() * 300); //le decimos que la reina tiene que esperar 3 segundos para incubar
	}
	
	//creamos las funciones para devolver los valores de las queue
	public int getValorObrera() throws InterruptedException {
		return this.obrera.take();
	}
	public int getValorCuidadora() throws InterruptedException {
		return this.cuidadora.take();
	}
	public int getValorGuerrera() throws InterruptedException {
		return this.guerrera.take();
	}
	
}