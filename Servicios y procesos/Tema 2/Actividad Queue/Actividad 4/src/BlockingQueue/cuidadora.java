package BlockingQueue;

public class cuidadora implements Runnable {
	private Reina reina;
	
	cuidadora(Reina r){ reina = r; }

	//aqui vamos a declarar las galerias de los diferentes huevos que hay
	int cantidad_huevos_obreras;
	int cantidad_huevos_cuidadoras;
	int cantidad_huevos_guerreras;
	
	boolean feromonas_galeria_obreras=false; //ponemos las feromonas a false porque no hay que crear una nueva galeria
	boolean feromonas_galeria_cuidadoras=false; //ponemos las feromonas a false porque no hay que crear una nueva galeria
	boolean feromonas_galeria_guerreras=false; //ponemos las feromonas a false porque no hay que crear una nueva galeria
	
	@Override
	public void run() {
		while(true) {
			try {
				
				//llamamos a las funciones para recoger los huevos y clasificarlos
				cogerHuevoObrera();
				cogerHuevoCuidadora();
				cogerHuevoGuerrera();
				
				
			} catch (InterruptedException e) {				
				e.printStackTrace();
			}
		}
		
	}
	
	
	
	
	
	//creamos las clases que reciben los valores de las queue
	public void cogerHuevoObrera() throws InterruptedException {
		reina.getValorObrera();//recibimos el valor de la queue
		llevarHuevoObreraAGaleria();//llamamos a la funcion para que ponga el huevo en su galeria
	}
	public void cogerHuevoCuidadora() throws InterruptedException {
		reina.getValorCuidadora();//recibimos el valor de la queue
		llevarHuevoCuidadoraAGaleria();//llamamos a la funcion para que ponga el huevo en su galeria
	}
	public void cogerHuevoGuerrera() throws InterruptedException {
		reina.getValorGuerrera();//recibimos el valor de la queue
		llevarHuevoGuerreraAGaleria();//llamamos a la funcion para que ponga el huevo en su galeria
	}
	
	
	
	
	
	
	
	
	//creamos las clases que llevaran los huevos a las galerias
	public void llevarHuevoObreraAGaleria() throws InterruptedException {
		Thread.sleep((long)Math.random() * 500); //tiempo de espera de 5 mili segundos
		
		cantidad_huevos_obreras++;
		
		//llamamos a la funcion de soltar feromonas para que se cree una nueva galeria
		if(cantidad_huevos_obreras>100) {
			soltarFeromonasParaObreras();
		}
		
	}
	public void llevarHuevoCuidadoraAGaleria() throws InterruptedException {
		Thread.sleep((long)Math.random() * 500); //tiempo de espera de 5 mili segundos
		
		cantidad_huevos_cuidadoras++;
		
		//llamamos a la funcion de soltar feromonas para que se cree una nueva galeria
		if(cantidad_huevos_cuidadoras>100) {
			soltarFeromonasParaCuidadoras();
		}
	}
	public void llevarHuevoGuerreraAGaleria() throws InterruptedException {
		Thread.sleep((long)Math.random() * 500); //tiempo de espera de 5 mili segundos
		
		cantidad_huevos_guerreras++;
		
		//llamamos a la funcion de soltar feromonas para que se cree una nueva galeria
		if(cantidad_huevos_guerreras>100) {
			soltarFeromonasParaGuerreras();
		}
	}
	
	
	
	
	
	//creamos las funciones que soltaran feromonas dependiendo del tipo de galeria que queramos crear
	public boolean soltarFeromonasParaObreras(){
		return feromonas_galeria_obreras=true;
	}
	public boolean soltarFeromonasParaCuidadoras(){
		return feromonas_galeria_cuidadoras=true;
	}
	public boolean soltarFeromonasParaGuerreras(){
		return feromonas_galeria_guerreras=true;
	}
}