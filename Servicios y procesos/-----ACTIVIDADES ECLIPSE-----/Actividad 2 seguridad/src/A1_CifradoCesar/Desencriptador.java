package A1_CifradoCesar;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

public class Desencriptador {


	public static void main(String[] args) throws IOException {
		
		String texto = "";
		String currentLine;
		
		@SuppressWarnings("resource")
		BufferedReader reader = new BufferedReader(new FileReader("CifradoCesar2.txt"));
		while((currentLine = reader.readLine()) != null) {
			texto = texto + currentLine;
		}
		reader.close();
		
		List<Character> caracteres_texto = new ArrayList<Character>();
		for(int i = 0; i<texto.length(); i++) {
			caracteres_texto.add(texto.charAt(i));
		}
		
		Map<Character, Integer> mapadecaracteres = new HashMap<Character, Integer>();
		Character letra;
		for(int i = 0; i<caracteres_texto.size(); i++) {
			letra = caracteres_texto.get(i);
			if(mapadecaracteres.containsKey(letra)) {
				Integer numRep = mapadecaracteres.get(letra);
				numRep = numRep + 1;
				mapadecaracteres.replace(letra, numRep);
			}else {
				mapadecaracteres.put(letra, 1);
			}
		}
		
		Character charMaxRepetido = null;
		Integer numMaxRepeticiones = 0;
		Iterator<Map.Entry<Character, Integer>> itr = mapadecaracteres.entrySet().iterator();
		
		while(itr.hasNext()) {
			Map.Entry<Character, Integer> entry = itr.next();
			if(entry.getValue() >= numMaxRepeticiones) {
				numMaxRepeticiones = entry.getValue();
				charMaxRepetido = entry.getKey();
			}
		}
		
		
		Integer asciiValorDesplazado = (int) charMaxRepetido;
		Integer desplazamiento = asciiValorDesplazado - 32;//Suponemos que el caracter más repetido es el espacio en blanco y calculamos el desplazamiento.
		String textoDesencriptado = "";
		
		for(int i = 0; i<caracteres_texto.size(); i++) {
			int asciicharDesencriptado = (int) caracteres_texto.get(i) - desplazamiento;
			char charDesencriptada = (char)asciicharDesencriptado;
			textoDesencriptado = textoDesencriptado + charDesencriptada;
		}
		
		System.out.println(textoDesencriptado);
	}
	
}
