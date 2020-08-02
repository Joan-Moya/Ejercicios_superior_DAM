package BlockingQueue;

import java.util.ArrayList;

public class BlockingQueue {
	
	final static int nHormiguero = 1;//definimos numero de hormigueros
	final static int nReinas = 1;//definimos numero de hormigueros

	public static void main(String[] args) throws InterruptedException {
		
		
		ArrayList<Thread> hilos = new ArrayList<Thread>();	
		
		
		//CREAMOS Y DEFINIMOS la reina
		Reina r = new Reina();
		Thread hiloReina = new Thread(r);
		hilos.add(hiloReina);
		
		
		for(int i = 0; i < nReinas; i++) {			
			Reina reina = new Reina();
			Thread hiloCons = new Thread(reina);			
			hilos.add(hiloCons);
		}	
		
		
			
		
	}

}
