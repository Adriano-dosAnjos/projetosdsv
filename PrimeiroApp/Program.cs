using System;

namespace PrimeiroApp{
    class Program{
        static void Main(string[] args){  
            
            Console.WriteLine("Hi Lorena, How are you?");

            Console.WriteLine("Digite o seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Informe a sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Nome: { name } tem idade: { age } ");
            //Console.WriteLine("Nome: " + name + "idade: " + age); exemplo acima se chama interpolação
        }
    }
}
