using System;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa // professor herda pessoa, colocando "sealed" a classe fica selada
    {
        public int Salario { get; set; }

        public override void Apresentar() // override sobrescreve metodo herdado
        {
            Console.WriteLine($"Olá, sou o professor {Nome} e tenho {Idade} anos. Meu salario é R${Salario}");
        }
    }    
}