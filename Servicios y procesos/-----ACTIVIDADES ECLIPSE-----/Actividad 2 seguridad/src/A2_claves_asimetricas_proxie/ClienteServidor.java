package A2_claves_asimetricas_proxie;

public class ClienteServidor {

	public static void main(String[] args) throws InterruptedException {
		
		Servidor servidor = new Servidor();//hacemos una instancia de servidor
		Thread threadServidor = new Thread(servidor);//inicializamos el hilo de servidor
		threadServidor.start();//arrancamos el hilo de servidor
		int contCliente = 0;//contador para los clientes
		
		while(true) {
			Cliente cliente = new Cliente();//inicializamos un cliente
			Thread threadCliente = new Thread(cliente);//declaramos un nuevo hilo de cliente
			threadCliente.setName("" + contCliente);//a�adimos nombre
			
			threadCliente.start();//arrancamos cliente
			
			contCliente++;//contamos el cliente
			
			
			threadCliente.join();
			
			System.out.println("Acaba el hilo del cliente");
			Thread.sleep(1000);
			contCliente++;
		}
	}

}
