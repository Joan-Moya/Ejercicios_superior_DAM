package ejemplos;

import java.io.File;
import java.io.IOException;

public class ProcessLauncher {

	//static int vecesLanzado = 0;//cada vez que entremos a la funcion sumaremos la variable para crear un archivo nuevo
	
	//entramos a esta funcion para guardar el resultado de sumador en un archivo txt
	public static void lanzamientoEscribirTexto(String texto) throws IOException {
		
		ProcessBuilder pb = new ProcessBuilder("java","-cp","bin","ejemplos.insertarTexto",texto);
		pb.redirectOutput(new File("TXT_con_frase.txt"));//redirigimos el out a un fichero
	    pb.start();
	    //vecesLanzado++;
	    
	}

	
	//en esta clase ponemos los numeros que queremos sumar llamando a la funcion lanzamientoSumadores
	public static void main(String[] args) throws IOException {
		
		//insertamos frase de prueba en un txt
		String Frase_a_analizar = "Esta es una frase de prueba";
		lanzamientoEscribirTexto(Frase_a_analizar);
		System.out.println("Archivo escrito");
		
		//leemos el archivo de la carpeta
		archivos archivo = new archivos();
		archivo.leerTxt("e","TXT_con_frase.txt");
		
		
	}

}
