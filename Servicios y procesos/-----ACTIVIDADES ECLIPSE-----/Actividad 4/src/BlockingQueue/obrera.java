package BlockingQueue;

public class obrera implements Runnable {
	private cuidadora cuidadora;
	private hormiguero hormiguero;
	
	obrera(cuidadora c, hormiguero h){ cuidadora = c; hormiguero=h;}

	
	
	@Override
	public void run() {
		while(true) {
			
			try {
				
				//creamos una clase que este todo el rato mirando el valor de la lista hormiguero
				detectarValor();
				
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}
	
	
	
	//aqui recojo los valores de feromonas
	public void detectarValor() throws InterruptedException {
	int valor= hormiguero.getValorFeromona();
		
	//clasificamos la creacion de la galeria segun el tipo de huevo
		if (valor == 1){
			hormiguero.CrearGaleriaObreras();
		}else if (valor==2) {
			hormiguero.CrearGaleriaCuidadoras();
		}else if (valor==3) {
			hormiguero.CrearGaleriaGuerreras();
		}	
	}
}