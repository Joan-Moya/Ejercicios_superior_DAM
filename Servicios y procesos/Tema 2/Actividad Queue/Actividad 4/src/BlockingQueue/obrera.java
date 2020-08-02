package BlockingQueue;

public class obrera implements Runnable {
	private cuidadora cuidadora;
	
	obrera(cuidadora c){ cuidadora = c; }

	int cantidad_galerias_creadas_obreras;
	int cantidad_galerias_creadas_cuidadoras;
	int cantidad_galerias_creadas_guerreras;
	
	@Override
	public void run() {
		while(true) {
			
			
			//llamamos a las funciones para que esten constantemente a la alerta de si hay feromonas
			detectarFeromonasObreras();
			detectarFeromonasCuidadoras();
			detectarFeromonasGuerreras();
			
			
		}
	}
	
	
	
	//creamos las funciones que se encargan de recibir las feromonas de cada tipo de galerias
	public void detectarFeromonasObreras() {
		boolean valor= cuidadora.feromonas_galeria_obreras;
		
		if(valor==true) {//si el valor es true se crea una nueva galeria
			cantidad_galerias_creadas_obreras++;
		}
	}
	
	public void detectarFeromonasCuidadoras() {
		boolean valor= cuidadora.feromonas_galeria_cuidadoras;
		
		if(valor==true) {//si el valor es true se crea una nueva galeria
			cantidad_galerias_creadas_cuidadoras++;
		}
	}
	
	public void detectarFeromonasGuerreras() {
		boolean valor= cuidadora.feromonas_galeria_guerreras;
		
		if(valor==true) {//si el valor es true se crea una nueva galeria
			cantidad_galerias_creadas_guerreras++;
		}
	}
	
	
	
	//vamos a crear las funciones que le pasaran al hormiguero cuantas galerias hay creadas
	public int cantidadGaleriasObreras() {
		return cantidad_galerias_creadas_obreras;
	}
	public int cantidadGaleriasGuerreras() {
		return cantidad_galerias_creadas_guerreras;
	}
	public int cantidadGaleriasCuidadoras() {
		return cantidad_galerias_creadas_cuidadoras;
	}
	
}