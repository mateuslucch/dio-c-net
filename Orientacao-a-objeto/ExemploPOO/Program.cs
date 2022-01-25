using System;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // obs: programa executado no wsl-ubuntu
            var caminhoRaiz = "/mnt/f/programming/bootcamp/dio_bootcamp/TrabalhandoComArquivos"; // não reconhece só \, usar \\ no cmd

            var caminhoArquivo = Path.Combine(caminhoRaiz, "arquivo-teste-stream.txt");
            var caminhoDestino = Path.Combine(caminhoRaiz, "Pasta Teste 2", "arquivo-teste-stream.txt"); // destino deve ter nome do arquivo

            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuação = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper();

            // helper.CriarArquivoTexto(caminhoArquivo, "Hello, world!");

            // var newFolder = Path.Combine(caminhoRaiz, "Pasta Teste 1");

            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString); // cria arquivo com stream
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuação); // adiciona linhas extras no final do arquivo

            // helper.LerArquivo(caminhoArquivo);
            // helper.LerArquivoStream(caminhoArquivo);

            // helper.MoverArquivo(caminhoArquivo, caminhoDestino, false);

            helper.CopiarArquivo(caminhoArquivo, caminhoDestino, true); // da erro se usar false!!

            // helper.CriarDiretorio(newFolder);
            // helper.ApagarDiretorio(newFolder, true); // usar true se quiser apagar arquivos

            // System.Console.WriteLine($"Pastas em {caminhoRaiz}");
            // helper.ListarDiretorios(caminhoRaiz);

            // System.Console.WriteLine($"Arquivos em {caminhoRaiz}");
            // helper.ListarArquivosDiretorios(caminhoRaiz);

            // // ex interface
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(2,5)); // Somar() virá da interface, nao da classe

            // //ex object
            // Computador comp = new Computador();


            // // ex abstrata
            // Corrente cCorrente = new Corrente();
            // cCorrente.Creditar(100);

            // cCorrente.ExibirSaldo();


            // // ex Polimorfismo(overload)
            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine($"Resultado da primeira soma: {calc.Somar(1, 5)}");
            // System.Console.WriteLine($"Resultado da segunda soma: {calc.Somar(1, 5, 7)}");

            // ex Polimorfismo(override), herança, encapsulamento
            // Aluno aluno1 = new Aluno();
            // // metodo de aluno
            // aluno1.Nota = 5.75;
            // // metodos herdados
            // aluno1.Nome = "Mateus";
            // aluno1.Idade = 37;

            // aluno1.Apresentar();

            // Professor professor1 = new Professor();
            // // metodo de professor
            // professor1.Salario = 1500;
            // // metodos herdados
            // professor1.Nome = "Mateus";
            // professor1.Idade = 27;
            // professor1.Documento = "5044881351";
            // professor1.Apresentar();


            //  Retangulo r = new Retangulo();
            //  r.DefinirMedidas(5, -2);
            //  Console.WriteLine($"Área: {r.ObterArea()}");

            // Pessoa  p1 = new Pessoa();
            // p1.Nome = "Mateus";
            // p1.Idade = 37;

            // p1.Apresentar();
        }
    }
}