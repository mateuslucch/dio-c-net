using System;
using Primeiro;
using Interface;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {       

        static void Main(string[] args)
        {
            
            Program print = new Program();
            print.Write("Hello World!");

            print.Write("Exemplo Namespace:");
            NameSpace classe1 = new NameSpace();
            Segundo.NameSpace classe2 = new Segundo.NameSpace();
            Console.WriteLine(classe1.Texto());
            Console.WriteLine(classe2.Texto());

            print.Write("Exemplo Classe:");
            Pessoa person1 = new Pessoa();

            person1.Nome = "Mateus";
            person1.Idade = 37;
            person1.Estado = "RS";

            Pessoa person2 = new Pessoa();

            person2.Nome = "Antonio";
            person2.Idade = 38;
            person2.Estado = "RS";

            print.Write("Exemplo Interface:");
            Animal animal = new Animal();
            animal.Nome = "Mel";
            animal.NomeDono = "Mateus";
            animal.Especie = "Cachorro";

            print.Write("Exemplo Enum:");

            var pessoa1 = (Pessoas)0; // pessoa valor de pessoa em indice 0;
            Pessoas pessoa2 = Pessoas.João;
            Pessoas pessoa3 = (Pessoas)4; // pessoa valor de pessoa em indice 4;
            print.Write(pessoa1.ToString());
            print.Write(pessoa2.ToString());
            print.Write(pessoa3.ToString());
        }

        public void Write(string text)
        {
            Console.WriteLine(text);
        }
        
    }
}