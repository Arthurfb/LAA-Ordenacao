package application.model;

public class Selection extends Ordenacao {

	@Override
	public int[] executar(int[] numeros) {
		
		return this.ordenarSelection(numeros);
	}
	
	private int[] ordenarSelection(int[] numeros) {
		int indice = 0;
		int i;
		for(i = 0; i < numeros.length-1; i++) {
			indice = i;
			for(int j = i + 1; j < numeros.length; j++) {
				if(numeros[j] < numeros[indice]) {
					indice = j;
				}
			}
		}
		int menorNumero = numeros[indice];
		numeros[indice] = numeros[i];
		numeros[i] = menorNumero;
		
		return numeros;
	}

}
