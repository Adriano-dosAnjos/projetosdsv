using System;
namespace ListaExercicio.Views{

    public class Exe04{

        public static void Renderizar(){

            Console.WriteLine("");
            Console.WriteLine("-----Exercicio 04-----");
            Console.WriteLine("");
            Console.WriteLine("Informe a idade: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age <= 13){
                Console.WriteLine("Crinaça");
            }else if (age > 13 && age <= 18){
                Console.WriteLine("Adolescente");
            }else if (age > 18 && age <= 60){
                Console.WriteLine("Adulto");
            }else if (age > 60){
                Console.WriteLine("Idoso");
            }
        }
    }
}