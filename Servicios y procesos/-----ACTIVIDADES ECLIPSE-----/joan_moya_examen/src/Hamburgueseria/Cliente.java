package Hamburgueseria;

public class Cliente implements Runnable{
	
	
	public String pedido;
	public Cocina cocina;
	public Restaurante restaurante;
	
	public Cliente(Cocina cocina, Restaurante restaurante){
		
		this.restaurante = restaurante;
		
		this.cocina = cocina;
	}
	
	// creamos la funcion para realizar el pedido
	public void realizarPedido() throws InterruptedException {
		
		double tipoRandom = Math.random();
		
		if(tipoRandom <= 0.50) {//calculamos la probabilidad
			pedido = "BurguerColesterol";
			
		}else {
			pedido = "BurguerGrasa";
		}
		
		cocina.ponerComandaBurguer(pedido);
	}
	
	
	public void run() {
		try {
			realizarPedido();//realizamos el pedido
			
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
		try {
			
			cocina.Cogerburguer(pedido);
			
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
		
	}
	
}
