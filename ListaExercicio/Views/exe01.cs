using System;
namespace ListaExercicio.Views{

    public class Exe01{

        public static void Renderizar(){

            Console.WriteLine("");
            Console.WriteLine("-----Exercicio 01-----");
            Console.WriteLine("");
            Console.WriteLine("Digite a altura(h) do retângulo: ");
            decimal h = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a largura(b) do retângulo: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            decimal area = h * b;
            Console.WriteLine("");
            Console.WriteLine(h + " * " + b + " = " + area);
            Console.WriteLine("");
            Console.WriteLine("area do retângulo: " + area);

        }

        public static int CalcularAreaRetangulo(int h, int b){
            
            return h * b;
        }
    }
}