using System;
using ListaExercicio.Models;

namespace ListaExercicio.Views
{
    public class Exe00{
        
        public static void Renderizar(){
            
            Console.WriteLine("");
            Console.WriteLine("----Exemplo----");
            Console.WriteLine("");
            Produto produto = new Produto();
            produto.Nome = "Bolacha";
            produto.Preco = 3.5;
            double valorFinal = produto.Preco * 2;

            Console.WriteLine($"Nome do produto: { produto.Nome }");
            Console.WriteLine($"Preço do produto: { produto.Preco }");
            Console.WriteLine($"Valor Final do produto { valorFinal }");

        }
    }
}