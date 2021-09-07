using System;

namespace ListaExercicio.Views{

    public class Exe02{

        public static void Renderizar(){

            Console.WriteLine("");
            Console.WriteLine("-----Exercicio 02-----");
            Console.WriteLine("");
            Console.WriteLine("Digite aqui o valor em Real(R$): ");
            double real = Convert.ToDouble(Console.ReadLine());

            //decimal realDecimal = Convert.ToDecimal(real);

            const double DOLAR_ATUAL = 5.17;
            const double EURO_ATUAL = 6.14;
            const double PESO_ARG_ATUAL = 0.05;

            double dolarxreal = real / DOLAR_ATUAL;
            double euroxreal = real / EURO_ATUAL;
            double pesoxreal = real / PESO_ARG_ATUAL;

            Console.WriteLine("");
            Console.WriteLine("Real: " + real);

            //Console.WriteLine("Dolar: " + dolarxreal);
            Console.WriteLine($"Dolar: {dolarxreal.ToString("F2")}");

            //Console.WriteLine("Euro: " + euroxreal);
            Console.WriteLine($"Euro: {euroxreal.ToString("F2")}");

            //Console.WriteLine("Peso Argentino: " + pesoxreal);
            Console.WriteLine($"Peso Argentino: {pesoxreal.ToString("F2")}");

        }

    }
}