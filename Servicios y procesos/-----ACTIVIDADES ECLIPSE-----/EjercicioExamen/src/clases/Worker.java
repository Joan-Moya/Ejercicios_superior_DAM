package clases;
import java.net.Socket;

public class Worker implements Runnable {

	private Cifrado cifrado;
	private Socket conexion;
	

	public Worker(Socket c, Cifrado gc) {
		this.conexion = c;
		cifrado = gc;
	}

	@Override
	public void run() {
		String respuesta = "en que te podemos ayudar??";
		
		
		try {
			//recibimos la clave publica
			cifrado.recibirClavePublica(conexion.getInputStream());
			//enviamos clave publica
			cifrado.enviarClavePublica(conexion.getOutputStream());

			//desencriptamos mensaje
			String decryptedMessage = cifrado.recibirMensajeEncriptado(conexion.getInputStream());
			
			System.out.println("Servidor: " + decryptedMessage);//mostramos el mensaje desencriptado

			//enviamos el mensaje encriptado
			cifrado.enviarMensajeEncriptado(respuesta.getBytes(), conexion.getOutputStream());
			
			conexion.close();//cerramos conexion
		} catch (Exception e) {
			System.out.println(e);
		}

	}

}