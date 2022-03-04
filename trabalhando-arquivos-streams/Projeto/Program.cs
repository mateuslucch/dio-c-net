using static System.Console;

namespace Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Digite o nome do arquivo, sem extensão:");
            var name = ReadLine();
            name = LimparNome(name);

            var path = Path.Combine(Environment.CurrentDirectory, $"{name}.txt");

            //var path = Path.Combine(Environment.CurrentDirectory, "teste.txt"); // equivalente a " var path = Environment.CurrentDirectory + "\\teste.txt"; "
            // Environment.CurrentDirectory cria mesmo diretorio projeto

            CriarArquivos(path);
            WriteLine("Digite enter para finalizar...");
            ReadLine();
        }

        private static string? LimparNome(string? name)
        {
            foreach (var @char in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(@char, '-'); // vai trocar todos os caracteres invalidos em name
            }

            return name;
        }

        private static void CriarArquivos(string path)
        {
            /*    var sw = File.CreateText(path);
               // adiciona valor a variável sw, por linha
               sw.WriteLine("Linha 1");
               sw.WriteLine("Linha 2");
               sw.WriteLine("Linha 3");
               sw.WriteLine("Linha 4");
               sw.WriteLine("Linha 5");
               // adiciona os valores ao arquivo
               sw.Flush(); */ //forma sem using, precisa do FLush()
                              //obs: nessa forma, arquivo vai ser sempre sobrescrito

            try
            {
                // EXTRA, usando "using", flush será automático!!            
                using var sw2 = File.CreateText(path);
                // adiciona valor a variável sw, por linha
                sw2.WriteLine("Linha 1");
                sw2.WriteLine("Linha 2");
                sw2.WriteLine("Linha 3");
                sw2.WriteLine("Linha 4");
                sw2.WriteLine("Linha 5");
            }
            catch (System.Exception)
            {
                WriteLine("O nome do arquivo é inválido!");
            }

        }
    }
}