import java.io.IOException;


public class Lanzador{


	public static void main(String[] args) throws IOException {
	
		String servidor = "Servidor";
		String cliente = "Cliente";
		lanzar(servidor);
		lanzar(cliente);
		}
	
	public static void lanzar(String clas ) throws IOException {
		
		ProcessBuilder pb;
		String sentencia = "sockets."+clas;

		try {
			pb = new ProcessBuilder("java" , "-cp", "bin" , sentencia );
			pb.start();
		

			}catch(Exception e) {
				e.printStackTrace();
			}
		}
	}