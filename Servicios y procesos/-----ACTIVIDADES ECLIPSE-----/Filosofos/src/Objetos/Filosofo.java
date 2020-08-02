package Objetos;

import java.util.Random;


public class Filosofo implements Runnable{
	
    GestorCubiertos gestorCubiertos;
    int posCubiertoIzq,posCubiertoDer;
    
    public Filosofo(GestorCubiertos g, int CIzq, int CDer){
            this.gestorCubiertos=g;
            this.posCubiertoDer=CDer;
            this.posCubiertoIzq=CIzq;
    }
    
    public void run() {
    	
            while (true){
            boolean cubiertosCogidos;
                    
            cubiertosCogidos= this.gestorCubiertos.cogerCubiertos(posCubiertoIzq, posCubiertoDer);
                    
            if (cubiertosCogidos){
                  comer();
                  this.gestorCubiertos.liberarCubiertos(posCubiertoIzq,posCubiertoDer);
                  dormir();
                  pensar();
                    }
            } 
    } 

    //creamos la clase comer
    private void comer() {
            System.out.println("Filosofo "+Thread.currentThread().getName()+" comiendo");
            esperarTiempoAzar();
    }
    
    
    //creamos la clase tiempoAzar para que nos genere el tiempo
    private void esperarTiempoAzar() {
            Random generador=new Random();
            
            int msAzar=generador.nextInt(3);
            try {
                    Thread.sleep(msAzar);
            } catch (InterruptedException ex) {
                    System.out.println("Fallo la espera");
            }
    }
    
    //creamos la clase dormir
    private void dormir(){
            System.out.println("Filosofo "+Thread.currentThread().getName()+" durmiendo (zzzzzz)");
            esperarTiempoAzar();
    }
    
   
    private void pensar(){
        System.out.println("Filosofo "+Thread.currentThread().getName()+" Pensando (mhmmm....)");
        esperarTiempoAzar();
}
}