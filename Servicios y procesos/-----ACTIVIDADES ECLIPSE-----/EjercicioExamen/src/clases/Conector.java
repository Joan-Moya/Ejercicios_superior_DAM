package clases;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.net.InetSocketAddress;
import java.net.Socket;

public class Conector {

	public static void main(String[] args) {
		String destino = "www.google.com";
		int puerto = 80;
		Socket socket = new Socket();
		InetSocketAddress direccion = new InetSocketAddress(destino, puerto);
		
		try {
			socket.connect(direccion);
			
			
			InputStream is = socket.getInputStream();
			OutputStream os = socket.getOutputStream();
			
			
			InputStreamReader isr = new InputStreamReader(is);
			OutputStreamWriter osw = new OutputStreamWriter(os);

			//iniciamos reader y writer
			BufferedReader bReader = new BufferedReader(isr);
			PrintWriter pWriter = new PrintWriter(osw);

			pWriter.println("GET /index.html");
			pWriter.flush();
			String linea;			
			while ((linea = bReader.readLine()) != null) {				
				System.out.println(linea);
			}
			
			//cerramos conexiones
			pWriter.close();
			bReader.close();
			isr.close();
			osw.close();
			is.close();
			os.close();
			socket.close();
		} catch (IOException e) {
			System.out.println("error de conexion");
		}
	}
}