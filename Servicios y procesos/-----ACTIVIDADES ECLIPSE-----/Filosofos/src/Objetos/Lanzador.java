package Objetos;

public class Lanzador {
    public static void main(String[] args) {
    	
            int NUM_PROCESOS=5;
            
            Filosofo filosofos[]=new Filosofo[NUM_PROCESOS];
            GestorCubiertos gestorCubiertos;
            gestorCubiertos=new GestorCubiertos(NUM_PROCESOS);
            
            Thread hilos[]=new Thread[NUM_PROCESOS];
            
            for (int i=1; i<NUM_PROCESOS; i++){
                    filosofos[i]=new Filosofo(
                            gestorCubiertos, i, i-1);
                    hilos[i]=new Thread(filosofos[i]);
                    hilos[i].start();
            }
            
            filosofos[0]=new Filosofo(gestorCubiertos, 0, 4);
            hilos[0]=new Thread(filosofos[0]);
            hilos[0].start();
    } 
} 
