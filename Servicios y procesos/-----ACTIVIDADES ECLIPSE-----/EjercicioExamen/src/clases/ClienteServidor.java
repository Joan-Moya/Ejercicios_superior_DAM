package clases;
import javax.crypto.NoSuchPaddingException;
import java.security.NoSuchAlgorithmException;

public class ClienteServidor {

	public static void main(String[] args) throws InterruptedException, NoSuchPaddingException, NoSuchAlgorithmException {
		
		Cifrado cifradoServidor = new Cifrado();
		Servidor servidor = new Servidor(cifradoServidor);//inicializamos la clase servidor
		Thread hiloServidor = new Thread(servidor);//hilo del servidor
		hiloServidor.start();//iniciamos
		
		//creamos variable para contar los clientes
		int contarCliente = 0;
		
		
		while(true) {
			
			/*CLIENTE A*/
			Cliente cA = new Cliente();//inicializamos la clase cliente
			Thread hiloClienteA = new Thread(cA);//declaramos el hilo
			hiloClienteA.setName("" + contarCliente);
			hiloClienteA.start();//iniciamos clienteA
			
			
			contarCliente++;//sumamos un +1 para saber la cantidad de clientes
			
			/*CLIENTE B*/
			Cliente cB = new Cliente();
			Thread hiloClienteB = new Thread(cB);
			hiloClienteB.setName("" + contarCliente);
			hiloClienteB.start();//iniciamos clienteB

			//a�adimos
			hiloClienteA.join();
			hiloClienteB.join();
			System.out.println("Fin");
			Thread.sleep(1000);
			
			contarCliente++;//sumamos un +1 para saber la cantidad de clientes
		}
	}

}