using System;
namespace ListaExercicio.Views{
    class Program{
        static void Main(string[] args){

            int opcao;
            //do{
                Console.Clear();

                Console.WriteLine("Digite o exercicio que deseja executar: ");
                Console.WriteLine("");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao){
                    case 1:
                        Exe01.Renderizar();
                    break;
                    
                    case 2:
                        Exe02.Renderizar();
                    break;

                    case 3:
                        Exe03.Renderizar();
                    break;

                    case 4:
                        Exe04.Renderizar();
                    break;

                    case 5:
                        Exe05.Renderizar();
                    break;

                    case 6:
                        Exe06.Renderizar();
                    break;
                    
                    case 7:
                        Exe00.Renderizar();
                    break;

                    default:
                        Console.WriteLine("Opção invalida! digite novamente");
                        Console.WriteLine("\n\n");
                    break;
                }   

            //}while (opcao < 6);

            //Ctrl+' -> terminal;
        }
    }
}
