package Hamburgueseria;

public class Lanzador {

	final static int N_SILLA = 7;
	final static int N_COCINA = 1;
	
	public static void main(String[] args) throws InterruptedException {
		Hamburgueseria Hamburgueseria = new Hamburgueseria(N_SILLA);
		Thread[] hilosCocina = new Thread[N_COCINA];
		for(int i = 0; i < N_COCINA; i++) {
			Cocina cocina = new Cocina(Hamburgueseria);
			Thread hilo = new Thread(cliente);
			hilosClientes[i] = cliente;
			cliente.start();
		}
		
		while(true) {
			Cliente cliente = new Cliente(Hamburgueseria);
			Thread threadCliente = new Thread(cliente);
			threadCliente.start();
			Thread.sleep(1750);
		}
	}

}


