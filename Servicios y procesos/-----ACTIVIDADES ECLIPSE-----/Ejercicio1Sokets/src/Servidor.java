import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class Servidor implements Runnable{

	@Override
	public void run() {
		
		//vamos a poner el servidor a la escucha
		ServerSocket socketEscucha = null;
		try {
			socketEscucha =  new ServerSocket(9879);
			
		}catch (IOException e) {
			System.out.println("Ha fallado la creacion de la escucha del socket");
			return;//terminamos la ejecucion
		}
		
		//si el socket se ha creado correctamente...
		while(true) {
			try {
				
				Socket conexion = socketEscucha.accept();//le decimos que acepte la conexion, estara esperando hasta que llegue una conexion
				System.out.print("");
				
				//vamos a recoger los datos de la conexion
				InputStream is = conexion.getInputStream();
				OutputStream os = conexion.getOutputStream();
				
				InputStreamReader isr = new InputStreamReader(is);
				OutputStreamWriter osw = new OutputStreamWriter(os);
				
				BufferedReader bf = new BufferedReader(isr);
				PrintWriter pw = new PrintWriter(osw);
				
				//vamos a leer el contenido que nos manda el cliente
				String lineaPeticion = bf.readLine();
				int resultadoCalculo =0;
				while(!lineaPeticion.contentEquals("fin")){//mientras lineaPeticion no sea igual a "fin"
					
					System.out.println("Linea peticion: "+lineaPeticion);//imprimimos la peticion
					resultadoCalculo = calculaOperacion(lineaPeticion); //guardamos el resultado de la operacion

					lineaPeticion = bf.readLine(); //leemos otra linea
					
					/*con esto conseguimos un bucle que lee el contenido de
					 "lineapeticion" hasta que encuentra la palabra fin o hasta
					 que no hayan mas caracteres
					 */
				}
				pw.write(resultadoCalculo+" \n\n");//enviamos la peticion a la funcion para que nos la calcule
				pw.flush(); //para que se envie
				
			}catch(Exception e) {
				System.out.println(e);
			}
		}
		
		
	}
	
    //creamos una funcion que nos divide la sentencia y nos hace el calculo
	public int calculaOperacion(String sentencia) {
		
		String[] partes = sentencia.split(" ");//lo ponemos en partes para coger los numeros y si es suma o resta
		String numero1 = partes[0];//guardamos el numero1
		String operador = partes[1];//guardamos el operador
		String numero2 = partes[2]; //guardamos el numero2
		
		
		//ahora vamos a parsear los numeros a int
		int numero1Entero = Integer.parseInt (numero1);
		int numero2Entero = Integer.parseInt (numero2);
		int resultado = 0;
		
		//el siguiente paso es saber cual es el operador que se encuentra en operador y hacer el calculo
		if(operador.contentEquals("-")){
			resultado = numero1Entero - numero2Entero;
		}else if(operador.contentEquals("+")){
			resultado = numero1Entero + numero2Entero;
		}
		
		return resultado;
	}

}
