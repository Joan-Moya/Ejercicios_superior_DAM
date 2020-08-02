package BlockingQueue;

public class cuidadora implements Runnable {
	private Reina reina;
	private int tipo;
	private hormiguero hormiguero;
	
	cuidadora(Reina r,int t, hormiguero h){ reina = r; tipo = t; hormiguero=h;}

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
				
				
				cogerHuevo();
				
				
			} catch (InterruptedException e) {				
				e.printStackTrace();
			}
		}
		
	}
	
	
	//creamos las clases que reciben los valores de las queue
	public void cogerHuevo() throws InterruptedException {
		
		if(this.tipo==1) {
			cogerHuevoObrera();
		}else if(this.tipo==2) {
			cogerHuevoCuidadora();
		}else if(this.tipo==3) {
			cogerHuevoGuerrera();
		}
			
	}
	
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
		
		hormiguero.IncrementarHuevosObreras();
		
		//llamamos a la funcion de soltar feromonas para que se cree una nueva galeria
		if(hormiguero.cantidadHuevosObreras>=100) {
			//le decimos a hormiguero que meta un entero con el valor de tipo de galeria a crear en la bloking cube de feromonas
			hormiguero.CrearGaleriaObreras();
			//i las obreras tienen un bucle que siempre recoge feromonas
		}
		
	}
	
	
	
	
	//creamos las clases que llevaran los huevos a las galerias
		public void llevarHuevoCuidadoraAGaleria() throws InterruptedException {
			Thread.sleep((long)Math.random() * 500); //tiempo de espera de 5 mili segundos
			
			hormiguero.IncrementarHuevosCuidadoras();
			
			//llamamos a la funcion de soltar feromonas para que se cree una nueva galeria
			if(hormiguero.cantidadHuevosCuidadoras>=100) {
				//le decimos a hormiguero que meta un entero con el valor de tipo de galeria a crear en la bloking cube de feromonas
				hormiguero.CrearGaleriaCuidadoras();
				//i las obreras tienen un bucle que siempre recoge feromonas
			}
			
		}
	
		
		
		//creamos las clases que llevaran los huevos a las galerias
		public void llevarHuevoGuerreraAGaleria() throws InterruptedException {
			Thread.sleep((long)Math.random() * 500); //tiempo de espera de 5 mili segundos
			
			hormiguero.IncrementarHuevosGuerreras();
			
			//llamamos a la funcion de soltar feromonas para que se cree una nueva galeria
			if(hormiguero.cantidadHuevosGuerreras>=100) {
				//le decimos a hormiguero que meta un entero con el valor de tipo de galeria a crear en la bloking cube de feromonas
				hormiguero.CrearGaleriaGuerreras();
				//i las obreras tienen un bucle que siempre recoge feromonas
			}
			
		}
	
	
	

}