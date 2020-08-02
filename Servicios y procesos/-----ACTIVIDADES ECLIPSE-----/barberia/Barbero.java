package barberia;

public class Barbero implements Runnable {
	Barberia barberia;
	
	public Barbero (Barberia b) {barberia = b;}

	@Override
	public void run() {
		while(true) {
			//System.out.println("Barbero: Busco cliente que atender;");
			Silla sillaAtendida = barberia.atenderCliente();
			if(sillaAtendida != null) {
				try {
					afeitar(sillaAtendida);
				} catch (InterruptedException e) {					
					e.printStackTrace();
				}
			} else {
				try {
					descansar();
				} catch (InterruptedException e) {					
					e.printStackTrace();
				}
			}
		}
	}
	
	private void afeitar(Silla silla) throws InterruptedException {
		System.out.println("Afeito a cliente");
		Thread.sleep(1500);
		silla.cliente.afeitado = true;
	}
	
	private void descansar() throws InterruptedException {
		Thread.sleep((long) (Math.random() * 2000));
	}
}
