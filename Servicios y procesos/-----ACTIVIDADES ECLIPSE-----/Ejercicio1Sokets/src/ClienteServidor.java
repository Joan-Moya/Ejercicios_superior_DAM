
public class ClienteServidor {

	public static void main(String[] args) throws InterruptedException {
		Servidor servidor = new Servidor();//definimos el servidor
		Thread threadservidor = new  Thread(servidor);
		threadservidor.start();
		int contClientes = 0; //vamos a contar los clientes que se hayan generado
		
		//ahora vamos a crear clientes
		while(true) {
			Cliente cliente = new Cliente();
			Thread threadCliente = new Thread(cliente);
			threadCliente.setName("" + contClientes);//le ponemos un nombre
			threadCliente.start();//arrancamos cliente
			threadCliente.join();
			Thread.sleep(4000);//añadimos un tiempo de espera
			contClientes++;
		}
	}

}


