package application.model;

public class Heap {

	public int[] executar(int[] vetor) {
		return this.ordenarHeap(vetor);
	}
	
	private int[] ordenarHeap(int[] vetor) {
		buildheap(vetor);
	      int sizeOfHeap=vetor.length-1;
	      for(int i=sizeOfHeap; i>0; i--) {
	         swap(vetor,0, i);
	         sizeOfHeap=sizeOfHeap-1;
	         heapify(vetor, 0,sizeOfHeap);
	        
	      }
		return vetor;
	}
	
	public static void buildheap(int []vetor) {
	    for(int i=(vetor.length-1)/2; i>=0; i--){
	           heapify(vetor,i,vetor.length-1);
	      }
	   }
	 
	   public static void heapify(int[] vetor, int i,int size) { 
	      int left = 2*i+1;
	      int right = 2*i+2;
	      int max;
	      if(left <= size && vetor[left] > vetor[i]){
	         max=left;
	      } else {
	         max=i;
	      }
	 
	      if(right <= size && vetor[right] > vetor[max]) {
	         max=right;
	      }
	      
	      if(max!=i) {
	         swap(vetor,i, max);
	         heapify(vetor, max,size);
	      }
	   }
	 
	   public static void swap(int[] vetor,int i, int j) {
	        int t = vetor[i];
	        vetor[i] = vetor[j];
	        vetor[j] = t; 
	   }
}
