using System;

namespace API.Models{

    public class Produto{
        
        //Contrutor
        //public Produto(){
        //    CriadoEm = DateTime.Now;
        //}
        //mesmo que..

        public Produto() => CriadoEm = DateTime.Now;

        public int Id { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public DateTime CriadoEm { get; set; }

        //ToString
        public override string ToString() => 
            $"Nome {Nome} | Preço: {Preco:C2} | Criado em: {CriadoEm}";
    }
}