using System;
namespace ListaExercicio.Views{

    public class Exe05{

        public static void Renderizar(){

            Console.WriteLine("");
            Console.WriteLine("-----Exercicio 05-----");
            Console.WriteLine("");
            Console.WriteLine("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            int p1 = 0, p2 = 1, soma = 0;
            //int cont = 0;
            
            Console.WriteLine();

            while(soma < num){

                Console.WriteLine(soma + ", ");

                soma = p1 + p2;
                p2 = p1;
                p1 = soma;
                
            }

            Console.WriteLine("");
            Console.WriteLine("Fim");
        }
    }
}