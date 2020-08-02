package A2_claves_asimetricas_proxie;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.security.Key;
import java.security.KeyFactory;
import java.security.PrivateKey;
import java.security.PublicKey;
import java.security.spec.X509EncodedKeySpec;

public class Cliente implements Runnable{

	@Override
	public void run() {
		InetSocketAddress direccion = new InetSocketAddress("localhost", 9876);
		Socket socket = new Socket();
		try {
			//instanciamos el gestor de cifrado.
			GestorCifrado gestorCifrado = new GestorCifrado();
			//Clave publica cliente
			PublicKey clavePublicaCliente = gestorCifrado.getPublica();//Generamos la clave publica.
			byte[] clavePublicaBytesCliente = clavePublicaCliente.getEncoded();//convertimos la clave publica a tipo byte.
			//Clave privada cliente.
			PrivateKey clavePrivadaCliente = gestorCifrado.getPrivada();//Generamos la clave privada.
			
			//Creamos un socket de cliente
			socket.setReuseAddress(true);
			socket.connect(direccion);
			//streams de entrada
			InputStream is = socket.getInputStream();//trabaja con bytes
			InputStreamReader isr = new InputStreamReader(is);//pasamos a caracteres
			BufferedReader bfr = new BufferedReader(isr);//para poder leer linea a linea.
			//streams de salida
			OutputStream os = socket.getOutputStream();//trabaja con bytes
			OutputStreamWriter osw = new OutputStreamWriter(os);//pasamos a caracteres
			PrintWriter pw = new PrintWriter(osw);//para poder leer linea a linea.

			//Enviamos clave publica cliente al servidor.
			os.write(clavePublicaBytesCliente);//usamos os para enviar ya que el tipo de dato es byte.
			os.flush();
			
			//Recibimos clave publica del servidor
			byte[] clavePublicaBytesServidor = new byte[1024];//La claves son de 1024 bytes, (mirese en GestorCifrado)
			is.read(clavePublicaBytesServidor);//guardamos la clave publica del servidor en clavePublicaServidor.
			PublicKey clavePublicaServidor = KeyFactory.getInstance("RSA").generatePublic(new X509EncodedKeySpec(clavePublicaBytesServidor));//Recuperamos la clave publica a tipo PublicKey.
			
			//Mensaje a enviar.
			String mensaje = "Hola";
			byte[] mensajeEncriptado = gestorCifrado.cifrar(mensaje.getBytes(), clavePublicaServidor);//Ciframos usando la clave publica del servidor asi solo el servidor podr� desencriptarlo con su clave privada.
			
			//Enviamos el mensaje encriptado
			os.write(mensajeEncriptado);
			os.flush();
			
			//Recibimos la respuesta del servidor encriptado.
			byte[] respuestaByteEncriptada = new byte[128];
			is.read(respuestaByteEncriptada);// guardamos el mensaje encriptada en la variable.
			byte[] mensajeDescifradaBytes = gestorCifrado.descifrar(respuestaByteEncriptada, clavePrivadaCliente);//desencriptamos el mensaje
			String  mensajeDescifrado = new String(mensajeDescifradaBytes, "UTF-8");//Pasamos de bytes a String la url descifrada
			System.out.println("La respuesta del servidor es: "+mensajeDescifrado);
			
			bfr.close();
			pw.close();
			isr.close();
			socket.close();
		} catch (Exception e) {
			System.out.println(e);
		}
	}
	
	public static void main(String[] args) {
		Cliente cliente	= new Cliente();
		cliente.run();
	}
}
