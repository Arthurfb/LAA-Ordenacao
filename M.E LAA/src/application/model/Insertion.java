package application.model;

public class Insertion {

	public int[] executar(int[] vetor) {
		return this.ordenarInsertion(vetor);
	}
	
	private int[] ordenarInsertion(int[] vetor) {
		for (int i = 1; i < vetor.length; i++) {
			int j = i;
			int aux = vetor[i];
			
			while ( (j > 0) && (vetor[j-1] > aux) ) {
				vetor[j] = vetor[j-1];
				j--;
			}
			
			vetor[j] = aux;
		}
		return vetor;
	}

}
