namespace Revisao
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            string opcaoUsuario = MenuPrincipal();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Aluno aluno = new Aluno();

                        System.Console.WriteLine("Informe o nome do aluno:");
                        aluno.Nome = Console.ReadLine();

                        System.Console.WriteLine("Informe a nota do aluno:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota)) //já checa se entrada do usuário é decimal e retorna nota se for
                        {
                            aluno.Nota = nota;
                        }
                        else { throw new ArgumentException("Valor da nota deve ser decimal"); }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        ExibirAlunos(alunos);
                        break;

                    case "3":
                        System.Console.WriteLine("");
                        CalculoMedia(alunos);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Entrada fora das opções");
                }

                opcaoUsuario = MenuPrincipal();
            }
        }

        private static void CalculoMedia(Aluno[] alunos)
        {
            decimal notaTotal = 0;
            var nrAlunos = 0;

            for (int i = 0; i < alunos.Length; i++)
            {
                if (!string.IsNullOrEmpty(alunos[i].Nome))
                {
                    notaTotal += alunos[i].Nota;
                    nrAlunos++;
                }
            }
            
            var mediaGeral = notaTotal / nrAlunos;
            Conceito conceitoGeral = new Conceito();

            if (mediaGeral < 2) { conceitoGeral = Conceito.E; }
            else if (mediaGeral < 4) { conceitoGeral = Conceito.D; }
            else if (mediaGeral < 6) { conceitoGeral = Conceito.C; }
            else if (mediaGeral < 8) { conceitoGeral = Conceito.B; }
            else if (mediaGeral <= 10) { conceitoGeral = Conceito.A; }

            System.Console.WriteLine("");
            System.Console.WriteLine($"Media Geral: {mediaGeral} - CONCEITO: {conceitoGeral}");
            System.Console.WriteLine("");
        }

        private static void ExibirAlunos(Aluno[] alunos)
        {
            System.Console.WriteLine("");
            foreach (var a in alunos)
            {
                if (!string.IsNullOrEmpty(a.Nome))
                {
                    System.Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                }
            }
            System.Console.WriteLine("");
        }

        private static string MenuPrincipal()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("Informe a opção desejada:");
            System.Console.WriteLine("1- Inserir novo aluno");
            System.Console.WriteLine("2- Listar alunos");
            System.Console.WriteLine("3- Calcular média geral");
            System.Console.WriteLine("X- Sair");
            System.Console.WriteLine("");

            return System.Console.ReadLine();
        }
    }
}