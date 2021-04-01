package application.model;

public class Bubble {
	
	public int[] executar(int[] vetor) {
		return this.ordenarBubble(vetor);
	}
	
	private int[] ordenarBubble(int[] vetor) {
		int aux = 0;
		for(int i = 0; i < vetor.length-1; i++) {
			for(int j = 0; j < vetor.length-1; j++) { 
				if(vetor[j] > vetor[j+1]) {	
					aux = vetor[j];		
					vetor[j] = vetor[j+1];		
					vetor[j+1] = aux;		
				}
			}
		}
		return vetor;
	}	
}
