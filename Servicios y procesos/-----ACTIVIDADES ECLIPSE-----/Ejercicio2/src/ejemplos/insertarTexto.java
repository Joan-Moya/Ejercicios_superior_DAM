package ejemplos;

public class insertarTexto {

	
	public static void insertar(String texto) {
		System.out.println(texto);
	}
	
	public static void main(String[] args) {
		
		String texto_pasado = args[0];
		insertarTexto.insertar(texto_pasado);
		
	}

}
