package sockets2;

public class ClienteServidor {

	public static void main(String[] args) throws InterruptedException {
		
		
		//El ejercicio lo hemos hecho entre Eugenio y yo en la biblioteca de la FLORIDA
		
		
		/*Como el proxy es realmente un "cliente" que hace de "puente" entre otro cliente 
		y un servidor vamos a "conectarnos a ese cliente que es el proxy para que el mismo
		haga las peticiones por nosotros al servidor
		*/
		
		//conectamos con el proxy
		Proxy proxy = new Proxy();
		Thread threadProxy = new Thread(proxy);
		threadProxy.start();
		
		
	}

}
