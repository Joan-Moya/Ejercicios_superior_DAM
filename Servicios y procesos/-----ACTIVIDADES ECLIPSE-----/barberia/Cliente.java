package barberia;

public class Cliente implements Runnable {
	Barberia barberia;
	public boolean afeitado = false;
	
	public Cliente(Barberia b) { barberia = b;}

	@Override
	public void run() {
		int indiceSilla = barberia.cogerSillaLibre(this);
		if(indiceSilla != -1) {
			System.out.println("Entro a la barberia");
			while(!afeitado) {
				try {
					Thread.sleep(500);
				} catch (InterruptedException e) {					
					e.printStackTrace();
				}
			}
			System.out.println("Ya estoy afeitado, me voy");
			barberia.liberarSilla(indiceSilla);			
		} else {
			System.out.println("No consigo silla, me voy");
		}
	}
}
