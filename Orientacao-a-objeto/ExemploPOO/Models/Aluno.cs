using System;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa // aluno herda pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar() // override sobrescreve metodo herdado
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. Minha nota é {Nota}");
        }
    }
}