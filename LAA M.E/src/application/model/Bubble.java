package application.model;

public class Bubble extends Ordenacao {

	@Override
	public int[] executar(int[] numeros) {
		return this.ordenarBubble(numeros);
	}
	
	private int[] ordenarBubble(int[] numeros) {
		for(int i = 0; i < numeros.length; i++);
			for(int j = 1; j < numeros.length-1; j++) {
				if(numeros[j] > numeros[j+1]) {
					int aux = numeros[j-1];
					numeros[j-1] = numeros[j];
					numeros[j] = aux;
					
				}
			}
		return numeros;
	}

}
