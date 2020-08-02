package ejemplos;

public class sumador {

	
	public static void sumatorio(int n1, int n2) {
		int resultado = 0;
		for(int i= n1; i<= n2; i++) {
			resultado+=i;
		}
		System.out.println(resultado);
	}
	
	public static void main(String[] args) {
		int n1 = Integer.parseInt(args[0]);
		int n2 = Integer.parseInt(args[1]);
		sumador.sumatorio(n1,n2);
		
	}

}
