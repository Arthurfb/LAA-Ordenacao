package application.model;

public class Intro extends Ordenacao{
	
	@Override
	public int[] executar(int[] numeros) {
		return this.ordenarIntro(numeros);
	}
	
	private int[] ordenarIntro(int[] numeros) {
		return numeros;
	}

}
