using System;
namespace ListaExercicio.Views{

    public class Exe03{

        public static void Renderizar(){

            Console.WriteLine("");
            Console.WriteLine("-----Exercicio 03-----");
            Console.WriteLine("");

            int[] num = new int[2];
            int cont, menor, maior;

            for (cont = 0; cont < 2; cont++){
                Console.WriteLine("Informe o %d° número inteiro: ",cont+1);
                num[cont] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("-------");
            Console.WriteLine("print:");
            for(cont = 0; cont < 2; cont++){
                Console.WriteLine(num[cont]);
            }

            if (cont == 0){
                menor = num[cont];
                maior = num[cont];
           // }else if (num[cont] < menor){
                menor = num[cont];
            //}else if (num[cont] > maior){
                maior = num[cont];
            }

          //  Console.WriteLine("Menor número: " + menor);
           // Console.WriteLine("Maior número: " + maior);
        }
    }
}