package BlockingQueue;

public class hormiguero implements Runnable {
	private obrera obrera;
	
	hormiguero(obrera o){ obrera = o; }



	
	@Override
	public void run() {
		while(true) {
			
			//llamamos a las funciones para saber la cantidad de galerias que hay construidas para cada tipo de hormiga
				cantidadTotalGaleriasObreras();
				cantidadTotalGaleriasCuidadoras();
				cantidadTotalGaleriasGuerreras();
				
		}
		
	}
	
	
	
	//definimos las funciones que llevaran la cuenta de las galerias creadas
	public void cantidadTotalGaleriasObreras(){
		int cantidad = obrera.cantidad_galerias_creadas_obreras;
		
		if(cantidad>5) {
			System.out.println("+5 GALERIAS CONSTRUIDAS PARA OBRERAS");
		}	
	}
	
	public void cantidadTotalGaleriasCuidadoras(){
		int cantidad = obrera.cantidad_galerias_creadas_cuidadoras;
		
		if(cantidad>5) {
			System.out.println("+5 GALERIAS CONSTRUIDAS PARA CUIDADORAS");
			cantidad=0;
		}
	}
	
	public void cantidadTotalGaleriasGuerreras(){
		int cantidad = obrera.cantidad_galerias_creadas_guerreras;
		
		if(cantidad>5) {
			System.out.println("+5 GALERIAS CONSTRUIDAS PARA GUERRERAS");
			cantidad=0;
		}
	}
}