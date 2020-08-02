package ejemplos;

import java.io.File;
import java.io.IOException;

public class ProcessLauncher {

	static int vecesLanzado = 0;//cada vez que entremos a la funcion sumaremos la variable para crear un archivo nuevo
	
	//entramos a esta funcion para guardar el resultado de sumador en un archivo txt
	public static void lanzamientoSumadores(String num1, String num2) throws IOException {
		
		ProcessBuilder pb = new ProcessBuilder("java","-cp","bin","ejemplos.sumador",num1,num2);
		pb.redirectOutput(new File("salidaLauncher"+vecesLanzado+".txt"));//redirigimos el out a un fichero
	    pb.start();
	    vecesLanzado++;
	    
	}

	
	
	
	//en esta clase ponemos los numeros que queremos sumar llamando a la funcion lanzamientoSumadores
	public static void main(String[] args) throws IOException {
		lanzamientoSumadores("1","30");
		System.out.println("Archivo escrito");
		lanzamientoSumadores("2","40");
		System.out.println("Archivo escrito");
	}

}
