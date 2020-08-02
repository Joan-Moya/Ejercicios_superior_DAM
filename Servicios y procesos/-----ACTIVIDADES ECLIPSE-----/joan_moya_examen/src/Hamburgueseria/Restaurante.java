package Hamburgueseria;

public class Restaurante {
	Silla[] sillas;
	
	public Restaurante(int num_sillas) {
		for(int i = 0; i < num_sillas; i++) {
			sillas = new Silla[i];
		}
	}
	
	public synchronized int cogerSillaLibre(Cliente cliente) {
		for(int i = 0; i < sillas.length; i++) {
			if(!sillas[i].ocupada) {
				System.out.println("Silla " + i + " disponible");
				sillas[i].ocupada = true;
				sillas[i].cliente = cliente;
				return i;
			}
		}
		System.out.println("No hay sillas disponibles");
		return -1;
	}
}

