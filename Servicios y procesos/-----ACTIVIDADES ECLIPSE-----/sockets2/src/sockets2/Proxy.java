package sockets2;

public class Proxy implements Runnable{

	public void run() {
		
		
		//Este es el cliente que finalmente va a conectarse con el servidor
		
		//Inicializamos el servidor y le pasamos los diferentes clientes que queremos procesar
			Servidor server = new Servidor();
			Thread threadServer = new Thread(server);
			threadServer.start();
			int contCliente = 0;
			
		
		//VAMOS A GENERAR LOS 10 CLIENTES QUE LE MANDAMOS AL SERVIDOR
			while(true) {
				
				Cliente cliente = new Cliente();
				Thread threadCliente = new Thread(cliente);
				threadCliente.setName("" + contCliente);
				threadCliente.start();
				contCliente++;
				
				Cliente cliente2 = new Cliente();
				Thread threadCliente2 = new Thread(cliente2);
				threadCliente2.setName("" + contCliente);
				threadCliente2.start();
				contCliente++;
				
				Cliente cliente3 = new Cliente();
				Thread threadCliente3 = new Thread(cliente3);
				threadCliente3.setName("" + contCliente);
				threadCliente3.start();
				contCliente++;
				
				Cliente cliente4 = new Cliente();
				Thread threadCliente4 = new Thread(cliente4);
				threadCliente4.setName("" + contCliente);
				threadCliente4.start();
				contCliente++;
				
				Cliente cliente5 = new Cliente();
				Thread threadCliente5 = new Thread(cliente5);
				threadCliente5.setName("" + contCliente);
				threadCliente5.start();
				contCliente++;
				
				Cliente cliente6 = new Cliente();
				Thread threadCliente6 = new Thread(cliente6);
				threadCliente6.setName("" + contCliente);
				threadCliente6.start();
				contCliente++;
				
				Cliente cliente7 = new Cliente();
				Thread threadCliente7 = new Thread(cliente7);
				threadCliente7.setName("" + contCliente);
				threadCliente7.start();
				contCliente++;
				
				Cliente cliente8 = new Cliente();
				Thread threadCliente8 = new Thread(cliente8);
				threadCliente8.setName("" + contCliente);
				threadCliente8.start();
				contCliente++;
				
				Cliente cliente9 = new Cliente();
				Thread threadCliente9 = new Thread(cliente9);
				threadCliente9.setName("" + contCliente);
				threadCliente9.start();
				contCliente++;
				
				Cliente cliente10 = new Cliente();
				Thread threadCliente10 = new Thread(cliente10);
				threadCliente10.setName("" + contCliente);
				threadCliente10.start();
				
		
				//excepciones generadas por el propio java
				try {
					threadCliente.join();
					threadCliente2.join();
					threadCliente3.join();
					threadCliente4.join();
					threadCliente5.join();
					threadCliente6.join();
					threadCliente7.join();
					threadCliente8.join();
					threadCliente9.join();
					threadCliente10.join();
					
				} catch (InterruptedException e) {
					e.printStackTrace();
				}

				//avisamos de que se han procesado los hilos
				System.out.println("Acaban los hilos");
				try {
					Thread.sleep(1000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
				contCliente++;
			}
			
		}
	}


