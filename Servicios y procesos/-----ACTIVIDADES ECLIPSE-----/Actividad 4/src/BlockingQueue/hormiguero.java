package BlockingQueue;

import java.util.concurrent.BlockingQueue;

public class hormiguero{
	
	private obrera obrera;
	
	hormiguero(obrera o){ obrera = o; }
	
	private BlockingQueue<Integer> feromonas;
	
	int cantidadHuevosObreras=0;
	int cantidadHuevosCuidadoras=0;
	int cantidadHuevosGuerreras=0;
	
	int galeriasObreras=0;
	int galeriasCuidadoras=0;
	int galeriasGuerreras=0;
	
	
	//contamos la cantidad de huevos
	public synchronized void IncrementarHuevosObreras (){
		cantidadHuevosObreras++;
	}
	public synchronized void IncrementarHuevosCuidadoras (){
		cantidadHuevosCuidadoras++;
	}
	public synchronized void IncrementarHuevosGuerreras (){
		cantidadHuevosGuerreras++;
	}
	
	//creamos galerias
	public synchronized void CrearGaleriaObreras () {
		galeriasObreras++;
	}
	public synchronized void CrearGaleriaCuidadoras () {
		galeriasCuidadoras++;
	}
	public synchronized void CrearGaleriaGuerreras () {
		galeriasGuerreras++;
	}
	public synchronized Integer getValorFeromona () throws InterruptedException {
		return feromonas.take();
	}
	
	
	
	
}