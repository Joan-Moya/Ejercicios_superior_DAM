package clases;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class Servidor implements Runnable {

	private ExecutorService executor = Executors.newFixedThreadPool(10);

	private Cifrado cifrado;

	public Servidor(Cifrado gc) {
		cifrado = gc;
	}

	@Override
	public void run() {
		System.out.println("iniciando Server");
		ServerSocket socketEscucha = null;
		try {
			socketEscucha = new ServerSocket(8089);
		} catch (IOException e) {
			System.out.println("error en escucha");
			return;
		}
		while (true) {
			try {
				Socket conexion = socketEscucha.accept();
				System.out.println("Conexion aceptada!");

				Worker worker = new Worker(conexion, cifrado);
				executor.execute(worker);
			} catch (Exception e) {
				try {
					socketEscucha.close();
				} catch (IOException e1) {
					e1.printStackTrace();
				}
				System.out.println(e);
			}
		}		
	}
}