import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.InetSocketAddress;
import java.net.Socket;

public class Cliente implements Runnable{

	@Override
	public void run() {
		InetSocketAddress direccion = new InetSocketAddress("LocalHost",9879);//ponemos la conexion del servidor
		Socket socket = new Socket();
		
		try {
			socket.setReuseAddress(true);//esto es para poder hacer varios clientes a y que las peticiones no fallen
			socket.connect(direccion);//le decimos al socket que se conecte a la direccion
			
			//escribimos los string de entrada y salida
			InputStreamReader isr = new InputStreamReader(socket.getInputStream());
			BufferedReader bfr = new BufferedReader(isr);
			PrintWriter pw = new PrintWriter(socket.getOutputStream());
			
			//ahora vamos a pasarle los datos al servidor
			System.out.println("Peticion desde cliente " + Thread.currentThread().getName());
			pw.println(cargarSentencia());
			pw.println("fin");
			pw.flush();//sale la peticion
			
			//ahora mostramos la respuesta
			String resultado = bfr.readLine();//recojo la respuesta
			System.out.println("El resultado es "+ resultado);//muestro la respuesta
			
			//ahora cerramos las conexiones y el socket
			bfr.close();
			pw.close();
			isr.close();
			socket.close();
			
		}catch (Exception e) {
			System.out.println(e);
		}
	}
	
	
	//creamos una funcion que nos genere la suma o la resta
	public String cargarSentencia() {
		//vamos a declarar variables que nos proporcionaran los numeros de la suma
		int numero1 = (int)(Math.random()*10+1);
		int numero2 = (int)(Math.random()*10+1);
		String caracter =" ";
		
		int sumaResta = (int)(Math.random()*2);//calculamos si es suma o resta
		
		//definimos el caracter que será dependiendo del numero
		if (sumaResta == 0) {
			caracter = "-";
		}else if (sumaResta == 1) {
			caracter = "+";
		}
		
		//montamos la cadena que se mostrará en el servidor
		String sentencia = (numero1+" "+caracter+" "+numero2);
		
		return sentencia;
	}

}
