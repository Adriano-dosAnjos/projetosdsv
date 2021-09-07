using System;
namespace ListaExercicio.Views{
    
    public class Exe06{

        const int VALOR_MAXIMO = 1001; //1001 pois o 0 é considerado;
        const int TAMANHO_VETOR = 100;
        public static void Renderizar(){
        
            Console.WriteLine("");
            Console.WriteLine("-----Exercicio 06-----");
            Console.WriteLine("\n");

            Random random = new Random();
            int[] numeros = new int[TAMANHO_VETOR];

            //Popular o vetor com valores aleatórios;
            for(int i = 0; i < TAMANHO_VETOR; i++){

                numeros[i] = random.Next(VALOR_MAXIMO);
            }

            foreach(int numero in numeros){

                Console.Write($"{ numero } ");
            }

            Console.WriteLine("\n");

            bool troca = false; 
            do{
                troca = false;
                for(int i = 0; i < TAMANHO_VETOR - 1; i++){

                    if(numeros[i] > numeros[i + 1]){
                        
                        int aux = numeros[i];
                        numeros[i] = numeros[i + 1];
                        numeros[i + 1] = aux;
                       troca = true;
                    }
                }

            }while(troca);
            
            //Odernar o vetor automaticamente;
            //Console.WriteLine("Valores listados acima porem em ordem crescente: \n");
            //Array.Sort(numeros);

            //foreach(int numero in numeros){
                   
            //    Console.Write($"{ numero } ");
            //}

            //Console.WriteLine("\n");

        }
    }
}