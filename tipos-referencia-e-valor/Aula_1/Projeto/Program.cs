using static System.Console;

namespace Projeto
{
    internal class Program
    {
        static void Demo1()
        {
            int a = 2;
            a = Adicionar20(a);
            WriteLine($"O valor da variável a é: {a}");
        }

        static void Demo2() // classe constructor 
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Mateus";
            p1.Idade = 37;
            p1.Documento = "7081885332";

            // Pessoa p2 = p1;  // dessa forma, p2 recebe a referencia de p1, e não uma cópia (se mudar p1, muda p2)

            // Forma abaixo nao referencia p1
            Pessoa p2 = p1.Clone(); // Clone() ja vai atribuir os valores de p1

            WriteLine($"Nome atual:{p1.Nome}");

            TrocarNome(p1, "El Mateus");
            // @ permite escrever em mais linhas
            WriteLine($@"   
    O nome de p1 é: {p1.Nome}
    O nome de p2 é: {p2.Nome}
            ");
        }

        static void Demo3()  // classe struct
        {
            StructPessoa p1 = new StructPessoa
            {
                Documento = "1234",
                Idade = 37,
                Nome = "El Gran Mateus"
            };

            WriteLine($@"
    Nome atual p1:{p1.Nome}");

            var p2 = p1;

            p1 = TrocarNome(p1, "Mateus El Diablo");

            WriteLine($@"   
    O nome de p1 é: {p1.Nome}
    O nome de p2 é: {p2.Nome}
            ");
        }

        private static void Demo4()
        {
            string nome = "Anonymous";

            TrocarNome(nome, "Mateus el?");

            WriteLine($"O novo nome é {nome}");
        }

        private static void Demo5()
        {
            int[] pares = new int[] { 0, 2, 4, 6, 8 };

            MudarParaImpar(pares);

            WriteLine($"Os impares são {string.Join(",", pares)}"); //string.Join("tipo separador", array)
        }

        private static void Demo6()
        {
            int[] pares = new int[] { 0, 2, 4, 6, 8 };
            WriteLine($"Digite o número que gostaria de encontrar");
            var numero = int.Parse(ReadLine());

            var indexEncontrado = EncontrarNumero(pares, numero);

            if (indexEncontrado >= 0) { WriteLine($"O numero { numero} está no índice {indexEncontrado}"); }
            else { WriteLine("O numero digitado não existe"); }
        }

        static int Adicionar20(int a)
        {
            return a + 20;
        }

        static void TrocarNome(Pessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }

        // TrocarNome aqui deve retornar StructPessoa, se nao nao troca nome de p1
        static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo) //sobrecarga de método
        {
            p1.Nome = nomeNovo;
            return p1;
        }

        static void TrocarNome(string nome, string nomeNovo)
        {
            nome = nomeNovo;
        }

        static void MudarParaImpar(int[] pares)
        {
            for (int i = 0; i < pares.Length; i++)
            {
                pares[i] = pares[i] + 1;
            }
        }

        static int EncontrarNumero(int[] numeros, int numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero)
                {
                    return i;
                }
            }
            return -1;
        }

        static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
        {
            foreach (var item in pessoas)
            {
                if (item.Nome == pessoa.Nome)   // obs: fazer item == pessoa nao rola, posições de memoria diferentes
                                                // obs2: usar item.Equals(pessoa) se gor usar struct
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa(){Nome = "Ricardo"},
                new Pessoa(){Nome = "Raquel"},
                new Pessoa(){Nome = "José"},
                new Pessoa(){Nome = "Maria"},
                new Pessoa(){Nome = "Eduardo"}
            };

            WriteLine("Digite a pessoa que gostaria de localizar:");
            var nome = ReadLine();
            var pessoa = new Pessoa() { Nome = nome };
            var encontrado = EncontrarPessoa(pessoas, pessoa);

            if (encontrado) { WriteLine($"Pessoa localizada!"); }
            else { WriteLine($"Pessoa não localizada!"); }
        }
    }
}