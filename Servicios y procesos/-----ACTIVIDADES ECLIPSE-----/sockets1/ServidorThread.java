package sockets1;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class ServidorThread implements Runnable {

	@Override
	public void run() {
		System.out.println("Arrancado el servidor");
		ServerSocket socketEscucha = null;
		try {
			socketEscucha = new ServerSocket(9876);
		} catch (IOException e) {
			System.out.println("No se pudo poner un socket " + "a escuchar en TCP 9876");
			return;
		}		
		while (true) {
			try {
				Socket conexion = socketEscucha.accept();
				System.out.println("Conexion recibida!");
				InputStream is = conexion.getInputStream();
				InputStreamReader isr = new InputStreamReader(is);
				BufferedReader bf = new BufferedReader(isr);
				String peticion = bf.readLine();
				while(!peticion.contentEquals("fin")) {				
					System.out.println("Peticion recibida en servidor: " + peticion);
					peticion = bf.readLine();
				}
				OutputStream os = conexion.getOutputStream();
				PrintWriter pw = new PrintWriter(os);
				pw.write("He recibido tu peticion\n");
				pw.flush();
			} catch (Exception e) {
				System.out.println(e);
			}
		}		
	}
}
