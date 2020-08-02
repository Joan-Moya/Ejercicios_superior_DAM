package ejemplos;

import java.io.*;


public class archivos{
	
	public static void main(String[] args) throws IOException {
		String vocal = (args[0]);
		String direccion = (args[1]);
		
		//leemos el archivo de la carpeta
		archivos archivo = new archivos();
		archivo.leerTxt(vocal,direccion);
	}
	
	public void leerTxt(String vocal,String direccion) throws IOException {
		
		
		String textoLeido = "";
		int vocalesEncontradas = 0;
		
		
		
		try {
			
			BufferedReader bf = new BufferedReader (new FileReader(direccion));//aqui abrimos el archivo txt 
			String bfRead;
			char vocalIntroducida =vocal.charAt(0);//parseamos la vocal a char
			
			while((bfRead = bf.readLine()) != null ){//se hace el ciclo mientras bfRead contiene un dato
				
				for(int i=0; i < bfRead.length(); i++) {
					
					if(bfRead.charAt(i) == vocalIntroducida) {
						vocalesEncontradas = vocalesEncontradas +1;//si la letra que hemos encontrado es igual a la pasada por parametro "++"
					}
					
				}
			}
						
			bf.close();
			
			System.out.println(textoLeido);
		}catch(Exception e) {
			
			System.err.println("No se ha encontrado el archivo");
			
			}
		
		
		
		String cadena = Integer.toString(vocalesEncontradas);//parseamos la cantidad de vocales a char
		
		FileWriter fileWriter = new FileWriter("Total_vocales.txt");
		PrintWriter printWriter = new PrintWriter(fileWriter);
		printWriter.print(cadena);		
		printWriter.close();
		
	}
}

