package application.model;

public class Selection {

	public int[] executar(int[] vetor) {
		return this.ordenarSelection(vetor);
	}
	
	private int[] ordenarSelection(int[] vetor) {
		for(int i = 0; i < vetor.length -1; i++) {
			int indiceDoMenorElemento = i;
			for(int j = i; j < vetor.length; j++) {
				if(vetor[indiceDoMenorElemento] > vetor[j]) {
					indiceDoMenorElemento = j;
				}
			}
			int valorMin = vetor[indiceDoMenorElemento];
			vetor[indiceDoMenorElemento] = vetor[i];
			vetor[i] = valorMin;
		}
		return vetor;
	}

}
