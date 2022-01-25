using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = "default name"; // evitar aviso de non-nullable

        public int Idade { get; set; }

        public string Documento { get; set; } = "00000000";

        public virtual void Apresentar() // com virtual, metodo pode ser sobrescrito
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}