package objetos;

public class Proceso extends Thread {

	public Proceso (String msg) {
		
		super (msg);
	}	
	
	public void run() {
		
			
				String nombreThread = Thread.currentThread().getName();
				for(int i = 0; i <= 20; i++) {
						System.out.println(nombreThread + " estoy en iteracion " + i);
					if(i==20) {
						System.out.println("Soy " + nombreThread + " acabo ejecucion.");

					}
				}		
		
	}
}
