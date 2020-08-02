package clases;
import java.net.InetSocketAddress;
import java.net.Socket;

public class Cliente implements Runnable {

	
	public void run() {
		
		
		String mensaje = "Hola buenas";//declaramos la variable con el nombre que le vamos a enviar al servidor
		InetSocketAddress rutaServidor = new InetSocketAddress("localhost", 8089);//inicializamos la ruta del servidor para conexion
		Socket socket = new Socket();
		
		
		try {
			
			Cifrado cifrado = new Cifrado();//delcaramos el cifrado
			socket.setReuseAddress(true);
			socket.connect(rutaServidor);//conectamos con el sevidor
			
			//enviamos clave publica
			cifrado.enviarClavePublica(socket.getOutputStream());
			
			//recibimos la clave publica
			cifrado.recibirClavePublica(socket.getInputStream());

			//enviamos el mensaje encriptado
			cifrado.enviarMensajeEncriptado(mensaje.getBytes(), socket.getOutputStream());

			//vamos a desencriptar el mensaje
			String desencriptarMensaje = cifrado.recibirMensajeEncriptado(socket.getInputStream());
			
			System.out.println("Cliente: " + desencriptarMensaje);
			socket.close();
			
		} catch (Exception e) {
			System.out.println(e);
		}		
	}
}