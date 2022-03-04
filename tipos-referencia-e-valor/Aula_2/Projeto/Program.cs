using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Demo1()
        {
            int a = 5;
            Adicionar20(ref a);
            WriteLine($"O valor de a é: {a}");
        }

        private static void Demo2()
        {
            var nomes = new string[] { "José", "Maria", "Ricardo", "Alice", "Pedro" };

            WriteLine($@"
Lista de nomes original: 
{string.Join("\n", nomes)}
");

            WriteLine("Digite o nome a ser substituido");
            var nome = ReadLine();

            WriteLine("Digite o nome novo");
            var nomeNovo = ReadLine();

            AlterarNome(nomes, nome, nomeNovo);

            WriteLine($@"
Nova lista: 
{string.Join("\n", nomes)}
");
        }

        static void Adicionar20(ref int a) // com ref, a em main é referenciada e pode ser modificada fora do escopo de main
        {
            a += 20;
        }

        static void AlterarNome(string[] nomes, string nome, string nomeNovo)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                    nomes[i] = nomeNovo;
                }
            }
        }

        static ref string LocalizarNome(string[] nomes, string nome)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                    return ref nomes[i];
                }
            }
            throw new Exception("Nome não encontrado");  // ref nao existe, dar uma exception
        }

        static void Main(string[] args)
        {
            var nomes = new string[] { "José", "Maria", "Ricardo", "Alice", "Pedro" };

            WriteLine($@"
    Lista de nomes original: 
{string.Join("\n\t", nomes)}
        ");

            WriteLine("Digite o nome a ser substituido");
            var nome = ReadLine();

            WriteLine("Digite o nome novo");
            var nomeNovo = ReadLine();

            ref var nomeAchado = ref LocalizarNome(nomes, nome);

            if (!string.IsNullOrWhiteSpace(nomeAchado))
            {
                nomeAchado = nomeNovo;

                WriteLine($@"
    Nova lista: 
    {string.Join("\n", nomes)}
            ");            
            }
            else { WriteLine("Nome não encontrado."); }
        }
    }
}