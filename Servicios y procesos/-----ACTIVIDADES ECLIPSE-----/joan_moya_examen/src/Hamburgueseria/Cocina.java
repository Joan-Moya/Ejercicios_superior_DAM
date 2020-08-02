package Hamburgueseria;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.LinkedBlockingDeque;
public class Cocina implements Runnable{
	
	//declaramos las BlockingQueue
	private BlockingQueue<String> cintaBurguerColesterol;
	private BlockingQueue<String> comandas;
	private BlockingQueue<String> burguerGrasa;
	
	
	public Cocina() {
		comandas = new LinkedBlockingDeque<String>();
		cintaBurguerColesterol = new LinkedBlockingDeque<String>();
		burguerGrasa = new LinkedBlockingDeque<String>();
	}
	
	@Override
	public void run() {
		while(true) {
			try {
				
				prepararBurguer();
				
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
	}
	
	//creamos el metodo para prepara la burguer
	private void prepararBurguer() throws InterruptedException {
		String burguer = this.comandas.take();
		if(burguer == "McColesterol") {
			
			Thread.sleep(1000);
			this.cintaBurguerColesterol.put("BurguerColesterol");
			
		}
		else if(burguer == "BurguerGrasa") {
			
			Thread.sleep(500);
			this.burguerGrasa.put("BurguerGrasa");
		}
	}
	
	
	//añadimos la comanda al BlockingQueue
	public void ponerComandaBurguer(String burguer) throws InterruptedException {
		this.comandas.put(burguer);
	}
	
	
	//creamos el metodo que coge la burguer
	public String Cogerburguer(String comanda) throws InterruptedException {
		if(comanda == "BurguerColesterol") {
			return this.cintaBurguerColesterol.take();
			
		}
		else if(comanda == "BurguerGrasa") {
			return this.burguerGrasa.take();
			
		}
		else {
			return "Algo ha fallado";
		}
	}
}
