package application;

import java.util.Scanner;

import application.model.Bubble;
import application.model.Heap;
import application.model.Insertion;
import application.model.Selection;

public class Main {

	public static void main(String[] args) {
		int opcao = 0;
		int[] vetor = new int[8];
		
		preencherVetor(vetor);
		print(vetor);
		long tempoInicial = System.nanoTime();
		int[] vetorOrdenado = opcaoOrdenacao(opcao, vetor);
		print(vetorOrdenado);
		long tempoFinal = System.nanoTime() - tempoInicial;
		System.out.println("Foi gasto " + tempoFinal + " nano segundos paga ordenar");

	}
	
	static void preencherVetor(int[] vetor) {
		Scanner valor = new Scanner(System.in);
		for(int i = 0; i < vetor.length; i++) {
			System.out.println("Digite o valor da casa " + i + ": ");
			vetor[i] = valor.nextInt();
		}
	}
	
	static int[] opcaoOrdenacao(int opcao, int[] vetor) {
		Scanner opcaoScan = new Scanner(System.in);
		System.out.println("Escolha o método de ordenação: 1-Bubble, 2-Insertion, 3-Selection, 4-Heap");
		opcao = opcaoScan.nextInt();
		
		if(opcao == 1) {
			Bubble bubble = new Bubble();
			bubble.executar(vetor);
		}
		if(opcao == 2) {
			Insertion insertion = new Insertion();
			insertion.executar(vetor);
		}
		if(opcao == 3) {
			Selection selection = new Selection();
			selection.executar(vetor);
		}
		if(opcao == 4) {
			Heap heap = new Heap();
			heap.executar(vetor);
		}
		return vetor;
	}
	
	private static void print(int[] numeros) {		
		for(int numero: numeros) {
			System.out.print(numero + ", ");
		}
		System.out.println();
	}

}
