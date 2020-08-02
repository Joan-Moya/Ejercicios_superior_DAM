package objetos;

public class ClasePrincipal{

	public static void main(String[] args) {
		
		
		//creamos los 3 objetos hilo
		Thread hiloTortuga = new Proceso("hiloBasico1");
		Thread hiloLiebre = new Proceso("hiloBasico2");
		Thread hiloGuepardo = new Proceso("hiloBasico3");
		
		//le añadimos un nombre a cada hilo para que se ejecute con el nombre del animal que queramos
		hiloTortuga.setName("Tortuga");
		hiloLiebre.setName("Liebre");
		hiloGuepardo.setName("Guepardo");
		
		
		hiloGuepardo.setPriority(10);//le ponemos la prioridad mas alta al guepardo para que se ejecute antes
		hiloLiebre.setPriority(5);//ponemos una prioridad media a la liebre para que quede la segunda
		hiloTortuga.setPriority(1);//ponemos una prioridad 1 a la tortuga para asegurarnos de que es la ultima
		
		
		//arrancamos los hilos de manera que terminara primero el guepardo, luego la liebre y despues la tortuga
		hiloGuepardo.start();
		System.out.println("");
		hiloLiebre.start();
		System.out.println("");
		hiloTortuga.start();
		
	}	
}
