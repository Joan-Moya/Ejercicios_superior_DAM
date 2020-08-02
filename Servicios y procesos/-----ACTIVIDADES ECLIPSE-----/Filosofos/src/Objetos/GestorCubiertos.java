package Objetos;

public class GestorCubiertos {
	
    boolean CubiertoLibre[];
    
    public GestorCubiertos(int numCubiertos){//le pasamos el numero de cubiertos por parametro
    	
            CubiertoLibre=new  boolean[numCubiertos]; //le pasamos a "CubiertoLibre" el numero de cubiertos pasado por parametro
            
            for (int i=0; i<numCubiertos; i++){
                    CubiertoLibre[i]=true;
            }
    } 
    
    
    public synchronized boolean cogerCubiertos(int pos1, int pos2){
    	
   /*
     si están disponibles los cubiertos en las posiciones pos1 y pos2 los marcará como no disponibles y devolverá true. 
     Si no, devolverá false.
    */
    	
            boolean seConsigue=false; //devuelve falso
            
            if ((CubiertoLibre[pos1]) &&(CubiertoLibre[pos2]) ){
            	
                    CubiertoLibre[pos1]=false;
                    CubiertoLibre[pos2]=false;
                    seConsigue=true; //devuelve true
            }
            
            return seConsigue;
    }

    public void liberarCubiertos(int pos1, int pos2){
    	
   //marcaremos los cubiertos en las posiciones pos1 y pos2 como libres.
     CubiertoLibre[pos1]=true;
     CubiertoLibre[pos2]=true;
    }
}